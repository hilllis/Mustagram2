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
    public partial class Log : UserControl
    {
        Log_list[] L_list = new Log_list[10];
        public Log()
        {
            InitializeComponent();
            for (int i = 0; i < L_list.Length; i++)
            {
                L_list[i] = new Log_list();
              //  L_list[i].Name = "Seo Jisu" + i.ToString();
               // L_list[i].Imagebox = Resources.jisu2;
               // L_list[i].MainImage = Resources.jisu2;
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                flowLayoutPanel1.Controls.Add(L_list[i]);

            }
         
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
