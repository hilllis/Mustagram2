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
        public profile()
        {
            InitializeComponent();
            string User_ID = setuser.getUser_id();
            string userIntro = "";
            int numFollowing = 0;
            int numFollower = 0;
            pro_ID.Text = User_ID.ToString();
            Console.WriteLine(User_ID);
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
            profile_modified pm = new profile_modified();
            this.Controls.Add(pm);
        }
    }
}
