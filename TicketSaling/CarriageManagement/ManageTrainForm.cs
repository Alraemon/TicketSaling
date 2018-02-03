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
    public partial class ManageTrainForm : Form
    {
        Train train = new Train();
        bool isInit = false;
        public ManageTrainForm()
        {
            InitializeComponent();
        }

        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            if (!isInit)
                train.addName(tbTrainName.Text);
            train.addType(lbCarTyp.SelectedItem.ToString(),tbCarNum.Text);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            TrainCtrl tc = new TrainCtrl();
            tc.saveTrain(train);
            this.Close();
        }

        private void btnDelTrain_Click(object sender, EventArgs e)
        {
            TrainCtrl tc = new TrainCtrl();
            tc.delTrain(tbTrainName.Text);
            this.Close();
        }

        private void ManageTrainForm_Load(object sender, EventArgs e)
        {
            CarriageCtrl cc = new CarriageCtrl();
            List<object[]> typeList = cc.loadCarriage();
            for(int i=0;i<typeList.Count;i++)
            {
                lbCarTyp.Items.Add(typeList[i][0]);
            }
        }
    }
}
