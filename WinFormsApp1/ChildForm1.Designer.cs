
namespace WinFormsApp1
{
    partial class ChildForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildForm1));
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            tabPage2 = new System.Windows.Forms.TabPage();
            tabPage3 = new System.Windows.Forms.TabPage();
            scintilla1 = new ScintillaNET.Scintilla();
            tabPage4 = new System.Windows.Forms.TabPage();
            scintillaDiffControl1 = new ScintillaDiff.ScintillaDiffControl();
            tabPage5 = new System.Windows.Forms.TabPage();
            propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            jetProgressBar1 = new JetProgressBar();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            excel저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            excel클리보드로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            탭추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            plot1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            plot2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            plot3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            odAnyFile = new System.Windows.Forms.OpenFileDialog();
            tabPage6 = new System.Windows.Forms.TabPage();
            reoGridControl1 = new unvell.ReoGrid.ReoGridControl();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            splitContainer1.Location = new System.Drawing.Point(0, 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(jetProgressBar1);
            splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            splitContainer1.Size = new System.Drawing.Size(1389, 903);
            splitContainer1.SplitterDistance = 674;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(671, 903);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new System.Drawing.Point(15, 88);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(684, 790);
            tabControl1.TabIndex = 5;
            tabControl1.DrawItem += tabControl1_DrawItem;
            tabControl1.MouseClick += tabControl1_MouseClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(formsPlot1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(676, 762);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            formsPlot1.Location = new System.Drawing.Point(3, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new System.Drawing.Size(670, 756);
            formsPlot1.TabIndex = 0;
            formsPlot1.MouseDown += formsPlot1_MouseDown;
            formsPlot1.MouseMove += formsPlot1_MouseMove;
            formsPlot1.MouseUp += formsPlot1_MouseUp;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(676, 762);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(scintilla1);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(676, 762);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // scintilla1
            // 
            scintilla1.AutocompleteListSelectedBackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            scintilla1.LexerName = null;
            scintilla1.Location = new System.Drawing.Point(27, 40);
            scintilla1.Name = "scintilla1";
            scintilla1.ScrollWidth = 49;
            scintilla1.Size = new System.Drawing.Size(610, 313);
            scintilla1.TabIndex = 0;
            scintilla1.Text = "scintilla1";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(scintillaDiffControl1);
            tabPage4.Location = new System.Drawing.Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(676, 762);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // scintillaDiffControl1
            // 
            scintillaDiffControl1.AddedCharacterSymbol = '+';
            scintillaDiffControl1.CharacterComparison = true;
            scintillaDiffControl1.CharacterComparisonMarkAddRemove = true;
            scintillaDiffControl1.DiffColorAdded = System.Drawing.Color.FromArgb(212, 242, 196);
            scintillaDiffControl1.DiffColorChangeBackground = System.Drawing.Color.FromArgb(252, 255, 140);
            scintillaDiffControl1.DiffColorCharAdded = System.Drawing.Color.FromArgb(154, 234, 111);
            scintillaDiffControl1.DiffColorCharDeleted = System.Drawing.Color.FromArgb(225, 125, 125);
            scintillaDiffControl1.DiffColorDeleted = System.Drawing.Color.FromArgb(255, 178, 178);
            scintillaDiffControl1.DiffStyle = ScintillaDiff.ScintillaDiffStyles.DiffStyle.DiffSideBySide;
            scintillaDiffControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            scintillaDiffControl1.ImageRowAdded = (System.Drawing.Bitmap)resources.GetObject("scintillaDiffControl1.ImageRowAdded");
            scintillaDiffControl1.ImageRowAddedScintillaIndex = 28;
            scintillaDiffControl1.ImageRowDeleted = (System.Drawing.Bitmap)resources.GetObject("scintillaDiffControl1.ImageRowDeleted");
            scintillaDiffControl1.ImageRowDeletedScintillaIndex = 29;
            scintillaDiffControl1.ImageRowDiff = (System.Drawing.Bitmap)resources.GetObject("scintillaDiffControl1.ImageRowDiff");
            scintillaDiffControl1.ImageRowDiffScintillaIndex = 31;
            scintillaDiffControl1.ImageRowOk = (System.Drawing.Bitmap)resources.GetObject("scintillaDiffControl1.ImageRowOk");
            scintillaDiffControl1.ImageRowOkScintillaIndex = 30;
            scintillaDiffControl1.IsEntireLineHighlighted = false;
            scintillaDiffControl1.Location = new System.Drawing.Point(3, 3);
            scintillaDiffControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            scintillaDiffControl1.MarkColorIndexModifiedBackground = 31;
            scintillaDiffControl1.MarkColorIndexRemovedOrAdded = 30;
            scintillaDiffControl1.Name = "scintillaDiffControl1";
            scintillaDiffControl1.RemovedCharacterSymbol = '-';
            scintillaDiffControl1.Size = new System.Drawing.Size(670, 756);
            scintillaDiffControl1.TabIndex = 0;
            scintillaDiffControl1.TextLeft = "";
            scintillaDiffControl1.TextRight = "";
            scintillaDiffControl1.UseRowOkSign = false;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(propertyGrid1);
            tabPage5.Location = new System.Drawing.Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new System.Windows.Forms.Padding(3);
            tabPage5.Size = new System.Drawing.Size(676, 762);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            propertyGrid1.Location = new System.Drawing.Point(6, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new System.Drawing.Size(274, 368);
            propertyGrid1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(15, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(289, 29);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // jetProgressBar1
            // 
            jetProgressBar1.Location = new System.Drawing.Point(15, 12);
            jetProgressBar1.Name = "jetProgressBar1";
            jetProgressBar1.Size = new System.Drawing.Size(289, 23);
            jetProgressBar1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1, toolStripDropDownButton1, toolStripButton2, toolStripDropDownButton2, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1389, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
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
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { excel저장ToolStripMenuItem, excel클리보드로저장ToolStripMenuItem, 탭추가ToolStripMenuItem });
            toolStripDropDownButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // excel저장ToolStripMenuItem
            // 
            excel저장ToolStripMenuItem.Name = "excel저장ToolStripMenuItem";
            excel저장ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            excel저장ToolStripMenuItem.Text = "excel 저장";
            excel저장ToolStripMenuItem.Click += excel저장ToolStripMenuItem_Click;
            // 
            // excel클리보드로저장ToolStripMenuItem
            // 
            excel클리보드로저장ToolStripMenuItem.Name = "excel클리보드로저장ToolStripMenuItem";
            excel클리보드로저장ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            excel클리보드로저장ToolStripMenuItem.Text = "excel 클리보드로 저장";
            excel클리보드로저장ToolStripMenuItem.Click += excel클리보드로저장ToolStripMenuItem_Click;
            // 
            // 탭추가ToolStripMenuItem
            // 
            탭추가ToolStripMenuItem.Name = "탭추가ToolStripMenuItem";
            탭추가ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            탭추가ToolStripMenuItem.Text = "탭 추가";
            탭추가ToolStripMenuItem.Click += 탭추가ToolStripMenuItem_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (System.Drawing.Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new System.Drawing.Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { plot1ToolStripMenuItem, plot2ToolStripMenuItem, plot3ToolStripMenuItem });
            toolStripDropDownButton2.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // plot1ToolStripMenuItem
            // 
            plot1ToolStripMenuItem.Name = "plot1ToolStripMenuItem";
            plot1ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            plot1ToolStripMenuItem.Text = "Plot1";
            plot1ToolStripMenuItem.Click += plot1ToolStripMenuItem_Click;
            // 
            // plot2ToolStripMenuItem
            // 
            plot2ToolStripMenuItem.Name = "plot2ToolStripMenuItem";
            plot2ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            plot2ToolStripMenuItem.Text = "Plot2";
            plot2ToolStripMenuItem.Click += plot2ToolStripMenuItem_Click;
            // 
            // plot3ToolStripMenuItem
            // 
            plot3ToolStripMenuItem.Name = "plot3ToolStripMenuItem";
            plot3ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            plot3ToolStripMenuItem.Text = "Plot3";
            plot3ToolStripMenuItem.Click += plot3ToolStripMenuItem_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (System.Drawing.Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new System.Drawing.Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (System.Drawing.Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new System.Drawing.Size(23, 22);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (System.Drawing.Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new System.Drawing.Size(23, 22);
            toolStripButton5.Text = "toolStripButton5";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripProgressBar1 });
            statusStrip1.Location = new System.Drawing.Point(0, 909);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1389, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.AutoSize = false;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // odAnyFile
            // 
            odAnyFile.FileName = "openFileDialog1";
            odAnyFile.Filter = "All files|*.*";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(reoGridControl1);
            tabPage6.Location = new System.Drawing.Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new System.Windows.Forms.Padding(3);
            tabPage6.Size = new System.Drawing.Size(676, 762);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // reoGridControl1
            // 
            reoGridControl1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            reoGridControl1.ColumnHeaderContextMenuStrip = null;
            reoGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            reoGridControl1.LeadHeaderContextMenuStrip = null;
            reoGridControl1.Location = new System.Drawing.Point(3, 3);
            reoGridControl1.Name = "reoGridControl1";
            reoGridControl1.RowHeaderContextMenuStrip = null;
            reoGridControl1.Script = null;
            reoGridControl1.SheetTabContextMenuStrip = null;
            reoGridControl1.SheetTabNewButtonVisible = true;
            reoGridControl1.SheetTabVisible = true;
            reoGridControl1.SheetTabWidth = 60;
            reoGridControl1.ShowScrollEndSpacing = true;
            reoGridControl1.Size = new System.Drawing.Size(670, 756);
            reoGridControl1.TabIndex = 0;
            reoGridControl1.Text = "reoGridControl1";
            // 
            // ChildForm1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1389, 931);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(splitContainer1);
            Name = "ChildForm1";
            Text = "ChildForm1";
            Load += ChildForm1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabPage6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private JetProgressBar jetProgressBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem excel저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel클리보드로저장ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem 탭추가ToolStripMenuItem;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem plot1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plot2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plot3ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.TabPage tabPage4;
        private ScintillaDiff.ScintillaDiffControl scintillaDiffControl1;
        private System.Windows.Forms.OpenFileDialog odAnyFile;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.TabPage tabPage6;
        private unvell.ReoGrid.ReoGridControl reoGridControl1;
    }
}