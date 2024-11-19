using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Linq.Expressions;

namespace MunicipalServiceApp
{
    public partial class ServiceRequestStatus : Form
    {
        private DataStore _dataStore; // Instance of DataStore to manage issues
        private string defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "default.jpg"); // Path to the default image

        public ServiceRequestStatus(DataStore dataStore)
        {
            InitializeComponent();
            _dataStore = dataStore; // Assign the provided DataStore instance

            DoubleBuffered = true; // Reduce flickering for custom painting
            StartPosition = FormStartPosition.CenterScreen; // Center the form on screen

            LoadIssues(); // Load issues into the list
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Create a vertical gradient background
            using (LinearGradientBrush brush = new LinearGradientBrush(
                ClientRectangle,
                Color.MediumPurple,
                Color.DeepPink,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }

        private void LoadIssues()
        {
            lstIssues.Items.Clear();

            var issues = _dataStore.GetAllIssues();
            foreach (Issue issue in issues)
            {
                lstIssues.Items.Add(issue); // Display each issue in the ListBox
            }
        }

        private void lstIssues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIssues.SelectedItem is Issue selectedIssue)
            {
                // Populate the fields with the selected issue's details
                txtDescription.Text = selectedIssue.Description;
                txtCategory.Text = selectedIssue.Category;
                txtStatus.Text = selectedIssue.Status;
                txtDate.Text = selectedIssue.DateReported.ToString("MMMM dd, yyyy");
                try {
                    pcbImage.Image = Image.FromFile(selectedIssue.MediaFilePath);
                }
                catch(Exception notfound){
                    pcbImage.Image = Image.FromFile(defaultImagePath);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to the home page
            var homeForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
            if (homeForm != null)
            {
                homeForm.Location = Location;
                homeForm.Size = Size;
                homeForm.Show();
            }
            else
            {
                homeForm = new Home
                {
                    Location = Location,
                    Size = Size
                };
                homeForm.Show();
            }

            Close();
        }
    }
}
