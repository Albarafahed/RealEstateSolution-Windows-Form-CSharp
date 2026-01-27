namespace RealEstate.UI
{



   
        partial class FrmSettings
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlSidebar = new Panel();
            btnSystem = new Button();
            btnPrinting = new Button();
            btnPayments = new Button();
            btnContracts = new Button();
            btnUsers = new Button();
            btnGeneral = new Button();
            pnlContent = new Panel();
            pnlUsers = new Panel();
            panel1 = new Panel();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            btnUpdateUser = new Button();
            pnlGeneral = new Panel();
            cbDateFormat = new ComboBox();
            lblDateFormat = new Label();
            cbCurrency = new ComboBox();
            lblCurrency = new Label();
            txtCompanyName = new TextBox();
            lblCompanyName = new Label();
            txtSystemName = new TextBox();
            lblSystemName = new Label();
            dgvUsers = new DataGridView();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            lnkChangePhoto = new LinkLabel();
            picUserPhoto = new PictureBox();
            lblUsersTitle = new Label();
            pnlContracts = new Panel();
            numInitialPaymentPercent = new NumericUpDown();
            lblInitialPaymentPercent = new Label();
            chkAllowWithoutPayment = new CheckBox();
            cbDefaultContractType = new ComboBox();
            lblDefaultContractType = new Label();
            cbDefaultContractStatus = new ComboBox();
            lblDefaultContractStatus = new Label();
            lblContractsTitle = new Label();
            pnlPayments = new Panel();
            numMaxPaymentAmount = new NumericUpDown();
            lblMaxPaymentAmount = new Label();
            chkAllowDeletePayment = new CheckBox();
            chkAllowEditPayment = new CheckBox();
            lblPaymentsTitle = new Label();
            pnlPrinting = new Panel();
            chkPrintRTL = new CheckBox();
            chkShowUserName = new CheckBox();
            chkShowPrintDate = new CheckBox();
            txtReportTitle = new TextBox();
            lblReportTitle = new Label();
            lblPrintingTitle = new Label();
            pnlSystem = new Panel();
            chkEnableLog = new CheckBox();
            btnBackupNow = new Button();
            txtBackupPath = new TextBox();
            lblBackupPath = new Label();
            lblSystemTitle = new Label();
            pnlFooter = new Panel();
            btnClose = new Button();
            btnSaveSettings = new Button();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlUsers.SuspendLayout();
            panel1.SuspendLayout();
            pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUserPhoto).BeginInit();
            pnlContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numInitialPaymentPercent).BeginInit();
            pnlPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxPaymentAmount).BeginInit();
            pnlPrinting.SuspendLayout();
            pnlSystem.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(868, 40);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(868, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "الإعدادات";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(25, 42, 86);
            pnlSidebar.Controls.Add(btnSystem);
            pnlSidebar.Controls.Add(btnPrinting);
            pnlSidebar.Controls.Add(btnPayments);
            pnlSidebar.Controls.Add(btnContracts);
            pnlSidebar.Controls.Add(btnUsers);
            pnlSidebar.Controls.Add(btnGeneral);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 40);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(150, 450);
            pnlSidebar.TabIndex = 1;
            // 
            // btnSystem
            // 
            btnSystem.Dock = DockStyle.Top;
            btnSystem.FlatAppearance.BorderSize = 0;
            btnSystem.FlatStyle = FlatStyle.Flat;
            btnSystem.Font = new Font("Segoe UI", 10F);
            btnSystem.ForeColor = Color.White;
            btnSystem.ImageAlign = ContentAlignment.MiddleRight;
            btnSystem.Location = new Point(0, 200);
            btnSystem.Name = "btnSystem";
            btnSystem.Padding = new Padding(8, 0, 0, 0);
            btnSystem.Size = new Size(150, 40);
            btnSystem.TabIndex = 5;
            btnSystem.Text = "النظام";
            btnSystem.TextAlign = ContentAlignment.MiddleLeft;
            btnSystem.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSystem.UseVisualStyleBackColor = true;
            // 
            // btnPrinting
            // 
            btnPrinting.Dock = DockStyle.Top;
            btnPrinting.FlatAppearance.BorderSize = 0;
            btnPrinting.FlatStyle = FlatStyle.Flat;
            btnPrinting.Font = new Font("Segoe UI", 10F);
            btnPrinting.ForeColor = Color.White;
            btnPrinting.ImageAlign = ContentAlignment.MiddleRight;
            btnPrinting.Location = new Point(0, 160);
            btnPrinting.Name = "btnPrinting";
            btnPrinting.Padding = new Padding(8, 0, 0, 0);
            btnPrinting.Size = new Size(150, 40);
            btnPrinting.TabIndex = 4;
            btnPrinting.Text = "الطباعة";
            btnPrinting.TextAlign = ContentAlignment.MiddleLeft;
            btnPrinting.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrinting.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            btnPayments.Dock = DockStyle.Top;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 10F);
            btnPayments.ForeColor = Color.White;
            btnPayments.ImageAlign = ContentAlignment.MiddleRight;
            btnPayments.Location = new Point(0, 120);
            btnPayments.Name = "btnPayments";
            btnPayments.Padding = new Padding(8, 0, 0, 0);
            btnPayments.Size = new Size(150, 40);
            btnPayments.TabIndex = 3;
            btnPayments.Text = "المدفوعات";
            btnPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnPayments.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnContracts
            // 
            btnContracts.Dock = DockStyle.Top;
            btnContracts.FlatAppearance.BorderSize = 0;
            btnContracts.FlatStyle = FlatStyle.Flat;
            btnContracts.Font = new Font("Segoe UI", 10F);
            btnContracts.ForeColor = Color.White;
            btnContracts.ImageAlign = ContentAlignment.MiddleRight;
            btnContracts.Location = new Point(0, 80);
            btnContracts.Name = "btnContracts";
            btnContracts.Padding = new Padding(8, 0, 0, 0);
            btnContracts.Size = new Size(150, 40);
            btnContracts.TabIndex = 2;
            btnContracts.Text = "العقود";
            btnContracts.TextAlign = ContentAlignment.MiddleLeft;
            btnContracts.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnContracts.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.ForeColor = Color.White;
            btnUsers.ImageAlign = ContentAlignment.MiddleRight;
            btnUsers.Location = new Point(0, 40);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(8, 0, 0, 0);
            btnUsers.Size = new Size(150, 40);
            btnUsers.TabIndex = 1;
            btnUsers.Text = "المستخدمون";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnGeneral
            // 
            btnGeneral.Dock = DockStyle.Top;
            btnGeneral.FlatAppearance.BorderSize = 0;
            btnGeneral.FlatStyle = FlatStyle.Flat;
            btnGeneral.ForeColor = Color.White;
            btnGeneral.ImageAlign = ContentAlignment.MiddleRight;
            btnGeneral.Location = new Point(0, 0);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Padding = new Padding(8, 0, 0, 0);
            btnGeneral.Size = new Size(150, 40);
            btnGeneral.TabIndex = 0;
            btnGeneral.Text = "عام";
            btnGeneral.TextAlign = ContentAlignment.MiddleLeft;
            btnGeneral.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGeneral.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlUsers);
            pnlContent.Controls.Add(pnlContracts);
            pnlContent.Controls.Add(pnlPayments);
            pnlContent.Controls.Add(pnlPrinting);
            pnlContent.Controls.Add(pnlSystem);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(150, 40);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(718, 450);
            pnlContent.TabIndex = 2;
            // 
            // pnlUsers
            // 
            pnlUsers.Controls.Add(panel1);
            pnlUsers.Controls.Add(pnlGeneral);
            pnlUsers.Controls.Add(dgvUsers);
            pnlUsers.Controls.Add(txtConfirmPassword);
            pnlUsers.Controls.Add(lblConfirmPassword);
            pnlUsers.Controls.Add(txtPassword);
            pnlUsers.Controls.Add(lblPassword);
            pnlUsers.Controls.Add(txtUserName);
            pnlUsers.Controls.Add(lblUserName);
            pnlUsers.Controls.Add(lnkChangePhoto);
            pnlUsers.Controls.Add(picUserPhoto);
            pnlUsers.Controls.Add(lblUsersTitle);
            pnlUsers.Dock = DockStyle.Fill;
            pnlUsers.Location = new Point(0, 0);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Padding = new Padding(20);
            pnlUsers.Size = new Size(718, 450);
            pnlUsers.TabIndex = 1;
            pnlUsers.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 42, 86);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(btnUpdateUser);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(20, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 34);
            panel1.TabIndex = 13;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(25, 42, 86);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(209, 0);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(70, 30);
            btnAddUser.TabIndex = 9;
            btnAddUser.Text = "إضافة";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(25, 42, 86);
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(110, 3);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(70, 30);
            btnDeleteUser.TabIndex = 11;
            btnDeleteUser.Text = "حذف";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.FromArgb(25, 42, 86);
            btnUpdateUser.FlatAppearance.BorderSize = 0;
            btnUpdateUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateUser.ForeColor = Color.White;
            btnUpdateUser.Location = new Point(21, 3);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(70, 30);
            btnUpdateUser.TabIndex = 10;
            btnUpdateUser.Text = "تحديث";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // pnlGeneral
            // 
            pnlGeneral.BackColor = Color.IndianRed;
            pnlGeneral.Controls.Add(cbDateFormat);
            pnlGeneral.Controls.Add(lblDateFormat);
            pnlGeneral.Controls.Add(cbCurrency);
            pnlGeneral.Controls.Add(lblCurrency);
            pnlGeneral.Controls.Add(txtCompanyName);
            pnlGeneral.Controls.Add(lblCompanyName);
            pnlGeneral.Controls.Add(txtSystemName);
            pnlGeneral.Controls.Add(lblSystemName);
            pnlGeneral.Location = new Point(3, 7);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Padding = new Padding(20);
            pnlGeneral.Size = new Size(715, 10);
            pnlGeneral.TabIndex = 0;
            // 
            // cbDateFormat
            // 
            cbDateFormat.Font = new Font("Segoe UI", 10F);
            cbDateFormat.FormattingEnabled = true;
            cbDateFormat.Items.AddRange(new object[] { "dd/MM/yyyy", "MM/dd/yyyy", "yyyy-MM-dd", "dd MMMM yyyy" });
            cbDateFormat.Location = new Point(20, 180);
            cbDateFormat.Name = "cbDateFormat";
            cbDateFormat.Size = new Size(200, 25);
            cbDateFormat.TabIndex = 7;
            // 
            // lblDateFormat
            // 
            lblDateFormat.AutoSize = true;
            lblDateFormat.Font = new Font("Segoe UI", 10F);
            lblDateFormat.Location = new Point(226, 183);
            lblDateFormat.Name = "lblDateFormat";
            lblDateFormat.Size = new Size(88, 19);
            lblDateFormat.TabIndex = 6;
            lblDateFormat.Text = "صيغة التاريخ:";
            // 
            // cbCurrency
            // 
            cbCurrency.Font = new Font("Segoe UI", 10F);
            cbCurrency.FormattingEnabled = true;
            cbCurrency.Items.AddRange(new object[] { "دينار (JD)", "ريال سعودي (SAR)", "دولار ($)", "يورو (€)" });
            cbCurrency.Location = new Point(20, 130);
            cbCurrency.Name = "cbCurrency";
            cbCurrency.Size = new Size(200, 25);
            cbCurrency.TabIndex = 5;
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Font = new Font("Segoe UI", 10F);
            lblCurrency.Location = new Point(226, 133);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(49, 19);
            lblCurrency.TabIndex = 4;
            lblCurrency.Text = "العملة:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Segoe UI", 10F);
            txtCompanyName.Location = new Point(20, 80);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(200, 25);
            txtCompanyName.TabIndex = 3;
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI", 10F);
            lblCompanyName.Location = new Point(226, 83);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(79, 19);
            lblCompanyName.TabIndex = 2;
            lblCompanyName.Text = "اسم الشركة:";
            // 
            // txtSystemName
            // 
            txtSystemName.Font = new Font("Segoe UI", 10F);
            txtSystemName.Location = new Point(20, 30);
            txtSystemName.Name = "txtSystemName";
            txtSystemName.Size = new Size(200, 25);
            txtSystemName.TabIndex = 1;
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI", 10F);
            lblSystemName.Location = new Point(226, 33);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(78, 19);
            lblSystemName.TabIndex = 0;
            lblSystemName.Text = "اسم النظام:";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Right;
            dgvUsers.Location = new Point(342, 20);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(356, 410);
            dgvUsers.TabIndex = 12;
            dgvUsers.CellClick += dgvUsers_CellClick;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(20, 330);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(200, 25);
            txtConfirmPassword.TabIndex = 8;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F);
            lblConfirmPassword.Location = new Point(226, 333);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(110, 19);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "تأكيد كلمة المرور:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(20, 280);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(200, 25);
            txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(226, 283);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(78, 19);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "كلمة المرور:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10F);
            txtUserName.Location = new Point(20, 230);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 25);
            txtUserName.TabIndex = 4;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F);
            lblUserName.Location = new Point(226, 233);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(97, 19);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "اسم المستخدم:";
            // 
            // lnkChangePhoto
            // 
            lnkChangePhoto.AutoSize = true;
            lnkChangePhoto.Font = new Font("Segoe UI", 9F);
            lnkChangePhoto.Location = new Point(60, 140);
            lnkChangePhoto.Name = "lnkChangePhoto";
            lnkChangePhoto.Size = new Size(69, 15);
            lnkChangePhoto.TabIndex = 2;
            lnkChangePhoto.TabStop = true;
            lnkChangePhoto.Text = "تغيير الصورة";
            lnkChangePhoto.LinkClicked += lnkChangePhoto_LinkClicked;
            // 
            // picUserPhoto
            // 
            picUserPhoto.BackColor = Color.FromArgb(236, 240, 241);
            picUserPhoto.BorderStyle = BorderStyle.FixedSingle;
            picUserPhoto.Location = new Point(40, 50);
            picUserPhoto.Name = "picUserPhoto";
            picUserPhoto.Size = new Size(131, 80);
            picUserPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picUserPhoto.TabIndex = 1;
            picUserPhoto.TabStop = false;
            // 
            // lblUsersTitle
            // 
            lblUsersTitle.AutoSize = true;
            lblUsersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsersTitle.Location = new Point(20, 20);
            lblUsersTitle.Name = "lblUsersTitle";
            lblUsersTitle.Size = new Size(91, 21);
            lblUsersTitle.TabIndex = 0;
            lblUsersTitle.Text = "المستخدمون";
            // 
            // pnlContracts
            // 
            pnlContracts.Controls.Add(numInitialPaymentPercent);
            pnlContracts.Controls.Add(lblInitialPaymentPercent);
            pnlContracts.Controls.Add(chkAllowWithoutPayment);
            pnlContracts.Controls.Add(cbDefaultContractType);
            pnlContracts.Controls.Add(lblDefaultContractType);
            pnlContracts.Controls.Add(cbDefaultContractStatus);
            pnlContracts.Controls.Add(lblDefaultContractStatus);
            pnlContracts.Controls.Add(lblContractsTitle);
            pnlContracts.Dock = DockStyle.Fill;
            pnlContracts.Location = new Point(0, 0);
            pnlContracts.Name = "pnlContracts";
            pnlContracts.Padding = new Padding(20);
            pnlContracts.Size = new Size(718, 450);
            pnlContracts.TabIndex = 2;
            pnlContracts.Visible = false;
            // 
            // numInitialPaymentPercent
            // 
            numInitialPaymentPercent.Font = new Font("Segoe UI", 10F);
            numInitialPaymentPercent.Location = new Point(20, 260);
            numInitialPaymentPercent.Name = "numInitialPaymentPercent";
            numInitialPaymentPercent.Size = new Size(200, 25);
            numInitialPaymentPercent.TabIndex = 7;
            // 
            // lblInitialPaymentPercent
            // 
            lblInitialPaymentPercent.AutoSize = true;
            lblInitialPaymentPercent.Font = new Font("Segoe UI", 10F);
            lblInitialPaymentPercent.Location = new Point(226, 262);
            lblInitialPaymentPercent.Name = "lblInitialPaymentPercent";
            lblInitialPaymentPercent.Size = new Size(156, 19);
            lblInitialPaymentPercent.TabIndex = 6;
            lblInitialPaymentPercent.Text = "نسبة الدفعة المبدئية (%):";
            // 
            // chkAllowWithoutPayment
            // 
            chkAllowWithoutPayment.AutoSize = true;
            chkAllowWithoutPayment.Font = new Font("Segoe UI", 10F);
            chkAllowWithoutPayment.Location = new Point(20, 200);
            chkAllowWithoutPayment.Name = "chkAllowWithoutPayment";
            chkAllowWithoutPayment.RightToLeft = RightToLeft.Yes;
            chkAllowWithoutPayment.Size = new Size(237, 23);
            chkAllowWithoutPayment.TabIndex = 5;
            chkAllowWithoutPayment.Text = "السماح بإضافة عقد بدون دفعة أولى";
            chkAllowWithoutPayment.UseVisualStyleBackColor = true;
            // 
            // cbDefaultContractType
            // 
            cbDefaultContractType.Font = new Font("Segoe UI", 10F);
            cbDefaultContractType.FormattingEnabled = true;
            cbDefaultContractType.Location = new Point(20, 150);
            cbDefaultContractType.Name = "cbDefaultContractType";
            cbDefaultContractType.Size = new Size(200, 25);
            cbDefaultContractType.TabIndex = 4;
            // 
            // lblDefaultContractType
            // 
            lblDefaultContractType.AutoSize = true;
            lblDefaultContractType.Font = new Font("Segoe UI", 10F);
            lblDefaultContractType.Location = new Point(226, 153);
            lblDefaultContractType.Name = "lblDefaultContractType";
            lblDefaultContractType.Size = new Size(127, 19);
            lblDefaultContractType.TabIndex = 3;
            lblDefaultContractType.Text = "نوع العقد الافتراضي:";
            // 
            // cbDefaultContractStatus
            // 
            cbDefaultContractStatus.Font = new Font("Segoe UI", 10F);
            cbDefaultContractStatus.FormattingEnabled = true;
            cbDefaultContractStatus.Location = new Point(20, 100);
            cbDefaultContractStatus.Name = "cbDefaultContractStatus";
            cbDefaultContractStatus.Size = new Size(200, 25);
            cbDefaultContractStatus.TabIndex = 2;
            // 
            // lblDefaultContractStatus
            // 
            lblDefaultContractStatus.AutoSize = true;
            lblDefaultContractStatus.Font = new Font("Segoe UI", 10F);
            lblDefaultContractStatus.Location = new Point(226, 103);
            lblDefaultContractStatus.Name = "lblDefaultContractStatus";
            lblDefaultContractStatus.Size = new Size(135, 19);
            lblDefaultContractStatus.TabIndex = 1;
            lblDefaultContractStatus.Text = "حالة العقد الافتراضية:";
            // 
            // lblContractsTitle
            // 
            lblContractsTitle.AutoSize = true;
            lblContractsTitle.Location = new Point(20, 20);
            lblContractsTitle.Name = "lblContractsTitle";
            lblContractsTitle.Size = new Size(39, 15);
            lblContractsTitle.TabIndex = 0;
            lblContractsTitle.Text = "العقود";
            // 
            // pnlPayments
            // 
            pnlPayments.Controls.Add(numMaxPaymentAmount);
            pnlPayments.Controls.Add(lblMaxPaymentAmount);
            pnlPayments.Controls.Add(chkAllowDeletePayment);
            pnlPayments.Controls.Add(chkAllowEditPayment);
            pnlPayments.Controls.Add(lblPaymentsTitle);
            pnlPayments.Dock = DockStyle.Fill;
            pnlPayments.Location = new Point(0, 0);
            pnlPayments.Name = "pnlPayments";
            pnlPayments.Padding = new Padding(20);
            pnlPayments.Size = new Size(718, 450);
            pnlPayments.TabIndex = 3;
            pnlPayments.Visible = false;
            // 
            // numMaxPaymentAmount
            // 
            numMaxPaymentAmount.DecimalPlaces = 2;
            numMaxPaymentAmount.Font = new Font("Segoe UI", 10F);
            numMaxPaymentAmount.Location = new Point(20, 210);
            numMaxPaymentAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numMaxPaymentAmount.Name = "numMaxPaymentAmount";
            numMaxPaymentAmount.Size = new Size(200, 25);
            numMaxPaymentAmount.TabIndex = 4;
            // 
            // lblMaxPaymentAmount
            // 
            lblMaxPaymentAmount.AutoSize = true;
            lblMaxPaymentAmount.Font = new Font("Segoe UI", 10F);
            lblMaxPaymentAmount.Location = new Point(226, 212);
            lblMaxPaymentAmount.Name = "lblMaxPaymentAmount";
            lblMaxPaymentAmount.Size = new Size(164, 19);
            lblMaxPaymentAmount.TabIndex = 3;
            lblMaxPaymentAmount.Text = "أقصى مبلغ للدفعة الواحدة:";
            // 
            // chkAllowDeletePayment
            // 
            chkAllowDeletePayment.AutoSize = true;
            chkAllowDeletePayment.Font = new Font("Segoe UI", 10F);
            chkAllowDeletePayment.Location = new Point(20, 150);
            chkAllowDeletePayment.Name = "chkAllowDeletePayment";
            chkAllowDeletePayment.RightToLeft = RightToLeft.Yes;
            chkAllowDeletePayment.Size = new Size(222, 23);
            chkAllowDeletePayment.TabIndex = 2;
            chkAllowDeletePayment.Text = "السماح بحذف المدفوعات المدخلة";
            chkAllowDeletePayment.UseVisualStyleBackColor = true;
            // 
            // chkAllowEditPayment
            // 
            chkAllowEditPayment.AutoSize = true;
            chkAllowEditPayment.Font = new Font("Segoe UI", 10F);
            chkAllowEditPayment.Location = new Point(20, 100);
            chkAllowEditPayment.Name = "chkAllowEditPayment";
            chkAllowEditPayment.RightToLeft = RightToLeft.Yes;
            chkAllowEditPayment.Size = new Size(227, 23);
            chkAllowEditPayment.TabIndex = 1;
            chkAllowEditPayment.Text = "السماح بتعديل المدفوعات المدخلة";
            chkAllowEditPayment.UseVisualStyleBackColor = true;
            // 
            // lblPaymentsTitle
            // 
            lblPaymentsTitle.AutoSize = true;
            lblPaymentsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPaymentsTitle.Location = new Point(20, 20);
            lblPaymentsTitle.Name = "lblPaymentsTitle";
            lblPaymentsTitle.Size = new Size(80, 21);
            lblPaymentsTitle.TabIndex = 0;
            lblPaymentsTitle.Text = "المدفوعات";
            // 
            // pnlPrinting
            // 
            pnlPrinting.Controls.Add(chkPrintRTL);
            pnlPrinting.Controls.Add(chkShowUserName);
            pnlPrinting.Controls.Add(chkShowPrintDate);
            pnlPrinting.Controls.Add(txtReportTitle);
            pnlPrinting.Controls.Add(lblReportTitle);
            pnlPrinting.Controls.Add(lblPrintingTitle);
            pnlPrinting.Dock = DockStyle.Fill;
            pnlPrinting.Location = new Point(0, 0);
            pnlPrinting.Name = "pnlPrinting";
            pnlPrinting.Padding = new Padding(20);
            pnlPrinting.Size = new Size(718, 450);
            pnlPrinting.TabIndex = 4;
            pnlPrinting.Visible = false;
            // 
            // chkPrintRTL
            // 
            chkPrintRTL.AutoSize = true;
            chkPrintRTL.Font = new Font("Segoe UI", 10F);
            chkPrintRTL.Location = new Point(20, 270);
            chkPrintRTL.Name = "chkPrintRTL";
            chkPrintRTL.RightToLeft = RightToLeft.Yes;
            chkPrintRTL.Size = new Size(166, 23);
            chkPrintRTL.TabIndex = 5;
            chkPrintRTL.Text = "طباعة من اليمين لليسار";
            chkPrintRTL.UseVisualStyleBackColor = true;
            // 
            // chkShowUserName
            // 
            chkShowUserName.AutoSize = true;
            chkShowUserName.Font = new Font("Segoe UI", 10F);
            chkShowUserName.Location = new Point(20, 210);
            chkShowUserName.Name = "chkShowUserName";
            chkShowUserName.RightToLeft = RightToLeft.Yes;
            chkShowUserName.Size = new Size(219, 23);
            chkShowUserName.TabIndex = 4;
            chkShowUserName.Text = "عرض اسم المستخدم في التقارير";
            chkShowUserName.UseVisualStyleBackColor = true;
            // 
            // chkShowPrintDate
            // 
            chkShowPrintDate.AutoSize = true;
            chkShowPrintDate.Font = new Font("Segoe UI", 10F);
            chkShowPrintDate.Location = new Point(20, 150);
            chkShowPrintDate.Name = "chkShowPrintDate";
            chkShowPrintDate.RightToLeft = RightToLeft.Yes;
            chkShowPrintDate.Size = new Size(212, 23);
            chkShowPrintDate.TabIndex = 3;
            chkShowPrintDate.Text = "عرض تاريخ الطباعة في التقارير";
            chkShowPrintDate.UseVisualStyleBackColor = true;
            // 
            // txtReportTitle
            // 
            txtReportTitle.Font = new Font("Segoe UI", 10F);
            txtReportTitle.Location = new Point(20, 90);
            txtReportTitle.Name = "txtReportTitle";
            txtReportTitle.Size = new Size(200, 25);
            txtReportTitle.TabIndex = 2;
            // 
            // lblReportTitle
            // 
            lblReportTitle.AutoSize = true;
            lblReportTitle.Font = new Font("Segoe UI", 10F);
            lblReportTitle.Location = new Point(226, 93);
            lblReportTitle.Name = "lblReportTitle";
            lblReportTitle.Size = new Size(92, 19);
            lblReportTitle.TabIndex = 1;
            lblReportTitle.Text = "عنوان التقارير:";
            // 
            // lblPrintingTitle
            // 
            lblPrintingTitle.AutoSize = true;
            lblPrintingTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrintingTitle.Location = new Point(20, 20);
            lblPrintingTitle.Name = "lblPrintingTitle";
            lblPrintingTitle.Size = new Size(58, 21);
            lblPrintingTitle.TabIndex = 0;
            lblPrintingTitle.Text = "الطباعة";
            // 
            // pnlSystem
            // 
            pnlSystem.Controls.Add(chkEnableLog);
            pnlSystem.Controls.Add(btnBackupNow);
            pnlSystem.Controls.Add(txtBackupPath);
            pnlSystem.Controls.Add(lblBackupPath);
            pnlSystem.Controls.Add(lblSystemTitle);
            pnlSystem.Dock = DockStyle.Fill;
            pnlSystem.Location = new Point(0, 0);
            pnlSystem.Name = "pnlSystem";
            pnlSystem.Padding = new Padding(20);
            pnlSystem.Size = new Size(718, 450);
            pnlSystem.TabIndex = 5;
            pnlSystem.Visible = false;
            // 
            // chkEnableLog
            // 
            chkEnableLog.AutoSize = true;
            chkEnableLog.Font = new Font("Segoe UI", 10F);
            chkEnableLog.Location = new Point(20, 180);
            chkEnableLog.Name = "chkEnableLog";
            chkEnableLog.RightToLeft = RightToLeft.Yes;
            chkEnableLog.Size = new Size(151, 23);
            chkEnableLog.TabIndex = 4;
            chkEnableLog.Text = "تفعيل سجل العمليات";
            chkEnableLog.UseVisualStyleBackColor = true;
            // 
            // btnBackupNow
            // 
            btnBackupNow.BackColor = Color.FromArgb(46, 204, 113);
            btnBackupNow.FlatAppearance.BorderSize = 0;
            btnBackupNow.FlatStyle = FlatStyle.Flat;
            btnBackupNow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBackupNow.ForeColor = Color.White;
            btnBackupNow.Location = new Point(20, 130);
            btnBackupNow.Name = "btnBackupNow";
            btnBackupNow.Size = new Size(180, 35);
            btnBackupNow.TabIndex = 3;
            btnBackupNow.Text = "إنشاء نسخة احتياطية الآن";
            btnBackupNow.UseVisualStyleBackColor = false;
            // 
            // txtBackupPath
            // 
            txtBackupPath.Font = new Font("Segoe UI", 10F);
            txtBackupPath.Location = new Point(20, 80);
            txtBackupPath.Name = "txtBackupPath";
            txtBackupPath.Size = new Size(350, 25);
            txtBackupPath.TabIndex = 2;
            // 
            // lblBackupPath
            // 
            lblBackupPath.AutoSize = true;
            lblBackupPath.Font = new Font("Segoe UI", 10F);
            lblBackupPath.Location = new Point(376, 83);
            lblBackupPath.Name = "lblBackupPath";
            lblBackupPath.Size = new Size(143, 19);
            lblBackupPath.TabIndex = 1;
            lblBackupPath.Text = "مسار النسخ الاحتياطي:";
            // 
            // lblSystemTitle
            // 
            lblSystemTitle.AutoSize = true;
            lblSystemTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSystemTitle.Location = new Point(20, 20);
            lblSystemTitle.Name = "lblSystemTitle";
            lblSystemTitle.Size = new Size(50, 21);
            lblSystemTitle.TabIndex = 0;
            lblSystemTitle.Text = "النظام";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(236, 240, 241);
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Controls.Add(btnSaveSettings);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 490);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(868, 40);
            pnlFooter.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(149, 165, 166);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(20, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 30);
            btnClose.TabIndex = 1;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.BackColor = Color.FromArgb(46, 204, 113);
            btnSaveSettings.FlatAppearance.BorderSize = 0;
            btnSaveSettings.FlatStyle = FlatStyle.Flat;
            btnSaveSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveSettings.ForeColor = Color.White;
            btnSaveSettings.Location = new Point(130, 5);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(100, 30);
            btnSaveSettings.TabIndex = 0;
            btnSaveSettings.Text = "حفظ";
            btnSaveSettings.UseVisualStyleBackColor = false;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 530);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Controls.Add(pnlFooter);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmSettings";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الإعدادات";
            Load += FrmSettings_Load_2;
            pnlHeader.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlUsers.ResumeLayout(false);
            pnlUsers.PerformLayout();
            panel1.ResumeLayout(false);
            pnlGeneral.ResumeLayout(false);
            pnlGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUserPhoto).EndInit();
            pnlContracts.ResumeLayout(false);
            pnlContracts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numInitialPaymentPercent).EndInit();
            pnlPayments.ResumeLayout(false);
            pnlPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxPaymentAmount).EndInit();
            pnlPrinting.ResumeLayout(false);
            pnlPrinting.PerformLayout();
            pnlSystem.ResumeLayout(false);
            pnlSystem.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Panel pnlSidebar;
            private System.Windows.Forms.Button btnGeneral;
            private System.Windows.Forms.Panel pnlContent;
            private System.Windows.Forms.Panel pnlGeneral;
            private System.Windows.Forms.Panel pnlUsers;
            private System.Windows.Forms.Panel pnlContracts;
            private System.Windows.Forms.Panel pnlPayments;
            private System.Windows.Forms.Panel pnlPrinting;
            private System.Windows.Forms.Button btnUsers;
            private System.Windows.Forms.Button btnContracts;
            private System.Windows.Forms.Button btnPayments;
            private System.Windows.Forms.Button btnPrinting;
            private System.Windows.Forms.Panel pnlFooter;
            private System.Windows.Forms.Button btnClose;
            private System.Windows.Forms.Button btnSaveSettings;
            private System.Windows.Forms.TextBox txtSystemName;
            private System.Windows.Forms.Label lblSystemName;
            private System.Windows.Forms.ComboBox cbDateFormat;
            private System.Windows.Forms.Label lblDateFormat;
            private System.Windows.Forms.ComboBox cbCurrency;
            private System.Windows.Forms.Label lblCurrency;
            private System.Windows.Forms.TextBox txtCompanyName;
            private System.Windows.Forms.Label lblCompanyName;
            private System.Windows.Forms.PictureBox picUserPhoto;
            private System.Windows.Forms.Label lblUsersTitle;
            private System.Windows.Forms.Label lblContractsTitle;
            private System.Windows.Forms.Label lblPaymentsTitle;
            private System.Windows.Forms.Label lblPrintingTitle;
            private System.Windows.Forms.Label lblDefaultContractStatus;
            private System.Windows.Forms.ComboBox cbDefaultContractType;
            private System.Windows.Forms.Label lblDefaultContractType;
            private System.Windows.Forms.CheckBox chkAllowWithoutPayment;
            private System.Windows.Forms.NumericUpDown numInitialPaymentPercent;
            private System.Windows.Forms.Label lblInitialPaymentPercent;
            private System.Windows.Forms.CheckBox chkAllowEditPayment;
            private System.Windows.Forms.CheckBox chkAllowDeletePayment;
            private System.Windows.Forms.NumericUpDown numMaxPaymentAmount;
            private System.Windows.Forms.Label lblMaxPaymentAmount;
            private System.Windows.Forms.TextBox txtReportTitle;
            private System.Windows.Forms.Label lblReportTitle;
            private System.Windows.Forms.CheckBox chkShowPrintDate;
            private System.Windows.Forms.CheckBox chkShowUserName;
            private System.Windows.Forms.CheckBox chkPrintRTL;
            private System.Windows.Forms.ComboBox cbDefaultContractStatus;
            private System.Windows.Forms.Label lblConfirmPassword;
            private System.Windows.Forms.TextBox txtPassword;
            private System.Windows.Forms.Label lblPassword;
            private System.Windows.Forms.TextBox txtUserName;
            private System.Windows.Forms.Label lblUserName;
            private System.Windows.Forms.TextBox txtConfirmPassword;
            private System.Windows.Forms.Button btnAddUser;
            private System.Windows.Forms.Button btnDeleteUser;
            private System.Windows.Forms.Button btnUpdateUser;
            private System.Windows.Forms.LinkLabel lnkChangePhoto;
            private System.Windows.Forms.Button btnSystem;
            private System.Windows.Forms.Panel pnlSystem;
            private System.Windows.Forms.Label lblSystemTitle;
            private System.Windows.Forms.CheckBox chkEnableLog;
            private System.Windows.Forms.Button btnBackupNow;
            private System.Windows.Forms.TextBox txtBackupPath;
            private System.Windows.Forms.Label lblBackupPath;
        private DataGridView dgvUsers;
        private Panel panel1;
    }
    


}
    
