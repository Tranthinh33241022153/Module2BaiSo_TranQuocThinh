using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Module2BaiSo8_TranQuocThinh
{
    public partial class frmCalulator : Form
    {
        // Biến để theo dõi trạng thái hợp lệ của từng trường nhập liệu
        private bool isInput1Valid = false;
        private bool isInput2Valid = false;
        public frmCalulator()
        {
            InitializeComponent();
        }


        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    bool flag = false;
        //    Control control = (Control)sender;
        //    if (control.Text.Length > 0 && !Char.IsDigit(control.Text[control.Text.Length - 1]))
        //    {
        //        this.errorProvider1.SetError(control, "This field is required");
        //        flag = true;
        //    }
        //    else
        //    {
        //        this.errorProvider1.Clear();
                
        //    }
        //    if (!flag)
        //    {
        //        btnTinh.Enabled = true;
        //    }

        //}

        private void btnTinh_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            double a;
            double.TryParse(txtA.Text, out a);
            double b;
            double.TryParse(txtB.Text, out b);
            if (a == 0)
            {
                lblNghiemPT.Text = "Phương trình vô nghiệm";
            }
            else
            {
                lblNghiemPT.Text = (a/b).ToString();
            }
        }

        private void txtA_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập dữ liệu");
                isInput1Valid = false;
            }
            else if (!IsValidNumber(txtA.Text))
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập số hợp lệ");
                isInput1Valid = false;
            }
            else
            {
                errorProvider1.SetError(txtA, ""); // Xóa thông báo lỗi nếu hợp lệ
                isInput1Valid = true;
            }
            UpdateButtonStates(); // Cập nhật trạng thái nút
        }

        private void UpdateButtonStates()
        {
            // Nút Tính chỉ được kích hoạt khi cả hai trường đều hợp lệ
            btnTinh.Enabled = isInput1Valid && isInput2Valid;
            
        }

     

        private void txtB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtB.Text))
            {
                errorProvider1.SetError(txtB, "Vui lòng nhập dữ liệu");
                isInput2Valid = false;
            }
            else if (!IsValidNumber(txtB.Text))
            {
                errorProvider1.SetError(txtB, "Vui lòng nhập số hợp lệ");
                isInput2Valid = false;
            }
            else
            {
                errorProvider1.SetError(txtB, ""); // Xóa thông báo lỗi nếu hợp lệ
                isInput2Valid = true;
            }
            UpdateButtonStates(); // Cập nhật trạng thái nút
        }
        private bool IsValidNumber(string text)
        {
            return double.TryParse(text, out _);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtB.Clear();
            txtA.Clear();
            lblNghiemPT.Text = "";
            txtA.Focus();
            btnXoa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng không?","Xác nhận thoát",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
               
                this.Close();
            }
        }
    }
}
