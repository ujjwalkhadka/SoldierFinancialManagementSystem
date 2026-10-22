namespace SoldierFinanceSample;

// All list changes happen here. MainForm shows the results after this dialog closes.
public partial class SoldierManagementForm : Form
{
    List<Soldier> soldiers = new List<Soldier>();
    Soldier original = null; // The existing record; null means we are adding a new one.
    bool loading;
    public Soldier SelectedSoldier { get; private set; }

    public SoldierManagementForm()
    {
        InitializeComponent();
    } // Designer constructor.
    public SoldierManagementForm(List<Soldier> records, Soldier selected, bool deleteOnly = false)
    {
        InitializeComponent();

        soldiers = records;
        original = selected;
        SelectedSoldier = selected;

        Soldier initial;

        if (selected == null)
        {
            initial = new Soldier();
            initial.Unit = "125TH FMSU";

            Text = "Add soldier";
            btnSave.Text = "Add soldier";
            btnDelete.Visible = false;
        }
        else
        {
            initial = selected;

            Text = "Update soldier";
            btnSave.Text = "Save changes";
            btnDelete.Visible = true;
        }

        LoadInputs(initial);

        if (deleteOnly) // applies for delete button
        {
            Text = "Delete soldier";
            btnSave.Visible = false;
            AcceptButton = btnDelete;
            tabs.Enabled = false;

            lblInstructions.Text =
                "Review the soldier, then click Delete soldier. Cancel to keeps the record.";
        }
        else // applies for both add and update button
        {
            btnSave.Visible = true;
            AcceptButton = btnSave;
            tabs.Enabled = true;

            lblInstructions.Text =
                "Edit the inputs below. Save applies changes; Cancel leaves the list unchanged.";
        }
    }
    // Copy the selected soldier values into the textboxes, dropdowns and number inputs.
    void LoadInputs(Soldier s)
    {
        loading = true;
        // TextBox.Text displays text; NumericUpDown.Value holds a decimal.
        // CheckBox.Checked holds true/false.
        txtId.Text = s.Id;
        txtFirstName.Text = s.FirstName;
        txtMiddleName.Text = s.MiddleName;
        txtLastName.Text = s.LastName;
        txtRank.Text = s.Rank;
        txtUnit.Text = s.Unit;
        if (cboStation.Items.Contains(s.DutyStation) == false)
        {
            cboStation.Items.Add(s.DutyStation);
        }
        cboStation.SelectedItem = s.DutyStation;
        cboGrade.SelectedItem = s.PayGrade;
        numYears.Value = s.YearsOfService;
        chkDependents.Checked = s.WithDependents;
        chkQuarters.Checked = s.GovernmentQuarters;
        numBah.Value = s.BahRate;
        numClothing.Value = s.Clothing; numSpecial.Value = s.SpecialPay;
        numOha.Value = s.OHA; numFsa.Value = s.FSA;
        numFederal.Value = s.FederalTax; numState.Value = s.StateTax;
        numAllotmentsDebt.Value = s.AllotmentsDebt;
        loading = false;
        PreviewBah();
    }
    // Preview the cached BAH rate for the selected station, grade and dependents.
    void PreviewBah()
    {
        if (loading)
        {
            return;
        }

        decimal rate;

        bool found = BahRates2026.TryGetRate(
            cboStation.Text,
            cboGrade.Text,
            chkDependents.Checked,
            out rate);

        if (found)
        {
            // Display the stored rate and prevent manual changes.
            numBah.ReadOnly = true;
            numBah.Increment = 0;
            numBah.Value = rate;
        }
        else
        {
            // Allow the user to enter a manual BAH rate.
            numBah.ReadOnly = false;
            numBah.Increment = 1;
        }
    }
    // Station/grade/dependent change events preview BAH without recalculating all pay.
    void BahInputChanged(object sender, EventArgs e)
    {
        if (loading)
        {
            return;
        }

        if (sender == cboStation &&
            cboStation.Text == "Other station (manual BAH)")
        {
            numBah.Value = 0;
        }

        PreviewBah(); // Preview the rate; Save applies the changes.
    }
    void Save_Click(object? sender, EventArgs e)
    {
        if (txtId.Text.Trim() == "" || txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "")
        {
            MessageBox.Show("Enter a SSN, first name and last name.");
            return;
        }

        // Check whether another soldier already has this ID.
        foreach (Soldier soldier in soldiers)
        {
            if (soldier != original)
            {
                if (string.Equals(
                    soldier.Id,
                    txtId.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("The ID must be unique.");
                    return;
                }
            }
        }

        // Check that a duty station is selected.
        if (cboStation.Text.Trim() == "")
        {
            MessageBox.Show("Choose a duty station.");
            return;
        }

        // Build a candidate instead of modifying the original record as you type.
        // If validation/calculation fails or Cancel is clicked, the original is unchanged.
        Soldier candidate = new Soldier
        {
            Id = txtId.Text.Trim(),
            FirstName = txtFirstName.Text.Trim(),
            MiddleName = txtMiddleName.Text.Trim(),
            LastName = txtLastName.Text.Trim(),
            Rank = txtRank.Text.Trim(),
            Unit = txtUnit.Text.Trim(),
            DutyStation = cboStation.Text,
            PayGrade = cboGrade.Text,
            YearsOfService = numYears.Value,
            WithDependents = chkDependents.Checked,
            GovernmentQuarters = chkQuarters.Checked,
            BahRate = numBah.Value,
            Clothing = numClothing.Value,
            SpecialPay = numSpecial.Value,
            OHA = numOha.Value,
            FSA = numFsa.Value,
            FederalTax = numFederal.Value,
            StateTax = numState.Value,
            AllotmentsDebt = numAllotmentsDebt.Value
        };
        try { candidate.Calculate(); }
        catch (Exception ex) { MessageBox.Show(ex.Message); return; }

        if (original == null) soldiers.Add(candidate); // Add only after validation.
        else soldiers[soldiers.IndexOf(original)] = candidate; // Replace the saved record.
        SelectedSoldier = candidate;
        DialogResult = DialogResult.OK; // Close and tell MainForm to refresh.
    }
    void Delete_Click(object? sender, EventArgs e)
    {
        if (original == null) return;
        if (MessageBox.Show("Delete " + original.Name + "?", "Delete soldier",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        soldiers.Remove(original);
        SelectedSoldier = soldiers.FirstOrDefault(); // null is safe when the list is empty.
        DialogResult = DialogResult.OK;
    }
    void Cancel_Click(object? sender, EventArgs e)
    {
        // No list changes occur from typing. Cancel and the window X discard the draft.
        DialogResult = DialogResult.Cancel;
    }

    private void numBah_ValueChanged(object sender, EventArgs e)
    {

    }

    private void numMidMonth_ValueChanged(object sender, EventArgs e)
    {
        
    }
}
