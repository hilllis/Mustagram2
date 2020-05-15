namespace Mustagram2
{
    partial class Log_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_list));
            this.lvw_profile1 = new Mustagram.CiclePicture();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_follow = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lvw_profile1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvw_profile1
            // 
            this.lvw_profile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lvw_profile1.Image = ((System.Drawing.Image)(resources.GetObject("lvw_profile1.Image")));
            this.lvw_profile1.Location = new System.Drawing.Point(32, 4);
            this.lvw_profile1.Name = "lvw_profile1";
            this.lvw_profile1.Size = new System.Drawing.Size(49, 49);
            this.lvw_profile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lvw_profile1.TabIndex = 6;
            this.lvw_profile1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seo_Jusu님이 회원님을 팔로우하기 시작했습니다.";
            // 
            // btn_follow
            // 
            this.btn_follow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.btn_follow.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btn_follow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.btn_follow.CornerRadius = 5;
            this.btn_follow.FillColor = System.Drawing.Color.LightGray;
            this.btn_follow.Location = new System.Drawing.Point(394, 14);
            this.btn_follow.Name = "btn_follow";
            this.btn_follow.Size = new System.Drawing.Size(75, 30);
            this.btn_follow.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btn_follow});
            this.shapeContainer1.Size = new System.Drawing.Size(491, 57);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(404, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "팔로우";
            // 
            // Log_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvw_profile1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Log_list";
            this.Size = new System.Drawing.Size(491, 57);
            this.Load += new System.EventHandler(this.Log_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvw_profile1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mustagram.CiclePicture lvw_profile1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btn_follow;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label2;
    }
}
