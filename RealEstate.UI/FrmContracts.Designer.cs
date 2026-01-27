namespace RealEstate.UI
{
   
        partial class FrmContracts
        {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.SplitContainer MainSplitContainer;
            private System.Windows.Forms.Panel DetailsHeader;
            private System.Windows.Forms.Label LblDetailsTitle;
            private System.Windows.Forms.Panel ListHeader;
            private System.Windows.Forms.Label LblListTitle;
            private System.Windows.Forms.Panel DetailsSeparator;
            private System.Windows.Forms.Panel ListSeparator;
            private System.Windows.Forms.Panel ToolbarSeparator;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContracts));
            MainSplitContainer = new SplitContainer();
            panel7 = new Panel();
            panel9 = new Panel();
            FormFieldsPanel = new Panel();
            button4 = new Button();
            button3 = new Button();
            cbProperteisAdd = new ComboBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            LblProperty = new Label();
            cbProperties = new ComboBox();
            LblClient = new Label();
            cbClients = new ComboBox();
            LblContractType = new Label();
            cbContractType = new ComboBox();
            LblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            LblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            LblValue = new Label();
            txtTotalAmount = new TextBox();
            LblStatus = new Label();
            cbStatus = new ComboBox();
            panel8 = new Panel();
            DetailsHeader = new Panel();
            LblDetailsTitle = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            dgvContracts = new DataGridView();
            panel5 = new Panel();
            ListStatus = new Panel();
            button2 = new Button();
            LblContractCount = new Label();
            panel3 = new Panel();
            ListHeader = new Panel();
            btnSearch = new Button();
            label1 = new Label();
            txtSearchClient = new TextBox();
            LblListTitle = new Label();
            panel1 = new Panel();
            ListToolbar = new Panel();
            button1 = new Button();
            BtnNewContract = new Button();
            BtnPrint = new Button();
            BtnExport = new Button();
            DetailsSeparator = new Panel();
            ListSeparator = new Panel();
            ToolbarSeparator = new Panel();
            printContracts = new System.Drawing.Printing.PrintDocument();
            printPreviewContracts = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            FormFieldsPanel.SuspendLayout();
            panel8.SuspendLayout();
            DetailsHeader.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).BeginInit();
            panel5.SuspendLayout();
            ListStatus.SuspendLayout();
            panel3.SuspendLayout();
            ListHeader.SuspendLayout();
            panel1.SuspendLayout();
            ListToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.BackColor = Color.FromArgb(245, 247, 250);
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.Location = new Point(0, 0);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.AutoScroll = true;
            MainSplitContainer.Panel1.BackColor = Color.FromArgb(25, 42, 86);
            MainSplitContainer.Panel1.BackgroundImageLayout = ImageLayout.Center;
            MainSplitContainer.Panel1.Controls.Add(panel7);
            MainSplitContainer.Panel1.Padding = new Padding(15);
            MainSplitContainer.Panel1.RightToLeft = RightToLeft.Yes;
            MainSplitContainer.Panel1.Paint += MainSplitContainer_Panel1_Paint;
            MainSplitContainer.Panel1MinSize = 400;
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.BackColor = Color.FromArgb(25, 42, 86);
            MainSplitContainer.Panel2.Controls.Add(panel2);
            MainSplitContainer.Panel2.Controls.Add(panel1);
            MainSplitContainer.Panel2.Padding = new Padding(5);
            MainSplitContainer.Panel2.RightToLeft = RightToLeft.Yes;
            MainSplitContainer.Panel2.Paint += MainSplitContainer_Panel2_Paint;
            MainSplitContainer.Size = new Size(1008, 656);
            MainSplitContainer.SplitterDistance = 400;
            MainSplitContainer.SplitterWidth = 1;
            MainSplitContainer.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(15, 15);
            panel7.Name = "panel7";
            panel7.Size = new Size(370, 626);
            panel7.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(25, 42, 86);
            panel9.Controls.Add(FormFieldsPanel);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 50);
            panel9.Name = "panel9";
            panel9.Size = new Size(370, 576);
            panel9.TabIndex = 1;
            // 
            // FormFieldsPanel
            // 
            FormFieldsPanel.BackColor = Color.FromArgb(25, 42, 86);
            FormFieldsPanel.Controls.Add(button4);
            FormFieldsPanel.Controls.Add(button3);
            FormFieldsPanel.Controls.Add(cbProperteisAdd);
            FormFieldsPanel.Controls.Add(BtnCancel);
            FormFieldsPanel.Controls.Add(BtnSave);
            FormFieldsPanel.Controls.Add(LblProperty);
            FormFieldsPanel.Controls.Add(cbProperties);
            FormFieldsPanel.Controls.Add(LblClient);
            FormFieldsPanel.Controls.Add(cbClients);
            FormFieldsPanel.Controls.Add(LblContractType);
            FormFieldsPanel.Controls.Add(cbContractType);
            FormFieldsPanel.Controls.Add(LblStartDate);
            FormFieldsPanel.Controls.Add(dtpStartDate);
            FormFieldsPanel.Controls.Add(LblEndDate);
            FormFieldsPanel.Controls.Add(dtpEndDate);
            FormFieldsPanel.Controls.Add(LblValue);
            FormFieldsPanel.Controls.Add(txtTotalAmount);
            FormFieldsPanel.Controls.Add(LblStatus);
            FormFieldsPanel.Controls.Add(cbStatus);
            FormFieldsPanel.Dock = DockStyle.Fill;
            FormFieldsPanel.Location = new Point(0, 0);
            FormFieldsPanel.Name = "FormFieldsPanel";
            FormFieldsPanel.Size = new Size(370, 576);
            FormFieldsPanel.TabIndex = 0;
            FormFieldsPanel.Paint += FormFieldsPanel_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(25, 42, 86);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(43, 405);
            button4.Name = "button4";
            button4.Size = new Size(118, 52);
            button4.TabIndex = 18;
            button4.Text = "تعديل";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnUpdate_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(25, 42, 86);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(202, 405);
            button3.Name = "button3";
            button3.Size = new Size(121, 52);
            button3.TabIndex = 17;
            button3.Text = "حذف العقد";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnDelete_Click;
            // 
            // cbProperteisAdd
            // 
            cbProperteisAdd.BackColor = Color.FromArgb(250, 252, 255);
            cbProperteisAdd.FlatStyle = FlatStyle.Flat;
            cbProperteisAdd.Font = new Font("Segoe UI", 10.5F);
            cbProperteisAdd.ForeColor = Color.FromArgb(60, 60, 80);
            cbProperteisAdd.FormattingEnabled = true;
            cbProperteisAdd.Location = new Point(0, 38);
            cbProperteisAdd.Margin = new Padding(0, 0, 0, 20);
            cbProperteisAdd.Name = "cbProperteisAdd";
            cbProperteisAdd.Size = new Size(234, 27);
            cbProperteisAdd.TabIndex = 16;
            cbProperteisAdd.SelectedIndexChanged += cbProperteisAdd_SelectedIndexChanged;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(25, 42, 86);
            BtnCancel.Cursor = Cursors.Hand;
            BtnCancel.FlatAppearance.BorderColor = Color.FromArgb(127, 140, 141);
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(127, 140, 141);
            BtnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 140, 141);
            BtnCancel.Font = new Font("Segoe UI", 11F);
            BtnCancel.ForeColor = Color.White;
            BtnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancel.Location = new Point(43, 342);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Padding = new Padding(15, 0, 15, 0);
            BtnCancel.Size = new Size(118, 45);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "إلغاء";
            BtnCancel.TextAlign = ContentAlignment.MiddleRight;
            BtnCancel.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(25, 42, 86);
            BtnSave.Cursor = Cursors.Hand;
            BtnSave.FlatAppearance.BorderColor = Color.FromArgb(39, 174, 96);
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 174, 96);
            BtnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 174, 96);
            BtnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnSave.ForeColor = Color.White;
            BtnSave.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSave.Location = new Point(202, 342);
            BtnSave.Name = "BtnSave";
            BtnSave.Padding = new Padding(15, 0, 15, 0);
            BtnSave.Size = new Size(121, 45);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "حفظ العقد";
            BtnSave.TextAlign = ContentAlignment.MiddleRight;
            BtnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // LblProperty
            // 
            LblProperty.AutoSize = true;
            LblProperty.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            LblProperty.ForeColor = Color.White;
            LblProperty.Location = new Point(251, 38);
            LblProperty.Margin = new Padding(0, 0, 0, 8);
            LblProperty.Name = "LblProperty";
            LblProperty.Size = new Size(82, 19);
            LblProperty.TabIndex = 2;
            LblProperty.Text = " نوع العقار : ";
            LblProperty.Click += LblProperty_Click;
            // 
            // cbProperties
            // 
            cbProperties.BackColor = Color.FromArgb(250, 252, 255);
            cbProperties.FlatStyle = FlatStyle.Flat;
            cbProperties.Font = new Font("Segoe UI", 10.5F);
            cbProperties.ForeColor = Color.FromArgb(60, 60, 80);
            cbProperties.FormattingEnabled = true;
            cbProperties.Location = new Point(0, 38);
            cbProperties.Margin = new Padding(0, 0, 0, 20);
            cbProperties.Name = "cbProperties";
            cbProperties.Size = new Size(234, 27);
            cbProperties.TabIndex = 3;
            cbProperties.SelectedIndexChanged += cmbProperty_SelectedIndexChanged;
            // 
            // LblClient
            // 
            LblClient.AutoSize = true;
            LblClient.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            LblClient.ForeColor = Color.White;
            LblClient.Location = new Point(247, 82);
            LblClient.Margin = new Padding(0, 0, 0, 8);
            LblClient.Name = "LblClient";
            LblClient.Size = new Size(76, 19);
            LblClient.TabIndex = 4;
            LblClient.Text = "اسم العميل";
            // 
            // cbClients
            // 
            cbClients.BackColor = Color.FromArgb(250, 252, 255);
            cbClients.FlatStyle = FlatStyle.Flat;
            cbClients.Font = new Font("Segoe UI", 10.5F);
            cbClients.ForeColor = Color.FromArgb(60, 60, 80);
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(0, 74);
            cbClients.Margin = new Padding(0, 0, 0, 20);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(234, 27);
            cbClients.TabIndex = 5;
            cbClients.SelectedIndexChanged += cboClients_SelectedIndexChanged;
            // 
            // LblContractType
            // 
            LblContractType.AutoSize = true;
            LblContractType.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            LblContractType.ForeColor = Color.White;
            LblContractType.Location = new Point(256, 129);
            LblContractType.Margin = new Padding(0, 0, 0, 8);
            LblContractType.Name = "LblContractType";
            LblContractType.Size = new Size(67, 19);
            LblContractType.TabIndex = 6;
            LblContractType.Text = "نوع العقد:";
            // 
            // cbContractType
            // 
            cbContractType.BackColor = Color.FromArgb(250, 252, 255);
            cbContractType.FlatStyle = FlatStyle.Flat;
            cbContractType.Font = new Font("Segoe UI", 10.5F);
            cbContractType.ForeColor = Color.FromArgb(60, 60, 80);
            cbContractType.FormattingEnabled = true;
            cbContractType.Items.AddRange(new object[] { "إيجار", "بيع", "شراء" });
            cbContractType.Location = new Point(43, 121);
            cbContractType.Margin = new Padding(0, 0, 0, 20);
            cbContractType.Name = "cbContractType";
            cbContractType.Size = new Size(190, 27);
            cbContractType.TabIndex = 7;
            // 
            // LblStartDate
            // 
            LblStartDate.AutoSize = true;
            LblStartDate.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            LblStartDate.ForeColor = Color.White;
            LblStartDate.Location = new Point(247, 175);
            LblStartDate.Margin = new Padding(0, 0, 0, 8);
            LblStartDate.Name = "LblStartDate";
            LblStartDate.Size = new Size(72, 19);
            LblStartDate.TabIndex = 8;
            LblStartDate.Text = "تاريخ البدء:";
            LblStartDate.Click += LblStartDate_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarFont = new Font("Segoe UI", 10.5F);
            dtpStartDate.CalendarForeColor = Color.FromArgb(60, 60, 80);
            dtpStartDate.CalendarTitleBackColor = Color.FromArgb(30, 50, 92);
            dtpStartDate.CalendarTitleForeColor = Color.White;
            dtpStartDate.Font = new Font("Segoe UI", 10.5F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(43, 168);
            dtpStartDate.Margin = new Padding(0, 0, 0, 20);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.RightToLeftLayout = true;
            dtpStartDate.Size = new Size(190, 26);
            dtpStartDate.TabIndex = 9;
            // 
            // LblEndDate
            // 
            LblEndDate.AutoSize = true;
            LblEndDate.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            LblEndDate.ForeColor = Color.White;
            LblEndDate.Location = new Point(238, 220);
            LblEndDate.Margin = new Padding(0, 0, 0, 8);
            LblEndDate.Name = "LblEndDate";
            LblEndDate.Size = new Size(85, 19);
            LblEndDate.TabIndex = 10;
            LblEndDate.Text = "تاريخ الانتهاء:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 10.5F);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(43, 214);
            dtpEndDate.Margin = new Padding(0, 0, 0, 20);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.RightToLeftLayout = true;
            dtpEndDate.Size = new Size(190, 26);
            dtpEndDate.TabIndex = 11;
            // 
            // LblValue
            // 
            LblValue.AutoSize = true;
            LblValue.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            LblValue.ForeColor = Color.White;
            LblValue.Location = new Point(271, 262);
            LblValue.Margin = new Padding(0, 0, 0, 8);
            LblValue.Name = "LblValue";
            LblValue.Size = new Size(48, 19);
            LblValue.TabIndex = 12;
            LblValue.Text = "القيمة:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = Color.FromArgb(250, 252, 255);
            txtTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAmount.Font = new Font("Segoe UI", 10.5F);
            txtTotalAmount.ForeColor = Color.FromArgb(60, 60, 80);
            txtTotalAmount.Location = new Point(43, 260);
            txtTotalAmount.Margin = new Padding(0, 0, 0, 20);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(190, 26);
            txtTotalAmount.TabIndex = 13;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            LblStatus.ForeColor = Color.White;
            LblStatus.Location = new Point(274, 300);
            LblStatus.Margin = new Padding(0, 0, 0, 8);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(45, 19);
            LblStatus.TabIndex = 14;
            LblStatus.Text = "الحالة:";
            LblStatus.Click += LblStatus_Click;
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.FromArgb(250, 252, 255);
            cbStatus.Font = new Font("Segoe UI", 10.5F);
            cbStatus.ForeColor = Color.FromArgb(60, 60, 80);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "نشط", "منتهي", "معلق", "ملغي" });
            cbStatus.Location = new Point(43, 292);
            cbStatus.Margin = new Padding(0, 0, 0, 20);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(190, 27);
            cbStatus.TabIndex = 15;
            // 
            // panel8
            // 
            panel8.Controls.Add(DetailsHeader);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(370, 50);
            panel8.TabIndex = 0;
            // 
            // DetailsHeader
            // 
            DetailsHeader.BackColor = Color.FromArgb(25, 42, 86);
            DetailsHeader.Controls.Add(LblDetailsTitle);
            DetailsHeader.Dock = DockStyle.Top;
            DetailsHeader.Location = new Point(0, 0);
            DetailsHeader.Name = "DetailsHeader";
            DetailsHeader.Padding = new Padding(20, 15, 20, 15);
            DetailsHeader.Size = new Size(370, 46);
            DetailsHeader.TabIndex = 0;
            // 
            // LblDetailsTitle
            // 
            LblDetailsTitle.AutoSize = true;
            LblDetailsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LblDetailsTitle.ForeColor = Color.White;
            LblDetailsTitle.Location = new Point(187, 13);
            LblDetailsTitle.Name = "LblDetailsTitle";
            LblDetailsTitle.Size = new Size(171, 25);
            LblDetailsTitle.TabIndex = 0;
            LblDetailsTitle.Text = "تفاصيل العقد الجديد";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(597, 580);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(597, 531);
            panel4.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgvContracts);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(597, 471);
            panel6.TabIndex = 1;
            // 
            // dgvContracts
            // 
            dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvContracts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvContracts.BackgroundColor = SystemColors.ControlLightLight;
            dgvContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContracts.Dock = DockStyle.Fill;
            dgvContracts.Location = new Point(0, 0);
            dgvContracts.Name = "dgvContracts";
            dgvContracts.Size = new Size(597, 471);
            dgvContracts.TabIndex = 1;
            dgvContracts.CellClick += dgvContracts_CellClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(ListStatus);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 471);
            panel5.Name = "panel5";
            panel5.Size = new Size(597, 60);
            panel5.TabIndex = 0;
            // 
            // ListStatus
            // 
            ListStatus.BackColor = Color.FromArgb(25, 42, 86);
            ListStatus.Controls.Add(button2);
            ListStatus.Controls.Add(LblContractCount);
            ListStatus.Dock = DockStyle.Bottom;
            ListStatus.Location = new Point(0, 2);
            ListStatus.Name = "ListStatus";
            ListStatus.Padding = new Padding(20, 10, 20, 10);
            ListStatus.Size = new Size(597, 58);
            ListStatus.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(25, 42, 86);
            button2.Dock = DockStyle.Right;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(475, 10);
            button2.Name = "button2";
            button2.Size = new Size(102, 38);
            button2.TabIndex = 1;
            button2.Text = "عرض الكل";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LblContractCount
            // 
            LblContractCount.AutoSize = true;
            LblContractCount.BackColor = Color.FromArgb(0, 0, 1, 74);
            LblContractCount.Font = new Font("Segoe UI", 10.5F);
            LblContractCount.ForeColor = Color.White;
            LblContractCount.Location = new Point(20, 15);
            LblContractCount.Name = "LblContractCount";
            LblContractCount.Size = new Size(114, 19);
            LblContractCount.TabIndex = 0;
            LblContractCount.Text = "عدد العقود: 0 عقد";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(ListHeader);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(597, 49);
            panel3.TabIndex = 0;
            // 
            // ListHeader
            // 
            ListHeader.BackColor = Color.FromArgb(30, 50, 92);
            ListHeader.Controls.Add(btnSearch);
            ListHeader.Controls.Add(label1);
            ListHeader.Controls.Add(txtSearchClient);
            ListHeader.Controls.Add(LblListTitle);
            ListHeader.Dock = DockStyle.Top;
            ListHeader.Location = new Point(0, 0);
            ListHeader.Name = "ListHeader";
            ListHeader.Padding = new Padding(20, 15, 20, 15);
            ListHeader.Size = new Size(597, 49);
            ListHeader.TabIndex = 0;
            ListHeader.Paint += ListHeader_Paint;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(23, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 30);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(311, 11);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 2;
            label1.Text = "بحث";
            label1.Click += label1_Click;
            // 
            // txtSearchClient
            // 
            txtSearchClient.Location = new Point(144, 8);
            txtSearchClient.Name = "txtSearchClient";
            txtSearchClient.Size = new Size(142, 29);
            txtSearchClient.TabIndex = 1;
            txtSearchClient.TextChanged += txtSearchClient_TextChanged;
            txtSearchClient.Enter += txtSearchClient_Enter;
            txtSearchClient.Leave += txtSearchClient_Leave;
            // 
            // LblListTitle
            // 
            LblListTitle.AutoSize = true;
            LblListTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblListTitle.ForeColor = Color.White;
            LblListTitle.Location = new Point(378, 11);
            LblListTitle.Name = "LblListTitle";
            LblListTitle.Size = new Size(147, 21);
            LblListTitle.TabIndex = 0;
            LblListTitle.Text = "قائمة العقود المسجلة";
            // 
            // panel1
            // 
            panel1.Controls.Add(ListToolbar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 66);
            panel1.TabIndex = 0;
            // 
            // ListToolbar
            // 
            ListToolbar.BackColor = Color.FromArgb(25, 42, 86);
            ListToolbar.Controls.Add(button1);
            ListToolbar.Controls.Add(BtnNewContract);
            ListToolbar.Controls.Add(BtnPrint);
            ListToolbar.Controls.Add(BtnExport);
            ListToolbar.Dock = DockStyle.Top;
            ListToolbar.Location = new Point(0, 0);
            ListToolbar.Name = "ListToolbar";
            ListToolbar.Padding = new Padding(20, 15, 20, 15);
            ListToolbar.Size = new Size(597, 60);
            ListToolbar.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 42, 86);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(416, 19);
            button1.Name = "button1";
            button1.Size = new Size(109, 39);
            button1.TabIndex = 3;
            button1.Text = "تفريغ الحقول";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BtnNewContract
            // 
            BtnNewContract.BackColor = Color.FromArgb(25, 42, 86);
            BtnNewContract.Cursor = Cursors.Hand;
            BtnNewContract.FlatAppearance.BorderSize = 0;
            BtnNewContract.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnNewContract.ForeColor = Color.White;
            BtnNewContract.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNewContract.Location = new Point(20, 19);
            BtnNewContract.Name = "BtnNewContract";
            BtnNewContract.Padding = new Padding(15, 0, 15, 0);
            BtnNewContract.Size = new Size(114, 37);
            BtnNewContract.TabIndex = 0;
            BtnNewContract.Text = "عقد جديد";
            BtnNewContract.TextAlign = ContentAlignment.MiddleRight;
            BtnNewContract.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnNewContract.UseVisualStyleBackColor = false;
            BtnNewContract.Click += BtnNewContract_Click;
            // 
            // BtnPrint
            // 
            BtnPrint.BackColor = Color.FromArgb(25, 42, 86);
            BtnPrint.Cursor = Cursors.Hand;
            BtnPrint.FlatAppearance.BorderSize = 0;
            BtnPrint.Font = new Font("Segoe UI", 11F);
            BtnPrint.ForeColor = Color.White;
            BtnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPrint.Location = new Point(162, 19);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Padding = new Padding(15, 0, 15, 0);
            BtnPrint.Size = new Size(97, 36);
            BtnPrint.TabIndex = 1;
            BtnPrint.Text = "طباعة";
            BtnPrint.TextAlign = ContentAlignment.MiddleRight;
            BtnPrint.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnPrint.UseVisualStyleBackColor = false;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // BtnExport
            // 
            BtnExport.BackColor = Color.FromArgb(25, 42, 86);
            BtnExport.Cursor = Cursors.Hand;
            BtnExport.FlatAppearance.BorderSize = 0;
            BtnExport.Font = new Font("Segoe UI", 11F);
            BtnExport.ForeColor = Color.White;
            BtnExport.ImageAlign = ContentAlignment.MiddleLeft;
            BtnExport.Location = new Point(288, 19);
            BtnExport.Name = "BtnExport";
            BtnExport.Padding = new Padding(15, 0, 15, 0);
            BtnExport.Size = new Size(93, 36);
            BtnExport.TabIndex = 2;
            BtnExport.Text = "تصدير";
            BtnExport.TextAlign = ContentAlignment.MiddleRight;
            BtnExport.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnExport.UseVisualStyleBackColor = false;
            BtnExport.Click += BtnExport_Click;
            // 
            // DetailsSeparator
            // 
            DetailsSeparator.BackColor = Color.FromArgb(230, 235, 245);
            DetailsSeparator.Dock = DockStyle.Top;
            DetailsSeparator.Location = new Point(0, 70);
            DetailsSeparator.Name = "DetailsSeparator";
            DetailsSeparator.Size = new Size(370, 2);
            DetailsSeparator.TabIndex = 1;
            // 
            // ListSeparator
            // 
            ListSeparator.BackColor = Color.FromArgb(230, 235, 245);
            ListSeparator.Dock = DockStyle.Top;
            ListSeparator.Location = new Point(0, 70);
            ListSeparator.Name = "ListSeparator";
            ListSeparator.Size = new Size(577, 2);
            ListSeparator.TabIndex = 1;
            // 
            // ToolbarSeparator
            // 
            ToolbarSeparator.BackColor = Color.FromArgb(230, 235, 245);
            ToolbarSeparator.Dock = DockStyle.Top;
            ToolbarSeparator.Location = new Point(0, 140);
            ToolbarSeparator.Name = "ToolbarSeparator";
            ToolbarSeparator.Size = new Size(577, 2);
            ToolbarSeparator.TabIndex = 3;
            // 
            // printContracts
            // 
            printContracts.PrintPage += printContracts_PrintPage;
            // 
            // printPreviewContracts
            // 
            printPreviewContracts.AutoScrollMargin = new Size(0, 0);
            printPreviewContracts.AutoScrollMinSize = new Size(0, 0);
            printPreviewContracts.ClientSize = new Size(400, 300);
            printPreviewContracts.Enabled = true;
            printPreviewContracts.Icon = (Icon)resources.GetObject("printPreviewContracts.Icon");
            printPreviewContracts.Name = "printPreviewDialog1";
            printPreviewContracts.Visible = false;
            // 
            // FrmContracts
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 656);
            Controls.Add(MainSplitContainer);
            Font = new Font("Segoe UI", 12F);
            Name = "FrmContracts";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "إدارة العقود";
            Load += FrmContracts_Load;
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            FormFieldsPanel.ResumeLayout(false);
            FormFieldsPanel.PerformLayout();
            panel8.ResumeLayout(false);
            DetailsHeader.ResumeLayout(false);
            DetailsHeader.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContracts).EndInit();
            panel5.ResumeLayout(false);
            ListStatus.ResumeLayout(false);
            ListStatus.PerformLayout();
            panel3.ResumeLayout(false);
            ListHeader.ResumeLayout(false);
            ListHeader.PerformLayout();
            panel1.ResumeLayout(false);
            ListToolbar.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Label label1;
        private TextBox txtSearchClient;
        private Button btnSearch;
        private Panel ListToolbar;
        private Button button1;
        private Button BtnNewContract;
        private Button BtnPrint;
        private Button BtnExport;
        private Panel ListStatus;
        private Button button2;
        private Label LblContractCount;
        private DataGridView dgvContracts;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Panel FormFieldsPanel;
        private ComboBox cbProperteisAdd;
        private Button BtnCancel;
        private Button BtnSave;
        private Label LblProperty;
        private ComboBox cbProperties;
        private Label LblClient;
        private ComboBox cbClients;
        private Label LblContractType;
        private ComboBox cbContractType;
        private Label LblStartDate;
        private DateTimePicker dtpStartDate;
        private Label LblEndDate;
        private DateTimePicker dtpEndDate;
        private Label LblValue;
        private TextBox txtTotalAmount;
        private Label LblStatus;
        private ComboBox cbStatus;
        private Panel panel7;
        private Panel panel9;
        private Panel panel8;
        private Button button4;
        private Button button3;
        private System.Drawing.Printing.PrintDocument printContracts;
        private PrintPreviewDialog printPreviewContracts;
    }
    
}