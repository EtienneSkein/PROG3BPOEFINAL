using System.Drawing.Drawing2D;

namespace MunicipalServiceApp
{
    partial class Home
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            lblDescription = new Label();
            label1 = new Label();
            btnStatus = new Button();
            btnEvents = new Button();
            btnReportIssue = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(272, 60);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(254, 29);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to Municify";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Arial", 12F);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(217, 119);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(383, 36);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Use this app to report municipal service issues, \nview local events, or check your service request status.";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(287, 182);
            label1.Name = "label1";
            label1.Size = new Size(230, 16);
            label1.TabIndex = 2;
            label1.Text = "Your gateway to municipal services!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStatus
            // 
            btnStatus.FlatAppearance.BorderColor = Color.White;
            btnStatus.FlatAppearance.BorderSize = 2;
            btnStatus.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStatus.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            btnStatus.FlatStyle = FlatStyle.Flat;
            btnStatus.ForeColor = Color.White;
            btnStatus.Location = new Point(300, 360);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(200, 40);
            btnStatus.TabIndex = 5;
            btnStatus.Text = "Service Request Status";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnEvents
            // 
            btnEvents.FlatAppearance.BorderColor = Color.White;
            btnEvents.FlatAppearance.BorderSize = 2;
            btnEvents.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEvents.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            btnEvents.FlatStyle = FlatStyle.Flat;
            btnEvents.ForeColor = Color.White;
            btnEvents.Location = new Point(300, 300);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(200, 40);
            btnEvents.TabIndex = 4;
            btnEvents.Text = "Local Events and Announcements";
            btnEvents.UseVisualStyleBackColor = true;
            btnEvents.Click += btnEvents_Click;
            // 
            // btnReportIssue
            // 
            btnReportIssue.FlatAppearance.BorderColor = Color.White;
            btnReportIssue.FlatAppearance.BorderSize = 2;
            btnReportIssue.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReportIssue.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            btnReportIssue.FlatStyle = FlatStyle.Flat;
            btnReportIssue.ForeColor = Color.White;
            btnReportIssue.Location = new Point(300, 240);
            btnReportIssue.Name = "btnReportIssue";
            btnReportIssue.Size = new Size(200, 40);
            btnReportIssue.TabIndex = 3;
            btnReportIssue.Text = "Report Issues";
            btnReportIssue.UseVisualStyleBackColor = true;
            btnReportIssue.Click += btnReportIssue_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWelcome);
            Controls.Add(lblDescription);
            Controls.Add(label1);
            Controls.Add(btnReportIssue);
            Controls.Add(btnEvents);
            Controls.Add(btnStatus);
            Name = "Home";
            Text = "Home";
            Paint += Home_Paint;
            Resize += Home_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Home_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
                ClientRectangle,
                Color.MediumPurple,
                Color.DeepPink,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(gradientBrush, ClientRectangle);
            }
        }

        private void CenterControls()
        {
            lblWelcome.Location = new Point((ClientSize.Width - lblWelcome.Width) / 2, 50);
            lblDescription.Location = new Point((ClientSize.Width - lblDescription.Width) / 2, 120);
            label1.Location = new Point((ClientSize.Width - label1.Width) / 2, 180);
            btnReportIssue.Location = new Point((ClientSize.Width - btnReportIssue.Width) / 2, 240);
            btnEvents.Location = new Point((ClientSize.Width - btnEvents.Width) / 2, 300);
            btnStatus.Location = new Point((ClientSize.Width - btnStatus.Width) / 2, 360);
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        #endregion

        private Label lblWelcome;
        private Label lblDescription;
        private Label label1;
        private Button btnReportIssue;
        private Button btnEvents;
        private Button btnStatus;
    }
}
