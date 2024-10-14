namespace MunicipalityApp
{
    partial class ReportIssuesForm
    {
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2Button btnAttachFile;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEngagement;
        private Guna.UI2.WinForms.Guna2Button btnBackToMenu;

        private void InitializeComponent()
        {
            // Set form size and background color
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.BackColor = System.Drawing.Color.White;

            // 
            // lblTitle
            // 
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(125, 20);  // Center title
            this.lblTitle.Size = new System.Drawing.Size(200, 30);
            this.lblTitle.Text = "Report an Issue";
            this.Controls.Add(this.lblTitle);

            // 
            // txtLocation
            // 
            this.txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLocation.PlaceholderText = "Enter Location";
            this.txtLocation.Location = new System.Drawing.Point(50, 80);  // Set margins
            this.txtLocation.Size = new System.Drawing.Size(350, 40);  // Increase width
            this.Controls.Add(this.txtLocation);

            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxCategory.Items.AddRange(new object[] { "Sanitation", "Roads", "Utilities" });
            this.comboBoxCategory.Location = new System.Drawing.Point(50, 140);
            this.comboBoxCategory.Size = new System.Drawing.Size(350, 40);  // Increase width
            this.Controls.Add(this.comboBoxCategory);

            // 
            // txtDescription
            // 
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription.PlaceholderText = "Enter Description";
            this.txtDescription.Multiline = true;  // Enable multiline
            this.txtDescription.Location = new System.Drawing.Point(50, 200);
            this.txtDescription.Size = new System.Drawing.Size(350, 100);  // Increase height for multiline
            this.Controls.Add(this.txtDescription);

            // 
            // btnAttachFile
            // 
            this.btnAttachFile = new Guna.UI2.WinForms.Guna2Button();
            this.btnAttachFile.Text = "Attach File";
            this.btnAttachFile.Location = new System.Drawing.Point(50, 320);
            this.btnAttachFile.Size = new System.Drawing.Size(350, 40);
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            this.Controls.Add(this.btnAttachFile);

            // 
            // btnSubmit
            // 
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Location = new System.Drawing.Point(50, 380);
            this.btnSubmit.Size = new System.Drawing.Size(350, 50);  // Increase size
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.Controls.Add(this.btnSubmit);

            // 
            // progressBar
            // 
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.progressBar.Location = new System.Drawing.Point(50, 450);
            this.progressBar.Size = new System.Drawing.Size(350, 20);
            this.Controls.Add(this.progressBar);

            // 
            // lblEngagement
            // 
            this.lblEngagement = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEngagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEngagement.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblEngagement.Location = new System.Drawing.Point(125, 480);  // Center text
            this.lblEngagement.Size = new System.Drawing.Size(200, 30);
            this.lblEngagement.Text = "Fill the form to submit your issue.";
            this.Controls.Add(this.lblEngagement);

            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnBackToMenu.Text = "Back to Main Menu";
            this.btnBackToMenu.Location = new System.Drawing.Point(50, 520);
            this.btnBackToMenu.Size = new System.Drawing.Size(350, 40);
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            this.Controls.Add(this.btnBackToMenu);
        }
    }
}
