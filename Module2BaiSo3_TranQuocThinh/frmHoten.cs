using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo3_TranQuocThinh
{
    public partial class frmHoten : Form
    {
        public frmHoten()
        {
            InitializeComponent();
            KeyPreview = true;  // cho phép bắt sự kiện nút nhấn
        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            string holot = txtHo.Text;
            lblHoTen.Text = holot;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            string hoten = txtHo.Text + " " + txtTen.Text;
            lblHoTen.Text = hoten;
        }

        private void frmHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void frmHoten_KeyDown(object sender, KeyEventArgs e)
        {
            var pressBtn = e.KeyCode;
            if (pressBtn == Keys.Enter)
            {
                btnHoTen.PerformClick();
            }
            else if (pressBtn == Keys.Escape)
            {
                btnKetThuc.PerformClick();
            }

        }

        private void btnTen(object sender, EventArgs e)
        {
            String ten = txtTen.Text;
            lblHoTen.Text = ten;
        }

        private void lblHoTen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
