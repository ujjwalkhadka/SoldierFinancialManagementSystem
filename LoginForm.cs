namespace SoldierFinanceSample;

// Login is the application's startup form. It owns the shared soldier list.
public partial class LoginForm : Form
{
    List<Soldier> soldiers = new List<Soldier>();

    // Keep the parameterless constructor so View Designer can open this form.
    public LoginForm()
    {
        InitializeComponent();
    }

    // Program.cs passes all 50 records here; do not create another list on login.
    public LoginForm(List<Soldier> records) : this()
    {
        soldiers = records;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text;

        if (username == "" || password == "")
        {
            MessageBox.Show("Enter your username and password.", "Login");
            return;
        }

        // Demo credentials. Change these two strings to choose another demo account.
        if (username != "Soldier" || password != "Password")
        {
            MessageBox.Show("Incorrect username or password.", "Login failed");
            txtPassword.Clear();
            txtPassword.Focus();
            return;
        }

        bool returnToLogin = false;
        btnLogin.Enabled = false;
        Hide(); // Keep this startup form alive while MainForm is open.
        try
        {
            // Pass the SAME list on every login so records/edits are preserved.
            // using disposes the closed form before creating a new session later.
            using (MainForm mainForm = new MainForm(soldiers))
            {
                mainForm.ShowDialog(this);
                returnToLogin = mainForm.LogoutRequested;
            }
        }
        catch (Exception ex)
        {
            // Do not leave a hidden login window running if MainForm cannot open.
            returnToLogin = true;
            MessageBox.Show("Could not open the main window.\n" + ex.Message, "Login");
        }
        finally
        {
            txtPassword.Clear(); // Never leave the previous password filled after Logout.
            btnLogin.Enabled = true;
        }

        if (returnToLogin)
        {
            // Logout returns here. Do not construct another LoginForm or another list.
            Show();
            Activate();
            txtUsername.Focus();
        }
        else
        {
            // MainForm's X/Alt+F4 means Exit, so close the hidden startup form too.
            Close();
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        // Closing the startup form ends Application.Run and releases the process.
        Close();
    }
}
