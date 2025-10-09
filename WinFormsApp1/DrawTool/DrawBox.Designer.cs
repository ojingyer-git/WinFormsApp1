namespace WinFormsApp1
{
    partial class DrawBox
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawBox));
            pictureBox_resize = new System.Windows.Forms.PictureBox();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            전체선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            전체해제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            삭제하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            전체삭제하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            imageList1 = new System.Windows.Forms.ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_resize).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_resize
            // 
            pictureBox_resize.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pictureBox_resize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            pictureBox_resize.Image = Properties.Resources.corner;
            pictureBox_resize.Location = new System.Drawing.Point(596, 411);
            pictureBox_resize.Name = "pictureBox_resize";
            pictureBox_resize.Size = new System.Drawing.Size(17, 17);
            pictureBox_resize.TabIndex = 0;
            pictureBox_resize.TabStop = false;
            pictureBox_resize.MouseDown += pictureBox_resize_MouseDown;
            pictureBox_resize.MouseMove += pictureBox_resize_MouseMove;
            pictureBox_resize.MouseUp += pictureBox_resize_MouseUp;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 전체선택ToolStripMenuItem, 전체해제ToolStripMenuItem, 삭제하기ToolStripMenuItem, 전체삭제하기ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(150, 92);
            // 
            // 전체선택ToolStripMenuItem
            // 
            전체선택ToolStripMenuItem.Name = "전체선택ToolStripMenuItem";
            전체선택ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            전체선택ToolStripMenuItem.Text = "전체 선택";
            // 
            // 전체해제ToolStripMenuItem
            // 
            전체해제ToolStripMenuItem.Name = "전체해제ToolStripMenuItem";
            전체해제ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            전체해제ToolStripMenuItem.Text = "전체 해제";
            // 
            // 삭제하기ToolStripMenuItem
            // 
            삭제하기ToolStripMenuItem.Name = "삭제하기ToolStripMenuItem";
            삭제하기ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            삭제하기ToolStripMenuItem.Text = "삭제하기";
            // 
            // 전체삭제하기ToolStripMenuItem
            // 
            전체삭제하기ToolStripMenuItem.Name = "전체삭제하기ToolStripMenuItem";
            전체삭제하기ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            전체삭제하기ToolStripMenuItem.Text = "전체 삭제하기";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "0.png");
            imageList1.Images.SetKeyName(1, "1.png");
            imageList1.Images.SetKeyName(2, "2.png");
            imageList1.Images.SetKeyName(3, "3.png");
            imageList1.Images.SetKeyName(4, "4.png");
            imageList1.Images.SetKeyName(5, "5.png");
            imageList1.Images.SetKeyName(6, "6.png");
            imageList1.Images.SetKeyName(7, "7.png");
            imageList1.Images.SetKeyName(8, "8.png");
            imageList1.Images.SetKeyName(9, "9.png");
            imageList1.Images.SetKeyName(10, "a.png");
            imageList1.Images.SetKeyName(11, "b.png");
            imageList1.Images.SetKeyName(12, "c.png");
            imageList1.Images.SetKeyName(13, "d.png");
            imageList1.Images.SetKeyName(14, "e.png");
            imageList1.Images.SetKeyName(15, "f.png");
            imageList1.Images.SetKeyName(16, "g.png");
            imageList1.Images.SetKeyName(17, "h.png");
            imageList1.Images.SetKeyName(18, "i.png");
            imageList1.Images.SetKeyName(19, "j.png");
            imageList1.Images.SetKeyName(20, "k.png");
            imageList1.Images.SetKeyName(21, "l.png");
            imageList1.Images.SetKeyName(22, "m.png");
            imageList1.Images.SetKeyName(23, "n.png");
            imageList1.Images.SetKeyName(24, "o.png");
            imageList1.Images.SetKeyName(25, "p.png");
            imageList1.Images.SetKeyName(26, "q.png");
            imageList1.Images.SetKeyName(27, "r.png");
            imageList1.Images.SetKeyName(28, "s.png");
            imageList1.Images.SetKeyName(29, "t.png");
            imageList1.Images.SetKeyName(30, "u.png");
            imageList1.Images.SetKeyName(31, "v.png");
            imageList1.Images.SetKeyName(32, "w.png");
            imageList1.Images.SetKeyName(33, "x.png");
            imageList1.Images.SetKeyName(34, "y.png");
            imageList1.Images.SetKeyName(35, "z.png");
            // 
            // DrawBox
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(pictureBox_resize);
            Name = "DrawBox";
            Size = new System.Drawing.Size(613, 428);
            Paint += DrawBox_Paint;
            KeyDown += DrawBox_KeyDown;
            MouseDown += DrawBox_MouseDown;
            MouseMove += DrawBox_MouseMove;
            MouseUp += DrawBox_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox_resize).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_resize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 전체선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전체해제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전체삭제하기ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}
