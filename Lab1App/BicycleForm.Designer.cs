namespace Lab1App
{
    partial class BicycleForm
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
            lblStart = new Label();
            lblEnd = new Label();
            lblTotal = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
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
            lblTitle.Text = "Bicycle Rental";
            //
            // lblStart
            //
            lblStart.AutoSize = true;
            lblStart.Location = new Point(40, 75);
            lblStart.Name = "lblStart";
            lblStart.Text = "Starting hour (0-23):";
            //
            // txtStart
            //
            txtStart.Location = new Point(190, 72);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(140, 23);
            txtStart.TabIndex = 0;
            //
            // lblEnd
            //
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(40, 115);
            lblEnd.Name = "lblEnd";
            lblEnd.Text = "Ending hour (1-24):";
            //
            // txtEnd
            //
            txtEnd.Location = new Point(190, 112);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(140, 23);
            txtEnd.TabIndex = 1;
            //
            // btnCalculate
            //
            btnCalculate.Location = new Point(190, 150);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(140, 32);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(40, 203);
            lblTotal.Name = "lblTotal";
            lblTotal.Text = "Total:";
            //
            // txtTotal
            //
            txtTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtTotal.Location = new Point(190, 200);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(140, 23);
            txtTotal.TabStop = false;
            //
            // btnBack
            //
            btnBack.Location = new Point(60, 250);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 32);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // btnLogout
            //
            btnLogout.Location = new Point(200, 250);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 32);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            //
            // BicycleForm
            //
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 305);
            Controls.Add(lblTitle);
            Controls.Add(lblStart);
            Controls.Add(txtStart);
            Controls.Add(lblEnd);
            Controls.Add(txtEnd);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BicycleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bicycle Rental";
            FormClosed += BicycleForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblStart;
        private Label lblEnd;
        private Label lblTotal;
        private TextBox txtStart;
        private TextBox txtEnd;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnBack;
        private Button btnLogout;
    }
}
