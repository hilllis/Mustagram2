namespace Mustagram2
{
    partial class listPictiure
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
            this.picure_main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picure_main)).BeginInit();
            this.SuspendLayout();
            // 
            // picure_main
            // 
            this.picure_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picure_main.Location = new System.Drawing.Point(0, 0);
            this.picure_main.Margin = new System.Windows.Forms.Padding(0);
            this.picure_main.Name = "picure_main";
            this.picure_main.Size = new System.Drawing.Size(491, 302);
            this.picure_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picure_main.TabIndex = 1;
            this.picure_main.TabStop = false;
            // 
            // listPictiure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picure_main);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "listPictiure";
            this.Size = new System.Drawing.Size(491, 302);
            ((System.ComponentModel.ISupportInitialize)(this.picure_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picure_main;
    }
}
