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
    public partial class ManageRoleForm : Form
    {
        public ManageRoleForm()
        {
            InitializeComponent();
        }
        
        private void ManageRoleForm_Load(object sender, EventArgs e)
        {
            AccountCtrl ac = new AccountCtrl();
            List<object[]> rightList =ac.loadRight();
            for(int i=0;i<rightList.Count;i++)
            {
                object[] o = rightList[i];
                lbRoleRight.Items.Add(o[1]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AccountCtrl ac = new AccountCtrl();
            int roleNo = ac.loadRoleIdMax()+1;
            int numRight = lbRoleRight.SelectedItems.Count;
            List<string> rightNo = new List<string>();
            for (int i=1;i<=numRight;i++)
            {
                rightNo.Add(ac.serachRightId((string)lbRoleRight.SelectedItems[i - 1]));
            }
            ac.addRole(numRight, rightNo, roleNo.ToString(), tbRoleName.Text);
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            AccountCtrl ac = new AccountCtrl();
            ac.delRole(ac.serachRoleId(tbRoleName.Text));
            this.Close();
        }
    }
}
