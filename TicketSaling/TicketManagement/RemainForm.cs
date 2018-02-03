using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSaling.TicketManagement
{
    public partial class RemainForm : Form
    {
        public RemainForm()
        {
            InitializeComponent();
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            lvTicketInfo.Items.Clear();
            TicketCtrl tc = new TicketCtrl();
            List <object[]> ticketList = new List<Object[]>();
            if (rbPassId.Checked)
            {
                ticketList = tc.serachTicketFromPassId(tbInfo.Text);
            }
            if(rbTimeId.Checked)
            {
                ticketList = tc.serachTicketFromTimeId(tbInfo.Text);
            }
            ListViewItem[] lvi = new ListViewItem[ticketList.Count];
            for (int i = 0; i < ticketList.Count; i++)
            {
                string[] subList = new string[4];
                for (int j = 0; j <= 3; j++)
                    subList[j] = ticketList[i][j].ToString();
                lvi[i] = new ListViewItem(subList);
            }
            lvTicketInfo.Items.AddRange(lvi);
        }
    }
}
