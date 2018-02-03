using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSaling.CarriageManagement
{
    public partial class ManageTimetableForm : Form
    {
        public ManageTimetableForm()
        {
            InitializeComponent();
        }

        private void ManageTimetableForm_Load(object sender, EventArgs e)
        {
            TrainCtrl tc = new TrainCtrl();
            dtpTime.CustomFormat = "yyyy-MM-dd HH:mm";
            List<object[]> trainList = tc.loadTrainName();
            for(int i=0;i<trainList.Count;i++)
            {
                lbTrain.Items.Add(trainList[i][0]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            Timetable tt = new Timetable(tbID.Text, lbTrain.SelectedItem.ToString(), tbFrom.Text, tbTo.Text, dtpTime.Value.ToString(), nudHour.Value.ToString(), nudMinute.Value.ToString(),tbPrice.Text);
            TimetableCtrl ttc = new TimetableCtrl();
            ttc.saveTimetable(tt);
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            TimetableCtrl ttc = new TimetableCtrl();
            ttc.delTimetable(tbID.Text);
            this.Close();
        }
    }
}
