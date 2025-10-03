namespace WinFormsApp1
{
    partial class treeForm
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonTreeView1 = new Krypton.Toolkit.KryptonTreeView();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonTreeView1);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(246, 456);
            kryptonPanel1.TabIndex = 1;
            // 
            // kryptonTreeView1
            // 
            kryptonTreeView1.Dock = System.Windows.Forms.DockStyle.Top;
            kryptonTreeView1.Location = new System.Drawing.Point(0, 0);
            kryptonTreeView1.Name = "kryptonTreeView1";
            kryptonTreeView1.Size = new System.Drawing.Size(246, 204);
            kryptonTreeView1.TabIndex = 0;
            // 
            // treeListView1
            // 

            // 
            // treeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Name = "treeForm";
            Size = new System.Drawing.Size(246, 456);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonTreeView kryptonTreeView1;
    }
}
