
namespace RealEstate.UI
{

  
        partial class FrmProperties
        {
            private System.ComponentModel.IContainer components = null;

            // الأقسام الرئيسية
            private System.Windows.Forms.Panel pnlMain;
            private System.Windows.Forms.Panel pnlHeader;
            private System.Windows.Forms.Panel pnlGrid;
            private System.Windows.Forms.Panel pnlForm;

            // العنوان
            private System.Windows.Forms.Label lblTitle;

            // الجدول
            private System.Windows.Forms.DataGridView dgvProperties;

            // حقول الإدخال
            private System.Windows.Forms.Label lblPropertyType;
            private System.Windows.Forms.TextBox txtPropertyType;
            private System.Windows.Forms.Label lblLocation;
            private System.Windows.Forms.TextBox txtLocation;
            private System.Windows.Forms.Label lblPrice;
            private System.Windows.Forms.TextBox txtPrice;
            private System.Windows.Forms.Label lblStatus;
            private System.Windows.Forms.ComboBox cmbStatus;

            // الأزرار
            private System.Windows.Forms.Button btnAdd;
            private System.Windows.Forms.Button btnUpdate;
            private System.Windows.Forms.Button btnDelete;
            private System.Windows.Forms.Button btnClear;

            // الفواصل
            private System.Windows.Forms.Panel pnlSeparator;

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
            pnlMain = new Panel();
            pnlHeader = new Panel();
            lblTimeDate = new Label();
            lblTitle = new Label();
            pnlGrid = new Panel();
            dgvProperties = new DataGridView();
            colIndex = new DataGridViewTextBoxColumn();
            pnlForm = new Panel();
            label1 = new Label();
            pnlSeparator = new Panel();
            btnAdd = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtLocation = new TextBox();
            lblLocation = new Label();
            txtPropertyType = new TextBox();
            lblPropertyType = new Label();
            pnlMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            pnlForm.SuspendLayout();
            pnlSeparator.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Controls.Add(pnlGrid);
            pnlMain.Controls.Add(pnlForm);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1054, 749);
            pnlMain.TabIndex = 0;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(25, 42, 86);
            pnlHeader.Controls.Add(lblTimeDate);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20);
            pnlHeader.Size = new Size(1054, 34);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblTimeDate
            // 
            lblTimeDate.AutoSize = true;
            lblTimeDate.Font = new Font("Segoe UI", 13F);
            lblTimeDate.ForeColor = SystemColors.ButtonFace;
            lblTimeDate.Location = new Point(20, 7);
            lblTimeDate.Name = "lblTimeDate";
            lblTimeDate.Size = new Size(59, 25);
            lblTimeDate.TabIndex = 1;
            lblTimeDate.Text = "label1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(907, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(147, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "إدارة العقارات";
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGrid.BackColor = Color.FromArgb(25, 42, 86);
            pnlGrid.Controls.Add(dgvProperties);
            pnlGrid.Location = new Point(0, 35);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(20);
            pnlGrid.Size = new Size(1054, 516);
            pnlGrid.TabIndex = 1;
            pnlGrid.Paint += pnlGrid_Paint;
            // 
            // dgvProperties
            // 
            dgvProperties.AccessibleRole = AccessibleRole.ScrollBar;
            dgvProperties.AllowUserToAddRows = false;
            dgvProperties.AllowUserToDeleteRows = false;
            dgvProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProperties.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProperties.BackgroundColor = Color.White;
            dgvProperties.BorderStyle = BorderStyle.Fixed3D;
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Columns.AddRange(new DataGridViewColumn[] { colIndex });
            dgvProperties.Cursor = Cursors.HSplit;
            dgvProperties.Dock = DockStyle.Fill;
            dgvProperties.Location = new Point(20, 20);
            dgvProperties.Name = "dgvProperties";
            dgvProperties.ReadOnly = true;
            dgvProperties.RightToLeft = RightToLeft.Yes;
            dgvProperties.RowHeadersVisible = false;
            dgvProperties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProperties.Size = new Size(1014, 476);
            dgvProperties.TabIndex = 0;
            dgvProperties.CellClick += dgvProperties_CellClick;
            dgvProperties.RowPostPaint += dgvProperties_RowPostPaint;
            // 
            // colIndex
            // 
            colIndex.HeaderText = "رقم العقار";
            colIndex.Name = "colIndex";
            colIndex.ReadOnly = true;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.FromArgb(192, 192, 255);
            pnlForm.Controls.Add(label1);
            pnlForm.Controls.Add(pnlSeparator);
            pnlForm.Controls.Add(cmbStatus);
            pnlForm.Controls.Add(lblStatus);
            pnlForm.Controls.Add(txtPrice);
            pnlForm.Controls.Add(lblPrice);
            pnlForm.Controls.Add(txtLocation);
            pnlForm.Controls.Add(lblLocation);
            pnlForm.Controls.Add(txtPropertyType);
            pnlForm.Controls.Add(lblPropertyType);
            pnlForm.Dock = DockStyle.Bottom;
            pnlForm.Location = new Point(0, 557);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(20);
            pnlForm.Size = new Size(1054, 192);
            pnlForm.TabIndex = 2;
            pnlForm.Paint += pnlForm_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Sitka Banner Semibold", 12F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(116, 81);
            label1.Name = "label1";
            label1.Size = new Size(35, 23);
            label1.TabIndex = 13;
            label1.Text = "ر.س";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.FromArgb(25, 42, 86);
            pnlSeparator.Controls.Add(btnAdd);
            pnlSeparator.Controls.Add(btnClear);
            pnlSeparator.Controls.Add(btnUpdate);
            pnlSeparator.Controls.Add(btnDelete);
            pnlSeparator.Location = new Point(39, 136);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(977, 40);
            pnlSeparator.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(815, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "إضافة عقار";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(128, 128, 255);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(83, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 40);
            btnClear.TabIndex = 11;
            btnClear.Text = "تفريغ الحقول";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(241, 196, 15);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(560, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "تعديل عقار";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(328, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "حذف عقار";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "متاح", "مؤجر", "مباع" });
            cmbStatus.Location = new Point(706, 78);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 25);
            cmbStatus.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatus.Location = new Point(972, 84);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(44, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "الحالة";
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Location = new Point(157, 79);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 25);
            txtPrice.TabIndex = 5;
            txtPrice.KeyDown += txtPrice_KeyDown;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPrice.Location = new Point(392, 84);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(46, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "السعر";
            // 
            // txtLocation
            // 
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Font = new Font("Segoe UI", 10F);
            txtLocation.Location = new Point(157, 28);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(200, 25);
            txtLocation.TabIndex = 3;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLocation.Location = new Point(392, 28);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(52, 20);
            lblLocation.TabIndex = 2;
            lblLocation.Text = "الموقع";
            // 
            // txtPropertyType
            // 
            txtPropertyType.BorderStyle = BorderStyle.FixedSingle;
            txtPropertyType.Font = new Font("Segoe UI", 10F);
            txtPropertyType.Location = new Point(706, 28);
            txtPropertyType.Name = "txtPropertyType";
            txtPropertyType.Size = new Size(200, 25);
            txtPropertyType.TabIndex = 1;
            // 
            // lblPropertyType
            // 
            lblPropertyType.AutoSize = true;
            lblPropertyType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPropertyType.Location = new Point(945, 28);
            lblPropertyType.Name = "lblPropertyType";
            lblPropertyType.Size = new Size(71, 20);
            lblPropertyType.TabIndex = 0;
            lblPropertyType.Text = "نوع العقار";
            // 
            // FrmProperties
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 42, 86);
            ClientSize = new Size(1054, 749);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmProperties";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "إدارة العقارات";
            Load += FrmProperties_Load;
            pnlMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlSeparator.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Label lblTimeDate;
        private DataGridViewTextBoxColumn colIndex;
        private Label label1;
    }
    

}