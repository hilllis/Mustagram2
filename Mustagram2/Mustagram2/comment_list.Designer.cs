namespace Mustagram2
{
    partial class comment_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comment_list));
            this.lvw_profile1 = new Mustagram.CiclePicture();
            this.tstId = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lvw_profile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvw_profile1
            // 
            this.lvw_profile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lvw_profile1.Image = ((System.Drawing.Image)(resources.GetObject("lvw_profile1.Image")));
            this.lvw_profile1.Location = new System.Drawing.Point(34, 3);
            this.lvw_profile1.Name = "lvw_profile1";
            this.lvw_profile1.Size = new System.Drawing.Size(49, 49);
            this.lvw_profile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lvw_profile1.TabIndex = 7;
            this.lvw_profile1.TabStop = false;
            // 
            // tstId
            // 
            this.tstId.AutoSize = true;
            this.tstId.Location = new System.Drawing.Point(120, 22);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(38, 12);
            this.tstId.TabIndex = 8;
            this.tstId.Text = "label1";
            // 
            // txtComment
            // 
            this.txtComment.AutoSize = true;
            this.txtComment.Location = new System.Drawing.Point(181, 22);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(38, 12);
            this.txtComment.TabIndex = 9;
            this.txtComment.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mustagram2.Properties.Resources.strokeheart;
            this.pictureBox1.Location = new System.Drawing.Point(457, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // comment_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.lvw_profile1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "comment_list";
            this.Size = new System.Drawing.Size(491, 57);
            ((System.ComponentModel.ISupportInitialize)(this.lvw_profile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mustagram.CiclePicture lvw_profile1;
        private System.Windows.Forms.Label tstId;
        private System.Windows.Forms.Label txtComment;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
