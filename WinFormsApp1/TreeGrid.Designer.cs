namespace WinFormsApp1
{
    partial class TreeGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            kryptonTreeGridView1 = new Krypton.Toolkit.Suite.Extended.TreeGridView.KryptonTreeGridView();
            Column1 = new Krypton.Toolkit.Suite.Extended.TreeGridView.KryptonTreeGridColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            splitter1 = new System.Windows.Forms.Splitter();
            Grid = new TenTec.Windows.iGridLib.iGrid();
            iGrid1DefaultCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            iGrid1DefaultColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            iGrid1RowTextColCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            ((System.ComponentModel.ISupportInitialize)kryptonTreeGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            kryptonToolStrip1.Location = new System.Drawing.Point(0, 0);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.Size = new System.Drawing.Size(1142, 25);
            kryptonToolStrip1.TabIndex = 0;
            kryptonToolStrip1.Text = "kryptonToolStrip1";
            // 
            // kryptonTreeGridView1
            // 
            kryptonTreeGridView1.AllowUserToAddRows = false;
            kryptonTreeGridView1.AllowUserToDeleteRows = false;
            kryptonTreeGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kryptonTreeGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3 });
            kryptonTreeGridView1.DataSource = null;
            kryptonTreeGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            kryptonTreeGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            kryptonTreeGridView1.ImageList = null;
            kryptonTreeGridView1.Location = new System.Drawing.Point(0, 25);
            kryptonTreeGridView1.Name = "kryptonTreeGridView1";
            kryptonTreeGridView1.Size = new System.Drawing.Size(546, 511);
            kryptonTreeGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.DefaultNodeImage = null;
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // splitter1
            // 
            splitter1.Location = new System.Drawing.Point(546, 25);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(3, 511);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // Grid
            // 
            Grid.DefaultCol.CellStyle = iGrid1DefaultCellStyle;
            Grid.DefaultCol.ColHdrStyle = iGrid1DefaultColHdrStyle;
            Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            Grid.Location = new System.Drawing.Point(549, 25);
            Grid.Name = "Grid";
            Grid.Size = new System.Drawing.Size(593, 511);
            Grid.TabIndex = 3;
            // 
            // TreeGrid
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1142, 536);
            Controls.Add(Grid);
            Controls.Add(splitter1);
            Controls.Add(kryptonTreeGridView1);
            Controls.Add(kryptonToolStrip1);
            Name = "TreeGrid";
            Text = "TreeGrid";
            ((System.ComponentModel.ISupportInitialize)kryptonTreeGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private Krypton.Toolkit.Suite.Extended.TreeGridView.KryptonTreeGridView kryptonTreeGridView1;
        private Krypton.Toolkit.Suite.Extended.TreeGridView.KryptonTreeGridColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Splitter splitter1;
        private TenTec.Windows.iGridLib.iGrid Grid;
        private TenTec.Windows.iGridLib.iGCellStyle iGrid1DefaultCellStyle;
        private TenTec.Windows.iGridLib.iGColHdrStyle iGrid1DefaultColHdrStyle;
        private TenTec.Windows.iGridLib.iGCellStyle iGrid1RowTextColCellStyle;
    }
}