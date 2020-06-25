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
using Mustagram2.Properties;

namespace Mustagram2
{
    public partial class listItem : UserControl
    {
        int PrevY=0;
        bool isCollapsed=true;
        firstMain md;
        hostPro hP = new hostPro();
        public WindowsMediaPlayer player = new WindowsMediaPlayer();
        double musiclocation = 0;
        public listPictiure[] LP = new listPictiure[4];
        int pictureindex = 0;
        public listItem()
        {
            InitializeComponent();
            pictureBox1.Parent = lvw_main.picure_main;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.Parent = lvw_main.picure_main;
            pictureBox2.BackColor = Color.Transparent;
            // panel7.Visible = false;
            music.Parent = lvw_main.picure_main;
            music.BackColor = Color.Transparent;
            for (int i = 0; i < LP.Length; i++)
            {
                LP[i] = new listPictiure();
            }


            LP[0].Image_main = Resources.jisu;
            LP[1].Image_main = Resources.jisu2;
            LP[2].Image_main = Resources.soo;
            LP[3].Image_main = Resources.seulgi;

        }
        public listItem(firstMain md)
        {
            InitializeComponent();
            this.md = md;
            pictureBox1.Parent = lvw_main.picure_main;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.Parent = lvw_main.picure_main;
            pictureBox2.BackColor = Color.Transparent;
           // panel7.Visible = false;
            music.Parent = lvw_main.picure_main;
            music.BackColor = Color.Transparent;
            for (int i = 0; i < LP.Length; i++)
            {
                LP[i] = new listPictiure();
           
            }
         

            LP[0].Image_main = Resources.jisu;
            LP[1].Image_main = Resources.jisu2;
            LP[2].Image_main = Resources.soo;
            LP[3].Image_main = Resources.seulgi;

        }
       
        #region MyRegion

        private string _name;
        private string _message;
        private Image _image;
        private string music_name;
        private Image main_image;
        private string _time;
        [Category("Custom Props")]
        public string Music_name
        {
            get { return music_name; }
            set
            {
                music_name = value;
                music.Text = value;
                string str = @"C:\Users\poop4\Desktop\유진하/";
                Console.WriteLine(music.Text);
                player.URL =music.Text;
                player.controls.stop();
                Console.WriteLine(player.status);
            }
        }
        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set { _name  = value; lvw_name.Text = value; }
        }
        [Category("Custom Props")]
        public string time
        {
            get { return _time; }
            set { _time = value; lvw_time.Text = value; }
        }
        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value;lvw_comment1.Text = value; }
        }

        [Category("Custom Props")]
        public Image Imagebox
        {
            get { return _image; }
            set { _image = value; lvw_profile1.Image = value;
                lvw_profile2.Image = value;
            }
        }
        [Category("Custom Props")]
        public Image MainImage
        {
            get { return main_image; }
            set
            {
                main_image = value; lvw_main.Image_main = value;
            
            }
        }

        public bool SCrollable { get; internal set; }
        public bool TopMost { get; private set; }


        #endregion

        private void music_Click(object sender, EventArgs e)
        {
            Console.WriteLine(player.playState.ToString());
            Console.WriteLine(player.URL);
            
            if (player.playState.ToString().Equals("wmppsReady")||player.playState.ToString().Equals("wmppsStopped") || player.playState.ToString().Equals("wmppsPaused"))
            {
                player.URL = music.Text;

                player.controls.currentPosition = musiclocation;
                Console.WriteLine("play {0}", musiclocation);
                player.controls.play();
              
                Console.WriteLine(player.status);
            }
            if (player.playState.ToString().Equals("wmppsPlaying"))
            {
                Console.WriteLine("stop befoe {0}  ", player.controls.currentPosition);
                player.controls.pause();
                musiclocation = player.controls.currentPosition;
                Console.WriteLine("stop after {0} ", player.controls.currentPosition);
                //player.controls.pause();
                Console.WriteLine(player.playState);
                Console.WriteLine(player.status);
            }
            
        }
        public void left(object sender, EventArgs e)
        {
            if (0 < pictureindex)
            {
                Console.WriteLine("left {0}", pictureindex);
                this.MainImage = LP[--pictureindex].Image_main;
            }
            
          
        }

        public void Right(object sender, EventArgs e)
        {
            if ( pictureindex<LP.Length-1)
            {
                Console.WriteLine("right {0}", pictureindex);
                this.MainImage = LP[++pictureindex].Image_main;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Left(object sender, EventArgs e)
        {

        }

        private void lvw_main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            hostPro1.Visible = true;
            // md.test();
            timer1.Start();
            // panel7.Controls.Add(hP);
       
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                hostPro1.Height += 10;
                if (hostPro1.Size == hostPro1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
             

                }
            }
            else
            {
                hostPro1.Height -= 10;

                if (hostPro1.Size == hostPro1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    hostPro1.Visible = false;

                }
            }
        }
    } 
}
