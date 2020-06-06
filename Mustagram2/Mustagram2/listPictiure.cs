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

        private void music_Click(object sender, EventArgs e)
        {
            Console.WriteLine(name);
            /*
            string str = @"C:\Users\poop4\Desktop\유진하/";
            Console.WriteLine(music.Text);
            player.URL = str+ music.Text;
            //  player.URL = @"C:\Users\poop4\Desktop\유진하/러블리즈_Sweet Dream.mp3";
         
                player.controls.play();
                Console.WriteLine(player.status);

            if (player.status == "연결중")
            {
                
                player.controls.stop();
                Console.WriteLine(player.playState);
                Console.WriteLine(player.status);
            }
            */
        }
    }
}
