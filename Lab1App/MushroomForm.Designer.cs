namespace Lab1App
{
    partial class MushroomForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblList = new Label();
            lblQuestion = new Label();
            lblCounter = new Label();
            btnStart = new Button();
            btnYes = new Button();
            btnNo = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(110, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Mushroom Finder";
            //
            // lblList
            //
            lblList.ForeColor = Color.DimGray;
            lblList.Location = new Point(30, 60);
            lblList.Name = "lblList";
            lblList.Size = new Size(360, 40);
            lblList.Text = "Agaric jaunissant, Amanite tue-mouche, Cepe de Bordeaux,\r\nCoprin chevelu, Girolle, Pied bleu";
            //
            // lblQuestion
            //
            lblQuestion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblQuestion.Location = new Point(30, 110);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(360, 50);
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblCounter
            //
            lblCounter.ForeColor = Color.DimGray;
            lblCounter.Location = new Point(30, 160);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(360, 20);
            lblCounter.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnStart
            //
            btnStart.Location = new Point(155, 190);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(110, 32);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            //
            // btnYes
            //
            btnYes.Location = new Point(85, 235);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(110, 38);
            btnYes.TabIndex = 1;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            //
            // btnNo
            //
            btnNo.Location = new Point(225, 235);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(110, 38);
            btnNo.TabIndex = 2;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            //
            // btnBack
            //
            btnBack.Location = new Point(85, 300);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 32);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // btnLogout
            //
            btnLogout.Location = new Point(225, 300);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 32);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            //
            // MushroomForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 355);
            Controls.Add(lblTitle);
            Controls.Add(lblList);
            Controls.Add(lblQuestion);
            Controls.Add(lblCounter);
            Controls.Add(btnStart);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MushroomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mushroom Finder";
            FormClosed += MushroomForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblList;
        private Label lblQuestion;
        private Label lblCounter;
        private Button btnStart;
        private Button btnYes;
        private Button btnNo;
        private Button btnBack;
        private Button btnLogout;
    }
}
