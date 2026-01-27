using RealEstate.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate.UI
{
    public partial class FrmContractPayments : Form
    {
        private int _contractId;
        public FrmContractPayments(int contractId)
        {
            InitializeComponent();
            _contractId = contractId;
        }
        private void LoadContractInfo()
        {
            DataRow row = PaymentDAL.GetContractSummary(_contractId);

            lblClientName.Text = row["FullName"].ToString();
            lblProperty.Text = row["PropertyType"].ToString();
            lblTotal.Text = row["TotalAmount"].ToString();
            lblPaid.Text = row["PaidAmount"].ToString();
            lblRemaining.Text = row["RemainingAmount"].ToString();
            lblStatus.Text = row["Status"].ToString();
        }
        private void LoadPayments()
        {
            dgvPayments.DataSource = PaymentDAL.GetPaymentsByContract(_contractId);
        }



        private void miViewPayments_Click(object sender, EventArgs e)
        {

        }

        private void FrmContractPayments_Load(object sender, EventArgs e)
        {
            LoadContractInfo();
            LoadPayments();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
       
            // 1️⃣ تأكد أن صف محدد
            if (dgvPayments.CurrentRow == null) return;

            // 2️⃣ رسالة تأكيد
            DialogResult result = MessageBox.Show(
                "هل أنت متأكد من حذف هذه الدفعة؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result != DialogResult.Yes) return;

            try
            {
               
                int paymentId = Convert.ToInt32(dgvPayments.CurrentRow.Cells["رقم الدفعة"].Value);

                // 4️⃣ حذف من قاعدة البيانات
                PaymentDAL dal = new PaymentDAL();
                dal.DeletePayment(paymentId);

                // 5️⃣ تحديث الـ DataGridView
                LoadPayments();
                LoadContractInfo();
                MessageBox.Show("تم حذف الدفعة بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

