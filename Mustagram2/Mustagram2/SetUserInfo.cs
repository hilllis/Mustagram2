using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustagram2
{
    public partial class SetUserInfo : Form
    {
        private string birth;
        private char sex;
        private string intro;
        private string Name;
        public SetUserInfo()
        {
            InitializeComponent();
           // dateTimePicker1.Format = "yyyyMMdd";
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            birth = dateTimePicker1.Value.ToString("yyyyMMdd");
            if (radioButton1.Checked == true)
            {
                sex = 'm';
            }
            else if(radioButton2.Checked==true)
            {
                sex = 'f';
            }
            Name = txtName.Text.ToString();
            intro = txtboxIntro.Text.ToString();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.label4_Click(sender, e);        
        }
    }
}
