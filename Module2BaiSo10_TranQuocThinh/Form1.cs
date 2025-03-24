using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo10_TranQuocThinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrower_Click(object sender, EventArgs e)
        {
            // Tạo OpenFileDialog để chọn file hình ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (BMP, GIF, JPEG, etc.)|" + 
                "*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tif;*.tiff|" + "BMP Files (*.bmp)|*.bmp|" + 
                "GIF Files (*.gif)|*.gif|" + "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + 
                "PNG Files (*.png)|*.png|" + "TIF Files (*.tif;*.tiff)|*.tif;*.tiff|" + 
                "All Files (*.*)|*.*"; // Lọc các file hình ảnh
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Hiển thị hình ảnh trong PictureBox
                    pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog.FileName);

                    // Lấy thông tin file
                    FileInfo file = new FileInfo(openFileDialog.FileName);

                    // Hiển thị thông tin file
                    lblSize.Text = String.Format("File Size: {0} Bytes", file.Length.ToString()); 
                    lblDateModified.Text = String.Format("Date last modified: {0}", file.LastWriteTime.ToLongDateString()); 
                    lblDateAccessed.Text = String.Format("Date last accessed: {0}", file.LastAccessTime.ToLongDateString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
