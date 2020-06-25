using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace Mustagram2
{
    public partial class profile_modified : UserControl
    {
        MustagramClient client = MustagramClient.GetClient();
        Set_User setuser = Set_User.SetUser();
        public profile prf;
        string path="";
        string imagepath = "http://ec2-18-191-128-120.us-east-2.compute.amazonaws.com:3000/profile/";
        public profile_modified()
        {
           // imagepath += setuser.getUser_id() + ".jpg";
          //  lvw_profile1.Load(imagepath);
            InitializeComponent();
        }
        public void setProfile(profile prf)
        {
            this.prf = prf;
        }

        private void ciclePicture1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                    Console.WriteLine(path);
                    lvw_profile1.ImageLocation = ofd.FileName;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            label4_Click(sender, e);
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            bool result=false;
            bool result2 = false;
            string intro = txtboxIntro.Text.ToString();
            Console.WriteLine(intro);
            Console.WriteLine(setuser.getUser_id());
            Func<Task> runAsync = async () =>
            {
                try
                {
                    if (path != "")
                    {
                        if (await client.UploadProfileImage(setuser.getUser_id(), path).ConfigureAwait(false))
                        {
                            Console.WriteLine("pictur ok");
                            result = true;
                        }
                        else
                        {
                            Console.WriteLine("pictur faile");
                            result = false;
                        }
                    }
                    if (await client.SendUserModifiedPersonalInfo(setuser.getUser_id(), intro).ConfigureAwait(false))
                    {
                        Console.WriteLine("intro ok");
                        result2 = true;
                    }
                    else
                    {
                        Console.WriteLine("intro faile");
                        result2 = false;
                    }

                }
                catch (Exception q)
                {
                    Console.WriteLine(q.Message);
                }
            };
            runAsync().GetAwaiter().GetResult();
            prf.setPath(path);
            Console.WriteLine("profile udate success {0}", path);
            this.Visible = false;
        }

        private void txtboxIntro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
