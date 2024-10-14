using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class LocalEventsForm : Form
    {
        // SortedDictionary to store events, with DateTime as the key and list of events as the value
        private SortedDictionary<DateTime, List<string>> eventsByDate = new SortedDictionary<DateTime, List<string>>();

        // Stack to store recent search categories for recommendations
        private Stack<string> recentSearchCategories = new Stack<string>();

        // Queue to handle upcoming events in the order they happen
        private Queue<string> upcomingEventsQueue = new Queue<string>();

        // HashSet to store unique categories to avoid duplicates in recommendations
        private HashSet<string> uniqueCategories = new HashSet<string>();

        public LocalEventsForm()
        {
            InitializeComponent();
            LoadEvents();  // Load sample events
            InitializeUniqueCategories(); // Load unique categories from events
            PopulateUpcomingEventsQueue(); // Populate queue with upcoming events
        }

        private void LoadEvents()
        {
            eventsByDate.Add(DateTime.Now.AddDays(1), new List<string> { "Sports: Soccer Tournament", "Cultural: Art Exhibition" });
            eventsByDate.Add(DateTime.Now.AddDays(2), new List<string> { "Educational: Math Workshop", "Cultural: Photography Expo" });
            eventsByDate.Add(DateTime.Now.AddDays(3), new List<string> { "Educational: Coding Workshop", "Social: Community Meetup" });
            eventsByDate.Add(DateTime.Now.AddDays(4), new List<string> { "Sports: Basketball Game", "Educational: Science Fair" });
            eventsByDate.Add(DateTime.Now.AddDays(5), new List<string> { "Cultural: Art Fair", "Social: Open Mic Night" });
            eventsByDate.Add(DateTime.Now.AddDays(6), new List<string> { "Sports: Tennis Tournament", "Cultural: Dance Performance" });
            eventsByDate.Add(DateTime.Now.AddDays(7), new List<string> { "Educational: History Lecture", "Social: Community Service" });
            eventsByDate.Add(DateTime.Now.AddDays(8), new List<string> { "Social: Volunteer Day", "Educational: Biology Workshop" });
            eventsByDate.Add(DateTime.Now.AddDays(9), new List<string> { "Cultural: Music Concert", "Sports: Swimming Championship" });
            eventsByDate.Add(DateTime.Now.AddDays(10), new List<string> { "Educational: Chemistry Lab Tour", "Social: Food Drive" });
            eventsByDate.Add(DateTime.Now.AddDays(11), new List<string> { "Cultural: Film Screening", "Educational: Environmental Workshop" });
            eventsByDate.Add(DateTime.Now.AddDays(12), new List<string> { "Sports: Marathon", "Social: Charity Auction" });
            eventsByDate.Add(DateTime.Now.AddDays(13), new List<string> { "Educational: Robotics Seminar", "Cultural: Poetry Reading" });
            eventsByDate.Add(DateTime.Now.AddDays(14), new List<string> { "Sports: Cricket Match", "Social: Yoga in the Park" });
            eventsByDate.Add(DateTime.Now.AddDays(15), new List<string> { "Educational: Astronomy Observation", "Cultural: Dance Workshop" });
            eventsByDate.Add(DateTime.Now.AddDays(16), new List<string> { "Social: Community Picnic", "Educational: Physics Lecture" });
            eventsByDate.Add(DateTime.Now.AddDays(17), new List<string> { "Cultural: Jazz Concert", "Sports: Cycling Race" });
            eventsByDate.Add(DateTime.Now.AddDays(18), new List<string> { "Educational: AI Workshop", "Social: Beach Cleanup" });
            eventsByDate.Add(DateTime.Now.AddDays(19), new List<string> { "Cultural: Art Exhibit", "Sports: Golf Tournament" });
            eventsByDate.Add(DateTime.Now.AddDays(20), new List<string> { "Educational: Chemistry Seminar", "Social: Game Night" });
        }


        // Load unique categories into HashSet
        private void InitializeUniqueCategories()
        {
            foreach (var events in eventsByDate.Values)
            {
                foreach (var ev in events)
                {
                    string category = ev.Split(':')[0].Trim();
                    uniqueCategories.Add(category);
                }
            }
        }

        // Populate the Queue with upcoming events
        private void PopulateUpcomingEventsQueue()
        {
            foreach (var kvp in eventsByDate)
            {
                foreach (var ev in kvp.Value)
                {
                    upcomingEventsQueue.Enqueue($"{kvp.Key.ToShortDateString()} - {ev}");
                }
            }
        }

        // Event handler for the "Sort by Date" checkbox
        private void chkSortByDate_CheckedChanged(object sender, EventArgs e)
        {
            datePicker.Visible = chkSortByDate.Checked;
        }

        // Event handler for the search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Clear previous results
            listBoxEvents.Items.Clear();
            listBoxRecommendations.Items.Clear();

            string selectedCategory = comboBoxCategory.SelectedItem?.ToString();
            bool sortByDate = chkSortByDate.Checked;

            // Ignore the "Select Category" placeholder
            if (selectedCategory == "Select Category")
            {
                selectedCategory = null; // Treat it as no category selected
            }
            else if (!string.IsNullOrEmpty(selectedCategory))
            {
                // Push the selected category onto the recent search stack
                recentSearchCategories.Push(selectedCategory);
            }

            // Prepare events for display
            IEnumerable<KeyValuePair<DateTime, List<string>>> events;
            if (sortByDate)
            {
                // Sort by date
                events = eventsByDate.OrderBy(kv => kv.Key);
            }
            else
            {
                events = eventsByDate;
            }

            // Filter and display events based on date and/or category
            foreach (var kvp in events)
            {
                var date = kvp.Key;
                var eventList = kvp.Value;

                // If sorting by date, filter by selected date
                if (sortByDate && date.Date != datePicker.Value.Date)
                    continue;

                foreach (var ev in eventList)
                {
                    // Display events that match the selected category or display all if no category is selected
                    if (string.IsNullOrEmpty(selectedCategory) || ev.StartsWith(selectedCategory))
                    {
                        string eventDisplayText = $"{date.ToShortDateString()} - {ev.Split(':')[0]}:\n  {ev.Split(':')[1].Trim()}";
                        listBoxEvents.Items.Add(eventDisplayText); // Format with date and description
                    }
                }
            }

            // Display recommendations based on selected category
            DisplayRecommendations(selectedCategory);
        }

        // Display recommendations based on selected category and recent searches
        private void DisplayRecommendations(string selectedCategory)
        {
            // Only recommend if there’s a recent search category
            if (string.IsNullOrEmpty(selectedCategory) && recentSearchCategories.Count == 0) return;

            // Use the last searched category if available
            string lastSearchedCategory = recentSearchCategories.Count > 0 ? recentSearchCategories.Peek() : selectedCategory;

            foreach (var kvp in eventsByDate)
            {
                foreach (var ev in kvp.Value)
                {
                    // Recommend events in the same category but on different dates
                    if (ev.StartsWith(lastSearchedCategory) && !listBoxEvents.Items.Contains(ev))
                    {
                        string recommendationDisplayText = $"{kvp.Key.ToShortDateString()} - {ev.Split(':')[0]}:\n  {ev.Split(':')[1].Trim()}";
                        listBoxRecommendations.Items.Add(recommendationDisplayText);
                    }
                }
            }
        }

        private void DisplayNextUpcomingEvent()
        {
            if (upcomingEventsQueue.Count > 0)
            {
                string nextEvent = upcomingEventsQueue.Dequeue(); // Remove the event from the queue
                MessageBox.Show($"Upcoming Event: {nextEvent}", "Next Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No more upcoming events in the queue.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close(); // Close the LocalEventsForm
        }

    }
}
