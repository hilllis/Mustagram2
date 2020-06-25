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
    public partial class comment_list : UserControl
    {
        public comment_list()
        {
            InitializeComponent();
            Console.WriteLine("commenlist");
        }
        private string _name;
        private string _comment;
        private Image _image;
        private int _commentNum;
        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set { _name = value; tstId.Text = value; }
        }
      
        [Category("Custom Props")]
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; txtComment.Text = value; }
        }
        [Category("Custom Props")]
        public int CommentNum
        {
            get { return _commentNum; }
            set { _commentNum = value; }
        }
        [Category("Custom Props")]
        public Image Imagebox
        {
            get { return _image; }
            set
            {
                _image = value; lvw_profile1.Image = value;
                lvw_profile1.Image = value;
            }
        }
    }
}
