using Microsoft.VisualBasic.PowerPacks.Printing;
using Mustagram2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustagram2
{
    
    public partial class MainDisplay : Form
    {
   

        int prevY = 0;
        public MainDisplay()
        {
            InitializeComponent();
      
        
           
        }
        private void MainDisplay_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void populateItems()
        {
            listItem[] LT = new listItem[10];
           
            for (int i = 0; i < LT.Length; i++)
            {
                LT[i] = new listItem();
                LT[i].Name = "Seo Jisu";
                LT[i].Imagebox = Resources.jisu2;
                LT[i].MainImage = Resources.jisu2;
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(LT[i]);
                }

            }
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