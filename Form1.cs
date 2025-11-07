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
    public partial class Form1 : Form
    {
        public Boolean gender, marital; // men/single=false & women/married=true
        public string name , piclocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void rdbwomen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbwomen.Checked)
            {
                gender = true;
            }
        }

        private void rdbmen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbmen.Checked)
            {
                gender = false;
            }
        }

        private void rdbsingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbsingle.Checked)
            {
                marital = false;
            }
        }

        private void rdbmarried_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbmarried.Checked)
            {
                marital = true;
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            name = txtname.Text;
            if ((rdbmarried.Checked || rdbsingle.Checked) && (rdbmen.Checked || rdbwomen.Checked) && name.Length>0 && picuser.ImageLocation !="")
            {
                if(MessageBox.Show("کاربر " + name + " خوش آمدید ", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Form2 frm = new Form2(this);
                    frm.Show();
                    
                }
            }
            else
            {
                MessageBox.Show("اطلاعات خود را کامل کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnchoosepic_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "image|*.jpg;*.jpeg;*.png";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                picuser.ImageLocation = openFileDialog1.FileName;
                piclocation = openFileDialog1.FileName;
            }
        }
    }
}
