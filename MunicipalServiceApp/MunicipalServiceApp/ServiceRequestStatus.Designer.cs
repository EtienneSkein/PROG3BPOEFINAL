using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MunicipalServiceApp
{
    partial class ServiceRequestStatus
    {
        private Button btnBack;
        private ListBox lstIssues;
        private TextBox txtDescription;
        private TextBox txtCategory;
        private TextBox txtStatus;
        private TextBox txtDate;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblStatus;
        private Label lblDate;
        private Label lblIssues;

        private void InitializeComponent()
        {
            btnBack = new Button();
            lstIssues = new ListBox();
            txtDescription = new TextBox();
            txtCategory = new TextBox();
            txtStatus = new TextBox();
            txtDate = new TextBox();
            lblDescription = new Label();
            lblCategory = new Label();
            lblStatus = new Label();
            lblDate = new Label();
            lblIssues = new Label();
            pcbImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbImage).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumPurple;
            btnBack.FlatAppearance.BorderColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(28, 385);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lstIssues
            // 
            lstIssues.BackColor = Color.MediumPurple;
            lstIssues.BorderStyle = BorderStyle.None;
            lstIssues.ForeColor = Color.White;
            lstIssues.ItemHeight = 15;
            lstIssues.Location = new Point(50, 50);
            lstIssues.Name = "lstIssues";
            lstIssues.Size = new Size(300, 270);
            lstIssues.TabIndex = 1;
            lstIssues.SelectedIndexChanged += lstIssues_SelectedIndexChanged;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.MediumPurple;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(438, 163);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(300, 61);
            txtDescription.TabIndex = 2;
            // 
            // txtCategory
            // 
            txtCategory.BackColor = Color.MediumPurple;
            txtCategory.BorderStyle = BorderStyle.None;
            txtCategory.ForeColor = Color.White;
            txtCategory.Location = new Point(438, 259);
            txtCategory.Multiline = true;
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(300, 34);
            txtCategory.TabIndex = 3;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.MediumPurple;
            txtStatus.BorderStyle = BorderStyle.None;
            txtStatus.ForeColor = Color.White;
            txtStatus.Location = new Point(438, 328);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(300, 34);
            txtStatus.TabIndex = 4;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.MediumPurple;
            txtDate.BorderStyle = BorderStyle.None;
            txtDate.ForeColor = Color.White;
            txtDate.Location = new Point(438, 399);
            txtDate.Multiline = true;
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(300, 34);
            txtDate.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.ForeColor = Color.Transparent;
            lblDescription.Location = new Point(537, 137);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCategory
            // 
            lblCategory.BackColor = Color.Transparent;
            lblCategory.ForeColor = Color.Transparent;
            lblCategory.Location = new Point(537, 233);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 23);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category:";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.ForeColor = Color.Transparent;
            lblStatus.Location = new Point(537, 302);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 23);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.Transparent;
            lblDate.ForeColor = Color.Transparent;
            lblDate.Location = new Point(537, 373);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date:";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIssues
            // 
            lblIssues.BackColor = Color.Transparent;
            lblIssues.ForeColor = Color.Transparent;
            lblIssues.Location = new Point(145, 24);
            lblIssues.Name = "lblIssues";
            lblIssues.Size = new Size(100, 23);
            lblIssues.TabIndex = 10;
            lblIssues.Text = "Issues";
            lblIssues.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcbImage
            // 
            pcbImage.Location = new Point(438, 24);
            pcbImage.Name = "pcbImage";
            pcbImage.Size = new Size(300, 110);
            pcbImage.TabIndex = 11;
            pcbImage.TabStop = false;
            // 
            // ServiceRequestStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pcbImage);
            Controls.Add(btnBack);
            Controls.Add(lstIssues);
            Controls.Add(txtDescription);
            Controls.Add(txtCategory);
            Controls.Add(txtStatus);
            Controls.Add(txtDate);
            Controls.Add(lblDescription);
            Controls.Add(lblCategory);
            Controls.Add(lblStatus);
            Controls.Add(lblDate);
            Controls.Add(lblIssues);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ServiceRequestStatus";
            Text = "Service Request Status";
            ((System.ComponentModel.ISupportInitialize)pcbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pcbImage;
    }
}
