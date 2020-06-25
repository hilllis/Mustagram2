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

        firstMain fM;
        Log lg = new Log();
        int listIndex = 0;
 
        public MainDisplay()
        {
            InitializeComponent();
            fM = new firstMain(this);
            //this.panel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseWheel);

        }
        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Delta > 0)
            {
             //   Console.WriteLine("dss");
               // panel1.
            }  
            else
            {
              //  Console.WriteLine("qqq");
            }
        }


        private void MainDisplay_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void populateItems()
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(fM);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            profile Pr = new profile();
            panel1.Controls.Clear();
            panel1.Controls.Add(Pr);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.strokeheart1;
            panel1.Controls.Clear();
            panel1.Controls.Add(fM);
        }

        public void commentdisplay_open()
        {
           
            CommentDisplay cd = new CommentDisplay(this);
            panel1.Controls.Clear();
            panel1.Controls.Add(cd);
        }
        public void commentdisplay_off()
        {
        
            panel1.Controls.Clear();
            panel1.Controls.Add(fM);
        }
        public void Exit()
        {
            this.Close();
        }

        public void exit_Click_2(object sender, EventArgs e)
        {
            Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.black_heart2;
            panel1.Controls.Clear();
            panel1.Controls.Add(lg);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HostCreate hc = new HostCreate();
            panel1.Controls.Clear();
            panel1.Controls.Add(hc);
        }
    }
}