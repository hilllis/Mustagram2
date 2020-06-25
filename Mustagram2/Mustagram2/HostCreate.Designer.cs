namespace Mustagram2
{
    partial class HostCreate
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostCreate));
            this.panel7 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.shapeContainer7 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLogin = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.lvw_profile1 = new Mustagram.CiclePicture();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvw_profile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel7.Controls.Add(this.lvw_profile1);
            this.panel7.Controls.Add(this.exit);
            this.panel7.Controls.Add(this.shapeContainer7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(491, 61);
            this.panel7.TabIndex = 45;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(463, 10);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(16, 16);
            this.exit.TabIndex = 45;
            this.exit.Text = "X";
            // 
            // shapeContainer7
            // 
            this.shapeContainer7.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer7.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer7.Name = "shapeContainer7";
            this.shapeContainer7.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape9});
            this.shapeContainer7.Size = new System.Drawing.Size(491, 61);
            this.shapeContainer7.TabIndex = 42;
            this.shapeContainer7.TabStop = false;
            // 
            // lineShape9
            // 
            this.lineShape9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lineShape9.Name = "c";
            this.lineShape9.X1 = 0;
            this.lineShape9.X2 = 491;
            this.lineShape9.Y1 = 60;
            this.lineShape9.Y2 = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(370, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Picture";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Music";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.textBox1.Location = new System.Drawing.Point(1, 500);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(487, 35);
            this.textBox1.TabIndex = 47;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.CornerRadius = 15;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FillColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(189, 559);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 53);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnLogin});
            this.shapeContainer1.Size = new System.Drawing.Size(491, 648);
            this.shapeContainer1.TabIndex = 51;
            this.shapeContainer1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Underline);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(225, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "완료";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lvw_profile1
            // 
            this.lvw_profile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lvw_profile1.Image = ((System.Drawing.Image)(resources.GetObject("lvw_profile1.Image")));
            this.lvw_profile1.Location = new System.Drawing.Point(216, 1);
            this.lvw_profile1.Name = "lvw_profile1";
            this.lvw_profile1.Size = new System.Drawing.Size(58, 58);
            this.lvw_profile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lvw_profile1.TabIndex = 46;
            this.lvw_profile1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 117);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HostCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HostCreate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(491, 648);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvw_profile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label exit;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape9;
        private Mustagram.CiclePicture lvw_profile1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnLogin;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label4;
    }
}
