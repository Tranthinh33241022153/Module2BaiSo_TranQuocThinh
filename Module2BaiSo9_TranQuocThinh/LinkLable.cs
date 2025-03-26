using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo9_TranQuocThinh
{
    public partial class LinkLable : Form
    {
        public LinkLable()
        {
            InitializeComponent();
            // Đặt văn bản cho LinkLabel
            lnkPrograms.Text = "Launch Calculator Open C: Drive";
            lnkWinForms.Text = "Windows Forms Community Website";
            // Thêm liên kết cho Calculator với đường dẫn đầy đủ
            lnkPrograms.Links.Add(0, "Launch Calculator".Length, "C:\\Windows\\System32\\calc.exe");
            // Thêm liên kết cho C: Drive
            lnkPrograms.Links.Add(lnkPrograms.Text.IndexOf("Open C: Drive"), "Open C: Drive".Length, "C:\\");
            // Đặt liên kết cho WinForms
            //lnkWinForms.Links.Add(0, lnkWinForms.Text.Length, "http://www.windowsforms.net");
            // Tự động điều chỉnh kích thước
            lnkPrograms.AutoSize = true;
        }

        private void lnkPrograms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Launch the program stored in the hyperlink
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void lnkWinForms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkWinForms.LinkVisited = true;
            // Mở URL trong trình duyệt mặc định của hệ thống
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "http://www.windowsforms.net",
                UseShellExecute = true  // mở URL trong trình duyệt mặc định
            });
        }
    }
}
