using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustagram2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Idbox_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "아이디")
            {
                txtId.Enabled = true;
                txtId.Focus();
                txtId.Text = "";
                txtId.ForeColor = Color.Black;
            }
        }

        private void Idbox_Click(object sender, EventArgs e)
        {
            Idbox_Enter(sender, e);
        }
        private void Idbox_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                txtId.Text = "아이디";
                txtId.ForeColor = Color.Gray;
            }
        }

        private void passwordbox_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("DSsd");
            if (txtPassword.Text == "비밀번호")
            {
                txtPassword.Enabled = true;
                txtPassword.Focus();
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void passwordbox_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "비밀번호";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (form2.IsDisposed) // 컨트롤이 죽었으면
            {
                form2 = new Form2(); // 다시 인스턴스생성하고 열어줍니다
                form2.Show();
            }
            else
            {
                form2.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
