using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSaling.AccountManagement
{
    public partial class DelAccountForm : Form
    {
        public DelAccountForm()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string delNo = tbDelAcc.Text;
            AccountCtrl ac = new AccountCtrl();
            ac.delAccount(delNo);
            this.Close();
        }
    }
}
