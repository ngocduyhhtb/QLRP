using QuanLyRapPhim.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            pnAdmin.Controls.Clear();
            Revenue_UC revenue = new Revenue_UC();
            revenue.Dock = DockStyle.Fill;
            pnAdmin.Controls.Add(revenue);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            pnAdmin.Controls.Clear();
            Staff_UC staff = new Staff_UC();
            staff.Dock = DockStyle.Fill;
            pnAdmin.Controls.Add(staff);
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            pnAdmin.Controls.Clear();
            Guest_UC guest = new Guest_UC();
            guest.Dock = DockStyle.Fill;
            pnAdmin.Controls.Add(guest);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnAdmin.Controls.Clear();
            Account_UC account = new Account_UC();
            account.Dock = DockStyle.Fill;
            pnAdmin.Controls.Add(account);
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            pnAdmin.Controls.Clear();
            Data_UC data = new Data_UC();
            data.Dock = DockStyle.Fill;
            pnAdmin.Controls.Add(data);
        }
    }
}
