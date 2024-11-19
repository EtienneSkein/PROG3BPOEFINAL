namespace MunicipalServiceApp
{
    public partial class Home : Form
    {
        private DataStore dataStore; // Instance of DataStore to manage application data

        public Home()
        {
            InitializeComponent(); // Initialize form components
            dataStore = new DataStore(); // Initialize the DataStore
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Disable resizing
            this.MaximizeBox = false; // Disable maximize button
            this.StartPosition = FormStartPosition.CenterScreen; // Open in center
        }

        // Event handler for "Report Issues" button click
        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new ReportIssueForm
                ReportIssueForm reportIssueForm = new ReportIssueForm(dataStore);

                // Set the location and size of the new form to match the current form
                reportIssueForm.Location = this.Location;
                reportIssueForm.Size = this.Size;
                reportIssueForm.StartPosition = FormStartPosition.Manual; // Ensure manual positioning
                reportIssueForm.MaximizeBox = false; // Disable maximize button
                reportIssueForm.FormBorderStyle = FormBorderStyle.FixedSingle; // Disable resizing
                reportIssueForm.Show(); // Show the ReportIssueForm
                this.Hide(); // Hide the Home form
            }
            catch (Exception ex)
            {
                // Handle errors during navigation
                MessageBox.Show($"Error opening Report Issue form: {ex.Message}", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for "Local Events and Announcements" button click
        private void btnEvents_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Events form
                Events eventsForm = new Events(dataStore);

                // Set the location and size of the new form to match the current form
                eventsForm.Location = this.Location;
                eventsForm.Size = this.Size;
                eventsForm.StartPosition = FormStartPosition.Manual; // Ensure manual positioning

                eventsForm.Show(); // Show the Events form
                this.Hide(); // Hide the Home form
            }
            catch (Exception ex)
            {
                // Handle errors during navigation
                MessageBox.Show($"Error opening Events form: {ex.Message}", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for "Service Request Status" button click
        private void btnStatus_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceRequestStatus statusForm = new ServiceRequestStatus(dataStore);
                statusForm.Location = this.Location;
                statusForm.Size = this.Size;
                statusForm.StartPosition = FormStartPosition.Manual; // Ensure manual positioning
                statusForm.MaximizeBox = false; // Disable maximize button
                statusForm.FormBorderStyle = FormBorderStyle.FixedSingle; // Disable resizing
                statusForm.Show(); // Show the ReportIssueForm
                this.Hide();
                statusForm.Show();
            }
            catch (Exception ex)
            {
                // Handle unexpected errors during notification
                MessageBox.Show($"Error displaying feature status: {ex.Message}", "Notification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
