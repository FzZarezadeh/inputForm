namespace week2
{
    partial class Form1
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
            this.lblhint = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.grpmaritalstatus = new System.Windows.Forms.GroupBox();
            this.rdbmarried = new System.Windows.Forms.RadioButton();
            this.rdbsingle = new System.Windows.Forms.RadioButton();
            this.grpgender = new System.Windows.Forms.GroupBox();
            this.rdbmen = new System.Windows.Forms.RadioButton();
            this.rdbwomen = new System.Windows.Forms.RadioButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.picuser = new System.Windows.Forms.PictureBox();
            this.btnchoosepic = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpmaritalstatus.SuspendLayout();
            this.grpgender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhint
            // 
            this.lblhint.AutoSize = true;
            this.lblhint.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblhint.Location = new System.Drawing.Point(478, 38);
            this.lblhint.Name = "lblhint";
            this.lblhint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblhint.Size = new System.Drawing.Size(114, 35);
            this.lblhint.TabIndex = 0;
            this.lblhint.Text = "ورود اطلاعات";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblname.Location = new System.Drawing.Point(504, 88);
            this.lblname.Name = "lblname";
            this.lblname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblname.Size = new System.Drawing.Size(86, 21);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "نام و نام خانوادگی:";
            // 
            // grpmaritalstatus
            // 
            this.grpmaritalstatus.Controls.Add(this.rdbmarried);
            this.grpmaritalstatus.Controls.Add(this.rdbsingle);
            this.grpmaritalstatus.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpmaritalstatus.Location = new System.Drawing.Point(394, 282);
            this.grpmaritalstatus.Name = "grpmaritalstatus";
            this.grpmaritalstatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpmaritalstatus.Size = new System.Drawing.Size(200, 100);
            this.grpmaritalstatus.TabIndex = 2;
            this.grpmaritalstatus.TabStop = false;
            this.grpmaritalstatus.Text = "تاهل: ";
            // 
            // rdbmarried
            // 
            this.rdbmarried.AutoSize = true;
            this.rdbmarried.Location = new System.Drawing.Point(128, 63);
            this.rdbmarried.Name = "rdbmarried";
            this.rdbmarried.Size = new System.Drawing.Size(57, 25);
            this.rdbmarried.TabIndex = 1;
            this.rdbmarried.TabStop = true;
            this.rdbmarried.Text = "متاهل";
            this.rdbmarried.UseVisualStyleBackColor = true;
            this.rdbmarried.CheckedChanged += new System.EventHandler(this.rdbmarried_CheckedChanged);
            // 
            // rdbsingle
            // 
            this.rdbsingle.AutoSize = true;
            this.rdbsingle.Location = new System.Drawing.Point(131, 36);
            this.rdbsingle.Name = "rdbsingle";
            this.rdbsingle.Size = new System.Drawing.Size(54, 25);
            this.rdbsingle.TabIndex = 0;
            this.rdbsingle.TabStop = true;
            this.rdbsingle.Text = "مجرد";
            this.rdbsingle.UseVisualStyleBackColor = true;
            this.rdbsingle.CheckedChanged += new System.EventHandler(this.rdbsingle_CheckedChanged);
            // 
            // grpgender
            // 
            this.grpgender.Controls.Add(this.rdbmen);
            this.grpgender.Controls.Add(this.rdbwomen);
            this.grpgender.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpgender.Location = new System.Drawing.Point(394, 163);
            this.grpgender.Name = "grpgender";
            this.grpgender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpgender.Size = new System.Drawing.Size(200, 100);
            this.grpgender.TabIndex = 0;
            this.grpgender.TabStop = false;
            this.grpgender.Text = "جنسیت: ";
            // 
            // rdbmen
            // 
            this.rdbmen.AutoSize = true;
            this.rdbmen.Location = new System.Drawing.Point(140, 58);
            this.rdbmen.Name = "rdbmen";
            this.rdbmen.Size = new System.Drawing.Size(46, 25);
            this.rdbmen.TabIndex = 1;
            this.rdbmen.TabStop = true;
            this.rdbmen.Text = "مرد";
            this.rdbmen.UseVisualStyleBackColor = true;
            this.rdbmen.CheckedChanged += new System.EventHandler(this.rdbmen_CheckedChanged);
            // 
            // rdbwomen
            // 
            this.rdbwomen.AutoSize = true;
            this.rdbwomen.Location = new System.Drawing.Point(144, 36);
            this.rdbwomen.Name = "rdbwomen";
            this.rdbwomen.Size = new System.Drawing.Size(43, 25);
            this.rdbwomen.TabIndex = 0;
            this.rdbwomen.TabStop = true;
            this.rdbwomen.Text = "زن";
            this.rdbwomen.UseVisualStyleBackColor = true;
            this.rdbwomen.CheckedChanged += new System.EventHandler(this.rdbwomen_CheckedChanged);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.Location = new System.Drawing.Point(394, 119);
            this.txtname.MaxLength = 100;
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(200, 27);
            this.txtname.TabIndex = 3;
            // 
            // picuser
            // 
            this.picuser.Location = new System.Drawing.Point(43, 38);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(180, 204);
            this.picuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picuser.TabIndex = 4;
            this.picuser.TabStop = false;
            // 
            // btnchoosepic
            // 
            this.btnchoosepic.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnchoosepic.Location = new System.Drawing.Point(43, 259);
            this.btnchoosepic.Name = "btnchoosepic";
            this.btnchoosepic.Size = new System.Drawing.Size(180, 29);
            this.btnchoosepic.TabIndex = 5;
            this.btnchoosepic.Text = "انتخاب تصویر";
            this.btnchoosepic.UseVisualStyleBackColor = true;
            this.btnchoosepic.Click += new System.EventHandler(this.btnchoosepic_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.DarkGreen;
            this.btnsubmit.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsubmit.ForeColor = System.Drawing.Color.Transparent;
            this.btnsubmit.Location = new System.Drawing.Point(43, 345);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(92, 37);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "ثبت";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 415);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btnchoosepic);
            this.Controls.Add(this.picuser);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.grpgender);
            this.Controls.Add(this.grpmaritalstatus);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblhint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpmaritalstatus.ResumeLayout(false);
            this.grpmaritalstatus.PerformLayout();
            this.grpgender.ResumeLayout(false);
            this.grpgender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhint;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox grpmaritalstatus;
        private System.Windows.Forms.RadioButton rdbmarried;
        private System.Windows.Forms.RadioButton rdbsingle;
        private System.Windows.Forms.GroupBox grpgender;
        private System.Windows.Forms.RadioButton rdbmen;
        private System.Windows.Forms.RadioButton rdbwomen;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.PictureBox picuser;
        private System.Windows.Forms.Button btnchoosepic;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

