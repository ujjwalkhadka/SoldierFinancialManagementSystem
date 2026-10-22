#nullable disable
namespace SoldierFinanceSample
{
partial class SoldierManagementForm
{
    private System.ComponentModel.IContainer components = null;
    // Designer-owned layout: use View Designer to move or resize controls.
    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }
        private void InitializeComponent()
        {
            header = new Panel();
            lblInstructions = new Label();
            footer = new Panel();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            tabs = new TabControl();
            identityPage = new TabPage();
            lbltxtId = new Label();
            txtId = new TextBox();
            lbltxtFirstName = new Label();
            txtFirstName = new TextBox();
            lbltxtMiddleName = new Label();
            txtMiddleName = new TextBox();
            lbltxtLastName = new Label();
            txtLastName = new TextBox();
            lbltxtRank = new Label();
            txtRank = new TextBox();
            lblcboGrade = new Label();
            cboGrade = new ComboBox();
            lbltxtUnit = new Label();
            txtUnit = new TextBox();
            lblnumYears = new Label();
            numYears = new NumericUpDown();
            lblcboStation = new Label();
            cboStation = new ComboBox();
            chkDependents = new CheckBox();
            chkQuarters = new CheckBox();
            entitlementsPage = new TabPage();
            lblnumBah = new Label();
            numBah = new NumericUpDown();
            lblnumOha = new Label();
            numOha = new NumericUpDown();
            lblnumClothing = new Label();
            numClothing = new NumericUpDown();
            lblnumFsa = new Label();
            numFsa = new NumericUpDown();
            lblnumSpecial = new Label();
            numSpecial = new NumericUpDown();
            lblHousingHelp = new Label();
            deductionsPage = new TabPage();
            lblnumFederal = new Label();
            numFederal = new NumericUpDown();
            lblnumState = new Label();
            numState = new NumericUpDown();
            lblnumAllotmentsDebt = new Label();
            numAllotmentsDebt = new NumericUpDown();
            summaryPage = new TabPage();
            lblnumMidMonth = new Label();
            numMidMonth = new NumericUpDown();
            lblSummaryHelp = new Label();
            header.SuspendLayout();
            footer.SuspendLayout();
            tabs.SuspendLayout();
            identityPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYears).BeginInit();
            entitlementsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numClothing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFsa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSpecial).BeginInit();
            deductionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFederal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAllotmentsDebt).BeginInit();
            summaryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMidMonth).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(lblInstructions);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(5, 6, 5, 6);
            header.Name = "header";
            header.Size = new Size(1886, 140);
            header.TabIndex = 2;
            // 
            // lblInstructions
            // 
            lblInstructions.Location = new Point(615, 61);
            lblInstructions.Margin = new Padding(5, 0, 5, 0);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(627, 57);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = "Edit the inputs, then Save. Cancel leaves the record unchanged.";
            // 
            // footer
            // 
            footer.Controls.Add(btnSave);
            footer.Controls.Add(btnDelete);
            footer.Controls.Add(btnCancel);
            footer.Dock = DockStyle.Bottom;
            footer.Location = new Point(0, 1320);
            footer.Margin = new Padding(5, 6, 5, 6);
            footer.Name = "footer";
            footer.Size = new Size(1886, 120);
            footer.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1114, 24);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(223, 68);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save changes";
            btnSave.Click += Save_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1363, 24);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(223, 68);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete soldier";
            btnDelete.Click += Delete_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(1611, 24);
            btnCancel.Margin = new Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(223, 68);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.Click += Cancel_Click;
            // 
            // tabs
            // 
            tabs.Controls.Add(identityPage);
            tabs.Controls.Add(entitlementsPage);
            tabs.Controls.Add(deductionsPage);
            tabs.Controls.Add(summaryPage);
            tabs.Dock = DockStyle.Fill;
            tabs.Location = new Point(0, 140);
            tabs.Margin = new Padding(5, 6, 5, 6);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1886, 1180);
            tabs.TabIndex = 0;
            // 
            // identityPage
            // 
            identityPage.AutoScroll = true;
            identityPage.Controls.Add(lbltxtId);
            identityPage.Controls.Add(txtId);
            identityPage.Controls.Add(lbltxtFirstName);
            identityPage.Controls.Add(txtFirstName);
            identityPage.Controls.Add(lbltxtMiddleName);
            identityPage.Controls.Add(txtMiddleName);
            identityPage.Controls.Add(lbltxtLastName);
            identityPage.Controls.Add(txtLastName);
            identityPage.Controls.Add(lbltxtRank);
            identityPage.Controls.Add(txtRank);
            identityPage.Controls.Add(lblcboGrade);
            identityPage.Controls.Add(cboGrade);
            identityPage.Controls.Add(lbltxtUnit);
            identityPage.Controls.Add(txtUnit);
            identityPage.Controls.Add(lblnumYears);
            identityPage.Controls.Add(numYears);
            identityPage.Controls.Add(lblcboStation);
            identityPage.Controls.Add(cboStation);
            identityPage.Controls.Add(chkDependents);
            identityPage.Controls.Add(chkQuarters);
            identityPage.Location = new Point(4, 39);
            identityPage.Margin = new Padding(5, 6, 5, 6);
            identityPage.Name = "identityPage";
            identityPage.Size = new Size(1878, 1137);
            identityPage.TabIndex = 0;
            identityPage.Text = "Personal Details";
            // 
            // lbltxtId
            // 
            lbltxtId.Location = new Point(41, 52);
            lbltxtId.Margin = new Padding(5, 0, 5, 0);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(840, 52);
            lbltxtId.TabIndex = 0;
            lbltxtId.Text = "SSN";
            // 
            // txtId
            // 
            txtId.Location = new Point(41, 116);
            txtId.Margin = new Padding(5, 6, 5, 6);
            txtId.Name = "txtId";
            txtId.Size = new Size(837, 35);
            txtId.TabIndex = 0;
            // 
            // lbltxtFirstName
            // 
            lbltxtFirstName.Location = new Point(958, 52);
            lbltxtFirstName.Margin = new Padding(5, 0, 5, 0);
            lbltxtFirstName.Name = "lbltxtFirstName";
            lbltxtFirstName.Size = new Size(840, 52);
            lbltxtFirstName.TabIndex = 1;
            lbltxtFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(958, 116);
            txtFirstName.Margin = new Padding(5, 6, 5, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(837, 35);
            txtFirstName.TabIndex = 1;
            // 
            // lbltxtMiddleName
            // 
            lbltxtMiddleName.Location = new Point(41, 228);
            lbltxtMiddleName.Margin = new Padding(5, 0, 5, 0);
            lbltxtMiddleName.Name = "lbltxtMiddleName";
            lbltxtMiddleName.Size = new Size(840, 52);
            lbltxtMiddleName.TabIndex = 2;
            lbltxtMiddleName.Text = "Middle (optional)";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(41, 292);
            txtMiddleName.Margin = new Padding(5, 6, 5, 6);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(837, 35);
            txtMiddleName.TabIndex = 2;
            // 
            // lbltxtLastName
            // 
            lbltxtLastName.Location = new Point(958, 228);
            lbltxtLastName.Margin = new Padding(5, 0, 5, 0);
            lbltxtLastName.Name = "lbltxtLastName";
            lbltxtLastName.Size = new Size(840, 52);
            lbltxtLastName.TabIndex = 3;
            lbltxtLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(958, 292);
            txtLastName.Margin = new Padding(5, 6, 5, 6);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(837, 35);
            txtLastName.TabIndex = 3;
            // 
            // lbltxtRank
            // 
            lbltxtRank.Location = new Point(41, 404);
            lbltxtRank.Margin = new Padding(5, 0, 5, 0);
            lbltxtRank.Name = "lbltxtRank";
            lbltxtRank.Size = new Size(840, 52);
            lbltxtRank.TabIndex = 4;
            lbltxtRank.Text = "Rank (grade determines pay)";
            // 
            // txtRank
            // 
            txtRank.Location = new Point(41, 468);
            txtRank.Margin = new Padding(5, 6, 5, 6);
            txtRank.Name = "txtRank";
            txtRank.Size = new Size(837, 35);
            txtRank.TabIndex = 4;
            // 
            // lblcboGrade
            // 
            lblcboGrade.Location = new Point(958, 404);
            lblcboGrade.Margin = new Padding(5, 0, 5, 0);
            lblcboGrade.Name = "lblcboGrade";
            lblcboGrade.Size = new Size(840, 52);
            lblcboGrade.TabIndex = 5;
            lblcboGrade.Text = "Pay grade (calculation input)";
            // 
            // cboGrade
            // 
            cboGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrade.Items.AddRange(new object[] { "E-2", "E-3", "E-4", "E-5", "E-6", "E-7", "E-8" });
            cboGrade.Location = new Point(958, 468);
            cboGrade.Margin = new Padding(5, 6, 5, 6);
            cboGrade.Name = "cboGrade";
            cboGrade.Size = new Size(837, 38);
            cboGrade.TabIndex = 5;
            cboGrade.SelectedIndexChanged += BahInputChanged;
            // 
            // lbltxtUnit
            // 
            lbltxtUnit.Location = new Point(41, 580);
            lbltxtUnit.Margin = new Padding(5, 0, 5, 0);
            lbltxtUnit.Name = "lbltxtUnit";
            lbltxtUnit.Size = new Size(840, 52);
            lbltxtUnit.TabIndex = 6;
            lbltxtUnit.Text = "Unit";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(41, 644);
            txtUnit.Margin = new Padding(5, 6, 5, 6);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(837, 35);
            txtUnit.TabIndex = 6;
            // 
            // lblnumYears
            // 
            lblnumYears.Location = new Point(958, 580);
            lblnumYears.Margin = new Padding(5, 0, 5, 0);
            lblnumYears.Name = "lblnumYears";
            lblnumYears.Size = new Size(840, 52);
            lblnumYears.TabIndex = 7;
            lblnumYears.Text = "Years of Service";
            // 
            // numYears
            // 
            numYears.DecimalPlaces = 2;
            numYears.Location = new Point(958, 644);
            numYears.Margin = new Padding(5, 6, 5, 6);
            numYears.Maximum = new decimal(new int[] { 18, 0, 0, 0 });
            numYears.Name = "numYears";
            numYears.Size = new Size(840, 35);
            numYears.TabIndex = 7;
            numYears.ThousandsSeparator = true;
            // 
            // lblcboStation
            // 
            lblcboStation.Location = new Point(41, 756);
            lblcboStation.Margin = new Padding(5, 0, 5, 0);
            lblcboStation.Name = "lblcboStation";
            lblcboStation.Size = new Size(840, 52);
            lblcboStation.TabIndex = 8;
            lblcboStation.Text = "Duty Station";
            // 
            // cboStation
            // 
            cboStation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStation.Items.AddRange(new object[] { "Fort Hood, TX (TX286)", "Fort Bliss, TX (TX279)", "Fort Sam Houston, TX (TX285)", "Fort Riley, KS (KS100)", "Fort Carson, CO (CO046)", "Fort Campbell, KY (KY106)", "Fort Jackson, SC (SC260)", "Schofield Barracks, HI (HI408)", "Other station (manual BAH)" });
            cboStation.Location = new Point(41, 820);
            cboStation.Margin = new Padding(5, 6, 5, 6);
            cboStation.Name = "cboStation";
            cboStation.Size = new Size(837, 38);
            cboStation.TabIndex = 8;
            cboStation.SelectedIndexChanged += BahInputChanged;
            // 
            // chkDependents
            // 
            chkDependents.Location = new Point(958, 820);
            chkDependents.Margin = new Padding(5, 6, 5, 6);
            chkDependents.Name = "chkDependents";
            chkDependents.Size = new Size(686, 56);
            chkDependents.TabIndex = 9;
            chkDependents.Text = "With dependents";
            chkDependents.CheckedChanged += BahInputChanged;
            // 
            // chkQuarters
            // 
            chkQuarters.Location = new Point(958, 920);
            chkQuarters.Margin = new Padding(5, 6, 5, 6);
            chkQuarters.Name = "chkQuarters";
            chkQuarters.Size = new Size(806, 56);
            chkQuarters.TabIndex = 10;
            chkQuarters.Text = "Government quarters (BAH = 0)";
            chkQuarters.CheckedChanged += BahInputChanged;
            // 
            // entitlementsPage
            // 
            entitlementsPage.AutoScroll = true;
            entitlementsPage.Controls.Add(lblnumBah);
            entitlementsPage.Controls.Add(numBah);
            entitlementsPage.Controls.Add(lblnumOha);
            entitlementsPage.Controls.Add(numOha);
            entitlementsPage.Controls.Add(lblnumClothing);
            entitlementsPage.Controls.Add(numClothing);
            entitlementsPage.Controls.Add(lblnumFsa);
            entitlementsPage.Controls.Add(numFsa);
            entitlementsPage.Controls.Add(lblnumSpecial);
            entitlementsPage.Controls.Add(numSpecial);
            entitlementsPage.Controls.Add(lblHousingHelp);
            entitlementsPage.Location = new Point(4, 39);
            entitlementsPage.Margin = new Padding(5, 6, 5, 6);
            entitlementsPage.Name = "entitlementsPage";
            entitlementsPage.Size = new Size(1878, 1137);
            entitlementsPage.TabIndex = 1;
            entitlementsPage.Text = "Entitlements";
            // 
            // lblnumBah
            // 
            lblnumBah.Location = new Point(41, 52);
            lblnumBah.Margin = new Padding(5, 0, 5, 0);
            lblnumBah.Name = "lblnumBah";
            lblnumBah.Size = new Size(840, 52);
            lblnumBah.TabIndex = 0;
            lblnumBah.Text = "Monthly locality BAH rate";
            // 
            // numBah
            // 
            numBah.DecimalPlaces = 2;
            numBah.Location = new Point(41, 116);
            numBah.Margin = new Padding(5, 6, 5, 6);
            numBah.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numBah.Name = "numBah";
            numBah.Size = new Size(840, 35);
            numBah.TabIndex = 0;
            numBah.ThousandsSeparator = true;
            numBah.ValueChanged += numBah_ValueChanged;
            // 
            // lblnumOha
            // 
            lblnumOha.Location = new Point(958, 52);
            lblnumOha.Margin = new Padding(5, 0, 5, 0);
            lblnumOha.Name = "lblnumOha";
            lblnumOha.Size = new Size(840, 52);
            lblnumOha.TabIndex = 1;
            lblnumOha.Text = "Overseas Housing Allowance (OHA)";
            // 
            // numOha
            // 
            numOha.DecimalPlaces = 2;
            numOha.Location = new Point(958, 116);
            numOha.Margin = new Padding(5, 6, 5, 6);
            numOha.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numOha.Name = "numOha";
            numOha.Size = new Size(840, 35);
            numOha.TabIndex = 1;
            numOha.ThousandsSeparator = true;
            // 
            // lblnumClothing
            // 
            lblnumClothing.Location = new Point(41, 228);
            lblnumClothing.Margin = new Padding(5, 0, 5, 0);
            lblnumClothing.Name = "lblnumClothing";
            lblnumClothing.Size = new Size(840, 52);
            lblnumClothing.TabIndex = 2;
            lblnumClothing.Text = "Clothing Allowance";
            // 
            // numClothing
            // 
            numClothing.DecimalPlaces = 2;
            numClothing.Location = new Point(41, 292);
            numClothing.Margin = new Padding(5, 6, 5, 6);
            numClothing.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numClothing.Name = "numClothing";
            numClothing.Size = new Size(840, 35);
            numClothing.TabIndex = 2;
            numClothing.ThousandsSeparator = true;
            // 
            // lblnumFsa
            // 
            lblnumFsa.Location = new Point(958, 228);
            lblnumFsa.Margin = new Padding(5, 0, 5, 0);
            lblnumFsa.Name = "lblnumFsa";
            lblnumFsa.Size = new Size(840, 52);
            lblnumFsa.TabIndex = 3;
            lblnumFsa.Text = "Family Separation Allowance (FSA)";
            // 
            // numFsa
            // 
            numFsa.DecimalPlaces = 2;
            numFsa.Location = new Point(958, 292);
            numFsa.Margin = new Padding(5, 6, 5, 6);
            numFsa.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numFsa.Name = "numFsa";
            numFsa.Size = new Size(840, 35);
            numFsa.TabIndex = 3;
            numFsa.ThousandsSeparator = true;
            // 
            // lblnumSpecial
            // 
            lblnumSpecial.Location = new Point(41, 404);
            lblnumSpecial.Margin = new Padding(5, 0, 5, 0);
            lblnumSpecial.Name = "lblnumSpecial";
            lblnumSpecial.Size = new Size(840, 52);
            lblnumSpecial.TabIndex = 4;
            lblnumSpecial.Text = "Special Pay";
            // 
            // numSpecial
            // 
            numSpecial.DecimalPlaces = 2;
            numSpecial.Location = new Point(41, 468);
            numSpecial.Margin = new Padding(5, 6, 5, 6);
            numSpecial.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numSpecial.Name = "numSpecial";
            numSpecial.Size = new Size(840, 35);
            numSpecial.TabIndex = 4;
            numSpecial.ThousandsSeparator = true;
            // 
            // lblHousingHelp
            // 
            lblHousingHelp.Location = new Point(41, 650);
            lblHousingHelp.Margin = new Padding(5, 0, 5, 0);
            lblHousingHelp.Name = "lblHousingHelp";
            lblHousingHelp.Size = new Size(1714, 140);
            lblHousingHelp.TabIndex = 5;
            lblHousingHelp.Text = "Base Salary and BAS calculate automatically on Save. Enter OHA and FSA only as authorized amounts. In this simplified model, positive OHA replaces BAH rather than adding both housing allowances.";
            // 
            // deductionsPage
            // 
            deductionsPage.AutoScroll = true;
            deductionsPage.Controls.Add(lblnumFederal);
            deductionsPage.Controls.Add(numFederal);
            deductionsPage.Controls.Add(lblnumState);
            deductionsPage.Controls.Add(numState);
            deductionsPage.Controls.Add(lblnumAllotmentsDebt);
            deductionsPage.Controls.Add(numAllotmentsDebt);
            deductionsPage.Location = new Point(4, 39);
            deductionsPage.Margin = new Padding(5, 6, 5, 6);
            deductionsPage.Name = "deductionsPage";
            deductionsPage.Size = new Size(1878, 1137);
            deductionsPage.TabIndex = 2;
            deductionsPage.Text = "Deductions";
            // 
            // lblnumFederal
            // 
            lblnumFederal.Location = new Point(41, 52);
            lblnumFederal.Margin = new Padding(5, 0, 5, 0);
            lblnumFederal.Name = "lblnumFederal";
            lblnumFederal.Size = new Size(840, 52);
            lblnumFederal.TabIndex = 0;
            lblnumFederal.Text = "Federal Income Tax Withheld";
            // 
            // numFederal
            // 
            numFederal.DecimalPlaces = 2;
            numFederal.Location = new Point(41, 116);
            numFederal.Margin = new Padding(5, 6, 5, 6);
            numFederal.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numFederal.Name = "numFederal";
            numFederal.Size = new Size(840, 35);
            numFederal.TabIndex = 0;
            numFederal.ThousandsSeparator = true;
            // 
            // lblnumState
            // 
            lblnumState.Location = new Point(958, 52);
            lblnumState.Margin = new Padding(5, 0, 5, 0);
            lblnumState.Name = "lblnumState";
            lblnumState.Size = new Size(840, 52);
            lblnumState.TabIndex = 1;
            lblnumState.Text = "State Income Tax Withheld";
            // 
            // numState
            // 
            numState.DecimalPlaces = 2;
            numState.Location = new Point(958, 116);
            numState.Margin = new Padding(5, 6, 5, 6);
            numState.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numState.Name = "numState";
            numState.Size = new Size(840, 35);
            numState.TabIndex = 1;
            numState.ThousandsSeparator = true;
            // 
            // lblnumAllotmentsDebt
            // 
            lblnumAllotmentsDebt.Location = new Point(41, 228);
            lblnumAllotmentsDebt.Margin = new Padding(5, 0, 5, 0);
            lblnumAllotmentsDebt.Name = "lblnumAllotmentsDebt";
            lblnumAllotmentsDebt.Size = new Size(840, 52);
            lblnumAllotmentsDebt.TabIndex = 2;
            lblnumAllotmentsDebt.Text = "Allotments/Debt Collections";
            // 
            // numAllotmentsDebt
            // 
            numAllotmentsDebt.DecimalPlaces = 2;
            numAllotmentsDebt.Location = new Point(41, 292);
            numAllotmentsDebt.Margin = new Padding(5, 6, 5, 6);
            numAllotmentsDebt.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numAllotmentsDebt.Name = "numAllotmentsDebt";
            numAllotmentsDebt.Size = new Size(840, 35);
            numAllotmentsDebt.TabIndex = 2;
            numAllotmentsDebt.ThousandsSeparator = true;
            // 
            // summaryPage
            // 
            summaryPage.AutoScroll = true;
            summaryPage.Controls.Add(lblnumMidMonth);
            summaryPage.Controls.Add(numMidMonth);
            summaryPage.Controls.Add(lblSummaryHelp);
            summaryPage.Location = new Point(4, 39);
            summaryPage.Margin = new Padding(5, 6, 5, 6);
            summaryPage.Name = "summaryPage";
            summaryPage.Size = new Size(1878, 1137);
            summaryPage.TabIndex = 3;
            summaryPage.Text = "Pay Summary";
            // 
            // lblnumMidMonth
            // 
            lblnumMidMonth.Location = new Point(41, 52);
            lblnumMidMonth.Margin = new Padding(5, 0, 5, 0);
            lblnumMidMonth.Name = "lblnumMidMonth";
            lblnumMidMonth.Size = new Size(840, 52);
            lblnumMidMonth.TabIndex = 0;
            lblnumMidMonth.Text = "Mid Month Deposit already paid";
            // 
            // numMidMonth
            // 
            numMidMonth.DecimalPlaces = 2;
            numMidMonth.Location = new Point(41, 116);
            numMidMonth.Margin = new Padding(5, 6, 5, 6);
            numMidMonth.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numMidMonth.Name = "numMidMonth";
            numMidMonth.Size = new Size(840, 35);
            numMidMonth.TabIndex = 0;
            numMidMonth.ThousandsSeparator = true;
            numMidMonth.ValueChanged += numMidMonth_ValueChanged;
            // 
            // lblSummaryHelp
            // 
            lblSummaryHelp.Location = new Point(41, 280);
            lblSummaryHelp.Margin = new Padding(5, 0, 5, 0);
            lblSummaryHelp.Name = "lblSummaryHelp";
            lblSummaryHelp.Size = new Size(1714, 140);
            lblSummaryHelp.TabIndex = 1;
            lblSummaryHelp.Text = "Total Entitlements, Total Deductions, Monthly Salary and End of Month Deposit calculate on Save. Allotments/Debt Collections is counted once inside Total Deductions.";
            // 
            // SoldierManagementForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1886, 1440);
            Controls.Add(tabs);
            Controls.Add(footer);
            Controls.Add(header);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(1869, 1376);
            Name = "SoldierManagementForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Soldier Management";
            header.ResumeLayout(false);
            footer.ResumeLayout(false);
            tabs.ResumeLayout(false);
            identityPage.ResumeLayout(false);
            identityPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYears).EndInit();
            entitlementsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numBah).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOha).EndInit();
            ((System.ComponentModel.ISupportInitialize)numClothing).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFsa).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSpecial).EndInit();
            deductionsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numFederal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numState).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAllotmentsDebt).EndInit();
            summaryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numMidMonth).EndInit();
            ResumeLayout(false);
        }
        private System.Windows.Forms.Panel header;
    private System.Windows.Forms.Label lblInstructions;
    private System.Windows.Forms.Panel footer;
    private System.Windows.Forms.TabControl tabs;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.TabPage identityPage;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.Label lbltxtId;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.Label lbltxtFirstName;
    private System.Windows.Forms.TextBox txtMiddleName;
    private System.Windows.Forms.Label lbltxtMiddleName;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.Label lbltxtLastName;
    private System.Windows.Forms.TextBox txtRank;
    private System.Windows.Forms.Label lbltxtRank;
    private System.Windows.Forms.ComboBox cboGrade;
    private System.Windows.Forms.Label lblcboGrade;
    private System.Windows.Forms.TextBox txtUnit;
    private System.Windows.Forms.Label lbltxtUnit;
    private System.Windows.Forms.NumericUpDown numYears;
    private System.Windows.Forms.Label lblnumYears;
    private System.Windows.Forms.ComboBox cboStation;
    private System.Windows.Forms.Label lblcboStation;
    private System.Windows.Forms.TabPage entitlementsPage;
    private System.Windows.Forms.NumericUpDown numBah;
    private System.Windows.Forms.Label lblnumBah;
    private System.Windows.Forms.NumericUpDown numOha;
    private System.Windows.Forms.Label lblnumOha;
    private System.Windows.Forms.NumericUpDown numClothing;
    private System.Windows.Forms.Label lblnumClothing;
    private System.Windows.Forms.NumericUpDown numFsa;
    private System.Windows.Forms.Label lblnumFsa;
    private System.Windows.Forms.NumericUpDown numSpecial;
    private System.Windows.Forms.Label lblnumSpecial;
    private System.Windows.Forms.TabPage deductionsPage;
    private System.Windows.Forms.NumericUpDown numFederal;
    private System.Windows.Forms.Label lblnumFederal;
    private System.Windows.Forms.NumericUpDown numState;
    private System.Windows.Forms.Label lblnumState;
    private System.Windows.Forms.NumericUpDown numAllotmentsDebt;
    private System.Windows.Forms.Label lblnumAllotmentsDebt;
    private System.Windows.Forms.TabPage summaryPage;
    private System.Windows.Forms.NumericUpDown numMidMonth;
    private System.Windows.Forms.Label lblnumMidMonth;
    private System.Windows.Forms.CheckBox chkDependents;
    private System.Windows.Forms.CheckBox chkQuarters;
    private System.Windows.Forms.Label lblHousingHelp;
    private System.Windows.Forms.Label lblSummaryHelp;
}
}
