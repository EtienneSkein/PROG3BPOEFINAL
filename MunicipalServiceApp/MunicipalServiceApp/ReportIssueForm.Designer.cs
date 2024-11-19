using System.Drawing.Drawing2D;

namespace MunicipalServiceApp
{
    partial class ReportIssueForm
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
            txtLocation = new TextBox();
            lblLocation = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            rtbDescription = new RichTextBox();
            lblDescription = new Label();
            btnAttachMedia = new Button();
            btnSubmitReport = new Button();
            btnHome = new Button();
            lblHiddenFilepath = new Label();
            SuspendLayout();
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.MediumPurple;
            txtLocation.BorderStyle = BorderStyle.None;
            txtLocation.ForeColor = Color.White;
            txtLocation.Location = new Point(210, 195);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(384, 23);
            txtLocation.TabIndex = 9;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.Transparent;
            lblLocation.ForeColor = Color.White;
            lblLocation.Location = new Point(149, 195);
            lblLocation.MinimumSize = new Size(10, 10);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(53, 15);
            lblLocation.TabIndex = 8;
            lblLocation.Text = "Location";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.MediumPurple;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.ForeColor = Color.White;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Sanitation", "Roads", "Water", "Electricity" });
            cmbCategory.Location = new Point(208, 224);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(386, 23);
            cmbCategory.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(147, 227);
            lblCategory.MinimumSize = new Size(10, 10);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category";
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.MediumPurple;
            rtbDescription.BorderStyle = BorderStyle.None;
            rtbDescription.ForeColor = Color.White;
            rtbDescription.Location = new Point(210, 82);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(384, 96);
            rtbDescription.TabIndex = 5;
            rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(371, 64);
            lblDescription.MinimumSize = new Size(10, 10);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // btnAttachMedia
            // 
            btnAttachMedia.FlatAppearance.BorderColor = Color.White;
            btnAttachMedia.FlatAppearance.BorderSize = 2;
            btnAttachMedia.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAttachMedia.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            btnAttachMedia.FlatStyle = FlatStyle.Flat;
            btnAttachMedia.ForeColor = Color.White;
            btnAttachMedia.Location = new Point(271, 284);
            btnAttachMedia.Name = "btnAttachMedia";
            btnAttachMedia.Size = new Size(115, 40);
            btnAttachMedia.TabIndex = 3;
            btnAttachMedia.Text = "Attach Media";
            btnAttachMedia.UseVisualStyleBackColor = true;
            btnAttachMedia.Click += btnAttachMedia_Click;
            // 
            // btnSubmitReport
            // 
            btnSubmitReport.FlatAppearance.BorderColor = Color.White;
            btnSubmitReport.FlatAppearance.BorderSize = 2;
            btnSubmitReport.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSubmitReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            btnSubmitReport.FlatStyle = FlatStyle.Flat;
            btnSubmitReport.ForeColor = Color.White;
            btnSubmitReport.Location = new Point(392, 284);
            btnSubmitReport.Name = "btnSubmitReport";
            btnSubmitReport.Size = new Size(115, 40);
            btnSubmitReport.TabIndex = 2;
            btnSubmitReport.Text = "Submit Report";
            btnSubmitReport.UseVisualStyleBackColor = true;
            btnSubmitReport.Click += btnSubmitReport_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 2;
            btnHome.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(30, 365);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(70, 40);
            btnHome.TabIndex = 1;
            btnHome.Text = "Back";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // lblHiddenFilepath
            // 
            lblHiddenFilepath.AutoSize = true;
            lblHiddenFilepath.ForeColor = Color.White;
            lblHiddenFilepath.Location = new Point(371, 371);
            lblHiddenFilepath.Name = "lblHiddenFilepath";
            lblHiddenFilepath.Size = new Size(0, 15);
            lblHiddenFilepath.TabIndex = 0;
            lblHiddenFilepath.Visible = false;
            // 
            // ReportIssueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHiddenFilepath);
            Controls.Add(btnHome);
            Controls.Add(btnSubmitReport);
            Controls.Add(btnAttachMedia);
            Controls.Add(lblDescription);
            Controls.Add(rtbDescription);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblLocation);
            Controls.Add(txtLocation);
            Name = "ReportIssueForm";
            Text = "Report Issue";
            Paint += ReportIssueForm_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// Custom Paint event to create a gradient background
        /// </summary>
        private void ReportIssueForm_Paint(object sender, PaintEventArgs e)
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

        #endregion

        private TextBox txtLocation;
        private Label lblLocation;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private RichTextBox rtbDescription;
        private Label lblDescription;
        private Button btnAttachMedia;
        private Button btnSubmitReport;
        private Button btnHome;
        private Label lblHiddenFilepath;
    }
}
