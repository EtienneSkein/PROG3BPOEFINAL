using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServiceApp
{
    public partial class ReportIssueForm : Form
    {
        private DataStore dataStore; // Instance of DataStore to manage reported issues
        private int issueIdCounter = 1; // Counter for generating unique issue IDs (unused but kept for context)

        // Constructor to initialize the form and setup DataStore
        public ReportIssueForm(DataStore dataStore)
        {
            try
            {
                InitializeComponent(); // Initialize form components
                this.FormBorderStyle = FormBorderStyle.FixedSingle; // Disable resizing
                this.MaximizeBox = false; // Disable maximize button
                this.StartPosition = FormStartPosition.CenterScreen; // Open in center
                this.dataStore = dataStore; // Assign the provided DataStore instance

                // Ensure the first item is selected in the category dropdown on startup
                if (cmbCategory.Items.Count > 0)
                {
                    cmbCategory.SelectedIndex = 0; // Select the first category by default
                }
            }
            catch (Exception ex)
            {
                // Handle initialization errors
                MessageBox.Show($"Error initializing form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the Home button click event
        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                // Find the existing Home form (if already opened)
                Home home = Application.OpenForms.OfType<Home>().FirstOrDefault();

                if (home != null)
                {
                    home.Location = this.Location;
                    home.Size = this.Size;
                    home.StartPosition = FormStartPosition.Manual; // Ensure manual positioning
                    home.Show(); // Show the existing Home form
                }
                else
                {
                    // Create a new instance of Home form if it doesn't exist
                    home = new Home();
                    home.Location = this.Location;
                    home.Size = this.Size;
                    home.StartPosition = FormStartPosition.Manual; // Ensure manual positioning
                    home.Show();
                }

                this.Close(); // Close the current ReportIssueForm
            }
            catch (Exception ex)
            {
                // Handle navigation errors
                MessageBox.Show($"Error navigating to Home: {ex.Message}", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for category dropdown selection change
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This can be used for additional logic when category changes
        }

        // Event handler for the Attach Media button click event
        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog(); // Open file dialog to select media
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*"; // Filter for image files

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Store the file path of the selected media file
                    string filePath = openFileDialog.FileName;

                    // Validate file existence
                    if (File.Exists(filePath))
                    {
                        MessageBox.Show("File Attached: " + filePath); // Notify user of attachment
                        lblHiddenFilepath.Text = filePath; // Save the file path to the hidden label
                    }
                    else
                    {
                        throw new FileNotFoundException("The selected file does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle file selection errors
                MessageBox.Show($"Error attaching media: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the Submit Report button click event
        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather information from the form fields
                string location = txtLocation.Text.Trim(); // Location of the issue
                string description = rtbDescription.Text.Trim(); // Detailed description of the issue
                int priority = cmbCategory.SelectedIndex; // Priority based on selected category
                DateTime dateReported = DateTime.Now; // Current date and time as the report date
                string mediaFilePath = lblHiddenFilepath.Text.Trim(); // File path of attached media
                string category = cmbCategory.SelectedItem?.ToString() ?? ""; // Selected category as a string

                // Validate user input
                if (string.IsNullOrWhiteSpace(location))
                {
                    throw new ArgumentException("Location cannot be empty.");
                }
                if (string.IsNullOrWhiteSpace(description))
                {
                    throw new ArgumentException("Description cannot be empty.");
                }
                if (priority < 0)
                {
                    throw new ArgumentException("Please select a valid category.");
                }

                // Create a new Issue object
                Issue newIssue = new Issue(
                    0, // Issue ID will be set by DataStore
                    location,
                    mediaFilePath,
                    description,
                    category,
                    dateReported,
                    priority,
                    "Unchecked"
                );

                // Add the new issue to the data store
                dataStore.AddIssue(newIssue);

                // Show a success message to the user
                MessageBox.Show("Issue reported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form fields to prepare for a new report
                rtbDescription.Clear();
                txtLocation.Clear();
                lblHiddenFilepath.Text = string.Empty;

                // Reset the category dropdown to the first item
                if (cmbCategory.Items.Count > 0)
                {
                    cmbCategory.SelectedIndex = 0; // Default to the first category after submission
                }
            }
            catch (ArgumentException ex)
            {
                // Handle validation errors
                MessageBox.Show($"Input Error: {ex.Message}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Handle other errors
                MessageBox.Show($"Error submitting report: {ex.Message}", "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
