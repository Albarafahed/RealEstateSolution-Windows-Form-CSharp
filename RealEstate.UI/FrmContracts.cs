using RealEstate.DataAccess;
using RealEstate.Entities;
using RealEstate.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate.UI
{
    public partial class FrmContracts : Form
    {

        public FrmContracts()
        {
            InitializeComponent();
        }
        private void ExportToCSV(DataGridView dgv, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // العناوين
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sb.Append(dgv.Columns[i].HeaderText + ",");
            }
            sb.AppendLine();

            // البيانات
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        sb.Append(row.Cells[i].Value?.ToString() + ",");
                    }
                    sb.AppendLine();
                }
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }



        void ClearContractInputs()
        {
            cbProperties.SelectedIndex = -1;
            cbContractType.SelectedIndex = -1;
            txtTotalAmount.Clear();
            cbStatus.SelectedIndex = -1;
        }
        private void LoadPropertisForAddContcat()
        {
            cbProperties.Visible = false;
            cbProperteisAdd.Visible = true;
            cbProperteisAdd.DataSource = ContractDAL.GetAllForSelection();
            cbProperteisAdd.DisplayMember = "DisplayText";   // الاسم الظاهر
            cbProperteisAdd.ValueMember = "PropertyID";     // المفتاح الحقيقي
            cbProperteisAdd.SelectedIndex = -1;
        }

        private void LoadClientsToCombo()
        {
            cbProperteisAdd.Visible = false;
            cbProperties.Visible = true;
            cbClients.DataSource = ClientDAL.GetAllClientsSwhow();
            cbClients.DisplayMember = "FullName";
            cbClients.ValueMember = "ClientID"; // القيمة الحقيقية
            cbClients.SelectedIndex = -1;
        }
        private void LoadProperties()
        {
            cbProperties.DataSource = null;
            cbProperties.Items.Clear();
            cbProperties.DataSource = PropertyDAL.GetAllProperties();
            cbProperties.DisplayMember = "نوع العقار";   // الاسم الظاهر
            cbProperties.ValueMember = "رقم العقار";     // المفتاح الحقيقي
            cbProperties.SelectedIndex = -1;
        }

        private void RenameContractColumns()
        {
            dgvContracts.Columns["ContractID"].HeaderText = "رقم العقد";
            dgvContracts.Columns["FullName"].HeaderText = "اسم العميل";
            dgvContracts.Columns["PropertyType"].HeaderText = "اسم العقار";
            dgvContracts.Columns["ContractType"].HeaderText = "نوع العقد";
            dgvContracts.Columns["Status"].HeaderText = "الحالة";
            dgvContracts.Columns["StartDate"].HeaderText = "تاريخ البداية";
            dgvContracts.Columns["EndDate"].HeaderText = "تاريخ النهاية";
            dgvContracts.Columns["TotalAmount"].HeaderText = "قيمة العقد";

        }
        private void LoadContracts()
        {

            dgvContracts.DataSource = ContractDAL.GetAllContracts();
            RenameContractColumns();
            dgvContracts.Columns["StartDate"].DefaultCellStyle.Format = "yyyy/MM/dd";
            dgvContracts.Columns["EndDate"].DefaultCellStyle.Format = "yyyy/MM/dd";
        }


        private void LblStartDate_Click(object sender, EventArgs e)
        {

        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (dgvContracts.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات للتصدير");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = "Contracts.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(dgvContracts, sfd.FileName);
                MessageBox.Show("تم التصدير بنجاح");
            }
        }

        private void DetailsContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmContracts_Load(object sender, EventArgs e)
        {

            LoadClientsToCombo();
            LoadContracts();
            LoadProperties();

            LblContractCount.Text = dgvContracts.ColumnCount.ToString();
        }

        private void cboClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormFieldsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbProperty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            cbProperties.Visible = true;
            cbProperteisAdd.Visible = false;
            // تحقق أساسي
            if (cbClients.SelectedValue == null || cbProperties.SelectedValue == null)
            {
                MessageBox.Show("يرجى اختيار العميل والعقار");
                return;
            }

            if (string.IsNullOrWhiteSpace(cbContractType.Text))
            {
                MessageBox.Show("يرجى تحديد نوع العقد");
                return;
            }

            decimal totalAmount;
            if (!decimal.TryParse(txtTotalAmount.Text, out totalAmount))
            {
                MessageBox.Show("قيمة العقد غير صحيحة");
                return;
            }


            Contract contract = new Contract
            {
                ClientID = (int)cbClients.SelectedValue,
                PropertyID = (int)cbProperties.SelectedValue,
                ContractType = cbContractType.Text.Trim(),
                StartDate = dtpStartDate.Value.Date,
                EndDate = dtpEndDate.Value.Date,
                TotalAmount = totalAmount,
                Status = "ساري"
            };

            bool added = ContractDAL.AddNewContract(contract);

            if (added)
            {

                string newPropertyStatus = "متاح";

                if (contract.ContractType == "إيجار")
                    newPropertyStatus = "مؤجر";
                else if (contract.ContractType == "بيع")
                    newPropertyStatus = "مباع";

                PropertyDAL.UpdateStatus(contract.PropertyID, newPropertyStatus);

                MessageBox.Show("تم إنشاء العقد بنجاح");
                LoadContracts();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

            // 1️⃣ التأكد من وجود صف محدد
            if (dgvContracts.CurrentRow == null)
            {
                MessageBox.Show("يرجى تحديد عقد للحذف");
                return;
            }

            // 2️⃣ جلب رقم العقد بأمان
            int contractId = Convert.ToInt32(
                dgvContracts.CurrentRow.Cells["ContractID"].Value
            );

            // 3️⃣ التأكد من عدم وجود دفعات مرتبطة
            if (PaymentDAL.IsContractHasPayments(contractId))
            {
                MessageBox.Show("لا يمكن حذف العقد لوجود دفعات مرتبطة به");
                return;
            }

            // 4️⃣ تأكيد الحذف
            DialogResult result = MessageBox.Show(
                "هل أنت متأكد من حذف هذا العقد؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            // 5️⃣ تنفيذ الحذف مع الحماية
            try
            {
                bool deleted = ContractDAL.Delete(contractId);

                if (deleted)
                {
                    MessageBox.Show("تم حذف العقد بنجاح");
                    LoadContracts(); // إعادة تحميل البيانات
                }
                else
                {
                    MessageBox.Show("لم يتم حذف العقد");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحذف:\n" + ex.Message);
            }
        }

        private void BtnNewContract_Click(object sender, EventArgs e)
        {
            ClearContractInputs();
            LoadPropertisForAddContcat();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cbProperteisAdd.Visible = false;
            cbProperties.Visible = true;

            if (dgvContracts.CurrentRow == null)
            {
                MessageBox.Show("يرجى اختيار عقد للتعديل");
                return;
            }


            if (cbClients.SelectedValue == null)
            {
                MessageBox.Show("يرجى اختيار العميل");
                cbClients.Focus();
                return;
            }


            if (cbProperties.SelectedValue == null)
            {
                MessageBox.Show("يرجى اختيار العقار");
                cbProperties.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(cbContractType.Text))
            {
                MessageBox.Show("يرجى إدخال أو اختيار نوع العقد");
                cbContractType.Focus();
                return;
            }


            if (dtpEndDate.Value.Date <= dtpStartDate.Value.Date)
            {
                MessageBox.Show("تاريخ نهاية العقد يجب أن يكون بعد تاريخ البداية");
                dtpEndDate.Focus();
                return;
            }


            if (!decimal.TryParse(txtTotalAmount.Text, out decimal totalAmount))
            {
                MessageBox.Show("قيمة العقد غير صحيحة");
                txtTotalAmount.Focus();
                return;
            }

            if (totalAmount <= 0)
            {
                MessageBox.Show("قيمة العقد يجب أن تكون أكبر من صفر");
                txtTotalAmount.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(cbStatus.Text))
            {
                MessageBox.Show("يرجى تحديد حالة العقد");
                cbStatus.Focus();
                return;
            }


            int contractId = Convert.ToInt32(dgvContracts.CurrentRow.Cells["ContractID"].Value);


            Contract contract = new Contract
            {
                ContractID = Convert.ToInt32(dgvContracts.CurrentRow.Cells["ContractID"].Value),

                ClientID = (int)cbClients.SelectedValue,      // ✅ رقم صحيح
                PropertyID = (int)cbProperties.SelectedValue, // ✅ رقم صحيح

                ContractType = cbContractType.Text.Trim(),
                StartDate = dtpStartDate.Value.Date,
                EndDate = dtpEndDate.Value.Date,
                TotalAmount = decimal.Parse(txtTotalAmount.Text),
                Status = cbStatus.Text.Trim()
            };


            try
            {
                bool updated = ContractDAL.Update(contract);

                if (updated)
                {
                    MessageBox.Show("تم تعديل العقد بنجاح");
                    LoadContracts();        // تحديث الجدول
                    ClearContractInputs();  // تنظيف الحقول إذا أردت
                }
                else
                {
                    MessageBox.Show("لم يتم تعديل العقد");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تعديل العقد:\n" + ex.Message);
            }
        }

        private void dgvContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (cbProperties.Visible == false)
            {
                DialogResult result = MessageBox.Show("اغلاق العقد لتتمكن من التنقل", "الغاء العقد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    cbProperteisAdd.Visible = false;
                    cbProperties.Visible = true;
                }
                else
                {
                    return;
                }
            }
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvContracts.Rows[e.RowIndex];

            try
            {
                string clientName = row.Cells["FullName"].Value.ToString();
                cbClients.SelectedIndex = cbClients.FindStringExact(clientName);

                // 🔹 اختيار العقار بالاسم
                string propertyName = row.Cells["PropertyType"].Value.ToString();
                cbProperties.SelectedIndex = cbProperties.FindStringExact(propertyName);

                // 🔹 باقي الحقول
                cbContractType.Text = row.Cells["ContractType"].Value.ToString();
                dtpStartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
                dtpEndDate.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);
                txtTotalAmount.Text = row.Cells["TotalAmount"].Value.ToString();
                cbStatus.Text = row.Cells["Status"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ClearContractInputs();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            cbProperteisAdd.Visible = false;
            cbProperties.Visible = true;

            DialogResult result = MessageBox.Show("تم الغاء العقد", "تاكيد العملية", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

            }

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printPreviewContracts.Document = printContracts;
            printPreviewContracts.ShowDialog();
        }

        private void txtSearchClient_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearchClient_Leave(object sender, EventArgs e)
        {


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LblContractCount.Text = dgvContracts.ColumnCount.ToString();
            if (string.IsNullOrWhiteSpace(txtSearchClient.Text))
            {
                MessageBox.Show("اكتب اسم العميل للبحث");
                return;
            }

            ContractDAL dal = new ContractDAL();
            dgvContracts.DataSource = dal.SearchContractsByClientName(
                txtSearchClient.Text.Trim()
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadContracts();
            LblContractCount.Text = dgvContracts.ColumnCount.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainSplitContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblProperty_Click(object sender, EventArgs e)
        {

        }

        private void cbProperteisAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListToolbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvContracts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainSplitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblStatus_Click(object sender, EventArgs e)
        {

        }

        private void printContracts_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridViewPrinter.PrintDataGridView(e, dgvContracts, "تقارير العقود");
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



