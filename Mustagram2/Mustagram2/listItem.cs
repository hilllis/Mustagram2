using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustagram2
{
    public partial class listItem : UserControl
    {
        int PrevY=0;
        public listItem()
        {
            InitializeComponent();
           
        }
       
        #region MyRegion

        private string _name;
        private string _message;
        private Image _image;
        private string _time;
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
            get { return _image; }
            set
            {
                _image = value; main_image.Image = value;
            
            }
        }

        public bool SCrollable { get; internal set; }

        #endregion

       
    } 
}
