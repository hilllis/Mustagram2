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
        firstMain fM = new firstMain();
        int listIndex = 0;
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
           // panel1.Controls.Clear();
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
    }
}