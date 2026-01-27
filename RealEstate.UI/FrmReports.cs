using Microsoft.Data.SqlClient;
using RealEstate.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstate.Helpers;

namespace RealEstate.UI
{
    public partial class FrmReports : Form
    {



        // دالة العقود المدفوعة بالكامل
        private DataTable GetUnpaidContracts()
        {
            DataTable dt = ReportsDAL.GetAllContracts();
            DataRow[] rows = dt.Select("PaidAmount = 0");

            if (rows.Length == 0)
                return dt.Clone(); // يرجع DataTable فارغ بنفس الأعمدة دون صفوف

            return rows.CopyToDataTable();
        }

        private DataTable GetPartialPaidContracts()
        {
            DataTable dt = ReportsDAL.GetAllContracts();
            DataRow[] rows = dt.Select("PaidAmount > 0 AND PaidAmount < TotalAmount");

            if (rows.Length == 0)
                return dt.Clone();

            return rows.CopyToDataTable();
        }

        private DataTable GetFullyPaidContracts()
        {
            DataTable dt = ReportsDAL.GetAllContracts();
            DataRow[] rows = dt.Select("PaidAmount >= TotalAmount");

            if (rows.Length == 0)
                return dt.Clone();

            return rows.CopyToDataTable();
        }


        public FrmReports()
        {
            InitializeComponent();
        }
        private void FormatReportsGrid()
        {
            if (dgvReports.DataSource == null || dgvReports.Columns.Count == 0) return;

            void SetHeader(string colName, string header)
            {
                if (dgvReports.Columns.Contains(colName))
                    dgvReports.Columns[colName].HeaderText = header;
            }

            void HideColumn(string colName)
            {
                if (dgvReports.Columns.Contains(colName))
                    dgvReports.Columns[colName].Visible = false;
            }

            SetHeader("FullName", "اسم العميل");
            SetHeader("PropertyType", "اسم العقار");
            SetHeader("Location", "الموقع");
            SetHeader("ContractType", "نوع العقد");
            SetHeader("StartDate", "تاريخ البداية");
            SetHeader("EndDate", "تاريخ النهاية");
            SetHeader("TotalAmount", "قيمة العقد");
            SetHeader("PaidAmount", "المدفوع");
            SetHeader("RemainingAmount", "المتبقي");
            SetHeader("Status", "الحالة");

            HideColumn("ContractID");

            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void ApplyStyles()
        {
            // تنسيق الجدول
            dgvReports.EnableHeadersVisualStyles = false;
            dgvReports.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvReports.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvReports.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(60, 70, 90);
            dgvReports.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvReports.ColumnHeadersHeight = 40;

            dgvReports.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvReports.DefaultCellStyle.ForeColor = Color.FromArgb(80, 90, 110);
            dgvReports.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 255);
            dgvReports.DefaultCellStyle.SelectionForeColor = Color.FromArgb(60, 70, 90);
            dgvReports.RowTemplate.Height = 35;

            // تعيين التواريخ الافتراضية
            dtFrom.Value = DateTime.Now.AddMonths(-1);
            dtTo.Value = DateTime.Now;

            // تعيين القيمة الافتراضية لنوع التقرير
            if (cbReportType.Items.Count > 0)
                cbReportType.SelectedIndex = 0;
        }


        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void FrmReports_Load_1(object sender, EventArgs e)
        {

            dtFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtTo.Value = DateTime.Now;
            cbReportType.Items.Add("الكل");
            cbReportType.Items.Add("المدفوعة بالكامل");
            cbReportType.Items.Add("غير المدفوعة بالكامل");
            cbReportType.Items.Add("مدفوعة جزئيًا");
            cbReportType.SelectedIndex = 0;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (cbReportType.SelectedIndex == -1)
            {
                MessageBox.Show("اختر نوع التقرير أولاً");
                return;
            }

            DataTable dt = null;
            string selected = cbReportType.SelectedItem.ToString();

            switch (selected)
            {
                case "الكل":
                    dt = ReportsDAL.GetAllContracts();
                    break;
                case "المدفوعة بالكامل":
                    dt = GetFullyPaidContracts();
                    break;
                case "غير المدفوعة بالكامل":
                    dt = GetUnpaidContracts();
                    break;
                case "مدفوعة جزئيًا":
                    dt = GetPartialPaidContracts();
                    break;
                default:
                    MessageBox.Show("نوع التقرير غير معروف");
                    return;
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لهذا التقرير");
                dgvReports.DataSource = null;
                return;
            }

            dgvReports.DataSource = dt;
            FormatReportsGrid();


        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            printperViewReports.Document = printReports;
            printperViewReports.ShowDialog();
        }

        private void printReports_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewPrinter.PrintDataGridView(e, dgvReports, "تقرير ");
        }
    }
}
