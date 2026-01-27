using RealEstate.DataAccess;
using RealEstate.Entities;
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
    public partial class FrmProperties : Form
    {
        private int _selectedPropertyID = -1;
        public FrmProperties()
        {
            InitializeComponent();
        }
        private void ClearFields()
        {
            txtPropertyType.Clear();
            txtLocation.Clear();
            txtPrice.Clear();
            cmbStatus.SelectedIndex = -1;
        }

        private void LoadProperties()
        {
            dgvProperties.DataSource = PropertyDAL.GetAllProperties();
            dgvProperties.Columns["رقم العقار"].Visible = false;
            //dgvProperties.Columns["السعر"].DefaultCellStyle.Format = "";
        }
        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtPropertyType.Text))
            {
                MessageBox.Show("الرجاء إدخال نوع العقار");
                txtPropertyType.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("الرجاء إدخال الموقع");
                txtLocation.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("الرجاء إدخال سعر صحيح");
                txtPrice.Focus();
                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء اختيار حالة العقار");
                cmbStatus.Focus();
                return false;
            }

            return true;
        }


        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmProperties_Load(object sender, EventArgs e)
        {
            LoadProperties();
            lblTimeDate.Text = DateTime.Now.ToString();

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProperties_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvProperties.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
                return;

            Property property = new Property()
            {
                PropertyType = txtPropertyType.Text.Trim(),
                Location = txtLocation.Text.Trim(),
                Price = decimal.Parse(txtPrice.Text),
                Status = cmbStatus.SelectedItem.ToString()
            };

            bool result = PropertyDAL.AddNewProperty(property);

            if (result)
            {
                MessageBox.Show("تمت إضافة العقار بنجاح");
                LoadProperties();
                ClearFields();
            }
            else
            {
                MessageBox.Show("فشل في إضافة العقار");
            }
        }

        private void dgvProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _selectedPropertyID = Convert.ToInt32(
            dgvProperties.CurrentRow.Cells["رقم العقار"].Value);

            txtPropertyType.Text = dgvProperties.CurrentRow.Cells["نوع العقار"].Value.ToString();
            txtLocation.Text = dgvProperties.CurrentRow.Cells["الموقع"].Value.ToString();
            txtPrice.Text = dgvProperties.CurrentRow.Cells["السعر"].Value.ToString();
            cmbStatus.Text = dgvProperties.CurrentRow.Cells["الحالة"].Value.ToString();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtPrice.Text.Contains('.'))
                e.Handled = true;

        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
                e.SuppressKeyPress = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedPropertyID == -1)
            {
                MessageBox.Show("الرجاء اختيار عقار للتعديل");
                return;
            }

            if (!IsValidInput())
                return;

            Property property = new Property
            {
                PropertyID = _selectedPropertyID,
                PropertyType = txtPropertyType.Text.Trim(),
                Location = txtLocation.Text.Trim(),
                Price = decimal.Parse(txtPrice.Text),
                Status = cmbStatus.SelectedItem.ToString()
            };

            bool result = PropertyDAL.UpdateProperty(property);

            if (result)
            {
                MessageBox.Show("تم تعديل العقار بنجاح");
                LoadProperties();
                ClearFields();
                _selectedPropertyID = -1;
            }
            else
            {
                MessageBox.Show("فشل في تعديل العقار");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedPropertyID == -1)
            {
                MessageBox.Show("الرجاء اختيار عقار للحذف");
                return;
            }

            DialogResult result = MessageBox.Show(
                "هل أنت متأكد من حذف هذا العقار؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            bool deleted = PropertyDAL.DeleteProperty(_selectedPropertyID);

            if (deleted)
            {
                MessageBox.Show("تم حذف العقار بنجاح");
                LoadProperties();
                ClearFields();
                _selectedPropertyID = -1;
            }
            else
            {
                MessageBox.Show("فشل في حذف العقار");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        ClearFields();
        }
    }
}
