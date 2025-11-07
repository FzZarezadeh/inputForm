namespace week2
{
    partial class Form2
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
            this.lblhint2 = new System.Windows.Forms.Label();
            this.lblname2 = new System.Windows.Forms.Label();
            this.lblmarital = new System.Windows.Forms.Label();
            this.picuser2 = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblgender = new System.Windows.Forms.Label();
            this.txtname2 = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txtmarital = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picuser2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhint2
            // 
            this.lblhint2.AutoSize = true;
            this.lblhint2.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblhint2.Location = new System.Drawing.Point(370, 33);
            this.lblhint2.Name = "lblhint2";
            this.lblhint2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblhint2.Size = new System.Drawing.Size(133, 35);
            this.lblhint2.TabIndex = 0;
            this.lblhint2.Text = "اطلاعات کاربری";
            // 
            // lblname2
            // 
            this.lblname2.AutoSize = true;
            this.lblname2.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblname2.Location = new System.Drawing.Point(395, 99);
            this.lblname2.Name = "lblname2";
            this.lblname2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblname2.Size = new System.Drawing.Size(107, 26);
            this.lblname2.TabIndex = 1;
            this.lblname2.Text = "نام و نام خانوادگی:";
            // 
            // lblmarital
            // 
            this.lblmarital.AutoSize = true;
            this.lblmarital.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblmarital.Location = new System.Drawing.Point(420, 172);
            this.lblmarital.Name = "lblmarital";
            this.lblmarital.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblmarital.Size = new System.Drawing.Size(82, 26);
            this.lblmarital.TabIndex = 2;
            this.lblmarital.Text = "وضعیت تاهل:";
            // 
            // picuser2
            // 
            this.picuser2.Location = new System.Drawing.Point(24, 33);
            this.picuser2.Name = "picuser2";
            this.picuser2.Size = new System.Drawing.Size(174, 202);
            this.picuser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picuser2.TabIndex = 3;
            this.picuser2.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexit.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexit.Location = new System.Drawing.Point(24, 358);
            this.btnexit.Name = "btnexit";
            this.btnexit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnexit.Size = new System.Drawing.Size(75, 37);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblgender.Location = new System.Drawing.Point(445, 134);
            this.lblgender.Name = "lblgender";
            this.lblgender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblgender.Size = new System.Drawing.Size(57, 26);
            this.lblgender.TabIndex = 5;
            this.lblgender.Text = "جنسیت:";
            // 
            // txtname2
            // 
            this.txtname2.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname2.Location = new System.Drawing.Point(275, 100);
            this.txtname2.Name = "txtname2";
            this.txtname2.ReadOnly = true;
            this.txtname2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname2.Size = new System.Drawing.Size(100, 27);
            this.txtname2.TabIndex = 6;
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtgender.Location = new System.Drawing.Point(275, 135);
            this.txtgender.Name = "txtgender";
            this.txtgender.ReadOnly = true;
            this.txtgender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtgender.Size = new System.Drawing.Size(100, 27);
            this.txtgender.TabIndex = 7;
            // 
            // txtmarital
            // 
            this.txtmarital.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtmarital.Location = new System.Drawing.Point(275, 173);
            this.txtmarital.Name = "txtmarital";
            this.txtmarital.ReadOnly = true;
            this.txtmarital.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmarital.Size = new System.Drawing.Size(100, 27);
            this.txtmarital.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(535, 407);
            this.Controls.Add(this.txtmarital);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtname2);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.picuser2);
            this.Controls.Add(this.lblmarital);
            this.Controls.Add(this.lblname2);
            this.Controls.Add(this.lblhint2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picuser2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhint2;
        private System.Windows.Forms.Label lblname2;
        private System.Windows.Forms.Label lblmarital;
        private System.Windows.Forms.PictureBox picuser2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.TextBox txtname2;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.TextBox txtmarital;
    }
}