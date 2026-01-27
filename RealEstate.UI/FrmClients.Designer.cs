namespace RealEstate.UI
{

   
        partial class FrmClients
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
            lblTitle = new Label();
            panelCenter = new Panel();
            dgvClients = new DataGridView();
            colIndex = new DataGridViewTextBoxColumn();
            panelBottom = new Panel();
            groupBoxDetails = new GroupBox();
            txtNotes = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            panelButtons = new Panel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            dgvPayments = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            dgvContracts = new DataGridView();
            numberContracts = new DataGridViewTextBoxColumn();
            bnlSerch = new Panel();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            label4 = new Label();
            panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            panelBottom.SuspendLayout();
            groupBoxDetails.SuspendLayout();
            panelButtons.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).BeginInit();
            bnlSerch.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(906, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "إدارة العملاء 👥";
            lblTitle.Click += lblTitle_Click;
            // 
            // panelCenter
            // 
            panelCenter.BackColor = Color.FromArgb(25, 42, 86);
            panelCenter.Controls.Add(dgvClients);
            panelCenter.Dock = DockStyle.Top;
            panelCenter.Location = new Point(0, 0);
            panelCenter.Name = "panelCenter";
            panelCenter.Padding = new Padding(7);
            panelCenter.Size = new Size(1042, 152);
            panelCenter.TabIndex = 1;
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.BackgroundColor = Color.White;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { colIndex });
            dgvClients.Dock = DockStyle.Fill;
            dgvClients.Location = new Point(7, 7);
            dgvClients.MultiSelect = false;
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RightToLeft = RightToLeft.Yes;
            dgvClients.RowHeadersWidth = 5;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.Size = new Size(1028, 138);
            dgvClients.TabIndex = 0;
            dgvClients.CellClick += dgvClients_CellClick;
            dgvClients.CellContentClick += dgvClients_CellContentClick;
            dgvClients.RowPostPaint += dgvClients_RowPostPaint;
            // 
            // colIndex
            // 
            colIndex.FillWeight = 30F;
            colIndex.HeaderText = "رقم العميل";
            colIndex.MinimumWidth = 2;
            colIndex.Name = "colIndex";
            colIndex.ReadOnly = true;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(25, 42, 86);
            panelBottom.Controls.Add(groupBoxDetails);
            panelBottom.Controls.Add(panelButtons);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 472);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1042, 129);
            panelBottom.TabIndex = 2;
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.BackColor = Color.FromArgb(192, 192, 255);
            groupBoxDetails.Controls.Add(txtNotes);
            groupBoxDetails.Controls.Add(label3);
            groupBoxDetails.Controls.Add(txtPhone);
            groupBoxDetails.Controls.Add(label2);
            groupBoxDetails.Controls.Add(txtFullName);
            groupBoxDetails.Controls.Add(label1);
            groupBoxDetails.Dock = DockStyle.Left;
            groupBoxDetails.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDetails.Location = new Point(0, 0);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.RightToLeft = RightToLeft.Yes;
            groupBoxDetails.Size = new Size(900, 129);
            groupBoxDetails.TabIndex = 1;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "بيانات العميل";
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(0, 56);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(300, 55);
            txtNotes.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(320, 69);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 4;
            label3.Text = "ملاحظات:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(433, 86);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 25);
            txtPhone.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(689, 89);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 2;
            label2.Text = "الهاتف:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(433, 36);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 25);
            txtFullName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(689, 39);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 0;
            label1.Text = "الاسم الكامل:";
            // 
            // panelButtons
            // 
            panelButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelButtons.BackColor = Color.FromArgb(192, 192, 255);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnClear);
            panelButtons.Location = new Point(906, -3);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(136, 129);
            panelButtons.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.Dock = DockStyle.Top;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(10, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 27);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "إضافة";
            btnAdd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(52, 152, 219);
            btnUpdate.Dock = DockStyle.Top;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdate.Location = new Point(10, 62);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 26);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "تعديل";
            btnUpdate.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.Dock = DockStyle.Top;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(10, 36);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 26);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "حذف";
            btnDelete.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(149, 165, 166);
            btnClear.Dock = DockStyle.Top;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.ImageAlign = ContentAlignment.MiddleRight;
            btnClear.Location = new Point(10, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 26);
            btnClear.TabIndex = 3;
            btnClear.Text = "تفريغ";
            btnClear.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(bnlSerch);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 472);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panelCenter);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(1042, 435);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 152);
            panel4.Name = "panel4";
            panel4.Size = new Size(1042, 283);
            panel4.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 139);
            panel6.Name = "panel6";
            panel6.Size = new Size(1042, 144);
            panel6.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 42, 86);
            panel3.Controls.Add(dgvPayments);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(7);
            panel3.Size = new Size(1042, 149);
            panel3.TabIndex = 2;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgvPayments.Dock = DockStyle.Top;
            dgvPayments.Location = new Point(7, 7);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RightToLeft = RightToLeft.Yes;
            dgvPayments.RowHeadersWidth = 5;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(1028, 132);
            dgvPayments.TabIndex = 0;
            dgvPayments.RowPostPaint += dgvPayments_RowPostPaint;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 30F;
            dataGridViewTextBoxColumn1.HeaderText = "رقم لدفع";
            dataGridViewTextBoxColumn1.MinimumWidth = 2;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(25, 42, 86);
            panel5.Controls.Add(dgvContracts);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(7);
            panel5.Size = new Size(1042, 139);
            panel5.TabIndex = 3;
            // 
            // dgvContracts
            // 
            dgvContracts.AllowUserToAddRows = false;
            dgvContracts.AllowUserToDeleteRows = false;
            dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContracts.BackgroundColor = Color.White;
            dgvContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContracts.Columns.AddRange(new DataGridViewColumn[] { numberContracts });
            dgvContracts.Dock = DockStyle.Fill;
            dgvContracts.Location = new Point(7, 7);
            dgvContracts.MultiSelect = false;
            dgvContracts.Name = "dgvContracts";
            dgvContracts.ReadOnly = true;
            dgvContracts.RightToLeft = RightToLeft.Yes;
            dgvContracts.RowHeadersWidth = 5;
            dgvContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContracts.Size = new Size(1028, 125);
            dgvContracts.TabIndex = 0;
            dgvContracts.CellClick += dgvContracts_CellClick_1;
            dgvContracts.CellContentClick += dgvContracts_CellContentClick_1;
            dgvContracts.RowPostPaint += dgvContracts_RowPostPaint_1;
            // 
            // numberContracts
            // 
            numberContracts.FillWeight = 30F;
            numberContracts.HeaderText = "رقم العقد";
            numberContracts.Name = "numberContracts";
            numberContracts.ReadOnly = true;
            // 
            // bnlSerch
            // 
            bnlSerch.BackColor = Color.FromArgb(25, 42, 86);
            bnlSerch.Controls.Add(lblTitle);
            bnlSerch.Controls.Add(btnRefresh);
            bnlSerch.Controls.Add(txtSearch);
            bnlSerch.Controls.Add(label4);
            bnlSerch.Dock = DockStyle.Top;
            bnlSerch.ForeColor = SystemColors.ActiveCaptionText;
            bnlSerch.Location = new Point(0, 0);
            bnlSerch.Name = "bnlSerch";
            bnlSerch.Size = new Size(1042, 37);
            bnlSerch.TabIndex = 3;
            bnlSerch.Paint += bnlSerch_Paint;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(25, 42, 86);
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ButtonHighlight;
            btnRefresh.Location = new Point(61, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(99, 32);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "عرض الكل";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(238, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(206, 23);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "ابحث بالاسم أو الهاتف";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(470, 5);
            label4.Name = "label4";
            label4.Size = new Size(72, 37);
            label4.TabIndex = 0;
            label4.Text = "بحث";
            label4.Click += label4_Click;
            // 
            // FrmClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1042, 601);
            Controls.Add(panel1);
            Controls.Add(panelBottom);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmClients";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة العملاء";
            Load += FrmClients_Load;
            panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            panelBottom.ResumeLayout(false);
            groupBoxDetails.ResumeLayout(false);
            groupBoxDetails.PerformLayout();
            panelButtons.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContracts).EndInit();
            bnlSerch.ResumeLayout(false);
            bnlSerch.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Panel panelCenter;
            private System.Windows.Forms.DataGridView dgvClients;
            private System.Windows.Forms.Panel panelBottom;
            private System.Windows.Forms.GroupBox groupBoxDetails;
            private System.Windows.Forms.TextBox txtNotes;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.TextBox txtPhone;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.TextBox txtFullName;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Panel panelButtons;
            private System.Windows.Forms.Button btnAdd;
            private System.Windows.Forms.Button btnUpdate;
            private System.Windows.Forms.Button btnDelete;
            private System.Windows.Forms.Button btnClear;
        private DataGridViewTextBoxColumn colIndex;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvPayments;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dgvContracts;
        private Panel panel6;
        private Panel bnlSerch;
        private Button btnRefresh;
        private TextBox txtSearch;
        private Label label4;
        private DataGridViewTextBoxColumn numberContracts;
    }
    

}