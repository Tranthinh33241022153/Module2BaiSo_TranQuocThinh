namespace Module2BaiSo11_TranQuocThinh
{
    partial class frmFont
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
            this.textFont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raddTimeNRoman = new System.Windows.Forms.RadioButton();
            this.raddArial = new System.Windows.Forms.RadioButton();
            this.raddTahoma = new System.Windows.Forms.RadioButton();
            this.raddCourierNew = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFont
            // 
            this.textFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFont.ForeColor = System.Drawing.Color.Blue;
            this.textFont.Location = new System.Drawing.Point(55, 68);
            this.textFont.Multiline = true;
            this.textFont.Name = "textFont";
            this.textFont.Size = new System.Drawing.Size(205, 282);
            this.textFont.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập văn bản";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(151, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raddCourierNew);
            this.groupBox1.Controls.Add(this.raddTahoma);
            this.groupBox1.Controls.Add(this.raddArial);
            this.groupBox1.Controls.Add(this.raddTimeNRoman);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(308, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // raddTimeNRoman
            // 
            this.raddTimeNRoman.AutoSize = true;
            this.raddTimeNRoman.Location = new System.Drawing.Point(20, 37);
            this.raddTimeNRoman.Name = "raddTimeNRoman";
            this.raddTimeNRoman.Size = new System.Drawing.Size(110, 17);
            this.raddTimeNRoman.TabIndex = 0;
            this.raddTimeNRoman.Text = "Time New Roman";
            this.raddTimeNRoman.UseVisualStyleBackColor = true;
            this.raddTimeNRoman.CheckedChanged += new System.EventHandler(this.raddo_CheckedChanged);
            // 
            // raddArial
            // 
            this.raddArial.AutoSize = true;
            this.raddArial.Location = new System.Drawing.Point(20, 92);
            this.raddArial.Name = "raddArial";
            this.raddArial.Size = new System.Drawing.Size(45, 17);
            this.raddArial.TabIndex = 1;
            this.raddArial.Text = "Arial";
            this.raddArial.UseVisualStyleBackColor = true;
            this.raddArial.CheckedChanged += new System.EventHandler(this.raddo_CheckedChanged);
            // 
            // raddTahoma
            // 
            this.raddTahoma.AutoSize = true;
            this.raddTahoma.Checked = true;
            this.raddTahoma.Location = new System.Drawing.Point(20, 147);
            this.raddTahoma.Name = "raddTahoma";
            this.raddTahoma.Size = new System.Drawing.Size(64, 17);
            this.raddTahoma.TabIndex = 2;
            this.raddTahoma.TabStop = true;
            this.raddTahoma.Text = "Tahoma";
            this.raddTahoma.UseVisualStyleBackColor = true;
            this.raddTahoma.CheckedChanged += new System.EventHandler(this.raddo_CheckedChanged);
            // 
            // raddCourierNew
            // 
            this.raddCourierNew.AutoSize = true;
            this.raddCourierNew.Location = new System.Drawing.Point(20, 202);
            this.raddCourierNew.Name = "raddCourierNew";
            this.raddCourierNew.Size = new System.Drawing.Size(83, 17);
            this.raddCourierNew.TabIndex = 3;
            this.raddCourierNew.Text = "Courier New";
            this.raddCourierNew.UseVisualStyleBackColor = true;
            this.raddCourierNew.CheckedChanged += new System.EventHandler(this.raddo_CheckedChanged);
            // 
            // frmFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFont);
            this.Name = "frmFont";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFont";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton raddCourierNew;
        private System.Windows.Forms.RadioButton raddTahoma;
        private System.Windows.Forms.RadioButton raddArial;
        private System.Windows.Forms.RadioButton raddTimeNRoman;
    }
}

