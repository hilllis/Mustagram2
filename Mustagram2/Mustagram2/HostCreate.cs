using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static Mustagram2.MustagramClient;
using System.Runtime.InteropServices;

namespace Mustagram2
{
    public partial class HostCreate : UserControl
    {
        Set_User setuser = Set_User.SetUser();
        MustagramClient client = MustagramClient.GetClient();
        string profiepath = "http://ec2-18-191-128-120.us-east-2.compute.amazonaws.com:3000/profile/";
        string imagepath;
        string musicpath;
        MainDisplay md;
        public HostCreate(MainDisplay md)
        {
            //profiepath += setuser.getUser_id() + ".jpg";
            this.md = md;
            InitializeComponent();
            //lvw_profile1.Load(profiepath);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files| *.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    musicpath = ofd.FileName;
           
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagepath = ofd.FileName;
                    pictureBox1.ImageLocation = ofd.FileName;
                    Console.WriteLine(imagepath);
                }
            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            label4_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            bool result = false;
            String comment = textBox1.Text.ToString();
            string User_ID = setuser.getUser_id();
            List<Post> postInfo = new List<Post>();
            int postNum=0;
            int postCount;
            Func<Task> runAsync = async () =>
            {
                try
                {
                    if (await client.CreatePost(setuser.getUser_id(), comment).ConfigureAwait(false))
                    {
                        postInfo = await client.GetMyPosts(User_ID).ConfigureAwait(false);
                        postCount = postInfo.Count();
                        postNum = postInfo[0].postNumber;
                        Console.WriteLine(postNum);
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                    if(await client.UploadImage(postNum, imagepath).ConfigureAwait(false))
                    {
                        Console.WriteLine("upload image O");
                    }
                    else
                    {
                        Console.WriteLine("upload image x");
                    }
                    if (await client.UploadMusic(postNum, musicpath).ConfigureAwait(false))
                    {
                        Console.WriteLine("upload musin O");
                    }
                    else
                    {
                        Console.WriteLine("upload musin x");
                    }
                }
                catch (Exception q)
                {
                    Console.WriteLine(q.Message);
                }
            };
            runAsync().GetAwaiter().GetResult();
            textBox1.Text = "";
            md.listRender();
        }
    }
}
