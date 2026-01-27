

using RealEstate.Entities;
namespace RealEstate.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void LoadForm(Form frm)
        {
            MainPanel.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(frm);
            frm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmProperties());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm= new FrmLogin();
            frm.Show();
           this.Close();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmClients());
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmContracts());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmPayments());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmReports());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmSettings());
        }
    }
}
