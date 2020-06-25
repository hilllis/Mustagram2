using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mustagram2.Properties;
using System.Runtime.InteropServices;
using WMPLib;
using static Mustagram2.MustagramClient;
using System.Runtime.CompilerServices;

namespace Mustagram2
{
    public partial class firstMain : UserControl
    {
        MustagramClient client = MustagramClient.GetClient();
        Set_User setuser = Set_User.SetUser();
        MainDisplay maindisplay;
        List<Post> postList;
        List<listItem> Lt = new List<listItem>();
        string img_path = "http://ec2-18-191-128-120.us-east-2.compute.amazonaws.com:3000/images/";
        string music_path = "http://ec2-18-191-128-120.us-east-2.compute.amazonaws.com:3000/music/";
        string profile = "http://ec2-18-191-128-120.us-east-2.compute.amazonaws.com:3000/profile/";
        int listCount = 0;
        int listIndex = 0;
        public int[] post_Like;
        public listItem lt;
        public string[] U_ID;
        bool outsider = true;

        public firstMain(MainDisplay maindisplay)
        {
            InitializeComponent();
            this.maindisplay = maindisplay;
            this.update();


        }

        private void flowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Delta > 0)
            {
                if (Lt[listIndex].player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    Lt[listIndex].player.controls.stop();
                }
                if (listIndex > 0)
                {
                    listIndex -= 1;
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(Lt[listIndex]);
                    Console.WriteLine(Lt[listIndex].postnumber);
                }
            }
            else
            {
                if (Lt[listIndex].player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    Lt[listIndex].player.controls.stop();
                }
                if (listIndex < listCount - 1)
                {
                    listIndex += 1;
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(Lt[listIndex]);
                    Console.WriteLine(Lt[listIndex].postnumber);
                }


            }
        }
        public void test()
        {
            Console.WriteLine("tetr");
        }

        private void exit_Click(object sender, EventArgs e)
        {


        }
        public void update()
        {
            string User_ID = setuser.getUser_id();
            postList = new List<Post>();
            Func<Task> runAsync = async () =>
            {
                try
                {
                    postList = await client.GetFriendsPost(User_ID).ConfigureAwait(false);
                    Console.WriteLine(User_ID);
                    Console.WriteLine(postList.Count);
                    listCount = postList.Count();
                    U_ID = new string[listCount];
                    post_Like = new int[listCount];

                    int j = 0;
                    if (listCount > 0)
                    {
                        outsider = false;
                        foreach (var postItem in postList)
                        {
                           

                            U_ID[j] = (await client.GetUserID(postItem.userNumber).ConfigureAwait(false));
                            post_Like[j] = (await client.GetPostLike(postItem.postNumber).ConfigureAwait(false));

                            j++;
                        }
                    }
                }
                catch (Exception q)
                {
                    Console.WriteLine(q.Message);
                }
            };
            runAsync().GetAwaiter().GetResult();
            int i = 0;
            if (outsider)
            {
                Console.WriteLine("OutSider!");
            }

            else
            {

                this.flowLayoutPanel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseWheel);

                foreach (var postItem in postList)
                {
                    this.lt = new listItem(maindisplay);
                    string pro_img=profile+ U_ID[i]+".jpg";
                    string main_img = img_path;
                    string mpath = music_path;
                    lt.Name = U_ID[i];
                    lt.postnumber = postItem.postNumber;
                    main_img += postItem.postNumber.ToString() + ".jpg";
                    mpath += postItem.postNumber.ToString() + ".mp3";
                    lt.Imagebox = pro_img;
   
                    lt.MainImage = main_img;
                    lt.Music_name = mpath;

                    lt.time = postItem.time;
                    lt.Message = postItem.content;
                    lt.P_like = post_Like[i].ToString();
                    Lt.Add(lt);

                    i++;
                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }

                }
                flowLayoutPanel1.Controls.Add(Lt[0]);
            }
        }
        private void exit_Click_1(object sender, EventArgs e)
        {
            if (Lt[listIndex].player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Lt[listIndex].player.controls.stop();
            }
            MainDisplay.ActiveForm.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}