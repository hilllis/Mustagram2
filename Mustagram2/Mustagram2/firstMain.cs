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

namespace Mustagram2
{
    public partial class firstMain : UserControl
    {
        MustagramClient client = MustagramClient.GetClient();
        Set_User setuser = Set_User.SetUser();
        MainDisplay maindisplay;
        List<Post> postList;
        int listCount = 0;
        int listIndex = 0;
        public listItem[] LT;
        public string[] U_ID;

        public firstMain(MainDisplay maindisplay)
        {
            InitializeComponent();
            this.maindisplay = maindisplay;
            string User_ID = setuser.getUser_id();

            Func<Task> runAsync = async () =>
           {
               try
               {
                   postList = await client.GetFriendsPost(User_ID).ConfigureAwait(false);
                   Console.WriteLine(User_ID);
                   Console.WriteLine(postList.Count);
                   listCount = postList.Count();
                   U_ID = new string[listCount];
                   int j = 0;
                   if (listCount > 0)
                   {
                       outsider = false;
                       foreach (var postItem in postList)
                       {
                           Console.WriteLine(postItem.userNumber);

                           U_ID[j] = (await client.GetUserID(postItem.userNumber).ConfigureAwait(false));
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

            if (outsider)
            {
                
                LT[i] = new listItem(maindisplay);
                LT[i].Name = U_ID[i];
                LT[i].Imagebox = Resources.jisu;
                LT[i].MainImage = LT[i].LP[0].Image_main;
                LT[i].Music_name= "러블리즈_Sweet Dream.mp3";
                LT[i].time = postItem.time;
                LT[i].Message = postItem.content;
                i++;
                if (flowLayoutPanel1.Controls.Count < 0)
                Console.WriteLine("OutSider!");
            }

            else
            {
                LT = new listItem[listCount];
                this.flowLayoutPanel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseWheel);
                int i = 0;
                foreach (var postItem in postList)
                {

                    LT[i] = new listItem(this);
                    LT[i].Name = U_ID[i];
                    LT[i].Imagebox = Resources.jisu;
                    LT[i].MainImage = LT[i].LP[0].Image_main;
                    LT[i].Music_name = "러블리즈_Sweet Dream.mp3";
                    LT[i].time = postItem.time;
                    LT[i].Message = postItem.content;
                    i++;
                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    Console.WriteLine("lovelz");
                }
                flowLayoutPanel1.Controls.Add(LT[0]);
            }
        }

        private void flowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Delta > 0)
            {
                if (LT[listIndex].player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    LT[listIndex].player.controls.stop();
                }
                if (listIndex > 0)
                {
                    listIndex -= 1;
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(LT[listIndex]);

                }
            }
            else
            {
                if (LT[listIndex].player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    LT[listIndex].player.controls.stop();
                }
                if (listIndex < listCount - 1)
                {
                    listIndex += 1;
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(LT[listIndex]);
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

        private void exit_Click_1(object sender, EventArgs e)
        {
            if (LT[listIndex].player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                LT[listIndex].player.controls.stop();
            }
            MainDisplay.ActiveForm.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
