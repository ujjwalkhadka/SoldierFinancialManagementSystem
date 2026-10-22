#nullable disable
namespace SoldierFinanceSample
{
partial class MainForm
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
            toolbar = new Panel();
            cmbSelector = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            tabs = new TabControl();
            personalPage = new TabPage();
            lblSsn = new Label();
            txtSsn = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblRank = new Label();
            txtRank = new TextBox();
            lblDependents = new Label();
            txtDependents = new TextBox();
            lblUnit = new Label();
            txtUnit = new TextBox();
            lblYears = new Label();
            txtYears = new TextBox();
            lblStation = new Label();
            txtStation = new TextBox();
            entitlementsPage = new TabPage();
            lblBasicPay = new Label();
            txtBasicPay = new TextBox();
            lblBah = new Label();
            txtBah = new TextBox();
            lblBas = new Label();
            txtBas = new TextBox();
            lblOha = new Label();
            txtOha = new TextBox();
            lblClothing = new Label();
            txtClothing = new TextBox();
            lblFsa = new Label();
            txtFsa = new TextBox();
            lblSpecial = new Label();
            txtSpecial = new TextBox();
            deductionsPage = new TabPage();
            lblFederal = new Label();
            txtFederal = new TextBox();
            lblState = new Label();
            txtState = new TextBox();
            lblFica = new Label();
            txtFica = new TextBox();
            lblInsurance = new Label();
            txtInsurance = new TextBox();
            lblAllotmentsDebt = new Label();
            txtAllotmentsDebt = new TextBox();
            summaryPage = new TabPage();
            lblTotalEntitlements = new Label();
            txtTotalEntitlements = new TextBox();
            lblTotalDeductions = new Label();
            txtTotalDeductions = new TextBox();
            lblMonthlySalary = new Label();
            txtMonthlySalary = new TextBox();
            lblMidMonth = new Label();
            txtMidMonth = new TextBox();
            lblEndMonth = new Label();
            txtEndMonth = new TextBox();
            btnLogout = new Button();
            toolbar.SuspendLayout();
            tabs.SuspendLayout();
            personalPage.SuspendLayout();
            entitlementsPage.SuspendLayout();
            deductionsPage.SuspendLayout();
            summaryPage.SuspendLayout();
            SuspendLayout();
            // 
            // toolbar
            // 
            toolbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            toolbar.Controls.Add(cmbSelector);
            toolbar.Controls.Add(btnAdd);
            toolbar.Controls.Add(btnUpdate);
            toolbar.Controls.Add(btnDelete);
            toolbar.Controls.Add(btnSave);
            toolbar.Controls.Add(lblSearch);
            toolbar.Controls.Add(txtSearch);
            toolbar.Controls.Add(btnSearch);
            toolbar.Controls.Add(btnShowAll);
            toolbar.Location = new Point(0, 0);
            toolbar.Margin = new Padding(5, 6, 5, 6);
            toolbar.Name = "toolbar";
            toolbar.Size = new Size(1962, 240);
            toolbar.TabIndex = 1;
            // 
            // cmbSelector
            // 
            cmbSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSelector.Location = new Point(27, 30);
            cmbSelector.Margin = new Padding(5, 6, 5, 6);
            cmbSelector.Name = "cmbSelector";
            cmbSelector.Size = new Size(597, 38);
            cmbSelector.TabIndex = 0;
            cmbSelector.SelectedIndexChanged += Selector_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(823, 30);
            btnAdd.Margin = new Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(189, 68);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add soldier";
            btnAdd.Click += Add_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1041, 33);
            btnUpdate.Margin = new Padding(5, 6, 5, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 62);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update soldier";
            btnUpdate.Click += Update_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1259, 30);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(209, 62);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete soldier";
            btnDelete.Click += Delete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1259, 124);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(209, 64);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Excel";
            btnSave.Click += btnSave_Click;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(27, 138);
            lblSearch.Margin = new Padding(5, 0, 5, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(209, 50);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Name / SSN / rank";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(268, 140);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(507, 35);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(823, 124);
            btnSearch.Margin = new Padding(5, 6, 5, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(189, 64);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.Click += Search_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(1041, 124);
            btnShowAll.Margin = new Padding(5, 6, 5, 6);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(189, 64);
            btnShowAll.TabIndex = 8;
            btnShowAll.Text = "Show all";
            btnShowAll.Click += ShowAll_Click;
            // 
            // tabs
            // 
            tabs.Controls.Add(personalPage);
            tabs.Controls.Add(entitlementsPage);
            tabs.Controls.Add(deductionsPage);
            tabs.Controls.Add(summaryPage);
            tabs.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabs.Location = new Point(0, 240);
            tabs.Margin = new Padding(5, 6, 5, 6);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1966, 817);
            tabs.TabIndex = 0;
            // 
            // personalPage
            // 
            personalPage.BackColor = Color.Gainsboro;
            personalPage.Controls.Add(lblSsn);
            personalPage.Controls.Add(txtSsn);
            personalPage.Controls.Add(lblFirstName);
            personalPage.Controls.Add(txtFirstName);
            personalPage.Controls.Add(lblMiddleName);
            personalPage.Controls.Add(txtMiddleName);
            personalPage.Controls.Add(lblLastName);
            personalPage.Controls.Add(txtLastName);
            personalPage.Controls.Add(lblRank);
            personalPage.Controls.Add(txtRank);
            personalPage.Controls.Add(lblDependents);
            personalPage.Controls.Add(txtDependents);
            personalPage.Controls.Add(lblUnit);
            personalPage.Controls.Add(txtUnit);
            personalPage.Controls.Add(lblYears);
            personalPage.Controls.Add(txtYears);
            personalPage.Controls.Add(lblStation);
            personalPage.Controls.Add(txtStation);
            personalPage.Location = new Point(4, 40);
            personalPage.Margin = new Padding(5, 6, 5, 6);
            personalPage.Name = "personalPage";
            personalPage.Size = new Size(1958, 773);
            personalPage.TabIndex = 0;
            personalPage.Text = "Personal Details";
            // 
            // lblSsn
            // 
            lblSsn.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSsn.Location = new Point(189, 120);
            lblSsn.Margin = new Padding(5, 0, 5, 0);
            lblSsn.Name = "lblSsn";
            lblSsn.Size = new Size(126, 46);
            lblSsn.TabIndex = 0;
            lblSsn.Text = "SSN";
            // 
            // txtSsn
            // 
            txtSsn.BackColor = Color.WhiteSmoke;
            txtSsn.Location = new Point(355, 111);
            txtSsn.Margin = new Padding(5, 6, 5, 6);
            txtSsn.Name = "txtSsn";
            txtSsn.ReadOnly = true;
            txtSsn.Size = new Size(340, 38);
            txtSsn.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(189, 211);
            lblFirstName.Margin = new Padding(5, 0, 5, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(144, 35);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.WhiteSmoke;
            txtFirstName.Location = new Point(354, 201);
            txtFirstName.Margin = new Padding(5, 6, 5, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(340, 38);
            txtFirstName.TabIndex = 3;
            // 
            // lblMiddleName
            // 
            lblMiddleName.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMiddleName.Location = new Point(767, 201);
            lblMiddleName.Margin = new Padding(5, 0, 5, 0);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(119, 45);
            lblMiddleName.TabIndex = 4;
            lblMiddleName.Text = "Middle";
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.WhiteSmoke;
            txtMiddleName.Location = new Point(896, 201);
            txtMiddleName.Margin = new Padding(5, 6, 5, 6);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.ReadOnly = true;
            txtMiddleName.Size = new Size(340, 38);
            txtMiddleName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(1307, 201);
            lblLastName.Margin = new Padding(5, 0, 5, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(157, 45);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.WhiteSmoke;
            txtLastName.Location = new Point(1485, 201);
            txtLastName.Margin = new Padding(5, 6, 5, 6);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(374, 38);
            txtLastName.TabIndex = 7;
            // 
            // lblRank
            // 
            lblRank.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRank.Location = new Point(189, 290);
            lblRank.Margin = new Padding(5, 0, 5, 0);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(126, 60);
            lblRank.TabIndex = 8;
            lblRank.Text = "Rank";
            // 
            // txtRank
            // 
            txtRank.BackColor = Color.WhiteSmoke;
            txtRank.Location = new Point(354, 290);
            txtRank.Margin = new Padding(5, 6, 5, 6);
            txtRank.Name = "txtRank";
            txtRank.ReadOnly = true;
            txtRank.Size = new Size(340, 38);
            txtRank.TabIndex = 9;
            // 
            // lblDependents
            // 
            lblDependents.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDependents.Location = new Point(189, 378);
            lblDependents.Margin = new Padding(5, 0, 5, 0);
            lblDependents.Name = "lblDependents";
            lblDependents.Size = new Size(159, 44);
            lblDependents.TabIndex = 10;
            lblDependents.Text = "Dependents";
            // 
            // txtDependents
            // 
            txtDependents.BackColor = Color.WhiteSmoke;
            txtDependents.Location = new Point(355, 377);
            txtDependents.Margin = new Padding(5, 6, 5, 6);
            txtDependents.Name = "txtDependents";
            txtDependents.ReadOnly = true;
            txtDependents.Size = new Size(340, 38);
            txtDependents.TabIndex = 11;
            // 
            // lblUnit
            // 
            lblUnit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnit.Location = new Point(189, 466);
            lblUnit.Margin = new Padding(5, 0, 5, 0);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(144, 50);
            lblUnit.TabIndex = 12;
            lblUnit.Text = "Unit";
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.WhiteSmoke;
            txtUnit.Location = new Point(354, 466);
            txtUnit.Margin = new Padding(5, 6, 5, 6);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(341, 38);
            txtUnit.TabIndex = 13;
            // 
            // lblYears
            // 
            lblYears.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYears.Location = new Point(189, 562);
            lblYears.Margin = new Padding(5, 0, 5, 0);
            lblYears.Name = "lblYears";
            lblYears.Size = new Size(182, 47);
            lblYears.TabIndex = 14;
            lblYears.Text = "Years of Service";
            // 
            // txtYears
            // 
            txtYears.BackColor = Color.WhiteSmoke;
            txtYears.Location = new Point(474, 553);
            txtYears.Margin = new Padding(5, 6, 5, 6);
            txtYears.Name = "txtYears";
            txtYears.ReadOnly = true;
            txtYears.Size = new Size(220, 38);
            txtYears.TabIndex = 15;
            // 
            // lblStation
            // 
            lblStation.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStation.Location = new Point(189, 638);
            lblStation.Margin = new Padding(5, 0, 5, 0);
            lblStation.Name = "lblStation";
            lblStation.Size = new Size(155, 50);
            lblStation.TabIndex = 16;
            lblStation.Text = "Duty Station";
            // 
            // txtStation
            // 
            txtStation.BackColor = Color.WhiteSmoke;
            txtStation.Location = new Point(354, 638);
            txtStation.Margin = new Padding(5, 6, 5, 6);
            txtStation.Name = "txtStation";
            txtStation.ReadOnly = true;
            txtStation.Size = new Size(341, 38);
            txtStation.TabIndex = 17;
            // 
            // entitlementsPage
            // 
            entitlementsPage.AutoScroll = true;
            entitlementsPage.BackColor = Color.Gainsboro;
            entitlementsPage.Controls.Add(lblBasicPay);
            entitlementsPage.Controls.Add(txtBasicPay);
            entitlementsPage.Controls.Add(lblBah);
            entitlementsPage.Controls.Add(txtBah);
            entitlementsPage.Controls.Add(lblBas);
            entitlementsPage.Controls.Add(txtBas);
            entitlementsPage.Controls.Add(lblOha);
            entitlementsPage.Controls.Add(txtOha);
            entitlementsPage.Controls.Add(lblClothing);
            entitlementsPage.Controls.Add(txtClothing);
            entitlementsPage.Controls.Add(lblFsa);
            entitlementsPage.Controls.Add(txtFsa);
            entitlementsPage.Controls.Add(lblSpecial);
            entitlementsPage.Controls.Add(txtSpecial);
            entitlementsPage.Location = new Point(4, 40);
            entitlementsPage.Margin = new Padding(5, 6, 5, 6);
            entitlementsPage.Name = "entitlementsPage";
            entitlementsPage.Size = new Size(1958, 773);
            entitlementsPage.TabIndex = 1;
            entitlementsPage.Text = "Entitlements";
            // 
            // lblBasicPay
            // 
            lblBasicPay.Location = new Point(315, 158);
            lblBasicPay.Margin = new Padding(5, 0, 5, 0);
            lblBasicPay.Name = "lblBasicPay";
            lblBasicPay.Size = new Size(178, 48);
            lblBasicPay.TabIndex = 0;
            lblBasicPay.Text = "Base Salary";
            // 
            // txtBasicPay
            // 
            txtBasicPay.BackColor = Color.WhiteSmoke;
            txtBasicPay.Location = new Point(891, 155);
            txtBasicPay.Margin = new Padding(5, 6, 5, 6);
            txtBasicPay.Name = "txtBasicPay";
            txtBasicPay.ReadOnly = true;
            txtBasicPay.Size = new Size(340, 38);
            txtBasicPay.TabIndex = 1;
            txtBasicPay.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBah
            // 
            lblBah.Location = new Point(315, 230);
            lblBah.Margin = new Padding(5, 0, 5, 0);
            lblBah.Name = "lblBah";
            lblBah.Size = new Size(398, 49);
            lblBah.TabIndex = 2;
            lblBah.Text = "Basic Allowance for Housing (BAH)";
            // 
            // txtBah
            // 
            txtBah.BackColor = Color.WhiteSmoke;
            txtBah.Location = new Point(891, 227);
            txtBah.Margin = new Padding(5, 6, 5, 6);
            txtBah.Name = "txtBah";
            txtBah.ReadOnly = true;
            txtBah.Size = new Size(340, 38);
            txtBah.TabIndex = 3;
            txtBah.TextAlign = HorizontalAlignment.Right;
            txtBah.TextChanged += txtBah_TextChanged;
            // 
            // lblBas
            // 
            lblBas.Location = new Point(313, 301);
            lblBas.Margin = new Padding(5, 0, 5, 0);
            lblBas.Name = "lblBas";
            lblBas.Size = new Size(445, 52);
            lblBas.TabIndex = 4;
            lblBas.Text = "Basic Allowance for Subsistence (BAS)";
            // 
            // txtBas
            // 
            txtBas.BackColor = Color.WhiteSmoke;
            txtBas.Location = new Point(891, 301);
            txtBas.Margin = new Padding(5, 6, 5, 6);
            txtBas.Name = "txtBas";
            txtBas.ReadOnly = true;
            txtBas.Size = new Size(340, 38);
            txtBas.TabIndex = 5;
            txtBas.TextAlign = HorizontalAlignment.Right;
            // 
            // lblOha
            // 
            lblOha.Location = new Point(315, 370);
            lblOha.Margin = new Padding(5, 0, 5, 0);
            lblOha.Name = "lblOha";
            lblOha.Size = new Size(405, 50);
            lblOha.TabIndex = 6;
            lblOha.Text = "Overseas Housing Allowance (OHA)";
            // 
            // txtOha
            // 
            txtOha.BackColor = Color.WhiteSmoke;
            txtOha.Location = new Point(891, 370);
            txtOha.Margin = new Padding(5, 6, 5, 6);
            txtOha.Name = "txtOha";
            txtOha.ReadOnly = true;
            txtOha.Size = new Size(340, 38);
            txtOha.TabIndex = 7;
            txtOha.TextAlign = HorizontalAlignment.Right;
            // 
            // lblClothing
            // 
            lblClothing.Location = new Point(315, 439);
            lblClothing.Margin = new Padding(5, 0, 5, 0);
            lblClothing.Name = "lblClothing";
            lblClothing.Size = new Size(227, 42);
            lblClothing.TabIndex = 8;
            lblClothing.Text = "Clothing Allowance";
            // 
            // txtClothing
            // 
            txtClothing.BackColor = Color.WhiteSmoke;
            txtClothing.Location = new Point(891, 436);
            txtClothing.Margin = new Padding(5, 6, 5, 6);
            txtClothing.Name = "txtClothing";
            txtClothing.ReadOnly = true;
            txtClothing.Size = new Size(340, 38);
            txtClothing.TabIndex = 9;
            txtClothing.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFsa
            // 
            lblFsa.Location = new Point(313, 510);
            lblFsa.Margin = new Padding(5, 0, 5, 0);
            lblFsa.Name = "lblFsa";
            lblFsa.Size = new Size(391, 42);
            lblFsa.TabIndex = 10;
            lblFsa.Text = "Family Separation Allowance (FSA)";
            // 
            // txtFsa
            // 
            txtFsa.BackColor = Color.WhiteSmoke;
            txtFsa.Location = new Point(891, 507);
            txtFsa.Margin = new Padding(5, 6, 5, 6);
            txtFsa.Name = "txtFsa";
            txtFsa.ReadOnly = true;
            txtFsa.Size = new Size(340, 38);
            txtFsa.TabIndex = 11;
            txtFsa.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSpecial
            // 
            lblSpecial.Location = new Point(315, 590);
            lblSpecial.Margin = new Padding(5, 0, 5, 0);
            lblSpecial.Name = "lblSpecial";
            lblSpecial.Size = new Size(146, 36);
            lblSpecial.TabIndex = 12;
            lblSpecial.Text = "Special Pay";
            // 
            // txtSpecial
            // 
            txtSpecial.BackColor = Color.WhiteSmoke;
            txtSpecial.Location = new Point(891, 590);
            txtSpecial.Margin = new Padding(5, 6, 5, 6);
            txtSpecial.Name = "txtSpecial";
            txtSpecial.ReadOnly = true;
            txtSpecial.Size = new Size(340, 38);
            txtSpecial.TabIndex = 13;
            txtSpecial.TextAlign = HorizontalAlignment.Right;
            // 
            // deductionsPage
            // 
            deductionsPage.AutoScroll = true;
            deductionsPage.BackColor = Color.Gainsboro;
            deductionsPage.Controls.Add(lblFederal);
            deductionsPage.Controls.Add(txtFederal);
            deductionsPage.Controls.Add(lblState);
            deductionsPage.Controls.Add(txtState);
            deductionsPage.Controls.Add(lblFica);
            deductionsPage.Controls.Add(txtFica);
            deductionsPage.Controls.Add(lblInsurance);
            deductionsPage.Controls.Add(txtInsurance);
            deductionsPage.Controls.Add(lblAllotmentsDebt);
            deductionsPage.Controls.Add(txtAllotmentsDebt);
            deductionsPage.Location = new Point(4, 40);
            deductionsPage.Margin = new Padding(5, 6, 5, 6);
            deductionsPage.Name = "deductionsPage";
            deductionsPage.Size = new Size(1958, 773);
            deductionsPage.TabIndex = 2;
            deductionsPage.Text = "Deductions";
            // 
            // lblFederal
            // 
            lblFederal.Location = new Point(402, 111);
            lblFederal.Margin = new Padding(5, 0, 5, 0);
            lblFederal.Name = "lblFederal";
            lblFederal.Size = new Size(416, 64);
            lblFederal.TabIndex = 0;
            lblFederal.Text = "Federal Income Tax Withheld";
            // 
            // txtFederal
            // 
            txtFederal.BackColor = Color.WhiteSmoke;
            txtFederal.Location = new Point(1055, 111);
            txtFederal.Margin = new Padding(5, 6, 5, 6);
            txtFederal.Name = "txtFederal";
            txtFederal.ReadOnly = true;
            txtFederal.Size = new Size(340, 38);
            txtFederal.TabIndex = 1;
            txtFederal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblState
            // 
            lblState.Location = new Point(402, 180);
            lblState.Margin = new Padding(5, 0, 5, 0);
            lblState.Name = "lblState";
            lblState.Size = new Size(377, 64);
            lblState.TabIndex = 2;
            lblState.Text = "State Income Tax Withheld";
            // 
            // txtState
            // 
            txtState.BackColor = Color.WhiteSmoke;
            txtState.Location = new Point(1055, 180);
            txtState.Margin = new Padding(5, 6, 5, 6);
            txtState.Name = "txtState";
            txtState.ReadOnly = true;
            txtState.Size = new Size(340, 38);
            txtState.TabIndex = 3;
            txtState.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFica
            // 
            lblFica.Location = new Point(402, 259);
            lblFica.Margin = new Padding(5, 0, 5, 0);
            lblFica.Name = "lblFica";
            lblFica.Size = new Size(324, 64);
            lblFica.TabIndex = 4;
            lblFica.Text = "FICA/Medicare Taxes";
            // 
            // txtFica
            // 
            txtFica.BackColor = Color.WhiteSmoke;
            txtFica.Location = new Point(1055, 256);
            txtFica.Margin = new Padding(5, 6, 5, 6);
            txtFica.Name = "txtFica";
            txtFica.ReadOnly = true;
            txtFica.Size = new Size(340, 38);
            txtFica.TabIndex = 5;
            txtFica.TextAlign = HorizontalAlignment.Right;
            // 
            // lblInsurance
            // 
            lblInsurance.Location = new Point(403, 337);
            lblInsurance.Margin = new Padding(5, 0, 5, 0);
            lblInsurance.Name = "lblInsurance";
            lblInsurance.Size = new Size(453, 51);
            lblInsurance.TabIndex = 6;
            lblInsurance.Text = "Servicemembers' Group Life Insurance";
            // 
            // txtInsurance
            // 
            txtInsurance.BackColor = Color.WhiteSmoke;
            txtInsurance.Location = new Point(1055, 334);
            txtInsurance.Margin = new Padding(5, 6, 5, 6);
            txtInsurance.Name = "txtInsurance";
            txtInsurance.ReadOnly = true;
            txtInsurance.Size = new Size(340, 38);
            txtInsurance.TabIndex = 7;
            txtInsurance.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAllotmentsDebt
            // 
            lblAllotmentsDebt.Location = new Point(403, 409);
            lblAllotmentsDebt.Margin = new Padding(5, 0, 5, 0);
            lblAllotmentsDebt.Name = "lblAllotmentsDebt";
            lblAllotmentsDebt.Size = new Size(453, 64);
            lblAllotmentsDebt.TabIndex = 8;
            lblAllotmentsDebt.Text = "Allotments/Debt Collections";
            // 
            // txtAllotmentsDebt
            // 
            txtAllotmentsDebt.BackColor = Color.WhiteSmoke;
            txtAllotmentsDebt.Location = new Point(1055, 406);
            txtAllotmentsDebt.Margin = new Padding(5, 6, 5, 6);
            txtAllotmentsDebt.Name = "txtAllotmentsDebt";
            txtAllotmentsDebt.ReadOnly = true;
            txtAllotmentsDebt.Size = new Size(340, 38);
            txtAllotmentsDebt.TabIndex = 9;
            txtAllotmentsDebt.TextAlign = HorizontalAlignment.Right;
            // 
            // summaryPage
            // 
            summaryPage.BackColor = Color.Gainsboro;
            summaryPage.Controls.Add(lblTotalEntitlements);
            summaryPage.Controls.Add(txtTotalEntitlements);
            summaryPage.Controls.Add(lblTotalDeductions);
            summaryPage.Controls.Add(txtTotalDeductions);
            summaryPage.Controls.Add(lblMonthlySalary);
            summaryPage.Controls.Add(txtMonthlySalary);
            summaryPage.Controls.Add(lblMidMonth);
            summaryPage.Controls.Add(txtMidMonth);
            summaryPage.Controls.Add(lblEndMonth);
            summaryPage.Controls.Add(txtEndMonth);
            summaryPage.Location = new Point(4, 40);
            summaryPage.Margin = new Padding(5, 6, 5, 6);
            summaryPage.Name = "summaryPage";
            summaryPage.Size = new Size(1958, 773);
            summaryPage.TabIndex = 3;
            summaryPage.Text = "Pay Summary";
            // 
            // lblTotalEntitlements
            // 
            lblTotalEntitlements.Location = new Point(587, 187);
            lblTotalEntitlements.Margin = new Padding(5, 0, 5, 0);
            lblTotalEntitlements.Name = "lblTotalEntitlements";
            lblTotalEntitlements.Size = new Size(269, 53);
            lblTotalEntitlements.TabIndex = 0;
            lblTotalEntitlements.Text = "Total Entitlements";
            // 
            // txtTotalEntitlements
            // 
            txtTotalEntitlements.BackColor = Color.WhiteSmoke;
            txtTotalEntitlements.Location = new Point(1182, 187);
            txtTotalEntitlements.Margin = new Padding(5, 6, 5, 6);
            txtTotalEntitlements.Name = "txtTotalEntitlements";
            txtTotalEntitlements.ReadOnly = true;
            txtTotalEntitlements.Size = new Size(340, 38);
            txtTotalEntitlements.TabIndex = 1;
            txtTotalEntitlements.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalDeductions
            // 
            lblTotalDeductions.Location = new Point(587, 270);
            lblTotalDeductions.Margin = new Padding(5, 0, 5, 0);
            lblTotalDeductions.Name = "lblTotalDeductions";
            lblTotalDeductions.Size = new Size(276, 51);
            lblTotalDeductions.TabIndex = 2;
            lblTotalDeductions.Text = "Total Deductions";
            // 
            // txtTotalDeductions
            // 
            txtTotalDeductions.BackColor = Color.WhiteSmoke;
            txtTotalDeductions.Location = new Point(1182, 270);
            txtTotalDeductions.Margin = new Padding(5, 6, 5, 6);
            txtTotalDeductions.Name = "txtTotalDeductions";
            txtTotalDeductions.ReadOnly = true;
            txtTotalDeductions.Size = new Size(340, 38);
            txtTotalDeductions.TabIndex = 3;
            txtTotalDeductions.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMonthlySalary
            // 
            lblMonthlySalary.Location = new Point(587, 345);
            lblMonthlySalary.Margin = new Padding(5, 0, 5, 0);
            lblMonthlySalary.Name = "lblMonthlySalary";
            lblMonthlySalary.Size = new Size(350, 59);
            lblMonthlySalary.TabIndex = 4;
            lblMonthlySalary.Text = "Monthly Salary(estimated)";
            // 
            // txtMonthlySalary
            // 
            txtMonthlySalary.BackColor = Color.WhiteSmoke;
            txtMonthlySalary.Location = new Point(1182, 342);
            txtMonthlySalary.Margin = new Padding(5, 6, 5, 6);
            txtMonthlySalary.Name = "txtMonthlySalary";
            txtMonthlySalary.ReadOnly = true;
            txtMonthlySalary.Size = new Size(340, 38);
            txtMonthlySalary.TabIndex = 5;
            txtMonthlySalary.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMidMonth
            // 
            lblMidMonth.Location = new Point(587, 416);
            lblMidMonth.Margin = new Padding(5, 0, 5, 0);
            lblMidMonth.Name = "lblMidMonth";
            lblMidMonth.Size = new Size(276, 47);
            lblMidMonth.TabIndex = 6;
            lblMidMonth.Text = "Mid Month Deposit";
            // 
            // txtMidMonth
            // 
            txtMidMonth.BackColor = Color.WhiteSmoke;
            txtMidMonth.Location = new Point(1182, 416);
            txtMidMonth.Margin = new Padding(5, 6, 5, 6);
            txtMidMonth.Name = "txtMidMonth";
            txtMidMonth.ReadOnly = true;
            txtMidMonth.Size = new Size(340, 38);
            txtMidMonth.TabIndex = 7;
            txtMidMonth.TextAlign = HorizontalAlignment.Right;
            txtMidMonth.TextChanged += txtMidMonth_TextChanged;
            // 
            // lblEndMonth
            // 
            lblEndMonth.Location = new Point(587, 490);
            lblEndMonth.Margin = new Padding(5, 0, 5, 0);
            lblEndMonth.Name = "lblEndMonth";
            lblEndMonth.Size = new Size(287, 47);
            lblEndMonth.TabIndex = 8;
            lblEndMonth.Text = "End of Month Deposit";
            // 
            // txtEndMonth
            // 
            txtEndMonth.BackColor = Color.WhiteSmoke;
            txtEndMonth.Location = new Point(1182, 490);
            txtEndMonth.Margin = new Padding(5, 6, 5, 6);
            txtEndMonth.Name = "txtEndMonth";
            txtEndMonth.ReadOnly = true;
            txtEndMonth.Size = new Size(340, 38);
            txtEndMonth.TabIndex = 9;
            txtEndMonth.TextAlign = HorizontalAlignment.Right;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.Window;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(887, 1119);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(185, 68);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1996, 1244);
            Controls.Add(btnLogout);
            Controls.Add(tabs);
            Controls.Add(toolbar);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Soldier Fiancial Management System";
            toolbar.ResumeLayout(false);
            toolbar.PerformLayout();
            tabs.ResumeLayout(false);
            personalPage.ResumeLayout(false);
            personalPage.PerformLayout();
            entitlementsPage.ResumeLayout(false);
            entitlementsPage.PerformLayout();
            deductionsPage.ResumeLayout(false);
            deductionsPage.PerformLayout();
            summaryPage.ResumeLayout(false);
            summaryPage.PerformLayout();
            ResumeLayout(false);
        }
        private System.Windows.Forms.Panel toolbar;
    private System.Windows.Forms.TabControl tabs;
    private System.Windows.Forms.ComboBox cmbSelector;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnShowAll;
    private System.Windows.Forms.TabPage personalPage;
    private System.Windows.Forms.TabPage entitlementsPage;
    private System.Windows.Forms.TabPage deductionsPage;
    private System.Windows.Forms.TabPage summaryPage;
    private System.Windows.Forms.TextBox txtSsn;
    private System.Windows.Forms.Label lblSsn;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.Label lblFirstName;
    private System.Windows.Forms.TextBox txtMiddleName;
    private System.Windows.Forms.Label lblMiddleName;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.Label lblLastName;
    private System.Windows.Forms.TextBox txtRank;
    private System.Windows.Forms.Label lblRank;
    private System.Windows.Forms.TextBox txtDependents;
    private System.Windows.Forms.Label lblDependents;
    private System.Windows.Forms.TextBox txtUnit;
    private System.Windows.Forms.Label lblUnit;
    private System.Windows.Forms.TextBox txtYears;
    private System.Windows.Forms.Label lblYears;
    private System.Windows.Forms.TextBox txtStation;
    private System.Windows.Forms.Label lblStation;
    private System.Windows.Forms.TextBox txtBasicPay;
    private System.Windows.Forms.Label lblBasicPay;
    private System.Windows.Forms.TextBox txtBah;
    private System.Windows.Forms.Label lblBah;
    private System.Windows.Forms.TextBox txtBas;
    private System.Windows.Forms.Label lblBas;
    private System.Windows.Forms.TextBox txtOha;
    private System.Windows.Forms.Label lblOha;
    private System.Windows.Forms.TextBox txtClothing;
    private System.Windows.Forms.Label lblClothing;
    private System.Windows.Forms.TextBox txtFsa;
    private System.Windows.Forms.Label lblFsa;
    private System.Windows.Forms.TextBox txtSpecial;
    private System.Windows.Forms.Label lblSpecial;
    private System.Windows.Forms.TextBox txtFederal;
    private System.Windows.Forms.Label lblFederal;
    private System.Windows.Forms.TextBox txtState;
    private System.Windows.Forms.Label lblState;
    private System.Windows.Forms.TextBox txtFica;
    private System.Windows.Forms.Label lblFica;
    private System.Windows.Forms.TextBox txtInsurance;
    private System.Windows.Forms.Label lblInsurance;
    private System.Windows.Forms.TextBox txtAllotmentsDebt;
    private System.Windows.Forms.Label lblAllotmentsDebt;
    private System.Windows.Forms.TextBox txtTotalEntitlements;
    private System.Windows.Forms.Label lblTotalEntitlements;
    private System.Windows.Forms.TextBox txtTotalDeductions;
    private System.Windows.Forms.Label lblTotalDeductions;
    private System.Windows.Forms.TextBox txtMonthlySalary;
    private System.Windows.Forms.Label lblMonthlySalary;
    private System.Windows.Forms.TextBox txtMidMonth;
    private System.Windows.Forms.Label lblMidMonth;
    private System.Windows.Forms.TextBox txtEndMonth;
    private System.Windows.Forms.Label lblEndMonth;
        private Button btnLogout;
    }
}
