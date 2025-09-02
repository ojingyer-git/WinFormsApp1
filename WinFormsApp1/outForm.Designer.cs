namespace WinFormsApp1
{
    partial class outForm
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
            kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            kryptonToolStrip1.Location = new System.Drawing.Point(0, 0);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.Size = new System.Drawing.Size(601, 25);
            kryptonToolStrip1.TabIndex = 0;
            kryptonToolStrip1.Text = "kryptonToolStrip1";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(listView1);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel1.Location = new System.Drawing.Point(0, 25);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(601, 201);
            kryptonPanel1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listView1.Location = new System.Drawing.Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(601, 201);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // outForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonToolStrip1);
            Name = "outForm";
            Size = new System.Drawing.Size(601, 226);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
