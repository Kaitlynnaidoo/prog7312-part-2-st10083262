namespace MunicipalityApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnReportIssues = new Guna.UI2.WinForms.Guna2Button();
            this.btnLocalEvents = new Guna.UI2.WinForms.Guna2Button();
            this.btnServiceRequest = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaLabel1.Location = new System.Drawing.Point(80, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(332, 27);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Welcome to Municipal Services";
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.FillColor = System.Drawing.Color.Orange;
            this.btnReportIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.Location = new System.Drawing.Point(100, 100);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(300, 50);
            this.btnReportIssues.TabIndex = 1;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.FillColor = System.Drawing.Color.DarkBlue;
            this.btnLocalEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLocalEvents.ForeColor = System.Drawing.Color.White;
            this.btnLocalEvents.Location = new System.Drawing.Point(100, 170);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(300, 50);
            this.btnLocalEvents.TabIndex = 2;
            this.btnLocalEvents.Text = "Local Events and Announcements";
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click_1);
            // 
            // btnServiceRequest
            // 
            this.btnServiceRequest.Enabled = false;
            this.btnServiceRequest.FillColor = System.Drawing.Color.LightGray;
            this.btnServiceRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnServiceRequest.ForeColor = System.Drawing.Color.White;
            this.btnServiceRequest.Location = new System.Drawing.Point(100, 240);
            this.btnServiceRequest.Name = "btnServiceRequest";
            this.btnServiceRequest.Size = new System.Drawing.Size(300, 50);
            this.btnServiceRequest.TabIndex = 3;
            this.btnServiceRequest.Text = "Service Request Status";
            // 
            // btnExit
            // 
            this.btnExit.FillColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(100, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnServiceRequest);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.Text = "Municipal Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button btnReportIssues;
        private Guna.UI2.WinForms.Guna2Button btnLocalEvents;
        private Guna.UI2.WinForms.Guna2Button btnServiceRequest;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}
