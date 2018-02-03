using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSaling.CarriageManagement;

namespace TicketSaling.TicketManagement
{
    public partial class NewTicketForm : Form
    {
        public NewTicketForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            TicketCtrl tc = new TicketCtrl();
            TimetableCtrl ttc = new TimetableCtrl();
            TrainCtrl trc = new TrainCtrl();
            string index = (tc.loadMaxId() + 1).ToString();
            Ticket t = new Ticket(index, tbName.Text, tbPassId.Text, lvTimetable.SelectedItems[0].Text.ToString());
            string trainName=ttc.loadTrainName(lvTimetable.SelectedItems[0].Text.ToString());
            if (tc.loadTicket().Count < int.Parse(trc.loadTrain(trainName)[0][3].ToString()))
            {
                tc.saveTicket(t);
                this.Close();
            }
            else
            {
                MessageBox.Show("该车次已售完", "购票失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewTicketForm_Load(object sender, EventArgs e)
        {
            TimetableCtrl ttc = new TimetableCtrl();
            List<object[]> timetable = ttc.loadTimetable();
            for(int i=0;i<timetable.Count;i++)
            {
                string[] subItem = new string[3];
                subItem[0] = timetable[i][0].ToString();
                subItem[1] = timetable[i][2].ToString();
                subItem[2] = timetable[i][3].ToString();
                ListViewItem lvi = new ListViewItem(subItem);
                lvTimetable.Items.Add(lvi);
            }
        }
    }
}
