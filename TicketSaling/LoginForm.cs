using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSaling
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public string acc, pwd;
        public bool isValid;

        private void btnLog_Click(object sender, EventArgs e)
        {
            isValid = true;
            acc = tbAcc.Text;
            pwd = tbPwd.Text;
            this.Close();
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            isValid = false;
            this.Close();
        }
    }
}
