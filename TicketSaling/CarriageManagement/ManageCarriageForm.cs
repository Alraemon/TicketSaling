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
    public partial class ManageCarriageForm : Form
    {
        public ManageCarriageForm()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Carriage car = new Carriage(tbCarTyp.Text, int.Parse(tbCarVol.Text), int.Parse(tbVolPerSec.Text));
            CarriageCtrl cc = new CarriageCtrl();
            cc.saveCarriage(car);
            this.Close();
        }

        private void btnDelCar_Click(object sender, EventArgs e)
        {
            CarriageCtrl cc = new CarriageCtrl();
            cc.delCarriage(tbCarTyp.Text);
            this.Close();
        }
    }
}
