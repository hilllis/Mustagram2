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
    public partial class SingUp : Form
    {
        MustagramClient client = MustagramClient.GetClient();
        SetUserInfo Setuserinfo = new SetUserInfo();
        public virtual string PlaceholderText { get; set; }
        bool act = false;
        bool btnMove = true;
        public SingUp()
        {
            InitializeComponent();
            //textPassword.PlaceholderText("dsadsa");
            this.ActiveControl = pictureBox1;
          
        }

        private void SingUp_Load(object sender, EventArgs e)
        {
         
          
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

        private void txtPassword_check_hint_On_Off(object sender, EventArgs e)
        {
            if (txtPassword_check.Text == "비밀번호 확인")
            {

                this.ActiveControl = txtPassword_check;
                txtPassword_check.Text = "";
                txtPassword_check.PasswordChar = '*';
                txtPassword_check.ForeColor = Color.Black;
                txtPassword_check.Enabled = true;

            }
            else if (txtPassword_check.Text == string.Empty)
            {

                txtPassword_check.PasswordChar = '\0';
                txtPassword_check.Text = "비밀번호 확인";
                txtPassword_check.ForeColor = Color.Gray;


            }
        }

        private void Button_Activation(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals("") && !txtPassword.Text.Equals("비밀번호")
                && !txtId.Text.Equals("아이디") && !txtId.Text.Equals("")
                && !txtPassword_check.Text.Equals("") && !txtPassword_check.Text.Equals("비밀번호 확인"))
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
            if (!txtPassword.Text.Equals("") && !txtPassword.Text.Equals("비밀번호")
                && !txtPassword_check.Text.Equals("") && !txtPassword_check.Text.Equals("비밀번호 확인"))
            {
                if(txtPassword.Text!= txtPassword_check.Text)
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Password error";
                }
                else
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = "Password match";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            bool result = false;
          if (!txtPassword.Text.Equals(txtPassword_check.Text))
            {
                MessageBox.Show("Password errer");
            }
            else if (txtId.Text == "" || txtPassword.Text == "" || txtPassword_check.Text == "")
            {
                MessageBox.Show("ID, Password Input");
            }
            else
            {
                Console.WriteLine("Sign Up Id : {0}", txtId.Text);
                Console.WriteLine("Sign Up Password : {0}", txtPassword.Text);

                Func<Task> runAsync = async () =>
                {
                    try
                    {
                        if (await client.SendSignInInfo(txtId.Text.ToString(), txtPassword.Text.ToString()).ConfigureAwait(false))
                        {
                            result = true;
                        }
                    }
                    catch (Exception q)
                    {
                        Console.WriteLine(q.Message);
                    }
                };
                runAsync().GetAwaiter().GetResult();
                if(result)
                {
                    Console.WriteLine("회원가입 성공!");
                    if (Setuserinfo.IsDisposed) // 컨트롤이 죽었으면
                    {
                        Setuserinfo = new SetUserInfo(); // 다시 인스턴스생성하고 열어줍니다
                        Setuserinfo.Show();
                    }
                    else
                    {
                        Setuserinfo.Show();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("회원가입 실패!");
                }
          
            }
        }

     

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Exit()
        {
            Close();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            if (act)
            {
                if (btnMove)
                {
                    int x = btnLogin.Location.X;
                    int y = btnLogin.Location.Y;
                  
                    btnLogin.Location = new Point(x, y + 10);
                    label2.Location = new Point(label2.Location.X, label2.Location.Y + 10);
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
                    btnLogin.Location = new Point(x, y - 10);
                    label2.Location = new Point(label2.Location.X, label2.Location.Y - 10);
                    btnMove = !btnMove;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.label2_Click(sender, e);

        }
    }
}
