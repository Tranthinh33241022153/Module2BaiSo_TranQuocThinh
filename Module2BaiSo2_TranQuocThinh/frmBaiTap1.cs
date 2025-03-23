using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Module2BaiSo_TranQuocThinh
{
    public partial class frmBaiTap1 : Form
    {
        bool flag = false;
        public frmBaiTap1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (var ct in this.Controls)
            {
                if (ct.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)ct;
                    if (textBox.Text.Trim().Length <= 0)
                    {
                        errorProvider1.SetError(textBox, "Not allow empty");
                        flag = true;
                    }
                    //else if (textBox.Text.Trim().Length > 0)
                    //{
                    //    errorProvider1.Clear();
                    //}
                    else if (txtYear.Text.Trim().Length <= 0 && !double.TryParse(txtYear.Text, out double number))
                    {
                        errorProvider1.SetError(txtYear, "Year of birth must be a number!");
                        flag = true;
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                }
          
            }
          


            double year = DateTime.Now.Year;
            double.TryParse(txtYear.Text, out double bod);
            if (!flag)
            {
                {
                    if (bod < 0 || bod > year)
                    {
                        MessageBox.Show("Invalid year of birth.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"My name: {txtYourName.Text}. \nAge: {year - bod}", "", MessageBoxButtons.OK);
                    }
                }
            }
                   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tắt chương trình không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYear.Clear();
            txtYourName.Clear();
            txtYourName.Focus();
        }

        private void frmBaiTap1_Load(object sender, EventArgs e)
        {

        }

        private void frmBaiTap1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tắt chương trình không?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    this.Close();
            }
            
        }

        private void frmBaiTap1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tắt chương trình không?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    this.Close();
            }
        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox textBox = sender as TextBox;
                if (textBox.Text.Trim().Length <= 0)
                {
                    errorProvider1.SetError(txtYourName, "Your name cannot be empty.");
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Length > 0 && !Char.IsDigit(control.Text[control.Text.Length - 1]))
                this.errorProvider1.SetError(control, "This is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        private void txtYourName_TextChanged(object sender, EventArgs e)
        {
            Control control =  (Control) sender;
            if (control.Text.Length > 0 && !Char.IsDigit(control.Text[control.Text.Length - 1]))
            {
                this.errorProvider1.SetError(control, "This field is required");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
