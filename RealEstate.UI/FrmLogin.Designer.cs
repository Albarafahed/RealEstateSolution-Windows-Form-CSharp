namespace RealEstate.UI
{

   
        partial class FrmLogin
        {
            private System.ComponentModel.IContainer components = null;

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
            RightPanel = new Panel();
            LoginCard = new Panel();
            btnExit = new Button();
            label2 = new Label();
            LogoPictureBox = new PictureBox();
            LblSystemTitle = new Label();
            LblLoginTitle = new Label();
            InputContainer = new Panel();
            UsernamePanel = new Panel();
            LblUsername = new Label();
            txtUsername = new TextBox();
            PasswordPanel = new Panel();
            LblPassword = new Label();
            txtPassword = new TextBox();
            ChkRememberMe = new CheckBox();
            LblForgotPassword = new Label();
            ButtonPanel = new Panel();
            btnLogin = new Button();
            LblError = new Label();
            SeparatorLine = new Panel();
            LeftPanel = new Panel();
            BackgroundImage = new PictureBox();
            LblWelcome = new Label();
            LblSubtitle = new Label();
            MainContainer = new Panel();
            RightPanel.SuspendLayout();
            LoginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            InputContainer.SuspendLayout();
            UsernamePanel.SuspendLayout();
            PasswordPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackgroundImage).BeginInit();
            MainContainer.SuspendLayout();
            SuspendLayout();
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.FromArgb(250, 252, 255);
            RightPanel.Controls.Add(LoginCard);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(0, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Padding = new Padding(60, 0, 60, 0);
            RightPanel.Size = new Size(985, 650);
            RightPanel.TabIndex = 1;
            // 
            // LoginCard
            // 
            LoginCard.Anchor = AnchorStyles.None;
            LoginCard.BackColor = Color.LightGray;
            LoginCard.Controls.Add(btnExit);
            LoginCard.Controls.Add(label2);
            LoginCard.Controls.Add(LogoPictureBox);
            LoginCard.Controls.Add(LblSystemTitle);
            LoginCard.Controls.Add(LblLoginTitle);
            LoginCard.Controls.Add(InputContainer);
            LoginCard.Controls.Add(ButtonPanel);
            LoginCard.Controls.Add(LblError);
            LoginCard.Controls.Add(SeparatorLine);
            LoginCard.Location = new Point(547, 22);
            LoginCard.Name = "LoginCard";
            LoginCard.Padding = new Padding(40);
            LoginCard.Size = new Size(371, 599);
            LoginCard.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 18F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(79, 514);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(231, 59);
            btnExit.TabIndex = 9;
            btnExit.Text = "خروج";
            btnExit.TextAlign = ContentAlignment.TopCenter;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.ScrollBar;
            label2.AllowDrop = true;
            label2.BackColor = Color.FromArgb(25, 42, 86);
            label2.Cursor = Cursors.No;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(367, 48);
            label2.TabIndex = 8;
            label2.Text = "مرحبا بك في BS_BIM";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Location = new Point(140, 64);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(100, 73);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPictureBox.TabIndex = 0;
            LogoPictureBox.TabStop = false;
            // 
            // LblSystemTitle
            // 
            LblSystemTitle.AutoSize = true;
            LblSystemTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LblSystemTitle.ForeColor = Color.FromArgb(25, 42, 86);
            LblSystemTitle.Location = new Point(100, 140);
            LblSystemTitle.Name = "LblSystemTitle";
            LblSystemTitle.Size = new Size(227, 41);
            LblSystemTitle.TabIndex = 1;
            LblSystemTitle.Text = "Real Estate Pro";
            LblSystemTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblLoginTitle
            // 
            LblLoginTitle.AutoSize = true;
            LblLoginTitle.Font = new Font("Segoe UI", 12F);
            LblLoginTitle.ForeColor = Color.FromArgb(100, 100, 120);
            LblLoginTitle.Location = new Point(145, 180);
            LblLoginTitle.Name = "LblLoginTitle";
            LblLoginTitle.Size = new Size(130, 28);
            LblLoginTitle.TabIndex = 2;
            LblLoginTitle.Text = "تسجيل الدخول";
            LblLoginTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputContainer
            // 
            InputContainer.Controls.Add(UsernamePanel);
            InputContainer.Controls.Add(PasswordPanel);
            InputContainer.Controls.Add(ChkRememberMe);
            InputContainer.Controls.Add(LblForgotPassword);
            InputContainer.Location = new Point(40, 220);
            InputContainer.Name = "InputContainer";
            InputContainer.Size = new Size(300, 180);
            InputContainer.TabIndex = 3;
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = Color.FromArgb(250, 252, 255);
            UsernamePanel.Controls.Add(LblUsername);
            UsernamePanel.Controls.Add(txtUsername);
            UsernamePanel.Location = new Point(0, 0);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Padding = new Padding(10);
            UsernamePanel.Size = new Size(300, 70);
            UsernamePanel.TabIndex = 0;
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblUsername.ForeColor = Color.FromArgb(80, 80, 100);
            LblUsername.Location = new Point(190, 25);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(101, 20);
            LblUsername.TabIndex = 1;
            LblUsername.Text = "اسم المستخدم";
            // 
            // txtUsername
            // 
            txtUsername.AccessibleRole = AccessibleRole.MenuBar;
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.FromArgb(60, 60, 80);
            txtUsername.Location = new Point(10, 22);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(170, 32);
            txtUsername.TabIndex = 1;
            txtUsername.TextAlign = HorizontalAlignment.Right;
            // 
            // PasswordPanel
            // 
            PasswordPanel.BackColor = Color.FromArgb(250, 252, 255);
            PasswordPanel.Controls.Add(LblPassword);
            PasswordPanel.Controls.Add(txtPassword);
            PasswordPanel.Location = new Point(0, 80);
            PasswordPanel.Name = "PasswordPanel";
            PasswordPanel.Padding = new Padding(10);
            PasswordPanel.Size = new Size(300, 70);
            PasswordPanel.TabIndex = 1;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblPassword.ForeColor = Color.FromArgb(80, 80, 100);
            LblPassword.Location = new Point(190, 25);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(80, 20);
            LblPassword.TabIndex = 1;
            LblPassword.Text = "كلمة المرور";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.FromArgb(60, 60, 80);
            txtPassword.Location = new Point(10, 22);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(170, 32);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Right;
            txtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // ChkRememberMe
            // 
            ChkRememberMe.AutoSize = true;
            ChkRememberMe.Font = new Font("Segoe UI", 9F);
            ChkRememberMe.ForeColor = Color.FromArgb(100, 100, 120);
            ChkRememberMe.Location = new Point(180, 160);
            ChkRememberMe.Name = "ChkRememberMe";
            ChkRememberMe.Size = new Size(147, 24);
            ChkRememberMe.TabIndex = 2;
            ChkRememberMe.Text = "تذكر بيانات الدخول";
            ChkRememberMe.TextAlign = ContentAlignment.MiddleRight;
            ChkRememberMe.UseVisualStyleBackColor = true;
            // 
            // LblForgotPassword
            // 
            LblForgotPassword.AutoSize = true;
            LblForgotPassword.Cursor = Cursors.Hand;
            LblForgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            LblForgotPassword.ForeColor = Color.FromArgb(52, 152, 219);
            LblForgotPassword.Location = new Point(0, 161);
            LblForgotPassword.Name = "LblForgotPassword";
            LblForgotPassword.Size = new Size(128, 20);
            LblForgotPassword.TabIndex = 3;
            LblForgotPassword.Text = "نسيت كلمة المرور؟";
            LblForgotPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(btnLogin);
            ButtonPanel.Location = new Point(40, 410);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(300, 60);
            ButtonPanel.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.BackColor = Color.FromArgb(25, 42, 86);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(0, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 60);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "دخول إلى النظام";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LblError
            // 
            LblError.Font = new Font("Segoe UI", 10F);
            LblError.ForeColor = Color.FromArgb(231, 76, 60);
            LblError.Location = new Point(40, 370);
            LblError.Name = "LblError";
            LblError.Size = new Size(300, 30);
            LblError.TabIndex = 5;
            LblError.TextAlign = ContentAlignment.MiddleCenter;
            LblError.Visible = false;
            // 
            // SeparatorLine
            // 
            SeparatorLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SeparatorLine.BackColor = Color.FromArgb(240, 242, 245);
            SeparatorLine.Location = new Point(40, 210);
            SeparatorLine.Name = "SeparatorLine";
            SeparatorLine.Size = new Size(291, 1);
            SeparatorLine.TabIndex = 7;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.FromArgb(25, 42, 86);
            LeftPanel.Controls.Add(BackgroundImage);
            LeftPanel.Controls.Add(LblWelcome);
            LeftPanel.Controls.Add(LblSubtitle);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(500, 650);
            LeftPanel.TabIndex = 0;
            // 
            // BackgroundImage
            // 
            BackgroundImage.Dock = DockStyle.Fill;
            BackgroundImage.Location = new Point(0, 0);
            BackgroundImage.Name = "BackgroundImage";
            BackgroundImage.Size = new Size(500, 650);
            BackgroundImage.TabIndex = 0;
            BackgroundImage.TabStop = false;
            BackgroundImage.Click += BackgroundImage_Click;
            // 
            // LblWelcome
            // 
            LblWelcome.Anchor = AnchorStyles.None;
            LblWelcome.AutoSize = true;
            LblWelcome.BackColor = Color.Transparent;
            LblWelcome.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            LblWelcome.ForeColor = Color.White;
            LblWelcome.Location = new Point(100, 200);
            LblWelcome.Name = "LblWelcome";
            LblWelcome.Size = new Size(382, 62);
            LblWelcome.TabIndex = 1;
            LblWelcome.Text = "مرحباً بك مرة أخرى";
            LblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblSubtitle
            // 
            LblSubtitle.Anchor = AnchorStyles.None;
            LblSubtitle.AutoSize = true;
            LblSubtitle.BackColor = Color.Transparent;
            LblSubtitle.Font = new Font("Segoe UI", 14F);
            LblSubtitle.ForeColor = Color.FromArgb(200, 200, 220);
            LblSubtitle.Location = new Point(150, 270);
            LblSubtitle.Name = "LblSubtitle";
            LblSubtitle.Size = new Size(253, 32);
            LblSubtitle.TabIndex = 2;
            LblSubtitle.Text = "إدارة عقاراتك بكل سهولة";
            LblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainContainer
            // 
            MainContainer.BackColor = Color.FromArgb(255, 255, 255);
            MainContainer.Controls.Add(LeftPanel);
            MainContainer.Controls.Add(RightPanel);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 0);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(985, 650);
            MainContainer.TabIndex = 0;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(985, 650);
            Controls.Add(MainContainer);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول - نظام إدارة العقارات";
            Load += FrmLogin_Load;
            RightPanel.ResumeLayout(false);
            LoginCard.ResumeLayout(false);
            LoginCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            InputContainer.ResumeLayout(false);
            InputContainer.PerformLayout();
            UsernamePanel.ResumeLayout(false);
            UsernamePanel.PerformLayout();
            PasswordPanel.ResumeLayout(false);
            PasswordPanel.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackgroundImage).EndInit();
            MainContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        private static object GetCover() => System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        private Panel RightPanel;
        private Panel LoginCard;
        private Button btnExit;
        private Label label2;
        private PictureBox LogoPictureBox;
        private Label LblSystemTitle;
        private Label LblLoginTitle;
        private Panel InputContainer;
        private Panel UsernamePanel;
        private Label LblUsername;
        private TextBox txtUsername;
        private Panel PasswordPanel;
        private Label LblPassword;
        private TextBox txtPassword;
        private CheckBox ChkRememberMe;
        private Label LblForgotPassword;
        private Panel ButtonPanel;
        private Button btnLogin;
        private Label LblError;
        private Panel SeparatorLine;
        private Panel LeftPanel;
        private PictureBox BackgroundImage;
        private Label LblWelcome;
        private Label LblSubtitle;
        private Panel MainContainer;
    }
    

}