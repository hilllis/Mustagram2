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
using static Mustagram2.MustagramClient;
using System.Collections.Generic;

namespace Mustagram2
{
    public partial class CommentDisplay : UserControl
    {
        MustagramClient client = MustagramClient.GetClient();
        Set_User setuser = Set_User.SetUser();
        MainDisplay md;
        int postnumber;
        List<Comment> CommentList;
        public string[] U_ID;
        bool isEmpty = true;
        int commentCount;

        public CommentDisplay(MainDisplay md, int postnumber)
        {
            InitializeComponent();
            this.md = md;
            this.postnumber = postnumber;
            udate_comment();
        }
        public void udate_comment()
        {
            CommentList = new List<Comment>();
            Func<Task> runAsync = async () =>
            {
                try
                {
                    Console.WriteLine(postnumber);
                    CommentList = await client.GetComments(postnumber).ConfigureAwait(false);
                    Console.WriteLine("Check!IT!");
                    commentCount = CommentList.Count();
                    Console.WriteLine("check1");
                    U_ID = new string[commentCount];
                    if (commentCount > 0)
                    {
                        Console.WriteLine("hello2");
                        isEmpty = false;
                    }
                    int i = 0;
                    foreach (var commentItem2 in CommentList)
                    {
                        Console.WriteLine("hello1");
                        U_ID[i] = await client.GetUserID(commentItem2.userNumber).ConfigureAwait(false);
                        i++;
                    }
                }
                catch (Exception q)
                {
                    Console.WriteLine(q.Message);
                }
            };
            runAsync().GetAwaiter().GetResult();
            flowLayoutPanel1.Controls.Clear();
            if (!isEmpty)
            {
                int i = 0;
                foreach (var commentItem in CommentList)
                {
                    Console.WriteLine("hello1");
                    comment_list[] c_list = new comment_list[commentCount];

                    c_list[i] = new comment_list();
                    c_list[i].Comment = commentItem.content;
                    c_list[i].Name = U_ID[i];
                    c_list[i].CommentNum = commentItem.commentNumber;
                    c_list[i].Imagebox = Resources.jisu;

                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    flowLayoutPanel1.Controls.Add(c_list[i]);
                    i++;
                }

                Console.WriteLine("commendisplay");
            }
            else
            {
                Console.WriteLine("Is Empty!");
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            md.commentdisplay_off();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string comment = txtcomment.Text;
            string user_id = setuser.getUser_id();
            Func<Task> runAsync = async () =>
            {
                try
                {
                    if (await client.CreateComment(user_id, postnumber, comment).ConfigureAwait(false))
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                catch (Exception q)
                {
                    Console.WriteLine(q.Message);
                }
            };
            runAsync().GetAwaiter().GetResult();
            txtcomment.Text = "";
            udate_comment();
        }
    }
}