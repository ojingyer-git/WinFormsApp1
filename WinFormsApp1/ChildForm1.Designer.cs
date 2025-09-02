
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
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
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
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1, toolStripDropDownButton1, toolStripButton2, toolStripDropDownButton2 });
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
            // tabPage4
            // 
            tabPage4.Location = new System.Drawing.Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(676, 762);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
    }
}