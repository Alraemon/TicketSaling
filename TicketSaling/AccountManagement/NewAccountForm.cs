using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using TicketSaling.AccountManagement;

namespace TicketSaling
{
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void NewAccountForm_Load(object sender, EventArgs e)
        {
            AccountCtrl ac = new AccountCtrl();
            List<object[]> comboBoxList = ac.loadRole();
            for (int i=0;i<comboBoxList.Count;i++)
            {
                object[] o = comboBoxList[i];
                cbAccess.Items.Add(o[0]);
            }
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            AccountCtrl ac = new AccountCtrl();
            ac.addAccount(tbID.Text, tbPwd.Text, cbAccess.Text);
            this.Close();
        }
    }
}
