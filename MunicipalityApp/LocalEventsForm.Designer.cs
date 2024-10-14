namespace MunicipalityApp
{
    partial class LocalEventsForm
    {
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEvents;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRecommendations;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCategory;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePicker;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnMainMenu; 
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxRecommendations;
        private Guna.UI2.WinForms.Guna2CheckBox chkSortByDate;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(650, 700); 
            this.BackColor = System.Drawing.Color.White;

            // Title Label
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(150, 20);
            this.lblTitle.Size = new System.Drawing.Size(350, 30);
            this.lblTitle.Text = "Local Events and Announcements";
            this.Controls.Add(this.lblTitle);

            // ComboBox for Event Category
            this.comboBoxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxCategory.Items.AddRange(new object[] { "Select Category", "Sports", "Cultural", "Educational", "Social" });
            this.comboBoxCategory.SelectedIndex = 0; // Set default selection
            this.comboBoxCategory.Location = new System.Drawing.Point(50, 70);
            this.comboBoxCategory.Size = new System.Drawing.Size(200, 40);
            this.Controls.Add(this.comboBoxCategory);

            // DatePicker for selecting the event date (hidden initially)
            this.datePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datePicker.Location = new System.Drawing.Point(300, 70);
            this.datePicker.Size = new System.Drawing.Size(200, 40);
            this.datePicker.Visible = false; // Hidden by default
            this.Controls.Add(this.datePicker);

            // Checkbox to allow sorting by date
            this.chkSortByDate = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkSortByDate.Text = "Sort by Date";
            this.chkSortByDate.Location = new System.Drawing.Point(50, 120);
            this.chkSortByDate.Size = new System.Drawing.Size(150, 30);
            this.chkSortByDate.CheckedChanged += new System.EventHandler(this.chkSortByDate_CheckedChanged);
            this.Controls.Add(this.chkSortByDate);

            // Search Button
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(250, 120);
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.Controls.Add(this.btnSearch);

            // Events ListBox label
            this.lblEvents = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEvents.Text = "Events";
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEvents.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEvents.Location = new System.Drawing.Point(50, 180);
            this.Controls.Add(this.lblEvents);

            // ListBox to display events
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxEvents.Location = new System.Drawing.Point(50, 210);
            this.listBoxEvents.Size = new System.Drawing.Size(500, 150);
            this.listBoxEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Controls.Add(this.listBoxEvents);

            // Recommendations ListBox label
            this.lblRecommendations = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRecommendations.Text = "Recommended Events";
            this.lblRecommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecommendations.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRecommendations.Location = new System.Drawing.Point(50, 380);
            this.Controls.Add(this.lblRecommendations);

            // Recommendations ListBox
            this.listBoxRecommendations = new System.Windows.Forms.ListBox();
            this.listBoxRecommendations.Location = new System.Drawing.Point(50, 410);
            this.listBoxRecommendations.Size = new System.Drawing.Size(500, 150);
            this.listBoxRecommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Controls.Add(this.listBoxRecommendations);

            // Main Menu Button
            this.btnMainMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnMainMenu.Text = "Back to Main Menu";
            this.btnMainMenu.Location = new System.Drawing.Point(250, 580); 
            this.btnMainMenu.Size = new System.Drawing.Size(150, 40);
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click); 
        }
    }
}
