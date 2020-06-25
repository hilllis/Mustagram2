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
using System.Runtime.CompilerServices;

namespace Mustagram2
{
    public partial class listItem : UserControl
    {
        int PrevY=0;
        bool isCollapsed=true;
        firstMain md;
        bool like = false;
        hostPro hP = new hostPro();
        public WindowsMediaPlayer player = new WindowsMediaPlayer();
        double musiclocation = 0;
        public listPictiure[] LP = new listPictiure[4];
        int pictureindex = 0;
        public int postnumber;
        MainDisplay maindis;
        public listItem(MainDisplay md)
        {
            this.maindis = md;
            InitializeComponent();
           
            // panel7.Visible = false;
          //  music.Parent = lvw_main;
           // music.BackColor = Color.Transparent;
           

        }
        public listItem(firstMain md)
        {
            InitializeComponent();
            this.md = md;

           // panel7.Visible = false;
           // music.Parent = lvw_main.picure_main;
           // music.BackColor = Color.Transparent;
           

        }
       
        #region MyRegion

        private string _name;
        private string _message;
        private string _image;
        private string music_name;
        private string main_image;
        private string _time;
        private string _pLike;
        [Category("Custom Props")]
        public string P_like
        {
            get { return _pLike; }
            set { _pLike = value; label4.Text = value; }
        }
        [Category("Custom Props")]
        public string Music_name
        {
            get { return music_name; }
            set
            {
                music_name = value;
              
                player.URL = music_name.ToString();
                player.controls.stop();
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
        public string Imagebox
        {
            get { return _image; }
            set { _image = value; lvw_profile1.Load(value);
                lvw_profile2.Load(value);
            }
        }
        [Category("Custom Props")]
        public string MainImage
        {
            get { return main_image; }
            set
            {
                main_image = value; pictureBox1.Load(value);
            
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
                player.URL = music_name;

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

        private void lvw_comment_display_Click(object sender, EventArgs e)
        {
            Console.WriteLine("click");
            maindis.commentdisplay_open(this.postnumber);
            //maindisplay.commentdispay();
        }

        private void lvw_heart1_Click(object sender, EventArgs e)
        {
            if (like)
            {
                like = false;
                lvw_heart1.Image = Resources.strokeheart;
                //Func<>
            }
            else if(!like)
            {
                like = true;
                lvw_heart1.Image = Resources.redheart;
            }
        }
    } 
}
