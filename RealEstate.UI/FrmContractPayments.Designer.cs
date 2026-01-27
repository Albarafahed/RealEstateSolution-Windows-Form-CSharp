namespace RealEstate.UI
{
    partial class FrmContractPayments
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
            lblClientName = new Label();
            lblProperty = new Label();
            lblTotal = new Label();
            lblPaid = new Label();
            lblRemaining = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            lblStatus = new Label();
            dgvPayments = new DataGridView();
            label1 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            btnPrint = new Button();
            btnDelete = new Button();
            panel7 = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            label7 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblClientName.ForeColor = SystemColors.ControlLightLight;
            lblClientName.Location = new Point(587, 13);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(83, 21);
            lblClientName.TabIndex = 0;
            lblClientName.Text = "اسم العميل";
            // 
            // lblProperty
            // 
            lblProperty.AutoSize = true;
            lblProperty.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProperty.ForeColor = SystemColors.ControlLightLight;
            lblProperty.Location = new Point(597, 60);
            lblProperty.Name = "lblProperty";
            lblProperty.Size = new Size(73, 21);
            lblProperty.TabIndex = 1;
            lblProperty.Text = "نوع العقار";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = SystemColors.ControlLightLight;
            lblTotal.Location = new Point(592, 105);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 21);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "قيمة العقد";
            // 
            // lblPaid
            // 
            lblPaid.AutoSize = true;
            lblPaid.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPaid.ForeColor = SystemColors.ControlLightLight;
            lblPaid.Location = new Point(561, 180);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(109, 21);
            lblPaid.TabIndex = 3;
            lblPaid.Text = "اجمالي المدفوع";
            lblPaid.Click += label4_Click;
            // 
            // lblRemaining
            // 
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRemaining.ForeColor = SystemColors.ControlLightLight;
            lblRemaining.Location = new Point(621, 137);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(49, 21);
            lblRemaining.TabIndex = 4;
            lblRemaining.Text = "الباقي";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 42, 86);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 450);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(891, 397);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblStatus);
            panel5.Controls.Add(dgvPayments);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(lblPaid);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblClientName);
            panel5.Controls.Add(lblRemaining);
            panel5.Controls.Add(lblProperty);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(lblTotal);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 73);
            panel5.Name = "panel5";
            panel5.Size = new Size(891, 324);
            panel5.TabIndex = 1;
            panel5.Paint += panel5_Paint;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatus.ForeColor = SystemColors.ControlLightLight;
            lblStatus.Location = new Point(597, 221);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(74, 21);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "حالة العقد";
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPayments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPayments.BackgroundColor = SystemColors.ControlLightLight;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Dock = DockStyle.Left;
            dgvPayments.Location = new Point(0, 0);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.Size = new Size(402, 324);
            dgvPayments.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(802, 231);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 11;
            label1.Text = ":حالة العقد";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(792, 13);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 6;
            label6.Text = ":اسم العميل";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(802, 58);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 7;
            label4.Text = ":نوع العقار";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(766, 180);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 9;
            label3.Text = ":اجمالي المدفوع";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(826, 138);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 10;
            label5.Text = ":الباقي";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(797, 105);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 8;
            label2.Text = ":قيمة العقد";
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(btnPrint);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(panel7);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(891, 73);
            panel4.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(25, 42, 86);
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPrint.ForeColor = SystemColors.ControlLightLight;
            btnPrint.Location = new Point(597, 6);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(122, 40);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "طباعة";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(25, 42, 86);
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(792, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 40);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "حذف الدفع";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 63);
            panel7.Name = "panel7";
            panel7.Size = new Size(891, 10);
            panel7.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 53);
            panel2.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Controls.Add(label7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(891, 53);
            panel6.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(408, 9);
            label7.Name = "label7";
            label7.Size = new Size(156, 28);
            label7.TabIndex = 0;
            label7.Text = "مراجة المدفوعات ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 42, 86);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(424, 6);
            button1.Name = "button1";
            button1.Size = new Size(122, 40);
            button1.TabIndex = 3;
            button1.Text = "تحديث";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmContractPayments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 450);
            Controls.Add(panel1);
            Name = "FrmContractPayments";
            Text = "FrmContractPayments";
            Load += FrmContractPayments_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblClientName;
        private Label lblProperty;
        private Label lblTotal;
        private Label lblPaid;
        private Label lblRemaining;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dgvPayments;
        private Label lblStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel6;
        private Label label7;
        private Panel panel7;
        private Button btnPrint;
        private Button btnDelete;
        private Button button1;
    }
}