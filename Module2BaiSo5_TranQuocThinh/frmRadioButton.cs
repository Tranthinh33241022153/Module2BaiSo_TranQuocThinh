using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo5_TranQuocThinh
{
    public partial class frmRadioButton : Form
    {
        public frmRadioButton()
        {
            InitializeComponent();
            txtNhapTen.TabIndex = 0;
            KeyPreview = true;  // cho phép bắt sự kiện nút nhấn
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        //Check color
        private void raddo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            // Chỉ xử lý khi RadioButton được chọn (Checked = true)
            if (r.Checked)
            {
                switch (r.Name)
                {
                    case "radioRed":
                        lblLapTrinh.ForeColor = Color.Red;
                        break;
                    case "radioGreen":
                        lblLapTrinh.ForeColor = Color.Green;
                        break;
                    case "radioBlue":
                        lblLapTrinh.ForeColor = Color.Blue;
                        break;
                    case "radioBlack":
                        lblLapTrinh.ForeColor = Color.Black;
                        break;
                }
            }
        }
        //check font
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style;

            // Trường hợp: Tích cả 3 ô
            if (chkBold.Checked && chkItalic.Checked && chkUnderline.Checked)
            {
                style = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
            }
            // Trường hợp: Tích 2 ô
            else if (chkBold.Checked && chkItalic.Checked)
            {
                style = FontStyle.Bold | FontStyle.Italic;
            }
            else if (chkBold.Checked && chkUnderline.Checked)
            {
                style = FontStyle.Bold | FontStyle.Underline;
            }
            else if (chkItalic.Checked && chkUnderline.Checked)
            {
                style = FontStyle.Italic | FontStyle.Underline;
            }
            // Trường hợp: Tích 1 ô
            else if (chkBold.Checked)
            {
                style = FontStyle.Bold;
            }
            else if (chkItalic.Checked)
            {
                style = FontStyle.Italic;
            }
            else if (chkUnderline.Checked)
            {
                style = FontStyle.Underline;
            }
            // Trường hợp: Không tích ô nào
            else
            {
                style = FontStyle.Regular;
            }

            lblLapTrinh.Font = new Font(lblLapTrinh.Font.FontFamily, lblLapTrinh.Font.Size, style);
        }

        private void frmRadioButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Gọi Close() để thoát, sẽ kích hoạt FormClosing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
