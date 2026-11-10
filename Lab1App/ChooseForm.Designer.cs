namespace Lab1App
{
    partial class ChooseForm
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
            btnBicycle = new Button();
            btnMushroom = new Button();
            btnLogout = new Button();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(110, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Choose";
            //
            // btnBicycle
            //
            btnBicycle.Location = new Point(40, 80);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(120, 45);
            btnBicycle.TabIndex = 0;
            btnBicycle.Text = "Bicycle";
            btnBicycle.UseVisualStyleBackColor = true;
            btnBicycle.Click += btnBicycle_Click;
            //
            // btnMushroom
            //
            btnMushroom.Location = new Point(180, 80);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(120, 45);
            btnMushroom.TabIndex = 1;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = true;
            btnMushroom.Click += btnMushroom_Click;
            //
            // btnLogout
            //
            btnLogout.Location = new Point(120, 150);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 32);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            //
            // ChooseForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 210);
            Controls.Add(lblTitle);
            Controls.Add(btnBicycle);
            Controls.Add(btnMushroom);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChooseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose";
            FormClosed += ChooseForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Button btnBicycle;
        private Button btnMushroom;
        private Button btnLogout;
    }
}
