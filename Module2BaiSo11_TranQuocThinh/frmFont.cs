using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo11_TranQuocThinh
{
    public partial class frmFont : Form
    {
        public frmFont()
        {
            InitializeComponent();
            
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
                    case "raddTimeNRoman":
                        textFont.Font = new Font("Times New Roman", 26);
                        break;
                    case "raddArial":
                        textFont.Font = new Font("Arial", 26);
                        break;
                    case "raddTahoma":
                        textFont.Font = new Font("Tahoma", 26);
                        break;
                    case "raddCourierNew":
                        textFont.Font = new Font("Courier New", 26);

                        break;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
