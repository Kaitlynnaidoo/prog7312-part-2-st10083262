using System;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Event handler for the "Report Issues" button
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // Open the ReportIssuesForm when the button is clicked
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.Show();
            this.Hide();
        }

        // Event handler for the "Exit" button
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application when the Exit button is clicked
            Application.Exit();
        }

        private void btnLocalEvents_Click_1(object sender, EventArgs e)
        {
            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.Show();
            this.Hide();  // Optionally hide the main form
        }
    }
}
