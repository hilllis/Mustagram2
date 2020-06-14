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
    public partial class hostPro : UserControl
    {
        public hostPro()
        {
            InitializeComponent();
        }

        public bool TopMost { get; internal set; }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Height -= 10;

            if (this.Size == this.MinimumSize)
            {
                timer1.Stop();
                this.Visible = false;

            }
        }
    }
}
