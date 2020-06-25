namespace Mustagram2
{
    partial class profile_modified
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile_modified));
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnLogin = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtboxIntro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ciclePicture1 = new Mustagram.CiclePicture();
            this.lvw_profile1 = new Mustagram.CiclePicture();
            ((System.ComponentModel.ISupportInitialize)(this.ciclePicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvw_profile1)).BeginInit();
            this.SuspendLayout();
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.CornerRadius = 15;
            this.rectangleShape1.FillColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.Location = new System.Drawing.Point(116, 70);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.White;
            this.rectangleShape1.Size = new System.Drawing.Size(312, 38);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnLogin,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(491, 234);
            this.shapeContainer1.TabIndex = 40;
            this.shapeContainer1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.CornerRadius = 15;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FillColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(192, 155);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 48);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // txtboxIntro
            // 
            this.txtboxIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.txtboxIntro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxIntro.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtboxIntro.ForeColor = System.Drawing.Color.Gray;
            this.txtboxIntro.HideSelection = false;
            this.txtboxIntro.Location = new System.Drawing.Point(130, 80);
            this.txtboxIntro.Margin = new System.Windows.Forms.Padding(0);
            this.txtboxIntro.Name = "txtboxIntro";
            this.txtboxIntro.ShortcutsEnabled = false;
            this.txtboxIntro.Size = new System.Drawing.Size(286, 21);
            this.txtboxIntro.TabIndex = 42;
            this.txtboxIntro.TextChanged += new System.EventHandler(this.txtboxIntro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Underline);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(217, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "완료";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ciclePicture1
            // 
            this.ciclePicture1.Image = global::Mustagram2.Properties.Resources.plus;
            this.ciclePicture1.Location = new System.Drawing.Point(76, 90);
            this.ciclePicture1.Name = "ciclePicture1";
            this.ciclePicture1.Size = new System.Drawing.Size(24, 21);
            this.ciclePicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ciclePicture1.TabIndex = 44;
            this.ciclePicture1.TabStop = false;
            this.ciclePicture1.Click += new System.EventHandler(this.ciclePicture1_Click);
            // 
            // lvw_profile1
            // 
            this.lvw_profile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lvw_profile1.Image = ((System.Drawing.Image)(resources.GetObject("lvw_profile1.Image")));
            this.lvw_profile1.Location = new System.Drawing.Point(33, 56);
            this.lvw_profile1.Name = "lvw_profile1";
            this.lvw_profile1.Size = new System.Drawing.Size(58, 58);
            this.lvw_profile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lvw_profile1.TabIndex = 43;
            this.lvw_profile1.TabStop = false;
            // 
            // profile_modified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ciclePicture1);
            this.Controls.Add(this.lvw_profile1);
            this.Controls.Add(this.txtboxIntro);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "profile_modified";
            this.Size = new System.Drawing.Size(491, 234);
            ((System.ComponentModel.ISupportInitialize)(this.ciclePicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvw_profile1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txtboxIntro;
        private Mustagram.CiclePicture lvw_profile1;
        private Mustagram.CiclePicture ciclePicture1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnLogin;
        private System.Windows.Forms.Label label4;
    }
}
