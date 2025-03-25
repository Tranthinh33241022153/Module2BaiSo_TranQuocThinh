using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo7_TranQuocThinh
{
    public partial class frmLight : Form
    {
        public frmLight()
        {
            InitializeComponent();
            lblNotify.Text = "Jack. Turn OFF the Light, please!";
        }

        private void picTurnOn_Click(object sender, EventArgs e)
        {
            picTurnOff.Visible = true;
            picTurnOn.Visible = false;
            lblNotify.Text = "Jack. Turn ON the Light, please!";
        }

        private void picTurnOff_Click(object sender, EventArgs e)
        {
            picTurnOff.Visible = false;
            picTurnOn.Visible = true;
            lblNotify.Text = "Jack. Turn OFF the Light, please!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
