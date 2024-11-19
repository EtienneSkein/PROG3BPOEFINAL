using System.Drawing.Drawing2D;

namespace MunicipalServiceApp
{
    partial class Events
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
            btnBack = new Button();
            lstEvents = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            btnSearch = new Button();
            txtDescription = new TextBox();
            txtDate = new TextBox();
            lblLocation = new Label();
            lblDate = new Label();
            cmbCategories = new ComboBox();
            button1 = new Button();
            lblCategory = new Label();
            txtCategory = new TextBox();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 382);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lstEvents
            // 
            lstEvents.BackColor = Color.MediumPurple;
            lstEvents.BorderStyle = BorderStyle.None;
            lstEvents.ForeColor = Color.White;
            lstEvents.ItemHeight = 15;
            lstEvents.Location = new Point(139, 52);
            lstEvents.Name = "lstEvents";
            lstEvents.Size = new Size(300, 150);
            lstEvents.TabIndex = 1;
            lstEvents.SelectedIndexChanged += lstEvents_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.BackColor = Color.MediumPurple;
            dateTimePicker1.CalendarMonthBackground = Color.MediumPurple;
            dateTimePicker1.ForeColor = Color.White;
            dateTimePicker1.Location = new Point(183, 231);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 2;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(181, 289);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 40);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.MediumPurple;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(491, 79);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(168, 31);
            txtDescription.TabIndex = 4;
            txtDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.MediumPurple;
            txtDate.BorderStyle = BorderStyle.None;
            txtDate.ForeColor = Color.White;
            txtDate.Location = new Point(491, 145);
            txtDate.Multiline = true;
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(168, 31);
            txtDate.TabIndex = 5;
            txtDate.TextAlign = HorizontalAlignment.Center;
            // 
            // lblLocation
            // 
            lblLocation.BackColor = Color.Transparent;
            lblLocation.ForeColor = Color.White;
            lblLocation.Location = new Point(524, 53);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(100, 23);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Event Location";
            lblLocation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.Transparent;
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(524, 119);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 7;
            lblDate.Text = "Event Date";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbCategories
            // 
            cmbCategories.BackColor = Color.MediumPurple;
            cmbCategories.FlatStyle = FlatStyle.Flat;
            cmbCategories.ForeColor = Color.White;
            cmbCategories.Items.AddRange(new object[] { "Concert", "Workshop", "Seminar", "Festival", "Exhibition " });
            cmbCategories.Location = new Point(183, 260);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(210, 23);
            cmbCategories.TabIndex = 9;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(290, 289);
            button1.Name = "button1";
            button1.Size = new Size(103, 40);
            button1.TabIndex = 10;
            button1.Text = "Recommend";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblCategory
            // 
            lblCategory.BackColor = Color.Transparent;
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(524, 179);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 23);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Event Category";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCategory
            // 
            txtCategory.BackColor = Color.MediumPurple;
            txtCategory.BorderStyle = BorderStyle.None;
            txtCategory.ForeColor = Color.White;
            txtCategory.Location = new Point(491, 205);
            txtCategory.Multiline = true;
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(168, 31);
            txtCategory.TabIndex = 12;
            txtCategory.TextAlign = HorizontalAlignment.Center;
            // 
            // Events
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(lstEvents);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSearch);
            Controls.Add(txtDescription);
            Controls.Add(txtDate);
            Controls.Add(lblLocation);
            Controls.Add(lblDate);
            Controls.Add(cmbCategories);
            Controls.Add(button1);
            Controls.Add(lblCategory);
            Controls.Add(txtCategory);
            Name = "Events";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Events";
            Paint += Events_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Events_Paint(object sender, PaintEventArgs e)
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

        private Button btnBack;
        private ListBox lstEvents;
        private DateTimePicker dateTimePicker1;
        private Button btnSearch;
        private TextBox txtDescription;
        private TextBox txtDate;
        private Label lblLocation;
        private Label lblDate;
        private ComboBox cmbCategories;
        private Button button1;
        private Label lblCategory;
        private TextBox txtCategory;
    }
}
