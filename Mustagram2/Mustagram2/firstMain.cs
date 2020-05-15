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

namespace Mustagram2
{
    public partial class firstMain : UserControl
    {


        listItem[] LT = new listItem[10];
        int listIndex = 0;

        public firstMain()
        {
            InitializeComponent();

            this.flowLayoutPanel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseWheel);
            for (int i = 0; i < LT.Length; i++)
            {
                LT[i] = new listItem();
                LT[i].Name = "Seo Jisu" + i.ToString();
                LT[i].Imagebox = Resources.jisu2;
                LT[i].MainImage = Resources.jisu2;
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }


            }
            flowLayoutPanel1.Controls.Add(LT[0]);
        }


        private void flowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Delta > 0)
            {

                if (listIndex > 0)
                {
                    listIndex -= 1;
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(LT[listIndex]);

                }


            }
            else
            {
                if (listIndex < LT.Length - 1)
                {
                    listIndex += 1;
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(LT[listIndex]);
                }

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {


        }

        private void exit_Click_1(object sender, EventArgs e)
        {

            MainDisplay.ActiveForm.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
