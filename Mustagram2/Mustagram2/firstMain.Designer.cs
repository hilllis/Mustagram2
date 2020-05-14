namespace Mustagram2
{
    partial class firstMain
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.shapeContainer7 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.exit = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel7.Controls.Add(this.exit);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.shapeContainer7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(491, 61);
            this.panel7.TabIndex = 44;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mustagram2.Properties.Resources.MustaIcon;
            this.pictureBox1.Location = new System.Drawing.Point(185, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 587);
            this.flowLayoutPanel1.TabIndex = 45;
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
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // firstMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel7);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "firstMain";
            this.Size = new System.Drawing.Size(491, 648);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label exit;
    }
}
