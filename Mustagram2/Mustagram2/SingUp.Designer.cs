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
            this.nameBox = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.passwordbox = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnLogin = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label2 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.nameBox.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.nameBox.BorderColor = System.Drawing.Color.LightGray;
            this.nameBox.CornerRadius = 15;
            this.nameBox.FillColor = System.Drawing.Color.LightGray;
            this.nameBox.Location = new System.Drawing.Point(26, 294);
            this.nameBox.Name = "nameBox";
            this.nameBox.SelectionColor = System.Drawing.Color.White;
            this.nameBox.Size = new System.Drawing.Size(432, 53);
            this.nameBox.Click += new System.EventHandler(this.Idbox_Click);
            this.nameBox.Enter += new System.EventHandler(this.Idbox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.Idbox_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.btnLogin,
            this.rectangleShape1,
            this.passwordbox,
            this.nameBox});
            this.shapeContainer1.Size = new System.Drawing.Size(491, 691);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // passwordbox
            // 
            this.passwordbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.passwordbox.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.passwordbox.BorderColor = System.Drawing.Color.LightGray;
            this.passwordbox.CornerRadius = 15;
            this.passwordbox.FillColor = System.Drawing.Color.LightGray;
            this.passwordbox.Location = new System.Drawing.Point(26, 370);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.SelectionColor = System.Drawing.Color.White;
            this.passwordbox.Size = new System.Drawing.Size(432, 53);
            this.passwordbox.Enter += new System.EventHandler(this.passwordbox_Enter);
            this.passwordbox.Leave += new System.EventHandler(this.passwordbox_Leave);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.CornerRadius = 15;
            this.rectangleShape1.FillColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.Location = new System.Drawing.Point(24, 447);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.White;
            this.rectangleShape1.Size = new System.Drawing.Size(432, 53);
            this.rectangleShape1.Click += new System.EventHandler(this.Idbox_Click);
            this.rectangleShape1.Enter += new System.EventHandler(this.Idbox_Enter);
            this.rectangleShape1.Leave += new System.EventHandler(this.Idbox_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.btnLogin.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.btnLogin.CornerRadius = 15;
            this.btnLogin.FillColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(164, 539);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 53);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(185, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "회원가입";
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
            // 
            // SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 691);
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
        private Microsoft.VisualBasic.PowerPacks.RectangleShape nameBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnLogin;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape passwordbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}