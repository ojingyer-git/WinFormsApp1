namespace WinFormsApp1
{
    partial class DrawItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawItem));
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            drawBox1 = new DrawBox();
            kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            kryptonToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.AutoScroll = true;
            kryptonPanel1.Controls.Add(drawBox1);
            kryptonPanel1.Controls.Add(kryptonToolStrip1);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(832, 644);
            kryptonPanel1.TabIndex = 0;
            // 
            // drawBox1
            // 
            drawBox1.Location = new System.Drawing.Point(0, 25);
            drawBox1.Name = "drawBox1";
            drawBox1.Size = new System.Drawing.Size(613, 428);
            drawBox1.TabIndex = 1;
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            kryptonToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1 });
            kryptonToolStrip1.Location = new System.Drawing.Point(0, 0);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.Size = new System.Drawing.Size(832, 25);
            kryptonToolStrip1.TabIndex = 0;
            kryptonToolStrip1.Text = "kryptonToolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new System.Drawing.Point(832, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(3, 644);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // DrawItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(splitter1);
            Controls.Add(kryptonPanel1);
            Name = "DrawItem";
            Size = new System.Drawing.Size(1028, 644);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            kryptonToolStrip1.ResumeLayout(false);
            kryptonToolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private System.Windows.Forms.Splitter splitter1;
        private DrawBox drawBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
