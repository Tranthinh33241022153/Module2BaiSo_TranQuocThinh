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

namespace Module2BaiSo6_TranQuocThinh
{
    public partial class frmMessageFormater : Form
    {
        public frmMessageFormater()
        {
            InitializeComponent();
            txtName.TabIndex = 0;
            KeyPreview = true;
            toolTip1.SetToolTip(picBig, "Click Me");
            toolTip1.SetToolTip(picSmall, "Click Me");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + ": " + txtMessage.Text;
        }

        private void frmMessageFormater_KeyDown(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode;
            if (key == Keys.Enter)
                btnDisplay.PerformClick();
        }

        private void raddo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            // Chỉ xử lý khi RadioButton được chọn (Checked = true)
            if (r.Checked)
            {
                switch (r.Name)
                {
                    case "radRed":
                        lblMessage.ForeColor = Color.Red;
                        break;
                    case "radGreen":
                        lblMessage.ForeColor = Color.Green;
                        break;
                    case "radBlue":
                        lblMessage.ForeColor = Color.Blue;
                        break;
                    case "radBlack":
                        lblMessage.ForeColor = Color.Black;
                        break;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtMessage.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkVisible.Checked;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picSmall.Visible = false;
            picBig.Visible = true;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }
    }
}
