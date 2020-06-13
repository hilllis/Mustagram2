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
        public virtual string PlaceholderText { get; set; }
        public SingUp()
        {
            InitializeComponent();
            //textPassword.PlaceholderText("dsadsa");
        }

        private void SingUp_Load(object sender, EventArgs e)
        {

        }

        private void Idbox_Click(object sender, EventArgs e)
        {
            Idbox_Enter(sender, e);
        }

        private void Idbox_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "아이디")
            {
                txtId.Enabled = true;
               
                txtId.Text = "";
                txtId.Focus();
                txtId.ForeColor = Color.Black;
            }
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
            if (textPassword.Text == "비밀번호")
            {
                textPassword.Enabled = true;
                textPassword.Focus();
                textPassword.Text = "";
                textPassword.ForeColor = Color.Black;
            }
        }
        private void passwordbox_Click(object sender, EventArgs e)
        {
            passwordbox_Enter(sender, e);
        }
        private void passwordbox_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == string.Empty)
            {
                textPassword.Text = "비밀번호";
                textPassword.ForeColor = Color.Gray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            label2_Click(sender, e);
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
          if (!textPassword.Text.Equals(txtPassword_check.Text))
            {
                MessageBox.Show("Password errer");
            }
            else if (txtId.Text == "" || textPassword.Text == "" || txtPassword_check.Text == "")
            {
                MessageBox.Show("ID, Password Input");
            }
            else
            {
                 Console.WriteLine("Sign Up Id : {0}", txtId.Text);
                Console.WriteLine("Sign Up Password : {0}", textPassword.Text);
               
                Close();
            }
        }

        private void Password_check_box_Click(object sender, EventArgs e)
        {
            Password_check_box_Enter(sender, e);
        }

        private void Password_check_box_Enter(object sender, EventArgs e)
        {
            if (txtPassword_check.Text == "비밀번호 확인")
            {
                txtPassword_check.Enabled = true;
                txtPassword_check.Focus();
                txtPassword_check.Text = "";
                txtPassword_check.ForeColor = Color.Black;
            }
        }

        private void Password_check_box_Leave(object sender, EventArgs e)
        {
            if (txtPassword_check.Text == string.Empty)
            {
                txtPassword_check.Text = "비밀번호 확인";
                txtPassword_check.ForeColor = Color.Gray;
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

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
