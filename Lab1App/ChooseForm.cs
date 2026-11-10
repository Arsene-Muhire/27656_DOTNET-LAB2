namespace Lab1App
{
    public partial class ChooseForm : Form
    {
        private readonly LoginForm loginForm;
        private bool navigating = false; // true when we close on purpose (Logout)

        public ChooseForm(LoginForm login)
        {
            InitializeComponent();
            loginForm = login;
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            Hide();
            new BicycleForm(loginForm, this).Show();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            Hide();
            new MushroomForm(loginForm, this).Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        public void Logout()
        {
            navigating = true;
            loginForm.ShowAfterLogout();
            Close();
        }

        // If the user clicks the X button, exit the whole application
        private void ChooseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!navigating)
            {
                Application.Exit();
            }
        }
    }
}
