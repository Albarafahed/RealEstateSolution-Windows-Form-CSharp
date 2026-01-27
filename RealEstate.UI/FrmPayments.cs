using RealEstate.DataAccess;
using RealEstate.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstate.Helpers;


namespace RealEstate.UI
{
    public partial class FrmPayments : Form
    {
        DataTable dtContracts;

        public FrmPayments()
        {
            InitializeComponent();
        }
        private void LoadContracts()
        {
            dtContracts = PaymentDAL.GetContractsForPayments(); // جلب جميع العقود
            dgvContracts.DataSource = dtContracts;
        }


        private void LoadContractsForPayments()
        {

            dgvContracts.DataSource = PaymentDAL.GetContractsForPayments();
            dgvContracts.Columns["ContractID"].Visible = false;
            dgvContracts.Columns["FullName"].HeaderText = "اسم العميل";
            dgvContracts.Columns["PropertyType"].HeaderText = "نوع العقار";
            dgvContracts.Columns["Location"].HeaderText = "موقع العقار";
            dgvContracts.Columns["TotalAmount"].HeaderText = "قيمة العقد";
            dgvContracts.Columns["PaidAmount"].HeaderText = "إجمالي المدفوع";
            dgvContracts.Columns["RemainingAmount"].HeaderText = "المتبقي";
            dgvContracts.Columns["Status"].HeaderText = "حالة العقد";
        }
        private void CleardataSersh()
        {
            cbClients.Text = null;
            cbProperties.Text = null;
            cbContracts.Text = null;
            cbContractStatus.Text = null;
            txtPaidAmount.Clear();
            txtTotalAmount.Clear();
            txtRemainingAmount.Clear();
        }


        private void ListContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaymentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainSplitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainSplitContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPayments_Load(object sender, EventArgs e)
        {
            //dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            LoadContractsForPayments();
            dgvContracts.ContextMenuStrip = cmsContracts;
        }

        private void dgvContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvContracts.Rows[e.RowIndex];

            cbClients.Text = row.Cells["FullName"].Value.ToString();
            cbProperties.Text = row.Cells["PropertyType"].Value.ToString();
            cbContracts.Text = row.Cells["Location"].Value.ToString();
            txtTotalAmount.Text = row.Cells["TotalAmount"].Value?.ToString();
            txtPaidAmount.Text = row.Cells["PaidAmount"].Value?.ToString();
            txtRemainingAmount.Text = row.Cells["RemainingAmount"].Value?.ToString();
            cbContractStatus.Text = row.Cells["Status"].Value?.ToString();
        }



        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            decimal payment = 0;
            decimal remaining = 0;
            if (dgvContracts.CurrentRow == null)
            {
                MessageBox.Show("اختر عقد أولاً");
                return;
            }

            int contractId = Convert.ToInt32(dgvContracts.CurrentRow.Cells["ContractID"].Value);
            if (txtRemainingAmount.Text != "" && txtTotalAmount.Text != "")
            {
                remaining = Convert.ToDecimal(txtRemainingAmount.Text);
                payment = Convert.ToDecimal(txtTotalAmount.Text);
            }
            else
            {

                MessageBox.Show("اختر عقد أولاً");
                return;
            }

            if (!decimal.TryParse(txtPaymentAmount.Text, out payment))
            {
                MessageBox.Show("أدخل مبلغ صالح للدفعة");
                return;
            }

            if (payment <= 0)
            {
                MessageBox.Show("المبلغ يجب أن يكون أكبر من صفر");
                return;
            }

            if (payment > remaining)
            {
                MessageBox.Show("لا يمكن دفع مبلغ أكبر من المتبقي");
                return;
            }


            Payment p = new Payment()
            {
                ContractID = contractId,
                Amount = payment,
                PaymentDate = dtpPaymentDate.Value
            };


            PaymentDAL dal = new PaymentDAL();
            bool success = dal.AddNewPayment(p);

            if (success)
            {
                MessageBox.Show("تمت إضافة الدفعة بنجاح");


                LoadContractsForPayments();

                txtPaymentAmount.Clear();
                TxtNotes.Clear();
                btnAddPayment.Enabled = false;
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء الإضافة");
            }


        }

        private void BtnNewPayment_Click(object sender, EventArgs e)
        {
            btnAddPayment.Enabled = true;

        }

        private void ListHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbClients.SelectedIndex == -1) return;

            //dgvContracts.DataSource =
            //    PaymentDAL.GetAllPaymentsByClient(cbClients.Text);
        }

        private void dgvContracts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvContracts.ClearSelection();
                dgvContracts.Rows[e.RowIndex].Selected = true;
            }
        }

        private void miViewPayments_Click(object sender, EventArgs e)
        {
            if (dgvContracts.SelectedRows.Count == 0) return;

            int contractId = Convert.ToInt32(
                dgvContracts.SelectedRows[0].Cells["ContractID"].Value);

            FrmContractPayments frm = new FrmContractPayments(contractId);
            frm.ShowDialog();
        }

        private void btnExportPayments_Click(object sender, EventArgs e)
        {
            printPreviewContracts.Document = printContracts;
            printPreviewContracts.ShowDialog();
        }

        private void printContracts_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridViewPrinter.PrintDataGridView(e, dgvContracts, "تقرير العقود والمدفوعات ");
        }

        private void btnDeletePaymentbtnDeletePayment_Click(object sender, EventArgs e)
        {

            LoadContractsForPayments();
            dgvContracts.ContextMenuStrip = cmsContracts;
            CleardataSersh();

        }

        private void txtSerchClintes_TextChanged(object sender, EventArgs e)
        {
            if (dtContracts == null)
                return; // لا نفعل شيء إذا البيانات غير محملة

            string search = txtSerchClintes.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                dgvContracts.DataSource = dtContracts; // عرض كل البيانات
                return;
            }

            var filteredRows = dtContracts.AsEnumerable()
                .Where(row => !row.IsNull("FullName") &&
                              row.Field<string>("FullName")
                                  .IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0);

            if (filteredRows.Any())
            {
                dgvContracts.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                // جدول فارغ بنفس الأعمدة لتجنب الخطأ
                dgvContracts.DataSource = dtContracts.Clone();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSerchClintes.Text))
            {
                MessageBox.Show("اكتب اسم العميل للبحث");
                return;
            }

          
            dgvContracts.DataSource = PaymentDAL.SearchContractsByClient(txtSerchClintes.Text.Trim());
        }
    }
}
