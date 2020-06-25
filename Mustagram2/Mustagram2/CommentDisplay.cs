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

namespace Mustagram2
{
    public partial class CommentDisplay : UserControl
    {
        MainDisplay md;
        comment_list[] c_list = new comment_list[5];
        public CommentDisplay(MainDisplay md)
        {
            this.md = md;
            InitializeComponent();
            Console.WriteLine("commendisplay");
            for (int i = 0; i < c_list.Length; i++)
            {
                c_list[i] = new comment_list();
                c_list[i].Name = "Seo Jisu" + i.ToString();
                c_list[i].Imagebox= Resources.jisu;
                c_list[i].Comment = "check" + i;
;                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                flowLayoutPanel1.Controls.Add(c_list[i]);

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            md.commentdisplay_off();
        }
    }
}
