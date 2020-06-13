using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Mustagram2
{
    public partial class listPictiure : UserControl
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        string name="";
        public listPictiure()
        {
            
            InitializeComponent();
     
 
        }
      
        private Image main_image;
        [Category("Custom Props")]
        public Image Image_main

        {
            get { return main_image; }
            set
            {
                main_image = value; picure_main.Image = value;

            }
        }
     
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            
        }

       
        
    }
}
