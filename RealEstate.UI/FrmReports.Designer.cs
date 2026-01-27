namespace RealEstate.UI
{

        partial class FrmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReports));
            pnlCommands = new Panel();
            btnPrint = new Button();
            btnExport = new Button();
            pnlSeparator = new Panel();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlMain = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            dgvReports = new DataGridView();
            pnlFilters = new Panel();
            btnView = new Button();
            dtTo = new DateTimePicker();
            lblTo = new Label();
            dtFrom = new DateTimePicker();
            lblFrom = new Label();
            cbReportType = new ComboBox();
            lblReportType = new Label();
            printReports = new System.Drawing.Printing.PrintDocument();
            printperViewReports = new PrintPreviewDialog();
            pnlCommands.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            pnlFilters.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCommands
            // 
            pnlCommands.BackColor = Color.FromArgb(25, 42, 86);
            pnlCommands.Controls.Add(btnPrint);
            pnlCommands.Controls.Add(btnExport);
            pnlCommands.Dock = DockStyle.Bottom;
            pnlCommands.Location = new Point(0, 445);
            pnlCommands.Name = "pnlCommands";
            pnlCommands.Padding = new Padding(20, 10, 20, 10);
            pnlCommands.Size = new Size(968, 49);
            pnlCommands.TabIndex = 4;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(25, 42, 86);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.Location = new Point(527, 13);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(232, 29);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "طباعة";
            btnPrint.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(25, 42, 86);
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(182, 13);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(251, 29);
            btnExport.TabIndex = 0;
            btnExport.Text = "تصدير";
            btnExport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.FromArgb(230, 230, 230);
            pnlSeparator.Dock = DockStyle.Bottom;
            pnlSeparator.Location = new Point(0, 444);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(968, 1);
            pnlSeparator.TabIndex = 3;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(25, 42, 86);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20);
            pnlHeader.Size = new Size(968, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(835, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📊 التقارير";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(panel1);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Controls.Add(pnlSeparator);
            pnlMain.Controls.Add(pnlCommands);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(968, 494);
            pnlMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlFilters);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 384);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvReports);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 64);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(968, 320);
            panel2.TabIndex = 3;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Dock = DockStyle.Fill;
            dgvReports.Location = new Point(10, 10);
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.Size = new Size(948, 300);
            dgvReports.TabIndex = 0;
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.FromArgb(25, 42, 86);
            pnlFilters.Controls.Add(btnView);
            pnlFilters.Controls.Add(dtTo);
            pnlFilters.Controls.Add(lblTo);
            pnlFilters.Controls.Add(dtFrom);
            pnlFilters.Controls.Add(lblFrom);
            pnlFilters.Controls.Add(cbReportType);
            pnlFilters.Controls.Add(lblReportType);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Location = new Point(0, 0);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(20, 15, 20, 15);
            pnlFilters.Size = new Size(968, 64);
            pnlFilters.TabIndex = 2;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(25, 42, 86);
            btnView.FlatAppearance.BorderSize = 0;
            btnView.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnView.ForeColor = Color.White;
            btnView.ImageAlign = ContentAlignment.MiddleLeft;
            btnView.Location = new Point(12, 8);
            btnView.Name = "btnView";
            btnView.Size = new Size(120, 35);
            btnView.TabIndex = 6;
            btnView.Text = "عرض";
            btnView.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnSearch_Click;
            // 
            // dtTo
            // 
            dtTo.CalendarFont = new Font("Segoe UI", 10F);
            dtTo.Font = new Font("Segoe UI", 10F);
            dtTo.Format = DateTimePickerFormat.Short;
            dtTo.Location = new Point(146, 11);
            dtTo.Name = "dtTo";
            dtTo.RightToLeftLayout = true;
            dtTo.Size = new Size(150, 25);
            dtTo.TabIndex = 5;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTo.ForeColor = Color.White;
            lblTo.Location = new Point(314, 15);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(35, 20);
            lblTo.TabIndex = 4;
            lblTo.Text = "إلى:";
            // 
            // dtFrom
            // 
            dtFrom.Font = new Font("Segoe UI", 10F);
            dtFrom.Format = DateTimePickerFormat.Short;
            dtFrom.Location = new Point(376, 12);
            dtFrom.Name = "dtFrom";
            dtFrom.RightToLeftLayout = true;
            dtFrom.Size = new Size(150, 25);
            dtFrom.TabIndex = 3;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFrom.ForeColor = Color.White;
            lblFrom.Location = new Point(552, 18);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(32, 20);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "من:";
            // 
            // cbReportType
            // 
            cbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReportType.FlatStyle = FlatStyle.Flat;
            cbReportType.Font = new Font("Segoe UI", 10F);
            cbReportType.FormattingEnabled = true;
            cbReportType.Location = new Point(609, 15);
            cbReportType.Name = "cbReportType";
            cbReportType.Size = new Size(150, 25);
            cbReportType.TabIndex = 1;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblReportType.ForeColor = Color.White;
            lblReportType.Location = new Point(781, 22);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(75, 20);
            lblReportType.TabIndex = 0;
            lblReportType.Text = "نوع التقرير";
            // 
            // printReports
            // 
            printReports.PrintPage += printReports_PrintPage;
            // 
            // printperViewReports
            // 
            printperViewReports.AutoScrollMargin = new Size(0, 0);
            printperViewReports.AutoScrollMinSize = new Size(0, 0);
            printperViewReports.ClientSize = new Size(400, 300);
            printperViewReports.Enabled = true;
            printperViewReports.Icon = (Icon)resources.GetObject("printperViewReports.Icon");
            printperViewReports.Name = "printperViewReports";
            printperViewReports.Visible = false;
            // 
            // FrmReports
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 494);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmReports";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "التقارير";
            Load += FrmReports_Load_1;
            pnlCommands.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ResumeLayout(false);
        }
        private Panel pnlCommands;
        private Button btnPrint;
        private Button btnExport;
        private Panel pnlSeparator;
        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlMain;
        private Panel panel1;
        private Panel pnlFilters;
        private Button btnView;
        private DateTimePicker dtTo;
        private Label lblTo;
        private DateTimePicker dtFrom;
        private Label lblFrom;
        private ComboBox cbReportType;
        private Label lblReportType;
        private Panel panel2;
        private DataGridView dgvReports;
        private System.Drawing.Printing.PrintDocument printReports;
        private PrintPreviewDialog printperViewReports;
    }

}