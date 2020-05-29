namespace Mustagram2
{
    partial class SingUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IdBox = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnLogin = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Password_check_box = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.passwordbox = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.txtPassword_check = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mustagram2.Properties.Resources.MustaIcon;
            this.pictureBox1.Location = new System.Drawing.Point(148, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // IdBox
            // 
            this.IdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.IdBox.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.IdBox.BorderColor = System.Drawing.Color.LightGray;
            this.IdBox.CornerRadius = 15;
            this.IdBox.FillColor = System.Drawing.Color.LightGray;
            this.IdBox.Location = new System.Drawing.Point(26, 291);
            this.IdBox.Name = "IdBox";
            this.IdBox.SelectionColor = System.Drawing.Color.White;
            this.IdBox.Size = new System.Drawing.Size(432, 53);
            this.IdBox.Click += new System.EventHandler(this.Idbox_Click);
            this.IdBox.Enter += new System.EventHandler(this.Idbox_Enter);
            this.IdBox.Leave += new System.EventHandler(this.Idbox_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.btnLogin,
            this.Password_check_box,
            this.passwordbox,
            this.IdBox});
            this.shapeContainer1.Size = new System.Drawing.Size(491, 691);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 491;
            this.lineShape1.Y1 = 641;
            this.lineShape1.Y2 = 641;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.btnLogin.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.btnLogin.CornerRadius = 15;
            this.btnLogin.FillColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(171, 539);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 53);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Password_check_box
            // 
            this.Password_check_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.Password_check_box.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.Password_check_box.BorderColor = System.Drawing.Color.LightGray;
            this.Password_check_box.CornerRadius = 15;
            this.Password_check_box.FillColor = System.Drawing.Color.LightGray;
            this.Password_check_box.Location = new System.Drawing.Point(24, 444);
            this.Password_check_box.Name = "Password_check_box";
            this.Password_check_box.SelectionColor = System.Drawing.Color.White;
            this.Password_check_box.Size = new System.Drawing.Size(432, 53);
            this.Password_check_box.Click += new System.EventHandler(this.Password_check_box_Click);
            this.Password_check_box.Enter += new System.EventHandler(this.Password_check_box_Enter);
            this.Password_check_box.Leave += new System.EventHandler(this.Password_check_box_Leave);
            // 
            // passwordbox
            // 
            this.passwordbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.passwordbox.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.passwordbox.BorderColor = System.Drawing.Color.LightGray;
            this.passwordbox.CornerRadius = 15;
            this.passwordbox.FillColor = System.Drawing.Color.LightGray;
            this.passwordbox.Location = new System.Drawing.Point(26, 367);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.SelectionColor = System.Drawing.Color.White;
            this.passwordbox.Size = new System.Drawing.Size(432, 53);
            this.passwordbox.Click += new System.EventHandler(this.passwordbox_Click);
            this.passwordbox.Enter += new System.EventHandler(this.passwordbox_Enter);
            this.passwordbox.Leave += new System.EventHandler(this.passwordbox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(193, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "회원가입";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(135, 665);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "이미 계정이 있으신가요?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Underline);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(179)))), ((int)(((byte)(244)))));
            this.label7.Location = new System.Drawing.Point(278, 665);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "로그인";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "X";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtId.ForeColor = System.Drawing.Color.Gray;
            this.txtId.HideSelection = false;
            this.txtId.Location = new System.Drawing.Point(45, 309);
            this.txtId.Name = "txtId";
            this.txtId.ShortcutsEnabled = false;
            this.txtId.Size = new System.Drawing.Size(387, 21);
            this.txtId.TabIndex = 35;
            this.txtId.Text = "아이디";
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Enabled = false;
            this.textPassword.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.textPassword.ForeColor = System.Drawing.Color.Gray;
            this.textPassword.HideSelection = false;
            this.textPassword.Location = new System.Drawing.Point(42, 385);
            this.textPassword.Name = "textPassword";
            this.textPassword.ShortcutsEnabled = false;
            this.textPassword.Size = new System.Drawing.Size(387, 21);
            this.textPassword.TabIndex = 36;
            this.textPassword.Text = "비밀번호";
            // 
            // txtPassword_check
            // 
            this.txtPassword_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.txtPassword_check.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword_check.Enabled = false;
            this.txtPassword_check.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtPassword_check.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword_check.HideSelection = false;
            this.txtPassword_check.Location = new System.Drawing.Point(41, 461);
            this.txtPassword_check.Name = "txtPassword_check";
            this.txtPassword_check.ShortcutsEnabled = false;
            this.txtPassword_check.Size = new System.Drawing.Size(387, 21);
            this.txtPassword_check.TabIndex = 37;
            this.txtPassword_check.Text = "비밀번호 확인";
            // 
            // SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 691);
            this.Controls.Add(this.txtPassword_check);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingUp";
            this.Load += new System.EventHandler(this.SingUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape IdBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnLogin;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape Password_check_box;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape passwordbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox txtPassword_check;
    }
}