using System;
using System.Windows.Forms;
using System.IO;

namespace MunicipalityApp
{
    public partial class ReportIssuesForm : Form
    {
        // To keep track of the attached file
        private string attachedFilePath;

        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        // Event handler for attaching a file
        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            // Open file dialog to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.png)|*.jpg;*.png|Document files (*.pdf)|*.pdf"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                attachedFilePath = openFileDialog.FileName;
                lblEngagement.Text = "File attached: " + attachedFilePath;
                progressBar.Value += 20; // Show some progress when file is attached
            }
        }

        // Event handler for submitting the issue
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get form inputs
            string location = txtLocation.Text;
            string category = comboBoxCategory.SelectedItem?.ToString();
            string description = txtDescription.Text;

            // Validate form inputs
            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please complete all fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simulate saving the issue (you can store this in a file or database)
            MessageBox.Show("Issue reported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update feedback to the user
            lblEngagement.Text = "Thank you for your submission!";
            progressBar.Value = 100; // Show full progress after submission

            // Reset the form after submission
            ResetForm();
        }

        // Event handler for navigating back to the main menu
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Open the MainForm and hide the current ReportIssuesForm
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        // Method to reset the form inputs after submission
        private void ResetForm()
        {
            txtLocation.Clear();
            comboBoxCategory.SelectedIndex = -1;
            txtDescription.Clear();
            attachedFilePath = null;
            progressBar.Value = 0;
            lblEngagement.Text = "Fill the form to submit your issue.";
        }
    }
}
