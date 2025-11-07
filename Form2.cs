using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2
{
    public partial class Form2 : Form
    {
        private Form1 prevform;
 
        public Form2(Form1 prev)
        {
            InitializeComponent();
            prevform = prev;
            this.Shown += Form2_Shown;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtname2.Text = prevform.name;
            //جنسیت
            if (prevform.gender)
                txtgender.Text = "زن";
            else
                txtgender.Text = "مرد";
            //تاهل
            if (prevform.marital)
                txtmarital.Text = "متاهل";
            else
                txtmarital.Text = "مجرد";
            //تصویر کاربر
            picuser2.ImageLocation = prevform.piclocation;

        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            prevform.Close();
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
