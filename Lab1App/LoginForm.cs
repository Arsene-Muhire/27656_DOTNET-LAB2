namespace Lab1App
{
    public partial class LoginForm : Form
    {
        // Fixed credentials (no database needed for this lab)
        private const string Username = "admin";
        private const string Password = "1234";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == Username && txtPassword.Text == Password)
            {
                Hide();
                ChooseForm choose = new ChooseForm(this);
                choose.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        // Called by other forms when the user logs out
        public void ShowAfterLogout()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            Show();
            txtUsername.Focus();
        }
    }
}
