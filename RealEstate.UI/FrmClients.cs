using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstate.DataAccess;
using RealEstate.Entities;

namespace RealEstate.UI
{
    public partial class FrmClients : Form
    {
        public FrmClients()
        {
            InitializeComponent();
        }
        private void LoadClintce()
        {
            dgvClients.DataSource = ClientDAL.GetAllClients();
            dgvClients.Columns["رقم العميل"].Visible = false;


        }
        private void ClearFields()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtNotes.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "ابحث بالاسم أو الهاتف")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "ابحث بالاسم أو الهاتف";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.Gray || string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dgvClients.DataSource = ClientDAL.GetAllClients();
            }
            else
            {
                dgvClients.DataSource = ClientDAL.SearchClients(txtSearch.Text.Trim());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            dgvClients.DataSource = ClientDAL.GetAllClients();
        }

        private void FrmClients_Load(object sender, EventArgs e)
        {
            LoadClintce();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClients_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvClients.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void bnlSerch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtFullName.Text = dgvClients.CurrentRow.Cells["الاسم الكامل"].Value.ToString();
            txtPhone.Text = dgvClients.CurrentRow.Cells["الهاتف"].Value.ToString();
            txtNotes.Text = dgvClients.CurrentRow.Cells["ملاحظات"].Value.ToString();



            if (e.RowIndex < 0) return;
            int clientID = Convert.ToInt32(dgvClients.CurrentRow.Cells["رقم العميل"].Value);
            dgvContracts.DataSource = ContractDAL.GetContractsByClient(clientID);
            dgvContracts.Columns["PropertyID"].Visible = false;
            dgvContracts.Columns["رقم العقد"].Visible = false;
            dgvPayments.DataSource = null;
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("اسم العميل مطلوب");
                return;
            }

            bool result = ClientDAL.AddClient(
                txtFullName.Text.Trim(),
                txtPhone.Text.Trim(),
                txtNotes.Text.Trim()
            );

            if (result)
            {
                MessageBox.Show("تمت إضافة العميل بنجاح");
                LoadClintce();
                ClearFields();
            }
            else
            {
                MessageBox.Show("فشل في الإضافة");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvContracts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null) return;

            int clientID = Convert.ToInt32(dgvClients.CurrentRow.Cells["رقم العميل"].Value);

            bool result = ClientDAL.UpdateClient(
                clientID,
                txtFullName.Text.Trim(),
                txtPhone.Text.Trim(),
                txtNotes.Text.Trim()
            );

            if (result)
            {
                MessageBox.Show("تم تعديل بيانات العميل بنجاح");
                LoadClintce();
                ClearFields();
            }
            else
            {
                MessageBox.Show("فشل في تعديل البيانات");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvClients.CurrentRow == null) return;

            int clientID = Convert.ToInt32(dgvClients.CurrentRow.Cells["رقم العميل"].Value);

            // التحقق من وجود عقود
            if (ClientDAL.HasContracts(clientID))
            {
                MessageBox.Show("لا يمكن حذف العميل! يوجد له عقود مرتبطة.",
                                "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show(
                "هل تريد حذف العميل؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                bool result = ClientDAL.DeleteClient(clientID);

                if (result)
                {
                    MessageBox.Show("تم حذف العميل بنجاح");
                    LoadClintce();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("فشل في الحذف");
                }
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvContracts_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            int PaymentsID = Convert.ToInt32(dgvContracts.CurrentRow.Cells["رقم العقد"].Value);

            dgvPayments.DataSource = PaymentDAL.GetPaymentsByContract(PaymentsID);
            dgvPayments.Columns["رقم الدفعة"].Visible = false;
        }

        private void dgvContracts_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvContracts.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvPayments_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvPayments.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvContracts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

