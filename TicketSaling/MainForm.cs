using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSaling.AccountManagement;
using TicketSaling.CarriageManagement;
using TicketSaling.TicketManagement;

namespace TicketSaling
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 新建账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccountForm naf = new NewAccountForm();
            naf.ShowDialog();
        }

        private void 删除账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelAccountForm daf = new DelAccountForm();
            daf.ShowDialog();
        }

        private void 权限分配ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoleForm mrf = new ManageRoleForm();
            mrf.ShowDialog();
        }

        private void btnAccList_Click(object sender, EventArgs e)
        {
            lvComplex.Clear();
            lvComplex.ShowGroups = false;
            AccountCtrl ac = new AccountCtrl();
            gbLvName.Text = "信息视图-账号列表";
            lvComplex.Columns.Add("帐户名", 120, HorizontalAlignment.Left);
            lvComplex.Columns.Add("账户密码", 120, HorizontalAlignment.Left);
            lvComplex.Columns.Add("账户角色", 120, HorizontalAlignment.Left);
            List<object[]> accList = ac.loadAccount();
            for(int i=0;i<accList.Count;i++)
            {
                accList[i][2]=ac.serachRoleName(accList[i][2].ToString());                
            }
            ListViewItem[] lvi = new ListViewItem[accList.Count];
            for(int i=0;i<accList.Count;i++)
            {
                string[] subList = new string[3];
                for (int j=0; j <= 2; j++)
                    subList[j] = (string)accList[i][j];
                lvi[i] = new ListViewItem(subList);
            }
            lvComplex.Items.AddRange(lvi);
        }

        private void btnRoleList_Click(object sender, EventArgs e)
        {
            lvComplex.Clear();
            lvComplex.ShowGroups = false;
            AccountCtrl ac = new AccountCtrl();
            gbLvName.Text = "信息视图-角色列表";
            lvComplex.Columns.Add("权限名", 120, HorizontalAlignment.Left);
            lvComplex.Columns.Add("角色名", 120, HorizontalAlignment.Left);
            List<object[]> roleList = ac.loadRoleRight();
            ListViewItem[] lvi = new ListViewItem[roleList.Count];
            for (int i = 0; i < roleList.Count; i++)
            {
                string[] subList = new string[2];
                for (int j = 1; j >= 0; j--)
                    subList[j] = (string)roleList[i][j];
                lvi[i] = new ListViewItem(subList);
            }
            lvComplex.Items.AddRange(lvi);
        }

        private void btnRightList_Click(object sender, EventArgs e)
        {
            lvComplex.Clear();
            lvComplex.ShowGroups = false;
            AccountCtrl ac = new AccountCtrl();
            gbLvName.Text = "信息视图-权限列表";
            lvComplex.Columns.Add("权限ID", 120, HorizontalAlignment.Left);
            lvComplex.Columns.Add("权限名", 120, HorizontalAlignment.Left);
            List<object[]> rightList = ac.loadRight();
            ListViewItem[] lvi = new ListViewItem[rightList.Count];
            for (int i = 0; i < rightList.Count; i++)
            {
                string[] subList = new string[2];
                for (int j = 0; j <= 1; j++)
                    subList[j] = rightList[i][j].ToString();
                lvi[i] = new ListViewItem(subList);
            }
            lvComplex.Items.AddRange(lvi);
        }

        private void 车厢型号管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCarriageForm mcf = new ManageCarriageForm();
            mcf.ShowDialog();
        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            lvComplex.Clear();
            lvComplex.ShowGroups = false;
            CarriageCtrl ac = new CarriageCtrl();
            gbLvName.Text = "信息视图-车厢列表";
            lvComplex.Columns.Add("车厢型号", 120, HorizontalAlignment.Left);
            lvComplex.Columns.Add("车厢容量", 120, HorizontalAlignment.Left);
            lvComplex.Columns.Add("每排席位数", 120, HorizontalAlignment.Left);
            List<object[]> carList = ac.loadCarriage();
            ListViewItem[] lvi = new ListViewItem[carList.Count];
            for (int i = 0; i < carList.Count; i++)
            {
                string[] subList = new string[3];
                for (int j = 0; j <= 2; j++)
                    subList[j] = carList[i][j].ToString();
                lvi[i] = new ListViewItem(subList);
            }
            lvComplex.Items.AddRange(lvi);
        }

        private void 车组方式管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTrainForm mft = new ManageTrainForm();
            mft.ShowDialog();
        }

        private void btnTrainList_Click(object sender, EventArgs e)
        {
            lvComplex.Clear();
            TrainCtrl tc = new TrainCtrl();
            gbLvName.Text = "信息视图-车组列表";
            lvComplex.Columns.Add("车组名称", 120, HorizontalAlignment.Left);
            lvComplex.Columns.Add("车厢类型", 120, HorizontalAlignment.Left);
            lvComplex.Columns.Add("车厢节数", 120, HorizontalAlignment.Left);
            lvComplex.Columns.Add("容量", 120, HorizontalAlignment.Left);
            List<object[]> nameList = tc.loadVolume();
            for (int k = 0; k < nameList.Count; k++)
            {
                ListViewGroup lvg = new ListViewGroup();
                lvg.Header = nameList[k][0].ToString()+"  总容量  "+ nameList[k][1].ToString();
                lvComplex.Groups.Add(lvg);
                lvComplex.ShowGroups = true;
                List<object[]> trainList = tc.loadTrain(nameList[k][0].ToString());
                ListViewItem[] lvi = new ListViewItem[trainList.Count];
                for (int i = 0; i < trainList.Count; i++)
                {
                    string[] subList = new string[4];
                    for (int j = 0; j <= 3; j++)
                        subList[j] = trainList[i][j].ToString();
                    lvi[i] = new ListViewItem(subList);
                    lvg.Items.Add(lvi[i]);
                }
                lvComplex.Items.AddRange(lvi);
            }
        }

        private void 车次管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTimetableForm mtf = new ManageTimetableForm();
            mtf.ShowDialog();
        }

        private void btnTimeList_Click(object sender, EventArgs e)
        {
            lvComplex.Clear();
            lvComplex.ShowGroups = false;
            TimetableCtrl ttc = new TimetableCtrl();
            TrainCtrl tc = new TrainCtrl();
            TicketCtrl tkc = new TicketCtrl();
            gbLvName.Text = "信息视图-车次列表";
            lvComplex.Columns.Add("车次", 90, HorizontalAlignment.Left);
            lvComplex.Columns.Add("车组方式", 60, HorizontalAlignment.Left);
            lvComplex.Columns.Add("始发站", 90, HorizontalAlignment.Left);
            lvComplex.Columns.Add("到达站", 90, HorizontalAlignment.Left);
            lvComplex.Columns.Add("发车时间", 120, HorizontalAlignment.Left);
            lvComplex.Columns.Add("运行时长", 90, HorizontalAlignment.Left);
            lvComplex.Columns.Add("票价", 60, HorizontalAlignment.Left);
            lvComplex.Columns.Add("余票", 60, HorizontalAlignment.Left);
            List<object[]> timeList = ttc.loadTimetable();
            ListViewItem[] lvi = new ListViewItem[timeList.Count];
            for (int i = 0; i < timeList.Count; i++)
            {
                List<object[]> ListTrain = tc.loadTrainSum(timeList[i][1].ToString());
                int sold = tkc.serachTicketFromTimeId(timeList[i][0].ToString()).Count;
                string remain = (int.Parse(ListTrain[0][0].ToString()) - sold).ToString();
                string[] subList = new string[8];
                for (int j = 0; j <= 6; j++)
                    subList[j] = timeList[i][j].ToString();
                subList[7] = remain;
                lvi[i] = new ListViewItem(subList);
            }
            lvComplex.Items.AddRange(lvi);
        }

        private void 购票ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewTicketForm ntf = new NewTicketForm();
            ntf.ShowDialog();
        }

        private void 退票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelAccountForm daf = new DelAccountForm();
            daf.ShowDialog();
        }

        private void 售出票查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemainForm rf = new RemainForm();
            rf.ShowDialog();
        }
        private void unVisibleForm()
        {
            msMain.Visible = false;
            gbLvName.Visible = false;
            gbAcc.Visible = false;
            gbCar.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            unVisibleForm();
            lf.ShowDialog();
            if (!lf.isValid)
            {
                lf.Close();
                this.Close();
            }
            else
            {
                string acc = lf.acc;
                string pwd = lf.pwd;
                AccountCtrl ac = new AccountCtrl();
                string[] rightID=ac.serachAccount(acc, pwd);
                if (rightID == null)
                {
                    MessageBox.Show("账号密码错误，或账号不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
                initInterface(rightID);
            }
        }
        private void initInterface(string[] rightID)
        {
            if(rightID.Contains("1"))
            {
                msMain.Visible = true;
                gbLvName.Visible = true;
                gbAcc.Visible = true;
                gbCar.Visible = true;
                权限系统ToolStripMenuItem.Visible = true;
                车次信息管理ToolStripMenuItem.Visible = true;
                车厢型号管理ToolStripMenuItem.Visible = true;
                车组方式管理ToolStripMenuItem.Visible = true;
                车次管理ToolStripMenuItem.Visible = true;
                票务管理ToolStripMenuItem.Visible = true;
                购票ToolStripMenuItem.Visible = true;
                退票ToolStripMenuItem.Visible = true;
                售出票查询ToolStripMenuItem.Visible = true;
                btnCarList.Enabled = true;
                btnTrainList.Enabled = true;
                btnTimeList.Enabled = true;
            }
            if (rightID.Contains("2"))
            {
                msMain.Visible = true;
                gbLvName.Visible = true;
                gbAcc.Visible = true;
                权限系统ToolStripMenuItem.Visible = true;
            }
            if (rightID.Contains("3"))
            {
                msMain.Visible = true;
                gbLvName.Visible = true;
                gbCar.Visible = true;
                车次信息管理ToolStripMenuItem.Visible = true;
                车厢型号管理ToolStripMenuItem.Visible = true;
                btnCarList.Enabled = true;
            }
            if (rightID.Contains("4"))
            {
                msMain.Visible = true;
                gbLvName.Visible = true;
                gbCar.Visible = true;
                车次信息管理ToolStripMenuItem.Visible = true;
                车组方式管理ToolStripMenuItem.Visible = true;
                btnTrainList.Enabled = true;
            }
            if (rightID.Contains("5"))
            {
                msMain.Visible = true;
                gbLvName.Visible = true;
                gbCar.Visible = true;
                车次信息管理ToolStripMenuItem.Visible = true;
                车次管理ToolStripMenuItem.Visible = true;
                btnTimeList.Enabled = true;
            }
            if (rightID.Contains("6"))
            {
                msMain.Visible = true;
                票务管理ToolStripMenuItem.Visible = true;
                购票ToolStripMenuItem.Visible = true;
            }
            if (rightID.Contains("7"))
            {
                msMain.Visible = true;
                票务管理ToolStripMenuItem.Visible = true;
                退票ToolStripMenuItem.Visible = true;
            }
            if (rightID.Contains("8"))
            {
                msMain.Visible = true;
                gbLvName.Visible = true;
                gbCar.Visible = true;
                票务管理ToolStripMenuItem.Visible = true;
                售出票查询ToolStripMenuItem.Visible = true;
                btnCarList.Enabled = true;
                btnTrainList.Enabled = true;
                btnTimeList.Enabled = true;
            }
        }
    }
}
