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
        private string sex;
        private string intro;
        private string Name;
        Set_User setuser = Set_User.SetUser();
        MustagramClient client = MustagramClient.GetClient();

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
            bool result = false;
            birth = dateTimePicker1.Value.ToString("yyyyMMdd");
            if (radioButton1.Checked == true)
            {
                sex = "m";
            }
            else if(radioButton2.Checked==true)
            {
                sex = "f";
            }
            Name = txtName.Text.ToString();
            intro = txtboxIntro.Text.ToString();
            Func<Task> runAsync = async () =>
            {
                try
                {
                    if (await client.SendUserPersonalInfo(setuser.getUser_id(), Name,sex,intro, birth).ConfigureAwait(false))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch (Exception q)
                {
                    Console.WriteLine(q.Message);
                }
            };
            runAsync().GetAwaiter().GetResult();
            if (result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.label4_Click(sender, e);        
        }

        private void txtboxIntro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
