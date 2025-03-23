using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Module2Baiso4_TranQuocThinh
{
    public partial class frmChangeMoney : Form
    {
        public frmChangeMoney()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Length > 0 && !Char.IsDigit(control.Text[control.Text.Length - 1]))
            {
                this.errorProvider1.SetError(control, "This field is required");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnVNDtoUSD_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = getExchangeMoney(17861);

        }
        public bool checkDigital(object sender)
        {
            bool result = true;
            Control control = (Control)sender;
            if (control.Text.Length > 0 && !Char.IsDigit(control.Text[control.Text.Length - 1]))
            {
                result = false;
            }
            return result;
        }

        private void txtTiGia_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Length > 0 &&  !Char.IsDigit(control.Text[control.Text.Length - 1]))
            {
                this.errorProvider1.SetError(control, "This field must be a number!");
            }
            else
            {
                this.errorProvider1.Clear();
            }

        }

        private void btnVNDtoEUR_Click(object sender, EventArgs e)
        {
            //double money; ;
            //string moneyText = txtMoney.Text;
            //double rate;
            //string rateText = txtTiGia.Text;
            lblKetQua.Text = getExchangeMoney(27043);
        }

        //Chuyển đổi tiền theo tỉ giá
        private string getExchangeMoney(double rateConst)
        {
            double money; ;
            string moneyText = txtMoney.Text;
            // Thay dấu phẩy thành dấu chấm và thử lại
            moneyText = moneyText.Replace(',', '.');
            double rate;
            string rateText = txtTiGia.Text;
            rateText = rateText.Replace(',', '.');
            string result = "";
            if (double.TryParse(moneyText, NumberStyles.Any, CultureInfo.InvariantCulture, out money))  //Check double type
            {
                if (double.TryParse(rateText, NumberStyles.Any, CultureInfo.InvariantCulture, out rate))
                {
                    
                    result = Math.Round((Double)(money / rate),2).ToString();
                   
                }
                else if (string.IsNullOrEmpty(rateText) ) //nếu rate không điền thì lấy mặc định
                {
                    result   = Math.Round((Double)(money / rateConst),2).ToString();
                }
                else 
                    MessageBox.Show("Rate field must be a number!","Error", MessageBoxButtons.OK);


            }
            else
            {
                MessageBox.Show("Money field must be a number!", "Error",  MessageBoxButtons.OK);
            }

            return result;


        }

        private void btnUSDtoVND_Click(object sender, EventArgs e)
        {
            
            lblKetQua.Text = getExchangeMoney(1.0/17861);
        }

        private void btnEURtoVND_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = getExchangeMoney(1.0 / 27043);
        }

        private void frmChangeMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tắt chương trình không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }


        }
    }
}
