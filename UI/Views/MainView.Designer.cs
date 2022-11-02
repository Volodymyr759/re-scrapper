
namespace UI
{
    partial class MainView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.newfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agencyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localityReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allAgenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allLocalitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newfileToolStripMenuItem
            // 
            this.newfileToolStripMenuItem.Name = "newfileToolStripMenuItem";
            this.newfileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newfileToolStripMenuItem.Text = "New";
            this.newfileToolStripMenuItem.Click += new System.EventHandler(this.NewfileToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.servicesToolStripMenuItem.Text = "Reports";
            // 
            // agencyReportToolStripMenuItem
            // 
            this.agencyReportToolStripMenuItem.Name = "agencyReportToolStripMenuItem";
            this.agencyReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agencyReportToolStripMenuItem.Text = "All agencies";
            this.agencyReportToolStripMenuItem.Click += new System.EventHandler(this.AgencyReportToolStripMenuItem_Click);
            // 
            // localityReportToolStripMenuItem
            // 
            this.localityReportToolStripMenuItem.Name = "localityReportToolStripMenuItem";
            this.localityReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.localityReportToolStripMenuItem.Text = "All localities";
            this.localityReportToolStripMenuItem.Click += new System.EventHandler(this.LocalityReportToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPanel.Location = new System.Drawing.Point(0, 32);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(830, 602);
            this.mainPanel.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.Location = new System.Drawing.Point(836, 32);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(286, 601);
            this.rightPanel.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewsToolStripMenuItem1,
            this.reportsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::UI.Properties.Resources._new;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.ToolTipText = "Create new txt file";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewfileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::UI.Properties.Resources.OpenFolder;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.ToolTipText = "Open existing file";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // viewsToolStripMenuItem1
            // 
            this.viewsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agenciesToolStripMenuItem,
            this.localitiesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.viewsToolStripMenuItem1.Name = "viewsToolStripMenuItem1";
            this.viewsToolStripMenuItem1.Size = new System.Drawing.Size(61, 24);
            this.viewsToolStripMenuItem1.Text = "Views";
            // 
            // agenciesToolStripMenuItem
            // 
            this.agenciesToolStripMenuItem.Name = "agenciesToolStripMenuItem";
            this.agenciesToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.agenciesToolStripMenuItem.Text = "Agencies";
            this.agenciesToolStripMenuItem.ToolTipText = "Agencies from database";
            this.agenciesToolStripMenuItem.Click += new System.EventHandler(this.AgenciesToolStripMenuItem_Click);
            // 
            // localitiesToolStripMenuItem
            // 
            this.localitiesToolStripMenuItem.Name = "localitiesToolStripMenuItem";
            this.localitiesToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.localitiesToolStripMenuItem.Text = "Localities";
            this.localitiesToolStripMenuItem.ToolTipText = "Localities from database";
            this.localitiesToolStripMenuItem.Click += new System.EventHandler(this.LocalitiesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::UI.Properties.Resources.tools;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allAgenciesToolStripMenuItem,
            this.allLocalitiesToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // allAgenciesToolStripMenuItem
            // 
            this.allAgenciesToolStripMenuItem.Image = global::UI.Properties.Resources.Print;
            this.allAgenciesToolStripMenuItem.Name = "allAgenciesToolStripMenuItem";
            this.allAgenciesToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.allAgenciesToolStripMenuItem.Text = "All Agencies";
            this.allAgenciesToolStripMenuItem.ToolTipText = "Save agencies list to csv file";
            this.allAgenciesToolStripMenuItem.Click += new System.EventHandler(this.AgencyReportToolStripMenuItem_Click);
            // 
            // allLocalitiesToolStripMenuItem
            // 
            this.allLocalitiesToolStripMenuItem.Image = global::UI.Properties.Resources.Print;
            this.allLocalitiesToolStripMenuItem.Name = "allLocalitiesToolStripMenuItem";
            this.allLocalitiesToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.allLocalitiesToolStripMenuItem.Text = "All Localities";
            this.allLocalitiesToolStripMenuItem.ToolTipText = "Save localities list to csv file";
            this.allLocalitiesToolStripMenuItem.Click += new System.EventHandler(this.LocalityReportToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 633);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1140, 680);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real Estate Scraper";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem newfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agencyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localityReportToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agenciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allAgenciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allLocalitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

