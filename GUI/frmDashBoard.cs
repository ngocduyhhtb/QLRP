using GUI.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard(TaiKhoan acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
        }

        private TaiKhoan loginAccount;

        public TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.LoaiTK); }
        }

        void ChangeAccount(int type)
        {
            if (loginAccount.LoaiTK == 2) btnAdmin.Enabled = false;
            lblAccountInfo.Text += LoginAccount.UserName;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminNewDesign frm = new frmAdminNewDesign();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSeller frm = new frmSeller();
            frm.ShowDialog();
            this.Show();
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            frmAccountSettings frm = new frmAccountSettings(loginAccount);
            frm.ShowDialog();
            this.Show();
        }
    }
}