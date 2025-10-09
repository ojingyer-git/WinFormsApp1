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
            iGrid1DefaultCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            iGrid1DefaultColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            treeGridView1 = new AdvancedDataGridView.TreeGridView();
            Column5 = new AdvancedDataGridView.TreeGridColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)kryptonTreeGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)treeGridView1).BeginInit();
            SuspendLayout();
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            kryptonTreeGridView1.DoubleBuffered = false;
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
            Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // treeGridView1
            // 
            treeGridView1.AllowUserToAddRows = false;
            treeGridView1.AllowUserToDeleteRows = false;
            treeGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            treeGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column5, Column6, Column7 });
            treeGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            treeGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            treeGridView1.ImageList = null;
            treeGridView1.Location = new System.Drawing.Point(549, 25);
            treeGridView1.Name = "treeGridView1";
            treeGridView1.Size = new System.Drawing.Size(593, 511);
            treeGridView1.TabIndex = 3;
            treeGridView1.CellPainting += treeGridView1_CellPainting;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column5.DefaultNodeImage = null;
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Column5.Width = 63;
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.Name = "Column7";
            Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TreeGrid
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1142, 536);
            Controls.Add(treeGridView1);
            Controls.Add(splitter1);
            Controls.Add(kryptonTreeGridView1);
            Controls.Add(kryptonToolStrip1);
            DoubleBuffered = true;
            Name = "TreeGrid";
            Text = "TreeGrid";
            ((System.ComponentModel.ISupportInitialize)kryptonTreeGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)treeGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private Krypton.Toolkit.Suite.Extended.TreeGridView.KryptonTreeGridView kryptonTreeGridView1;
        private System.Windows.Forms.Splitter splitter1;
        private TenTec.Windows.iGridLib.iGCellStyle iGrid1DefaultCellStyle;
        private TenTec.Windows.iGridLib.iGColHdrStyle iGrid1DefaultColHdrStyle;
        private AdvancedDataGridView.TreeGridView treeGridView1;
        private Krypton.Toolkit.Suite.Extended.TreeGridView.KryptonTreeGridColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private AdvancedDataGridView.TreeGridColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}