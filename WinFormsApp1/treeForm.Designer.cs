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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("노드4");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("노드5");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("노드6");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("노드7");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("노드0", new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("노드8");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("노드9");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("노드1", new System.Windows.Forms.TreeNode[] { treeNode6, treeNode7 });
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("노드10");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("노드2", new System.Windows.Forms.TreeNode[] { treeNode9 });
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("노드3");
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(treeView1);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(246, 456);
            kryptonPanel1.TabIndex = 1;
            // 
            // treeView1
            // 
            treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            treeView1.Location = new System.Drawing.Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Name = "노드4";
            treeNode1.Text = "노드4";
            treeNode2.Name = "노드5";
            treeNode2.Text = "노드5";
            treeNode3.Name = "노드6";
            treeNode3.Text = "노드6";
            treeNode4.Name = "노드7";
            treeNode4.Text = "노드7";
            treeNode5.Name = "노드0";
            treeNode5.Text = "노드0";
            treeNode6.Name = "노드8";
            treeNode6.Text = "노드8";
            treeNode7.Name = "노드9";
            treeNode7.Text = "노드9";
            treeNode8.Name = "노드1";
            treeNode8.Text = "노드1";
            treeNode9.Name = "노드10";
            treeNode9.Text = "노드10";
            treeNode10.Name = "노드2";
            treeNode10.Text = "노드2";
            treeNode11.Name = "노드3";
            treeNode11.Text = "노드3";
            treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode5, treeNode8, treeNode10, treeNode11 });
            treeView1.Size = new System.Drawing.Size(246, 456);
            treeView1.TabIndex = 0;
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
        private System.Windows.Forms.TreeView treeView1;
    }
}
