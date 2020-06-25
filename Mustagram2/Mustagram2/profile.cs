using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustagram2
{
    public partial class profile : UserControl
    {
        MustagramClient client = MustagramClient.GetClient();
        Set_User setuser = Set_User.SetUser();
        string path = "";
        string[] name;
        string imagepath = "http://ec2-18-191-128-120.us-east-2.compute.amazonaws.com:3000/profile/";
        public profile()
        {
            InitializeComponent();
            string User_ID = setuser.getUser_id();
            string userIntro = "";
            int numFollowing = 0;
            int numFollower = 0;
            pro_ID.Text = User_ID.ToString();
            profile_modified2.setProfile(this);
            Console.WriteLine(User_ID);
           //imagepath += User_ID + ".jpg";
            //lvw_profile1.Load(imagepath);
            Func<Task> runAsync = async () =>
            {
                try
                {
                    userIntro = await client.GetPersonalDescription(User_ID).ConfigureAwait(false);
                    numFollowing = await client.GetFollowingCounts(User_ID).ConfigureAwait(false);
                    numFollower = await client.GetFollowerCounts(User_ID).ConfigureAwait(false);
                }
                catch (Exception q)
                {
                    Console.WriteLine(q.Message);
                }
            };
            runAsync().GetAwaiter().GetResult();
         
            pro_Name.Text = userIntro.ToString();
            pro_follower.Text = numFollower.ToString();
            pro_following.Text = numFollowing.ToString();
         }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvw_profile1_Click(object sender, EventArgs e)
        {
            this.label4_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("DSsd");
            profile_modified2.Visible = true;
            //this.Controls.Add(pm);
        }
        public void setPath(string path)
        {
            this.path = path;
          name = this.path.Split('\\');
            Console.WriteLine(name[name.Length - 1]);
            imagepath = "http://ec2-18-191-128-120.us-east-2.compute.amazonaws.com:3000/profile/";
            imagepath += setuser.getUser_id() + ".jpg";


        }
        private void profile_modified2_VisibleChanged(object sender, EventArgs e)
        {
            string User_ID = setuser.getUser_id();
            string userIntro = "";
            int numFollowing = 0;
            int numFollower = 0;
         
            pro_ID.Text = User_ID.ToString();
            if (profile_modified1.Visible == false)
            {
         
                Func<Task> runAsync = async () =>
                {
                    try
                    {
                     
                        userIntro = await client.GetPersonalDescription(User_ID).ConfigureAwait(false);
                        numFollowing = await client.GetFollowingCounts(User_ID).ConfigureAwait(false);
                        numFollower = await client.GetFollowerCounts(User_ID).ConfigureAwait(false);
                    }
                    catch (Exception q)
                    {
                        Console.WriteLine(q.Message);
                    }
                };
                runAsync().GetAwaiter().GetResult();

                lvw_profile1.Load(imagepath);
                Console.WriteLine("visi {0}", userIntro.ToString());
                Console.WriteLine(imagepath);
           
                pro_Name.Text = userIntro.ToString();
                pro_follower.Text = numFollower.ToString();
                pro_following.Text = numFollowing.ToString();
            }
        }
    }
}
