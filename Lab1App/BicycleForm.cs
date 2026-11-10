namespace Lab1App
{
    public partial class BicycleForm : Form
    {
        private readonly LoginForm loginForm;
        private readonly ChooseForm chooseForm;
        private bool navigating = false; // true when we close on purpose (Back / Logout)

        public BicycleForm(LoginForm login, ChooseForm choose)
        {
            InitializeComponent();
            loginForm = login;
            chooseForm = choose;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start, end;

            // Only whole numbers are accepted (no decimals, no letters)
            if (!int.TryParse(txtStart.Text.Trim(), out start) ||
                !int.TryParse(txtEnd.Text.Trim(), out end))
            {
                ShowError("Please enter whole numbers only (no decimals or letters).");
                return;
            }

            if (start < 0 || start > 23)
            {
                ShowError("Starting time must be between 0 and 23.");
                return;
            }

            if (end < 1 || end > 24)
            {
                ShowError("Ending time must be between 1 and 24.");
                return;
            }

            if (start >= end)
            {
                ShowError("Starting time must be less than ending time.");
                return;
            }

            int total = CalculateRent(start, end);
            txtTotal.Text = total + " RWF";
        }

        // Adds the rate of every hour from start up to end
        private int CalculateRent(int start, int end)
        {
            int total = 0;

            for (int hour = start; hour < end; hour++)
            {
                if (hour < 7 || hour >= 21)
                {
                    total += 500;    // 0-7 and 21-24
                }
                else if (hour < 14 || hour >= 19)
                {
                    total += 1000;   // 7-14 and 19-21
                }
                else
                {
                    total += 1500;   // 14-19
                }
            }

            return total;
        }

        private void ShowError(string message)
        {
            txtTotal.Clear();
            MessageBox.Show(message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            navigating = true;
            chooseForm.Show();
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            navigating = true;
            chooseForm.Logout();
            Close();
        }

        // If the user clicks the X button, exit the whole application
        private void BicycleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!navigating)
            {
                Application.Exit();
            }
        }
    }
}
