﻿using System;
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
        private void btnTinh_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            double a;
            double.TryParse(txtA.Text, out a);
            double b;
            double.TryParse(txtB.Text, out b);
            if (b == 0 & a!=0)
            {
                lblNghiemPT.Text = "Phương trình có nghiệm là 0.";
            }
            if (b == 0 && a == 0)
            {
                lblNghiemPT.Text = "Phương trình vô số nghiệm.";
            }
            else
            {
                lblNghiemPT.Text = (-b/a).ToString();
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
                errorProvider1.Clear(); // Xóa thông báo lỗi nếu hợp lệ
                isInput1Valid = true;
            }
            UpdateButtonStates(); // Cập nhật trạng thái nút
        }

        private void UpdateButtonStates()
        {
            // Nút Tính chỉ được kích hoạt khi cả hai trường đều hợp lệ
            if (isInput1Valid && isInput2Valid)
            {
                btnTinh.Enabled = true;
            }
            else
            {
                btnTinh.Enabled = false;
            }
            
            
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
                errorProvider1.Clear(); // Xóa thông báo lỗi nếu hợp lệ
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
            btnTinh.Enabled = false;
            //reset state 2 input
            isInput2Valid = false;
            isInput1Valid = false;
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
