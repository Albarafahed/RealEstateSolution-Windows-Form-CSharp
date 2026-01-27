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

namespace RealEstate.UI
{
    public partial class FrmSettings : Form
    {
        private BindingSource userBinding = new BindingSource();
        public FrmSettings()
        {
            InitializeComponent();
        }
        private void LoadUsers()
        {


            // جلب كل المستخدمين
            DataTable dt = UserDAL.GetAllUsers();

            // ربط مباشرة مع 
            userBinding.DataSource = dt;


            dgvUsers.DataSource = userBinding;
            dgvUsers.Columns["UserID"].Visible = false;



            dgvUsers.Columns["Username"].HeaderText = "اسم المستخدم";
            dgvUsers.Columns["Role"].HeaderText = "الصلاحية";
            dgvUsers.Columns["Photo"].HeaderText = "صورة المستخدم";


        }




        private void LblUsername_Click(object sender, EventArgs e)
        {

        }

        private void LblPassword_Click(object sender, EventArgs e)
        {

        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {

        }

        private void pnlUsers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picUserPhoto_Click(object sender, EventArgs e)
        {

        }
        private void FrmSettings_Load_2(object sender, EventArgs e)
        {
            LoadUsers();
            // مثال
            pnlUsers.Visible = true;
            pnlGeneral.Visible = false;
            pnlContracts.Visible = false;
            pnlPayments.Visible = false;
            pnlPrinting.Visible = false;
            pnlSystem.Visible = false;

            pnlUsers.BringToFront(); // تأكد أن يكون فوق الجميع

        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            txtUserName.Text = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();
            txtPassword.Text = dgvUsers.CurrentRow.Cells["Password"].Value.ToString();
            txtConfirmPassword.Text = dgvUsers.CurrentRow.Cells["Password"].Value.ToString();


            if (e.RowIndex < 0) return;

            string photoPath = dgvUsers.Rows[e.RowIndex]
                                          .Cells["Photo"]
                                          .Value?.ToString();

            if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
            {
                picUserPhoto.Image = Image.FromFile(photoPath);
            }
            else
            {
                picUserPhoto.Image = null;
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void lnkChangePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("اختر مستخدم أولاً");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK) picUserPhoto.Image = Image.FromFile(ofd.FileName);

            {
                // عرض الصورة في PictureBox

                // تحديث المسار في الجدول فقط
                dgvUsers.CurrentRow.Cells["Photo"].Value = ofd.FileName;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string photoPath = dgvUsers.CurrentRow.Cells["Photo"].Value?.ToString();
            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);

            UserDAL.UpdateUserPhoto(userId, photoPath);
        }
    }
}
