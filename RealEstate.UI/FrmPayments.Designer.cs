namespace RealEstate.UI
{
   
        partial class FrmPayments
        {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.SplitContainer MainSplitContainer;
            private System.Windows.Forms.Panel PaymentDetailsPanel;
            private System.Windows.Forms.Panel PaymentHeader;
            private System.Windows.Forms.Label LblPaymentTitle;
            private System.Windows.Forms.Panel PaymentContent;
            private System.Windows.Forms.Panel PaymentFieldsPanel;
            private System.Windows.Forms.Label LblContract;
            private System.Windows.Forms.Label LblReceiptNumber;
            private System.Windows.Forms.TextBox txtPaymentAmount;
            private System.Windows.Forms.Label LblPaymentDate;
            private System.Windows.Forms.DateTimePicker dtpPaymentDate;
            private System.Windows.Forms.Label LblPaymentMethod;
            private System.Windows.Forms.Label LblNotes;
            private System.Windows.Forms.TextBox TxtNotes;
            private System.Windows.Forms.Button btnAddPayment;
            private System.Windows.Forms.Button btnCancelPayment;
            private System.Windows.Forms.Label LblPaymentsTitle;
            private System.Windows.Forms.Panel ListToolbar;
            private System.Windows.Forms.Button BtnNewPayment;
            private System.Windows.Forms.Button btnPrintPaymentsbtnPrintPayments;
            private System.Windows.Forms.Button btnPrint;
            private System.Windows.Forms.DataGridView dgvContracts;
            private System.Windows.Forms.Panel HeaderSeparator;
            private System.Windows.Forms.Panel FieldsSeparator;
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayments));
            MainSplitContainer = new SplitContainer();
            PaymentDetailsPanel = new Panel();
            PaymentHeader = new Panel();
            LblPaymentTitle = new Label();
            PaymentContent = new Panel();
            PaymentFieldsPanel = new Panel();
            btnDeletePaymentbtnDeletePayment = new Button();
            panel4 = new Panel();
            panel8 = new Panel();
            btnPrintPaymentsbtnPrintPayments = new Button();
            btnPrint = new Button();
            BtnNewPayment = new Button();
            btnCancelPayment = new Button();
            btnAddPayment = new Button();
            comboBox1 = new ComboBox();
            LblReceiptNumber = new Label();
            txtPaymentAmount = new TextBox();
            LblPaymentDate = new Label();
            dtpPaymentDate = new DateTimePicker();
            LblPaymentMethod = new Label();
            LblNotes = new Label();
            TxtNotes = new TextBox();
            FieldsSeparator = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel9 = new Panel();
            dgvContracts = new DataGridView();
            panel7 = new Panel();
            cbContractStatus = new ComboBox();
            txtRemainingAmount = new TextBox();
            txtPaidAmount = new TextBox();
            txtTotalAmount = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbContracts = new ComboBox();
            cbProperties = new ComboBox();
            label1 = new Label();
            cbClients = new ComboBox();
            LblContract = new Label();
            panel2 = new Panel();
            ListToolbar = new Panel();
            button1 = new Button();
            label7 = new Label();
            txtSerchClintes = new TextBox();
            LblPaymentsTitle = new Label();
            HeaderSeparator = new Panel();
            ToolbarSeparator = new Panel();
            cmsContracts = new ContextMenuStrip(components);
            miViewPayments = new ToolStripMenuItem();
            printContracts = new System.Drawing.Printing.PrintDocument();
            printPreviewContracts = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            PaymentDetailsPanel.SuspendLayout();
            PaymentHeader.SuspendLayout();
            PaymentContent.SuspendLayout();
            PaymentFieldsPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).BeginInit();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            ListToolbar.SuspendLayout();
            cmsContracts.SuspendLayout();
            SuspendLayout();
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.BackColor = Color.FromArgb(250, 252, 255);
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.Location = new Point(0, 0);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.BackColor = Color.FromArgb(25, 42, 86);
            MainSplitContainer.Panel1.Controls.Add(PaymentDetailsPanel);
            MainSplitContainer.Panel1.Padding = new Padding(15);
            MainSplitContainer.Panel1.RightToLeft = RightToLeft.Yes;
            MainSplitContainer.Panel1.Paint += MainSplitContainer_Panel1_Paint;
            MainSplitContainer.Panel1MinSize = 400;
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.BackColor = Color.Cornsilk;
            MainSplitContainer.Panel2.Controls.Add(panel1);
            MainSplitContainer.Panel2.Padding = new Padding(7);
            MainSplitContainer.Panel2.RightToLeft = RightToLeft.Yes;
            MainSplitContainer.Panel2.Paint += MainSplitContainer_Panel2_Paint;
            MainSplitContainer.Size = new Size(1008, 670);
            MainSplitContainer.SplitterDistance = 400;
            MainSplitContainer.SplitterWidth = 1;
            MainSplitContainer.TabIndex = 0;
            // 
            // PaymentDetailsPanel
            // 
            PaymentDetailsPanel.BackColor = Color.White;
            PaymentDetailsPanel.Controls.Add(PaymentHeader);
            PaymentDetailsPanel.Controls.Add(PaymentContent);
            PaymentDetailsPanel.Dock = DockStyle.Fill;
            PaymentDetailsPanel.Location = new Point(15, 15);
            PaymentDetailsPanel.Name = "PaymentDetailsPanel";
            PaymentDetailsPanel.Size = new Size(370, 640);
            PaymentDetailsPanel.TabIndex = 0;
            // 
            // PaymentHeader
            // 
            PaymentHeader.BackColor = Color.FromArgb(25, 42, 86);
            PaymentHeader.Controls.Add(LblPaymentTitle);
            PaymentHeader.Dock = DockStyle.Top;
            PaymentHeader.Location = new Point(0, 0);
            PaymentHeader.Name = "PaymentHeader";
            PaymentHeader.Padding = new Padding(20, 15, 20, 15);
            PaymentHeader.Size = new Size(370, 40);
            PaymentHeader.TabIndex = 0;
            // 
            // LblPaymentTitle
            // 
            LblPaymentTitle.AutoSize = true;
            LblPaymentTitle.Dock = DockStyle.Right;
            LblPaymentTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LblPaymentTitle.ForeColor = Color.White;
            LblPaymentTitle.Location = new Point(134, 15);
            LblPaymentTitle.Name = "LblPaymentTitle";
            LblPaymentTitle.Size = new Size(216, 32);
            LblPaymentTitle.TabIndex = 0;
            LblPaymentTitle.Text = "سجل مدفوعات جديد";
            // 
            // PaymentContent
            // 
            PaymentContent.BackColor = Color.White;
            PaymentContent.Controls.Add(PaymentFieldsPanel);
            PaymentContent.Controls.Add(FieldsSeparator);
            PaymentContent.Dock = DockStyle.Fill;
            PaymentContent.Location = new Point(0, 0);
            PaymentContent.Name = "PaymentContent";
            PaymentContent.Padding = new Padding(10);
            PaymentContent.Size = new Size(370, 640);
            PaymentContent.TabIndex = 2;
            // 
            // PaymentFieldsPanel
            // 
            PaymentFieldsPanel.BackColor = Color.FromArgb(25, 42, 86);
            PaymentFieldsPanel.Controls.Add(btnDeletePaymentbtnDeletePayment);
            PaymentFieldsPanel.Controls.Add(panel4);
            PaymentFieldsPanel.Controls.Add(btnCancelPayment);
            PaymentFieldsPanel.Controls.Add(btnAddPayment);
            PaymentFieldsPanel.Controls.Add(comboBox1);
            PaymentFieldsPanel.Controls.Add(LblReceiptNumber);
            PaymentFieldsPanel.Controls.Add(txtPaymentAmount);
            PaymentFieldsPanel.Controls.Add(LblPaymentDate);
            PaymentFieldsPanel.Controls.Add(dtpPaymentDate);
            PaymentFieldsPanel.Controls.Add(LblPaymentMethod);
            PaymentFieldsPanel.Controls.Add(LblNotes);
            PaymentFieldsPanel.Controls.Add(TxtNotes);
            PaymentFieldsPanel.Dock = DockStyle.Fill;
            PaymentFieldsPanel.ForeColor = SystemColors.ControlLightLight;
            PaymentFieldsPanel.Location = new Point(10, 10);
            PaymentFieldsPanel.Name = "PaymentFieldsPanel";
            PaymentFieldsPanel.Size = new Size(350, 618);
            PaymentFieldsPanel.TabIndex = 0;
            // 
            // btnDeletePaymentbtnDeletePayment
            // 
            btnDeletePaymentbtnDeletePayment.BackColor = Color.FromArgb(25, 42, 86);
            btnDeletePaymentbtnDeletePayment.Cursor = Cursors.Hand;
            btnDeletePaymentbtnDeletePayment.FlatAppearance.BorderSize = 0;
            btnDeletePaymentbtnDeletePayment.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeletePaymentbtnDeletePayment.ForeColor = Color.White;
            btnDeletePaymentbtnDeletePayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeletePaymentbtnDeletePayment.Location = new Point(118, 392);
            btnDeletePaymentbtnDeletePayment.Name = "btnDeletePaymentbtnDeletePayment";
            btnDeletePaymentbtnDeletePayment.Padding = new Padding(15, 0, 15, 0);
            btnDeletePaymentbtnDeletePayment.Size = new Size(101, 32);
            btnDeletePaymentbtnDeletePayment.TabIndex = 15;
            btnDeletePaymentbtnDeletePayment.Text = "تحديث";
            btnDeletePaymentbtnDeletePayment.TextAlign = ContentAlignment.MiddleRight;
            btnDeletePaymentbtnDeletePayment.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDeletePaymentbtnDeletePayment.UseVisualStyleBackColor = false;
            btnDeletePaymentbtnDeletePayment.Click += btnDeletePaymentbtnDeletePayment_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel8);
            panel4.Location = new Point(3, 43);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(3);
            panel4.Size = new Size(347, 50);
            panel4.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(25, 42, 86);
            panel8.Controls.Add(btnPrintPaymentsbtnPrintPayments);
            panel8.Controls.Add(btnPrint);
            panel8.Controls.Add(BtnNewPayment);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(341, 44);
            panel8.TabIndex = 0;
            // 
            // btnPrintPaymentsbtnPrintPayments
            // 
            btnPrintPaymentsbtnPrintPayments.BackColor = Color.FromArgb(25, 42, 86);
            btnPrintPaymentsbtnPrintPayments.Cursor = Cursors.Hand;
            btnPrintPaymentsbtnPrintPayments.Dock = DockStyle.Fill;
            btnPrintPaymentsbtnPrintPayments.FlatAppearance.BorderSize = 0;
            btnPrintPaymentsbtnPrintPayments.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            btnPrintPaymentsbtnPrintPayments.ForeColor = Color.White;
            btnPrintPaymentsbtnPrintPayments.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrintPaymentsbtnPrintPayments.Location = new Point(87, 0);
            btnPrintPaymentsbtnPrintPayments.Name = "btnPrintPaymentsbtnPrintPayments";
            btnPrintPaymentsbtnPrintPayments.Padding = new Padding(15, 0, 15, 0);
            btnPrintPaymentsbtnPrintPayments.Size = new Size(168, 44);
            btnPrintPaymentsbtnPrintPayments.TabIndex = 1;
            btnPrintPaymentsbtnPrintPayments.Text = "طباعة إيصال";
            btnPrintPaymentsbtnPrintPayments.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrintPaymentsbtnPrintPayments.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(25, 42, 86);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Dock = DockStyle.Left;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.Location = new Point(0, 0);
            btnPrint.Name = "btnPrint";
            btnPrint.Padding = new Padding(15, 0, 15, 0);
            btnPrint.Size = new Size(87, 44);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "تصدير";
            btnPrint.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnExportPayments_Click;
            // 
            // BtnNewPayment
            // 
            BtnNewPayment.BackColor = Color.FromArgb(25, 42, 86);
            BtnNewPayment.Cursor = Cursors.Hand;
            BtnNewPayment.Dock = DockStyle.Right;
            BtnNewPayment.FlatAppearance.BorderSize = 0;
            BtnNewPayment.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            BtnNewPayment.ForeColor = Color.White;
            BtnNewPayment.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNewPayment.Location = new Point(255, 0);
            BtnNewPayment.Name = "BtnNewPayment";
            BtnNewPayment.Padding = new Padding(15, 0, 15, 0);
            BtnNewPayment.Size = new Size(86, 44);
            BtnNewPayment.TabIndex = 0;
            BtnNewPayment.Text = "دفعة جديدة";
            BtnNewPayment.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnNewPayment.UseVisualStyleBackColor = false;
            BtnNewPayment.Click += BtnNewPayment_Click;
            // 
            // btnCancelPayment
            // 
            btnCancelPayment.BackColor = Color.FromArgb(25, 42, 86);
            btnCancelPayment.Cursor = Cursors.Hand;
            btnCancelPayment.FlatAppearance.BorderSize = 0;
            btnCancelPayment.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelPayment.ForeColor = Color.White;
            btnCancelPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelPayment.Location = new Point(22, 392);
            btnCancelPayment.Name = "btnCancelPayment";
            btnCancelPayment.Padding = new Padding(15, 0, 15, 0);
            btnCancelPayment.Size = new Size(80, 32);
            btnCancelPayment.TabIndex = 1;
            btnCancelPayment.Text = "إلغاء";
            btnCancelPayment.TextAlign = ContentAlignment.MiddleRight;
            btnCancelPayment.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelPayment.UseVisualStyleBackColor = false;
            // 
            // btnAddPayment
            // 
            btnAddPayment.BackColor = Color.FromArgb(25, 42, 86);
            btnAddPayment.Cursor = Cursors.Hand;
            btnAddPayment.Enabled = false;
            btnAddPayment.FlatAppearance.BorderSize = 0;
            btnAddPayment.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddPayment.ForeColor = Color.White;
            btnAddPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddPayment.Location = new Point(225, 392);
            btnAddPayment.Name = "btnAddPayment";
            btnAddPayment.Padding = new Padding(15, 0, 15, 0);
            btnAddPayment.Size = new Size(115, 32);
            btnAddPayment.TabIndex = 0;
            btnAddPayment.Text = "حفظ الدفع";
            btnAddPayment.TextAlign = ContentAlignment.MiddleRight;
            btnAddPayment.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddPayment.UseVisualStyleBackColor = false;
            btnAddPayment.Click += btnAddPayment_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "تحويل", "نقدا", "شيك" });
            comboBox1.Location = new Point(31, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 36);
            comboBox1.TabIndex = 14;
            // 
            // LblReceiptNumber
            // 
            LblReceiptNumber.AutoSize = true;
            LblReceiptNumber.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            LblReceiptNumber.ForeColor = Color.White;
            LblReceiptNumber.Location = new Point(232, 120);
            LblReceiptNumber.Margin = new Padding(0, 0, 0, 8);
            LblReceiptNumber.Name = "LblReceiptNumber";
            LblReceiptNumber.Size = new Size(95, 25);
            LblReceiptNumber.TabIndex = 2;
            LblReceiptNumber.Text = "مبلغ الدفع:";
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.BackColor = Color.FromArgb(250, 255, 252);
            txtPaymentAmount.BorderStyle = BorderStyle.FixedSingle;
            txtPaymentAmount.Font = new Font("Segoe UI", 10.5F);
            txtPaymentAmount.ForeColor = Color.FromArgb(60, 80, 70);
            txtPaymentAmount.Location = new Point(31, 118);
            txtPaymentAmount.Margin = new Padding(0, 0, 0, 20);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(190, 31);
            txtPaymentAmount.TabIndex = 3;
            // 
            // LblPaymentDate
            // 
            LblPaymentDate.AutoSize = true;
            LblPaymentDate.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            LblPaymentDate.ForeColor = Color.White;
            LblPaymentDate.Location = new Point(232, 171);
            LblPaymentDate.Margin = new Padding(0, 0, 0, 8);
            LblPaymentDate.Name = "LblPaymentDate";
            LblPaymentDate.Size = new Size(99, 25);
            LblPaymentDate.TabIndex = 6;
            LblPaymentDate.Text = "تاريخ الدفع:";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.CalendarFont = new Font("Segoe UI", 10.5F);
            dtpPaymentDate.CalendarForeColor = Color.FromArgb(60, 80, 70);
            dtpPaymentDate.CalendarTitleBackColor = Color.FromArgb(46, 204, 113);
            dtpPaymentDate.CalendarTitleForeColor = Color.White;
            dtpPaymentDate.Font = new Font("Segoe UI", 10.5F);
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(31, 164);
            dtpPaymentDate.Margin = new Padding(0, 0, 0, 20);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.RightToLeftLayout = true;
            dtpPaymentDate.Size = new Size(190, 31);
            dtpPaymentDate.TabIndex = 7;
            // 
            // LblPaymentMethod
            // 
            LblPaymentMethod.AutoSize = true;
            LblPaymentMethod.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            LblPaymentMethod.ForeColor = Color.White;
            LblPaymentMethod.Location = new Point(232, 222);
            LblPaymentMethod.Margin = new Padding(0, 0, 0, 8);
            LblPaymentMethod.Name = "LblPaymentMethod";
            LblPaymentMethod.Size = new Size(110, 25);
            LblPaymentMethod.TabIndex = 8;
            LblPaymentMethod.Text = "طريقة الدفع:";
            // 
            // LblNotes
            // 
            LblNotes.AutoSize = true;
            LblNotes.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            LblNotes.ForeColor = Color.White;
            LblNotes.Location = new Point(251, 313);
            LblNotes.Margin = new Padding(0, 0, 0, 8);
            LblNotes.Name = "LblNotes";
            LblNotes.Size = new Size(86, 25);
            LblNotes.TabIndex = 12;
            LblNotes.Text = "ملاحظات:";
            // 
            // TxtNotes
            // 
            TxtNotes.BackColor = Color.FromArgb(250, 255, 252);
            TxtNotes.BorderStyle = BorderStyle.FixedSingle;
            TxtNotes.Font = new Font("Segoe UI", 10.5F);
            TxtNotes.ForeColor = Color.FromArgb(60, 80, 70);
            TxtNotes.Location = new Point(31, 268);
            TxtNotes.Margin = new Padding(0, 0, 0, 20);
            TxtNotes.Multiline = true;
            TxtNotes.Name = "TxtNotes";
            TxtNotes.ScrollBars = ScrollBars.Vertical;
            TxtNotes.Size = new Size(190, 83);
            TxtNotes.TabIndex = 13;
            // 
            // FieldsSeparator
            // 
            FieldsSeparator.BackColor = Color.FromArgb(220, 240, 230);
            FieldsSeparator.Dock = DockStyle.Bottom;
            FieldsSeparator.Location = new Point(10, 628);
            FieldsSeparator.Name = "FieldsSeparator";
            FieldsSeparator.Size = new Size(350, 2);
            FieldsSeparator.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(7, 7);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(593, 656);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 42, 86);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(4, 42);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(585, 610);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(5, 5);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(575, 600);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.BackColor = Color.FromArgb(25, 42, 86);
            panel6.Controls.Add(panel9);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(5, 191);
            panel6.Margin = new Padding(10);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10);
            panel6.Size = new Size(565, 404);
            panel6.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(dgvContracts);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(10, 10);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(5);
            panel9.Size = new Size(545, 384);
            panel9.TabIndex = 0;
            // 
            // dgvContracts
            // 
            dgvContracts.AllowUserToAddRows = false;
            dgvContracts.AllowUserToDeleteRows = false;
            dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvContracts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvContracts.BackgroundColor = Color.White;
            dgvContracts.BorderStyle = BorderStyle.None;
            dgvContracts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvContracts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 255, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(60, 80, 70);
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 255, 250);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(60, 80, 70);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvContracts.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(80, 100, 90);
            dataGridViewCellStyle2.Padding = new Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 255, 245);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(60, 80, 70);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvContracts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvContracts.Dock = DockStyle.Fill;
            dgvContracts.EnableHeadersVisualStyles = false;
            dgvContracts.GridColor = Color.Black;
            dgvContracts.Location = new Point(5, 5);
            dgvContracts.Name = "dgvContracts";
            dgvContracts.ReadOnly = true;
            dgvContracts.RightToLeft = RightToLeft.Yes;
            dgvContracts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(8);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(240, 255, 245);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvContracts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvContracts.RowHeadersVisible = false;
            dgvContracts.RowHeadersWidth = 51;
            dgvContracts.RowTemplate.DefaultCellStyle.Padding = new Padding(8);
            dgvContracts.RowTemplate.Height = 45;
            dgvContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContracts.Size = new Size(535, 374);
            dgvContracts.TabIndex = 0;
            dgvContracts.CellClick += dgvContracts_CellClick;
            dgvContracts.CellContentClick += PaymentsGrid_CellContentClick;
            dgvContracts.CellMouseDown += dgvContracts_CellMouseDown;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(25, 42, 86);
            panel7.Controls.Add(cbContractStatus);
            panel7.Controls.Add(txtRemainingAmount);
            panel7.Controls.Add(txtPaidAmount);
            panel7.Controls.Add(txtTotalAmount);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(cbContracts);
            panel7.Controls.Add(cbProperties);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(cbClients);
            panel7.Controls.Add(LblContract);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(5, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(565, 186);
            panel7.TabIndex = 1;
            panel7.Paint += panel7_Paint;
            // 
            // cbContractStatus
            // 
            cbContractStatus.BackColor = Color.FromArgb(250, 255, 252);
            cbContractStatus.FlatStyle = FlatStyle.Flat;
            cbContractStatus.Font = new Font("Segoe UI", 10.5F);
            cbContractStatus.ForeColor = Color.FromArgb(60, 80, 70);
            cbContractStatus.FormattingEnabled = true;
            cbContractStatus.Location = new Point(7, 113);
            cbContractStatus.Margin = new Padding(0, 0, 0, 20);
            cbContractStatus.Name = "cbContractStatus";
            cbContractStatus.Size = new Size(134, 31);
            cbContractStatus.TabIndex = 13;
            // 
            // txtRemainingAmount
            // 
            txtRemainingAmount.Location = new Point(7, 72);
            txtRemainingAmount.Name = "txtRemainingAmount";
            txtRemainingAmount.ReadOnly = true;
            txtRemainingAmount.Size = new Size(134, 34);
            txtRemainingAmount.TabIndex = 12;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Location = new Point(316, 142);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.ReadOnly = true;
            txtPaidAmount.Size = new Size(134, 34);
            txtPaidAmount.TabIndex = 11;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(316, 99);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(134, 34);
            txtTotalAmount.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(460, 104);
            label6.Margin = new Padding(0, 0, 0, 8);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 9;
            label6.Text = "قيمة العقد";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(460, 149);
            label5.Margin = new Padding(0, 0, 0, 8);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 8;
            label5.Text = "أجمالي الدفوع";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(162, 82);
            label4.Margin = new Padding(0, 0, 0, 8);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 7;
            label4.Text = "المتبقي";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(162, 121);
            label3.Margin = new Padding(0, 0, 0, 8);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 6;
            label3.Text = "حالة العقد";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(460, 52);
            label2.Margin = new Padding(0, 0, 0, 8);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 5;
            label2.Text = "رقم/وصف العقد";
            // 
            // cbContracts
            // 
            cbContracts.BackColor = Color.FromArgb(250, 255, 252);
            cbContracts.FlatStyle = FlatStyle.Flat;
            cbContracts.Font = new Font("Segoe UI", 10.5F);
            cbContracts.ForeColor = Color.FromArgb(60, 80, 70);
            cbContracts.FormattingEnabled = true;
            cbContracts.Location = new Point(200, 49);
            cbContracts.Margin = new Padding(0, 0, 0, 20);
            cbContracts.Name = "cbContracts";
            cbContracts.Size = new Size(250, 31);
            cbContracts.TabIndex = 4;
            cbContracts.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cbProperties
            // 
            cbProperties.BackColor = Color.FromArgb(250, 255, 252);
            cbProperties.FlatStyle = FlatStyle.Flat;
            cbProperties.Font = new Font("Segoe UI", 10.5F);
            cbProperties.ForeColor = Color.FromArgb(60, 80, 70);
            cbProperties.FormattingEnabled = true;
            cbProperties.ImeMode = ImeMode.NoControl;
            cbProperties.Location = new Point(7, 9);
            cbProperties.Margin = new Padding(0, 0, 0, 20);
            cbProperties.Name = "cbProperties";
            cbProperties.Size = new Size(165, 31);
            cbProperties.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(179, 11);
            label1.Margin = new Padding(0, 0, 0, 8);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 2;
            label1.Text = "اسم العقار";
            // 
            // cbClients
            // 
            cbClients.BackColor = Color.FromArgb(250, 255, 252);
            cbClients.FlatStyle = FlatStyle.Flat;
            cbClients.Font = new Font("Segoe UI", 10.5F);
            cbClients.ForeColor = Color.FromArgb(60, 80, 70);
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(271, 11);
            cbClients.Margin = new Padding(0, 0, 0, 20);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(213, 31);
            cbClients.TabIndex = 1;
            cbClients.SelectedIndexChanged += cbClients_SelectedIndexChanged;
            // 
            // LblContract
            // 
            LblContract.AutoSize = true;
            LblContract.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            LblContract.ForeColor = Color.White;
            LblContract.Location = new Point(484, 14);
            LblContract.Margin = new Padding(0, 0, 0, 8);
            LblContract.Name = "LblContract";
            LblContract.Size = new Size(99, 25);
            LblContract.TabIndex = 0;
            LblContract.Text = "اسم العميل";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ListToolbar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 38);
            panel2.TabIndex = 0;
            // 
            // ListToolbar
            // 
            ListToolbar.BackColor = Color.FromArgb(25, 42, 86);
            ListToolbar.Controls.Add(button1);
            ListToolbar.Controls.Add(label7);
            ListToolbar.Controls.Add(txtSerchClintes);
            ListToolbar.Controls.Add(LblPaymentsTitle);
            ListToolbar.Dock = DockStyle.Top;
            ListToolbar.Location = new Point(0, 0);
            ListToolbar.Name = "ListToolbar";
            ListToolbar.Padding = new Padding(20, 15, 20, 15);
            ListToolbar.Size = new Size(585, 38);
            ListToolbar.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 42, 86);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(20, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 3;
            button1.Text = "بحث";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(291, 7);
            label7.Name = "label7";
            label7.Size = new Size(154, 28);
            label7.TabIndex = 2;
            label7.Text = "بحث/اسم العميل";
            // 
            // txtSerchClintes
            // 
            txtSerchClintes.Location = new Point(118, 3);
            txtSerchClintes.Name = "txtSerchClintes";
            txtSerchClintes.Size = new Size(167, 34);
            txtSerchClintes.TabIndex = 1;
            txtSerchClintes.TextChanged += txtSerchClintes_TextChanged;
            // 
            // LblPaymentsTitle
            // 
            LblPaymentsTitle.AutoSize = true;
            LblPaymentsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LblPaymentsTitle.ForeColor = Color.White;
            LblPaymentsTitle.Location = new Point(440, 8);
            LblPaymentsTitle.Name = "LblPaymentsTitle";
            LblPaymentsTitle.Size = new Size(177, 32);
            LblPaymentsTitle.TabIndex = 0;
            LblPaymentsTitle.Text = "سجل المدفوعات";
            // 
            // HeaderSeparator
            // 
            HeaderSeparator.BackColor = Color.FromArgb(220, 240, 230);
            HeaderSeparator.Dock = DockStyle.Top;
            HeaderSeparator.Location = new Point(0, 70);
            HeaderSeparator.Name = "HeaderSeparator";
            HeaderSeparator.Size = new Size(370, 2);
            HeaderSeparator.TabIndex = 1;
            // 
            // ToolbarSeparator
            // 
            ToolbarSeparator.BackColor = Color.FromArgb(220, 240, 230);
            ToolbarSeparator.Dock = DockStyle.Top;
            ToolbarSeparator.Location = new Point(0, 140);
            ToolbarSeparator.Name = "ToolbarSeparator";
            ToolbarSeparator.Size = new Size(577, 2);
            ToolbarSeparator.TabIndex = 3;
            // 
            // cmsContracts
            // 
            cmsContracts.ImageScalingSize = new Size(20, 20);
            cmsContracts.Items.AddRange(new ToolStripItem[] { miViewPayments });
            cmsContracts.Name = "cmsContracts";
            cmsContracts.RightToLeft = RightToLeft.Yes;
            cmsContracts.Size = new Size(202, 28);
            // 
            // miViewPayments
            // 
            miViewPayments.Name = "miViewPayments";
            miViewPayments.Size = new Size(201, 24);
            miViewPayments.Text = "عرض تفاضيل الدفع";
            miViewPayments.Click += miViewPayments_Click;
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
            printPreviewContracts.Name = "printPreviewContracts";
            printPreviewContracts.Visible = false;
            // 
            // FrmPayments
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 670);
            Controls.Add(MainSplitContainer);
            Font = new Font("Segoe UI", 12F);
            Name = "FrmPayments";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "إدارة المدفوعات";
            Load += FrmPayments_Load;
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            PaymentDetailsPanel.ResumeLayout(false);
            PaymentHeader.ResumeLayout(false);
            PaymentHeader.PerformLayout();
            PaymentContent.ResumeLayout(false);
            PaymentFieldsPanel.ResumeLayout(false);
            PaymentFieldsPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContracts).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            ListToolbar.ResumeLayout(false);
            ListToolbar.PerformLayout();
            cmsContracts.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private ComboBox comboBox1;
        private Panel panel7;
        private ComboBox cbProperties;
        private Label label1;
        private ComboBox cbContracts;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbContractStatus;
        private TextBox txtRemainingAmount;
        private TextBox txtPaidAmount;
        private TextBox txtTotalAmount;
        private Button btnDeletePaymentbtnDeletePayment;
        public ComboBox cbClients;
        private Panel panel8;
        private Panel panel6;
        private Panel panel9;
        private ContextMenuStrip cmsContracts;
        private ToolStripMenuItem miViewPayments;
        private System.Drawing.Printing.PrintDocument printContracts;
        private PrintPreviewDialog printPreviewContracts;
        private Label label7;
        private TextBox txtSerchClintes;
        private Button button1;
    }
    
}