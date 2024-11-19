using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServiceApp
{
    public partial class Events : Form
    {
        private DataStore dataStore; // Instance of DataStore to manage events and data
        private string defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "default.jpg"); // Path to the default image
        private static readonly string[] Categories = { "Concert", "Workshop", "Seminar", "Festival", "Exhibition" }; // Categories

        // Constructor to initialize the Events form and load events
        public Events(DataStore dataStore)
        {
            try
            {
                InitializeComponent(); // Initialize the form components
                this.dataStore = dataStore; // Assign the provided DataStore instance

                // Populate with 10 test events if the data store is empty
                if (!dataStore.GetAllEvents().Any())
                {
                    AddTestEvents();
                }

                this.FormBorderStyle = FormBorderStyle.FixedSingle; // Disable resizing
                this.MaximizeBox = false; // Disable maximize button
                this.StartPosition = FormStartPosition.CenterScreen; // Open in center
                LoadEvents(); // Load all events into the ListBox
            }
            catch (Exception ex)
            {
                // Handle initialization errors
                MessageBox.Show($"Error initializing form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Adds 10 test events to the DataStore
        private void AddTestEvents()
        {
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                var newEvent = new Event(
                    id: i + 1, // Unique ID
                    title: $"Event Title {i + 1}", // Test title
                    description: $"This is a test description for Event {i + 1}.", // Test description
                    date: new DateTime(2024, random.Next(1, 13), random.Next(1, 28)), // Random date in 2024
                    category: Categories[random.Next(Categories.Length)] // Random category
                );

                dataStore.AddEvent(newEvent); // Add event to the data store
            }
        }

        // Load events from the dataStore into the ListBox
        public void LoadEvents()
        {
            try
            {
                lstEvents.Items.Clear(); // Clear the ListBox before loading new items

                // Safely load events from the dataStore
                var events = dataStore?.GetAllEvents(); // Retrieve all events from dataStore
                if (events != null)
                {
                    foreach (Event ev in events)
                    {
                        lstEvents.Items.Add(ev); // Add each event to the ListBox
                    }
                }

                // Select the first item if the ListBox is not empty
                if (lstEvents.Items.Count > 0)
                {
                    lstEvents.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                // Handle errors during event loading
                MessageBox.Show($"Error loading events: {ex.Message}", "Load Events Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for when the selected item in the ListBox changes
        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstEvents.SelectedItem != null)
                {
                    // Cast the selected item as an Event
                    Event selectedEvent = (Event)lstEvents.SelectedItem;

                    // Populate the text fields with the selected event's details
                    txtDescription.Text = selectedEvent.Description;
                    txtDate.Text = selectedEvent.Date.ToString("MMMM dd, yyyy"); // Format the date
                    txtCategory.Text = selectedEvent.Category;
                }
            }
            catch (Exception ex)
            {
                // Handle errors during item selection
                MessageBox.Show($"Error displaying selected event: {ex.Message}", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the Back button click event
        private void btnBack_Click(object sender, EventArgs e)
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
                    home.Show();
                }
                else
                {
                    home = new Home();
                    home.Location = this.Location;
                    home.Size = this.Size;
                    home.StartPosition = FormStartPosition.Manual; // Ensure manual positioning
                    home.Show();
                }

                this.Close(); // Close the current Events form
            }
            catch (Exception ex)
            {
                // Handle navigation errors
                MessageBox.Show($"Error navigating to Home: {ex.Message}", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected date and category from the UI
                DateTime? searchDate = dateTimePicker1.Value.Date;
                int searchCategoryIndex = cmbCategories.SelectedIndex;

                // Get the matching category string from the combo box
                string searchCategory = searchCategoryIndex >= 0 ? cmbCategories.Items[searchCategoryIndex].ToString() : null;

                // Add the search criteria to the user's search history
                dataStore.AddToSearchHistory(searchDate, searchCategoryIndex);

                // Perform the search
                var filteredEvents = dataStore.GetAllEvents()
                    .Where(ev =>
                        (!searchDate.HasValue || ev.Date.Date == searchDate.Value) && // Match date
                        (string.IsNullOrEmpty(searchCategory) || ev.Category == searchCategory)) // Match category
                    .ToList();

                // Update the ListBox with the search results
                lstEvents.Items.Clear();
                foreach (var ev in filteredEvents)
                {
                    lstEvents.Items.Add(ev);
                }

                // Notify if no matching events were found
                if (!filteredEvents.Any())
                {
                    MessageBox.Show("No events match the search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error performing search: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the user's search history
                var searchedDates = dataStore.SearchHistory.SearchedDates.InOrderTraversal();
                var searchedCategories = dataStore.SearchHistory.SearchedCategories.InOrderTraversal();

                // Check if there is any search history
                if (!searchedDates.Any() && !searchedCategories.Any())
                {
                    MessageBox.Show("No search history available to recommend events.", "No Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Recommend events based on search history
                var recommendedEvents = dataStore.GetAllEvents()
                    .Where(ev =>
                        searchedDates.Any(date => Math.Abs((ev.Date - date).Days) <= 7) || // Date within 7 days
                        searchedCategories.Any(category => ev.Category == Categories[category])) // Category match
                    .ToList();

                // Update the ListBox with the recommended events
                lstEvents.Items.Clear();
                foreach (var ev in recommendedEvents)
                {
                    lstEvents.Items.Add(ev);
                }

                // Notify if no recommendations were found
                if (!recommendedEvents.Any())
                {
                    MessageBox.Show("No recommended events found.", "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching recommendations: {ex.Message}", "Recommendation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
