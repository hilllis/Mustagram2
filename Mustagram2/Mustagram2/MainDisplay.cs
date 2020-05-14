using Microsoft.VisualBasic.PowerPacks.Printing;
using Mustagram2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustagram2
{
    
    public partial class MainDisplay : Form
    {

        listItem[] LT = new listItem[10];
        int listIndex = 0;
        public MainDisplay()
        {
            InitializeComponent();

            this.flowLayoutPanel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseWheel);
            flowLayoutPanel1.AutoScrollPosition = new Point(0, 0);
            flowLayoutPanel1.Focus();
            // Set maximum position of your panel beyond the point your panel items reach.
            // You'll have to change this size depending on the total size of items for your case.
            // flowLayoutPanel1.VerticalScroll.Maximum = 280;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.HorizontalScroll.Visible = false;

        }


        private void flowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {
          
            if(e.Delta > 0)
            {
               
                if (listIndex >0)
                {
                    listIndex -= 1;
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(LT[listIndex]);
                }
              

            }
            else
            {
                if (listIndex < LT.Length-1)
                {
                    listIndex += 1;
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(LT[listIndex]);
                }
            }
        }
        private void MainDisplay_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void populateItems()
        {
          
           
            for (int i = 0; i < LT.Length; i++)
            {
                LT[i] = new listItem();
                LT[i].Name = "Seo Jisu"+i.ToString();
                LT[i].Imagebox = Resources.jisu2;
                LT[i].MainImage = Resources.jisu2;
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }       

            }
            flowLayoutPanel1.Controls.Add(LT[0]);
            listIndex = 0;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("test");
           // exit.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
           
           // exit.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("test22");
            this.Close();
        }
    }
}