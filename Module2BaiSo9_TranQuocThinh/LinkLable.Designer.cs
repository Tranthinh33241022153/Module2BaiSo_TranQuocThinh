namespace Module2BaiSo9_TranQuocThinh
{
    partial class LinkLable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnkPrograms = new System.Windows.Forms.LinkLabel();
            this.lnkWinForms = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkPrograms
            // 
            this.lnkPrograms.AutoSize = true;
            this.lnkPrograms.Location = new System.Drawing.Point(89, 122);
            this.lnkPrograms.Name = "lnkPrograms";
            this.lnkPrograms.Size = new System.Drawing.Size(55, 13);
            this.lnkPrograms.TabIndex = 1;
            this.lnkPrograms.TabStop = true;
            this.lnkPrograms.Text = "linkLabel1";
            this.lnkPrograms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPrograms_LinkClicked);
            // 
            // lnkWinForms
            // 
            this.lnkWinForms.AutoSize = true;
            this.lnkWinForms.Location = new System.Drawing.Point(92, 68);
            this.lnkWinForms.Name = "lnkWinForms";
            this.lnkWinForms.Size = new System.Drawing.Size(149, 13);
            this.lnkWinForms.TabIndex = 0;
            this.lnkWinForms.TabStop = true;
            this.lnkWinForms.Text = "http://www.windowsforms.net";
            this.lnkWinForms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWinForms_LinkClicked);
            // 
            // LinkLable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 219);
            this.Controls.Add(this.lnkWinForms);
            this.Controls.Add(this.lnkPrograms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LinkLable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StepByStep2_7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkPrograms;
        private System.Windows.Forms.LinkLabel lnkWinForms;
    }
}

