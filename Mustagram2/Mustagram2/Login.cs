using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustagram2
{
    public partial class Login : Form
    {
        MustagramClient client = MustagramClient.GetClient();
        Set_User setuser = Set_User.SetUser();
        SingUp signUp = new SingUp();
        MainDisplay ma = new MainDisplay();

        string Id = "";
        string Password = "";
        bool btnMove = true;
        bool act = false;
        public Login()
        {
            InitializeComponent();

            this.ActiveControl = pictureBox1;
        }
        private void txtId_hint_On_Off(object sender, EventArgs e)
        {
            if (txtId.Text == "아이디")
            {

                this.ActiveControl = txtId;
                txtId.Text = "";
                txtId.ForeColor = Color.Black;
                txtId.Enabled = true;

            }
            else if (txtId.Text == string.Empty)
            {
                txtId.Text = "아이디";
                txtId.ForeColor = Color.Gray;


            }

        }
        private void txtPassword_hint_On_Off(object sender, EventArgs e)
        {
            if (txtPassword.Text == "비밀번호")
            {

                this.ActiveControl = txtPassword;
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
                txtPassword.Enabled = true;

            }
            else if (txtPassword.Text == string.Empty)
            {

                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "비밀번호";
                txtPassword.ForeColor = Color.Gray;


            }

        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Activation(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals("") && !txtPassword.Text.Equals("비밀번호") && !txtId.Text.Equals("아이디") && !txtId.Text.Equals(""))
            {
                btnLogin.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                btnLogin.Cursor = Cursors.Hand;
                act = true;
            }
            else
            {
                btnLogin.BackColor = Color.FromArgb(64, 64, 64);
                label2.BackColor = Color.FromArgb(64, 64, 64);
                btnLogin.Cursor = Cursors.Default;
                act = false;
            }
        }

        int left;
        private void label7_Click(object sender, EventArgs e)
        {


            if (signUp.IsDisposed) // 컨트롤이 죽었으면
            {
                signUp = new SingUp(); // 다시 인스턴스생성하고 열어줍니다
                signUp.Show();
            }
            else
            {
                signUp.Show();
            }
            left = signUp.Left;
            timer1.Start();

        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool result=false;

            Func<Task> runAsyn = async () =>
            {
                try
                {

                    if (await client.SendLoginInfo(txtId.Text.ToString(), txtPassword.Text.ToString()).ConfigureAwait(false))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }



                }
                catch (Exception q)
                {
                    Console.WriteLine(q.Message);
                }
            };
            if (txtId.Text != "" && txtPassword.Text != "" && txtId.Text != "아이디" && txtPassword.Text != "비밀번호")
            {
                runAsyn().GetAwaiter().GetResult();
                if (result)
                {
                    setuser.setUser_id(txtId.Text.ToString());
                    Console.WriteLine(setuser.getUser_id());
                    if (ma.IsDisposed) // 컨트롤이 죽었으면
                    {
                        ma = new MainDisplay(); // 다시 인스턴스생성하고 열어줍니다
                        ma.Show();


                    }
                    else
                    {
                        ma.Show();

                    }
                }
                
                txtId.Text = "아이디";
                txtId.ForeColor = Color.Gray;
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "비밀번호";
                txtPassword.ForeColor = Color.Gray;
            }
            else
            {
                MessageBox.Show("ID, Password Input");
            }


        }
        private void label2_Click(object sender, EventArgs e)
        {
            btnLogin_Click(sender, e);
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            if (act)
            {
                if (btnMove)
                {
                    int x = btnLogin.Location.X;
                    int y = btnLogin.Location.Y;
                    btnLogin.Location = new Point(x, y + 5);
                    label2.Location = new Point(label2.Location.X, label2.Location.Y + 5);
                    btnMove = !btnMove;
                }
            }
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            if (act)
            {
                if (!btnMove)
                {
                    int x = btnLogin.Location.X;
                    int y = btnLogin.Location.Y;
                    btnLogin.Location = new Point(x, y - 5);
                    label2.Location = new Point(label2.Location.X, label2.Location.Y - 5);
                    btnMove = !btnMove;
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            signUp.Left += 10;
            if (signUp.Left >= left + 400)
            {
                timer1.Stop();
                this.TopMost = false;
                signUp.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {

            signUp.Left -= 10;
            if (signUp.Left <= left)
            {
                timer2.Stop();
            }
        }
    }
}
