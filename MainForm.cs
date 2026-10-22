/*This form only displays records, searches and exports. editing is done is different form*/


using System.Globalization;
namespace SoldierFinanceSample;


public partial class MainForm : Form
{
    List<Soldier> soldiers = new List<Soldier>();
    Soldier current = new Soldier();
    bool loading;

    // LoginForm reads this after MainForm closes to distinguish Logout from Exit.
    public bool LogoutRequested { get; private set; }

    public MainForm() : this(new List<Soldier>()) { }
    public MainForm(List<Soldier> demoSoldiers)
    {
        InitializeComponent();
        soldiers = demoSoldiers;
        if (soldiers.Count > 0)
        {
            Selector(soldiers, soldiers[0]);//to show first value
        }
        else
        {
            Selector(soldiers, null);
        }
    }
    // Display either the whole list or search results. The original list stays intact.
    void Selector(List<Soldier> displayed, Soldier selected)
    {
        loading = true;

        cmbSelector.DataSource = null;
        cmbSelector.DataSource = displayed;
        cmbSelector.SelectedItem = selected;

        current = cmbSelector.SelectedItem as Soldier;

        loading = false;

        Selector_SelectedIndexChanged(cmbSelector, EventArgs.Empty);
    }
    void Selector_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (loading)
        {
            return;
        }

        current = cmbSelector.SelectedItem as Soldier;

        if (current != null)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
        else
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        ShowData();
    }
    /* ShowDialog opens the separate form and waits until it is closed.
     A null selected Soldier means Add mode; deleteOnly means review/delete mode.*/

    void OpenManagement(Soldier selected, bool deleteOnly = false)
    {
        using SoldierManagementForm form =
            new SoldierManagementForm(soldiers, selected, deleteOnly);

        if (form.ShowDialog(this) == DialogResult.OK)
        {
            txtSearch.Clear();
            Selector(soldiers, form.SelectedSoldier);
        }
    }
    void Add_Click(object sender, EventArgs e)
    {
        OpenManagement(null);
    }
    void Update_Click(object sender, EventArgs e)
    {
        if (current != null)
        {
            OpenManagement(current);
        }
    }
    void Delete_Click(object sender, EventArgs e)
    {
        if (current != null)
        {
            OpenManagement(current, true);
        }
    }
    // Partial matches ignore letter case. Search by name, demo SSN or rank.
    void Search_Click(object sender, EventArgs e)
    {
        string query = txtSearch.Text.Trim();

        if (query == "")
        {
            ShowAll_Click(sender, e);
            return;
        }

        List<Soldier> matches = new List<Soldier>();

        foreach (Soldier soldier in soldiers)
        {
            if (soldier.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                soldier.Id.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                soldier.Rank.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                matches.Add(soldier);
            }
        }

        if (matches.Count > 0)
        {
            Selector(matches, matches[0]);
        }
        else
        {
            Selector(matches, null);
            MessageBox.Show("No matching soldiers found.");
        }
    }
    void ShowAll_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();

        if (current != null)
        {
            Selector(soldiers, current);
        }
        else if (soldiers.Count > 0)
        {
            Selector(soldiers, soldiers[0]);
        }
        else
        {
            Selector(soldiers, null);
        }
    }

    // Fill read-only controls without changing the selected record.
    void ShowData()
    {
        if (current == null)
        {
            // Clear the textboxes when no soldier is selected.
            foreach (TabPage page in tabs.TabPages)
            {
                foreach (Control control in page.Controls)
                {
                    if (control is TextBox box)
                    {
                        box.Clear();
                    }

                }
            }

            return;
        }

        txtSsn.Text = current.Id;
        txtFirstName.Text = current.FirstName;
        txtMiddleName.Text = current.MiddleName;
        txtLastName.Text = current.LastName;
        txtRank.Text = current.Rank;

        if (current.WithDependents)
        {
            txtDependents.Text = "Yes";
        }
        else
        {
            txtDependents.Text = "No";
        }

        txtUnit.Text = current.Unit;
        txtYears.Text = current.YearsOfService.ToString("0.##");
        txtStation.Text = current.DutyStation;

        ShowAmount(txtBasicPay, lblBasicPay, current.BasicPay);
        ShowAmount(txtBah, lblBah, current.BAH);
        ShowAmount(txtBas, lblBas, current.BAS);
        ShowAmount(txtOha, lblOha, current.OHA);
        ShowAmount(txtClothing, lblClothing, current.Clothing);
        ShowAmount(txtFsa, lblFsa, current.FSA);
        ShowAmount(txtSpecial, lblSpecial, current.SpecialPay);

        ShowAmount(txtFederal, lblFederal, current.FederalTax);
        ShowAmount(txtState, lblState, current.StateTax);
        ShowAmount(txtFica, lblFica, current.FicaMedicare);
        ShowAmount(txtInsurance, lblInsurance, current.Insurance);
        ShowAmount(txtAllotmentsDebt, lblAllotmentsDebt, current.AllotmentsDebt);

        ShowAmount(txtTotalEntitlements, lblTotalEntitlements, current.TotalEntitlements);
        ShowAmount(txtTotalDeductions, lblTotalDeductions, current.TotalDeductions);
        ShowAmount(txtMonthlySalary, lblMonthlySalary, current.NetPay);
        ShowAmount(txtMidMonth, lblMidMonth, current.MidMonthPay);
        ShowAmount(txtEndMonth, lblEndMonth, current.EndMonthPay);
    }
    static void ShowAmount(TextBox box, Label label, decimal amount)
    {
        box.Text = amount.ToString("N2", CultureInfo.CurrentCulture);
        box.Visible = true;
        label.Visible = true;
    }
    // Save all current records to one real XLSX worksheet through ExcelExporter.
    private void btnSave_Click(object? sender, EventArgs e)
    {
        // Stop with a message when there are no records to export.
        if (soldiers.Count == 0)
        {
            MessageBox.Show("No soldiers available.");
            return;
        }

        string folder = @"C:\Files";
        string path = Path.Combine(folder, "SoldierFinance.xlsx");
        try
        {
            // Create the folder if missing; an existing folder is left in place.
            Directory.CreateDirectory(folder);

            ExcelExporter.Save(soldiers, path);
            MessageBox.Show("All soldiers saved to:\n" + path,
                "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Could not save the Excel file.\n" + ex.Message,
                "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtBah_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtMidMonth_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        // Close this session, not the application. LoginForm will become visible again.
        LogoutRequested = true;
        Close();
    }
}
