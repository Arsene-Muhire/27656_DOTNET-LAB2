namespace Lab1App
{
    public partial class MushroomForm : Form
    {
        private readonly LoginForm loginForm;
        private readonly ChooseForm chooseForm;
        private bool navigating = false; // true when we close on purpose (Back / Logout)

        // Which question is currently shown
        // 0 = gills?  1 = forest?  2 = ring?  3 = convex cup? (meadow)  4 = convex cup? (forest, no ring)
        private int step = 0;
        private int questionsAsked = 0;

        public MushroomForm(LoginForm login, ChooseForm choose)
        {
            InitializeComponent();
            loginForm = login;
            chooseForm = choose;
            ResetGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            step = 0;
            questionsAsked = 1;
            lblQuestion.Text = "Does your mushroom have gills?";
            btnYes.Enabled = true;
            btnNo.Enabled = true;
            btnStart.Enabled = false;
            UpdateCounter();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Answer(true);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Answer(false);
        }

        // Decision tree: never asks more than 3 questions
        private void Answer(bool yes)
        {
            switch (step)
            {
                case 0: // Gills?
                    if (!yes)
                        ShowResult("Cepe de Bordeaux");   // the only one with pores
                    else
                        AskNext(1, "Does your mushroom grow in a forest?");
                    break;

                case 1: // Forest?
                    if (!yes)
                        AskNext(3, "Does your mushroom have a convex cup?");  // meadow: Agaric or Coprin
                    else
                        AskNext(2, "Does your mushroom have a ring?");        // forest: Amanite, Girolle, Pied bleu
                    break;

                case 2: // Ring? (forest)
                    if (yes)
                        ShowResult("Amanite tue-mouche");
                    else
                        AskNext(4, "Does your mushroom have a convex cup?");  // Pied bleu or Girolle
                    break;

                case 3: // Convex cup? (meadow)
                    ShowResult(yes ? "Agaric jaunissant" : "Coprin chevelu");
                    break;

                case 4: // Convex cup? (forest, no ring)
                    ShowResult(yes ? "Pied bleu" : "Girolle");
                    break;
            }
        }

        private void AskNext(int nextStep, string question)
        {
            step = nextStep;
            questionsAsked++;
            lblQuestion.Text = question;
            UpdateCounter();
        }

        private void ShowResult(string mushroom)
        {
            MessageBox.Show("Your mushroom is: " + mushroom, "Result",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetGame();
        }

        private void ResetGame()
        {
            step = 0;
            questionsAsked = 0;
            lblQuestion.Text = "Think of one of the six mushrooms, then click Start.";
            lblCounter.Text = "";
            btnYes.Enabled = false;
            btnNo.Enabled = false;
            btnStart.Enabled = true;
        }

        private void UpdateCounter()
        {
            lblCounter.Text = "Question " + questionsAsked + " of max 3";
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
        private void MushroomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!navigating)
            {
                Application.Exit();
            }
        }
    }
}
