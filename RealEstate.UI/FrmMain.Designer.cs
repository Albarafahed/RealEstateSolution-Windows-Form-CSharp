namespace RealEstate.UI
{
    
        partial class FrmMain
        {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Panel TopBarPanel;
            private System.Windows.Forms.Panel SideMenuPanel;
            private System.Windows.Forms.Panel MainContentPanel;
            private System.Windows.Forms.PictureBox LogoPictureBox;
            private System.Windows.Forms.Label LblAppTitle;
            private System.Windows.Forms.Label LblCurrentUser;
            private System.Windows.Forms.Button btnLogout;
            private System.Windows.Forms.Panel MainPanel;
            private System.Windows.Forms.Label LblPageTitle;
            private System.Windows.Forms.Panel SideMenuHeader;
            private System.Windows.Forms.Label LblMenuTitle;
            private System.Windows.Forms.Panel BtnPropertiesPanel;
            private System.Windows.Forms.Button btnProperties;
            private System.Windows.Forms.Panel BtnClientsPanel;
            private System.Windows.Forms.Button btnClients;
            private System.Windows.Forms.Panel BtnContractsPanel;
            private System.Windows.Forms.Button btnContracts;
            private System.Windows.Forms.Panel BtnPaymentsPanel;
            private System.Windows.Forms.Button btnPayments;
            private System.Windows.Forms.Panel BtnReportsPanel;
            private System.Windows.Forms.Button btnReports;
            private System.Windows.Forms.Panel BtnSettingsPanel;
            private System.Windows.Forms.Button btnSettings;
            private System.Windows.Forms.Panel UserInfoPanel;
            private System.Windows.Forms.Label LblWelcome;
            private System.Windows.Forms.Panel TopBarRightPanel;
            private System.Windows.Forms.Panel TopBarLeftPanel;
            private System.Windows.Forms.Panel TopBarSeparator;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

        private void InitializeComponent()
        {
            TopBarPanel = new Panel();
            TopBarLeftPanel = new Panel();
            LogoPictureBox = new PictureBox();
            LblAppTitle = new Label();
            TopBarRightPanel = new Panel();
            UserInfoPanel = new Panel();
            LblWelcome = new Label();
            LblCurrentUser = new Label();
            btnLogout = new Button();
            TopBarSeparator = new Panel();
            SideMenuPanel = new Panel();
            SideMenuHeader = new Panel();
            LblMenuTitle = new Label();
            BtnPropertiesPanel = new Panel();
            btnProperties = new Button();
            BtnClientsPanel = new Panel();
            btnClients = new Button();
            BtnContractsPanel = new Panel();
            btnContracts = new Button();
            BtnPaymentsPanel = new Panel();
            btnPayments = new Button();
            BtnReportsPanel = new Panel();
            btnReports = new Button();
            BtnSettingsPanel = new Panel();
            btnSettings = new Button();
            MainContentPanel = new Panel();
            LblPageTitle = new Label();
            MainPanel = new Panel();
            TopBarPanel.SuspendLayout();
            TopBarLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            TopBarRightPanel.SuspendLayout();
            UserInfoPanel.SuspendLayout();
            SideMenuPanel.SuspendLayout();
            SideMenuHeader.SuspendLayout();
            BtnPropertiesPanel.SuspendLayout();
            BtnClientsPanel.SuspendLayout();
            BtnContractsPanel.SuspendLayout();
            BtnPaymentsPanel.SuspendLayout();
            BtnReportsPanel.SuspendLayout();
            BtnSettingsPanel.SuspendLayout();
            MainContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopBarPanel
            // 
            TopBarPanel.BackColor = Color.FromArgb(25, 42, 86);
            TopBarPanel.Controls.Add(TopBarLeftPanel);
            TopBarPanel.Controls.Add(TopBarRightPanel);
            TopBarPanel.Controls.Add(TopBarSeparator);
            TopBarPanel.Dock = DockStyle.Top;
            TopBarPanel.Location = new Point(0, 0);
            TopBarPanel.Name = "TopBarPanel";
            TopBarPanel.Size = new Size(1255, 70);
            TopBarPanel.TabIndex = 0;
            // 
            // TopBarLeftPanel
            // 
            TopBarLeftPanel.Controls.Add(LogoPictureBox);
            TopBarLeftPanel.Controls.Add(LblAppTitle);
            TopBarLeftPanel.Dock = DockStyle.Left;
            TopBarLeftPanel.Location = new Point(0, 0);
            TopBarLeftPanel.Name = "TopBarLeftPanel";
            TopBarLeftPanel.Padding = new Padding(20, 0, 0, 0);
            TopBarLeftPanel.Size = new Size(400, 65);
            TopBarLeftPanel.TabIndex = 0;
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Location = new Point(20, 10);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(50, 50);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPictureBox.TabIndex = 0;
            LogoPictureBox.TabStop = false;
            // 
            // LblAppTitle
            // 
            LblAppTitle.AutoSize = true;
            LblAppTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LblAppTitle.ForeColor = Color.White;
            LblAppTitle.Location = new Point(80, 20);
            LblAppTitle.Name = "LblAppTitle";
            LblAppTitle.Size = new Size(186, 30);
            LblAppTitle.TabIndex = 1;
            LblAppTitle.Text = "نظام إدارة العقارات";
            // 
            // TopBarRightPanel
            // 
            TopBarRightPanel.Controls.Add(UserInfoPanel);
            TopBarRightPanel.Controls.Add(btnLogout);
            TopBarRightPanel.Dock = DockStyle.Right;
            TopBarRightPanel.Location = new Point(855, 0);
            TopBarRightPanel.Name = "TopBarRightPanel";
            TopBarRightPanel.Padding = new Padding(0, 0, 20, 0);
            TopBarRightPanel.Size = new Size(400, 65);
            TopBarRightPanel.TabIndex = 1;
            // 
            // UserInfoPanel
            // 
            UserInfoPanel.Controls.Add(LblWelcome);
            UserInfoPanel.Controls.Add(LblCurrentUser);
            UserInfoPanel.Location = new Point(150, 15);
            UserInfoPanel.Name = "UserInfoPanel";
            UserInfoPanel.Size = new Size(200, 40);
            UserInfoPanel.TabIndex = 0;
            // 
            // LblWelcome
            // 
            LblWelcome.AutoSize = true;
            LblWelcome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblWelcome.ForeColor = Color.FromArgb(200, 200, 200);
            LblWelcome.Location = new Point(120, 0);
            LblWelcome.Name = "LblWelcome";
            LblWelcome.Size = new Size(53, 15);
            LblWelcome.TabIndex = 0;
            LblWelcome.Text = "مرحباً بك،";
            // 
            // LblCurrentUser
            // 
            LblCurrentUser.AutoSize = true;
            LblCurrentUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LblCurrentUser.ForeColor = Color.White;
            LblCurrentUser.Location = new Point(50, 15);
            LblCurrentUser.Name = "LblCurrentUser";
            LblCurrentUser.Size = new Size(78, 20);
            LblCurrentUser.TabIndex = 1;
            LblCurrentUser.Text = "محمد أحمد";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(52, 152, 219);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(20, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 35);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "تسجيل الخروج";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // TopBarSeparator
            // 
            TopBarSeparator.BackColor = Color.FromArgb(52, 152, 219);
            TopBarSeparator.Dock = DockStyle.Bottom;
            TopBarSeparator.Location = new Point(0, 65);
            TopBarSeparator.Name = "TopBarSeparator";
            TopBarSeparator.Size = new Size(1255, 5);
            TopBarSeparator.TabIndex = 2;
            // 
            // SideMenuPanel
            // 
            SideMenuPanel.BackColor = Color.FromArgb(30, 50, 92);
            SideMenuPanel.Controls.Add(SideMenuHeader);
            SideMenuPanel.Controls.Add(BtnPropertiesPanel);
            SideMenuPanel.Controls.Add(BtnClientsPanel);
            SideMenuPanel.Controls.Add(BtnContractsPanel);
            SideMenuPanel.Controls.Add(BtnPaymentsPanel);
            SideMenuPanel.Controls.Add(BtnReportsPanel);
            SideMenuPanel.Controls.Add(BtnSettingsPanel);
            SideMenuPanel.Dock = DockStyle.Left;
            SideMenuPanel.Location = new Point(0, 70);
            SideMenuPanel.Name = "SideMenuPanel";
            SideMenuPanel.Size = new Size(233, 649);
            SideMenuPanel.TabIndex = 1;
            // 
            // SideMenuHeader
            // 
            SideMenuHeader.BackColor = Color.FromArgb(25, 42, 86);
            SideMenuHeader.Controls.Add(LblMenuTitle);
            SideMenuHeader.Dock = DockStyle.Top;
            SideMenuHeader.Location = new Point(0, 0);
            SideMenuHeader.Name = "SideMenuHeader";
            SideMenuHeader.Size = new Size(233, 60);
            SideMenuHeader.TabIndex = 0;
            // 
            // LblMenuTitle
            // 
            LblMenuTitle.AutoSize = true;
            LblMenuTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblMenuTitle.ForeColor = Color.White;
            LblMenuTitle.Location = new Point(80, 20);
            LblMenuTitle.Name = "LblMenuTitle";
            LblMenuTitle.Size = new Size(108, 21);
            LblMenuTitle.TabIndex = 0;
            LblMenuTitle.Text = "القائمة الرئيسية";
            // 
            // BtnPropertiesPanel
            // 
            BtnPropertiesPanel.BackColor = Color.Transparent;
            BtnPropertiesPanel.Controls.Add(btnProperties);
            BtnPropertiesPanel.Location = new Point(0, 70);
            BtnPropertiesPanel.Name = "BtnPropertiesPanel";
            BtnPropertiesPanel.Size = new Size(250, 50);
            BtnPropertiesPanel.TabIndex = 1;
            // 
            // btnProperties
            // 
            btnProperties.BackColor = Color.Transparent;
            btnProperties.Cursor = Cursors.Hand;
            btnProperties.Dock = DockStyle.Fill;
            btnProperties.FlatAppearance.BorderSize = 0;
            btnProperties.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 152, 219);
            btnProperties.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 60, 110);
            btnProperties.FlatStyle = FlatStyle.Flat;
            btnProperties.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProperties.ForeColor = Color.White;
            btnProperties.ImageAlign = ContentAlignment.MiddleRight;
            btnProperties.Location = new Point(0, 0);
            btnProperties.Name = "btnProperties";
            btnProperties.Padding = new Padding(10, 0, 20, 0);
            btnProperties.Size = new Size(250, 50);
            btnProperties.TabIndex = 0;
            btnProperties.Text = "العقارات";
            btnProperties.TextAlign = ContentAlignment.MiddleLeft;
            btnProperties.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProperties.UseVisualStyleBackColor = false;
            btnProperties.Click += btnProperties_Click;
            // 
            // BtnClientsPanel
            // 
            BtnClientsPanel.BackColor = Color.Transparent;
            BtnClientsPanel.Controls.Add(btnClients);
            BtnClientsPanel.Location = new Point(0, 120);
            BtnClientsPanel.Name = "BtnClientsPanel";
            BtnClientsPanel.Size = new Size(250, 50);
            BtnClientsPanel.TabIndex = 2;
            // 
            // btnClients
            // 
            btnClients.BackColor = Color.Transparent;
            btnClients.Cursor = Cursors.Hand;
            btnClients.Dock = DockStyle.Fill;
            btnClients.FlatAppearance.BorderSize = 0;
            btnClients.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 152, 219);
            btnClients.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 60, 110);
            btnClients.FlatStyle = FlatStyle.Flat;
            btnClients.Font = new Font("Segoe UI", 11F);
            btnClients.ForeColor = Color.White;
            btnClients.ImageAlign = ContentAlignment.MiddleRight;
            btnClients.Location = new Point(0, 0);
            btnClients.Name = "btnClients";
            btnClients.Padding = new Padding(10, 0, 20, 0);
            btnClients.Size = new Size(250, 50);
            btnClients.TabIndex = 0;
            btnClients.Text = "العملاء";
            btnClients.TextAlign = ContentAlignment.MiddleLeft;
            btnClients.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnClients.UseVisualStyleBackColor = false;
            btnClients.Click += btnClients_Click;
            // 
            // BtnContractsPanel
            // 
            BtnContractsPanel.BackColor = Color.Transparent;
            BtnContractsPanel.Controls.Add(btnContracts);
            BtnContractsPanel.Location = new Point(0, 170);
            BtnContractsPanel.Name = "BtnContractsPanel";
            BtnContractsPanel.Size = new Size(250, 50);
            BtnContractsPanel.TabIndex = 3;
            // 
            // btnContracts
            // 
            btnContracts.BackColor = Color.Transparent;
            btnContracts.Cursor = Cursors.Hand;
            btnContracts.Dock = DockStyle.Fill;
            btnContracts.FlatAppearance.BorderSize = 0;
            btnContracts.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 152, 219);
            btnContracts.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 60, 110);
            btnContracts.FlatStyle = FlatStyle.Flat;
            btnContracts.Font = new Font("Segoe UI", 11F);
            btnContracts.ForeColor = Color.White;
            btnContracts.ImageAlign = ContentAlignment.MiddleRight;
            btnContracts.Location = new Point(0, 0);
            btnContracts.Name = "btnContracts";
            btnContracts.Padding = new Padding(10, 0, 20, 0);
            btnContracts.Size = new Size(250, 50);
            btnContracts.TabIndex = 0;
            btnContracts.Text = "العقود";
            btnContracts.TextAlign = ContentAlignment.MiddleLeft;
            btnContracts.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnContracts.UseVisualStyleBackColor = false;
            btnContracts.Click += btnContracts_Click;
            // 
            // BtnPaymentsPanel
            // 
            BtnPaymentsPanel.BackColor = Color.Transparent;
            BtnPaymentsPanel.Controls.Add(btnPayments);
            BtnPaymentsPanel.Location = new Point(0, 220);
            BtnPaymentsPanel.Name = "BtnPaymentsPanel";
            BtnPaymentsPanel.Size = new Size(250, 50);
            BtnPaymentsPanel.TabIndex = 4;
            // 
            // btnPayments
            // 
            btnPayments.BackColor = Color.Transparent;
            btnPayments.Cursor = Cursors.Hand;
            btnPayments.Dock = DockStyle.Fill;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 152, 219);
            btnPayments.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 60, 110);
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 11F);
            btnPayments.ForeColor = Color.White;
            btnPayments.ImageAlign = ContentAlignment.MiddleRight;
            btnPayments.Location = new Point(0, 0);
            btnPayments.Name = "btnPayments";
            btnPayments.Padding = new Padding(10, 0, 20, 0);
            btnPayments.Size = new Size(250, 50);
            btnPayments.TabIndex = 0;
            btnPayments.Text = "المدفوعات";
            btnPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnPayments.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPayments.UseVisualStyleBackColor = false;
            btnPayments.Click += btnPayments_Click;
            // 
            // BtnReportsPanel
            // 
            BtnReportsPanel.BackColor = Color.Transparent;
            BtnReportsPanel.Controls.Add(btnReports);
            BtnReportsPanel.Location = new Point(0, 270);
            BtnReportsPanel.Name = "BtnReportsPanel";
            BtnReportsPanel.Size = new Size(250, 50);
            BtnReportsPanel.TabIndex = 5;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.Cursor = Cursors.Hand;
            btnReports.Dock = DockStyle.Fill;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 152, 219);
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 60, 110);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 11F);
            btnReports.ForeColor = Color.White;
            btnReports.ImageAlign = ContentAlignment.MiddleRight;
            btnReports.Location = new Point(0, 0);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(10, 0, 20, 0);
            btnReports.Size = new Size(250, 50);
            btnReports.TabIndex = 0;
            btnReports.Text = "التقارير";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // BtnSettingsPanel
            // 
            BtnSettingsPanel.BackColor = Color.Transparent;
            BtnSettingsPanel.Controls.Add(btnSettings);
            BtnSettingsPanel.Dock = DockStyle.Bottom;
            BtnSettingsPanel.Location = new Point(0, 599);
            BtnSettingsPanel.Name = "BtnSettingsPanel";
            BtnSettingsPanel.Size = new Size(233, 50);
            BtnSettingsPanel.TabIndex = 6;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.Dock = DockStyle.Fill;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 204, 113);
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 60, 110);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 11F);
            btnSettings.ForeColor = Color.White;
            btnSettings.ImageAlign = ContentAlignment.MiddleRight;
            btnSettings.Location = new Point(0, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 20, 0);
            btnSettings.Size = new Size(233, 50);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "الإعدادات";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // MainContentPanel
            // 
            MainContentPanel.BackColor = Color.FromArgb(245, 245, 250);
            MainContentPanel.Controls.Add(LblPageTitle);
            MainContentPanel.Controls.Add(MainPanel);
            MainContentPanel.Dock = DockStyle.Fill;
            MainContentPanel.Location = new Point(233, 70);
            MainContentPanel.Name = "MainContentPanel";
            MainContentPanel.Padding = new Padding(20);
            MainContentPanel.Size = new Size(1022, 649);
            MainContentPanel.TabIndex = 2;
            MainContentPanel.Paint += MainContentPanel_Paint;
            // 
            // LblPageTitle
            // 
            LblPageTitle.AutoSize = true;
            LblPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPageTitle.ForeColor = Color.FromArgb(25, 42, 86);
            LblPageTitle.Location = new Point(12, 0);
            LblPageTitle.Name = "LblPageTitle";
            LblPageTitle.Size = new Size(103, 25);
            LblPageTitle.TabIndex = 0;
            LblPageTitle.Text = "لوحة التحكم";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(20, 20);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(982, 609);
            MainPanel.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1255, 719);
            Controls.Add(MainContentPanel);
            Controls.Add(SideMenuPanel);
            Controls.Add(TopBarPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMain";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نظام إدارة العقارات";
            WindowState = FormWindowState.Maximized;
            TopBarPanel.ResumeLayout(false);
            TopBarLeftPanel.ResumeLayout(false);
            TopBarLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            TopBarRightPanel.ResumeLayout(false);
            UserInfoPanel.ResumeLayout(false);
            UserInfoPanel.PerformLayout();
            SideMenuPanel.ResumeLayout(false);
            SideMenuHeader.ResumeLayout(false);
            SideMenuHeader.PerformLayout();
            BtnPropertiesPanel.ResumeLayout(false);
            BtnClientsPanel.ResumeLayout(false);
            BtnContractsPanel.ResumeLayout(false);
            BtnPaymentsPanel.ResumeLayout(false);
            BtnReportsPanel.ResumeLayout(false);
            BtnSettingsPanel.ResumeLayout(false);
            MainContentPanel.ResumeLayout(false);
            MainContentPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
    
}
