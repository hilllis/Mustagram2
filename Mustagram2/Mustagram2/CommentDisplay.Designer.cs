namespace Mustagram2
{
    partial class CommentDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentDisplay));
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.shapeContainer7 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvw_profile1 = new Mustagram.CiclePicture();
            this.IdBox = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.txtcomment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvw_profile1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.exit);
            this.panel7.Controls.Add(this.shapeContainer7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(491, 61);
            this.panel7.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(219, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "댓글";
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
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 528);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtcomment);
            this.panel1.Controls.Add(this.lvw_profile1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 589);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 59);
            this.panel1.TabIndex = 0;
            // 
            // lvw_profile1
            // 
            this.lvw_profile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lvw_profile1.Image = ((System.Drawing.Image)(resources.GetObject("lvw_profile1.Image")));
            this.lvw_profile1.Location = new System.Drawing.Point(30, 3);
            this.lvw_profile1.Name = "lvw_profile1";
            this.lvw_profile1.Size = new System.Drawing.Size(49, 49);
            this.lvw_profile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lvw_profile1.TabIndex = 8;
            this.lvw_profile1.TabStop = false;
            // 
            // IdBox
            // 
            this.IdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.IdBox.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.IdBox.BorderColor = System.Drawing.Color.LightGray;
            this.IdBox.CornerRadius = 15;
            this.IdBox.FillColor = System.Drawing.Color.LightGray;
            this.IdBox.Location = new System.Drawing.Point(98, 9);
            this.IdBox.Name = "IdBox";
            this.IdBox.SelectionColor = System.Drawing.Color.White;
            this.IdBox.Size = new System.Drawing.Size(367, 39);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.IdBox});
            this.shapeContainer1.Size = new System.Drawing.Size(491, 59);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // txtcomment
            // 
            this.txtcomment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.txtcomment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcomment.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtcomment.ForeColor = System.Drawing.Color.Gray;
            this.txtcomment.HideSelection = false;
            this.txtcomment.Location = new System.Drawing.Point(116, 20);
            this.txtcomment.Name = "txtcomment";
            this.txtcomment.ShortcutsEnabled = false;
            this.txtcomment.Size = new System.Drawing.Size(298, 21);
            this.txtcomment.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(179)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(423, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "게시";
            // 
            // CommentDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel7);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CommentDisplay";
            this.Size = new System.Drawing.Size(491, 648);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvw_profile1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exit;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Mustagram.CiclePicture lvw_profile1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape IdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcomment;
    }
}
