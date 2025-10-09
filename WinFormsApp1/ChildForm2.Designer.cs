namespace WinFormsApp1
{
    partial class ChildForm2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildForm2));
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonDockableWorkspace1 = new Krypton.Docking.KryptonDockableWorkspace();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            kryptonDockingManager1 = new Krypton.Docking.KryptonDockingManager();
            kryptonManager1 = new Krypton.Toolkit.KryptonManager(components);
            toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDockableWorkspace1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            kryptonToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            kryptonStatusStrip1.Location = new System.Drawing.Point(0, 475);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new System.Drawing.Size(800, 22);
            kryptonStatusStrip1.TabIndex = 0;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(kryptonPanel1);
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 450);
            toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new System.Drawing.Size(800, 475);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(kryptonToolStrip1);
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonDockableWorkspace1);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(800, 450);
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonDockableWorkspace1
            // 
            kryptonDockableWorkspace1.ActivePage = null;
            kryptonDockableWorkspace1.CompactFlags = Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences | Krypton.Workspace.CompactFlags.PromoteLeafs;
            kryptonDockableWorkspace1.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            kryptonDockableWorkspace1.ContextMenus.ShortcutClose = System.Windows.Forms.Keys.D0;
            kryptonDockableWorkspace1.ContextMenus.TextClose = "";
            kryptonDockableWorkspace1.ContextMenuStrip = contextMenuStrip1;
            kryptonDockableWorkspace1.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonDockableWorkspace1.Location = new System.Drawing.Point(0, 0);
            kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            kryptonDockableWorkspace1.Root.UniqueName = "bec69f7b4ad54b26b4dbda6764518fa3";
            kryptonDockableWorkspace1.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile;
            kryptonDockableWorkspace1.ShowMaximizeButton = false;
            kryptonDockableWorkspace1.Size = new System.Drawing.Size(800, 450);
            kryptonDockableWorkspace1.SplitterWidth = 5;
            kryptonDockableWorkspace1.TabIndex = 0;
            kryptonDockableWorkspace1.TabStop = true;
            kryptonDockableWorkspace1.PageCloseClicked += kryptonDockableWorkspace1_PageCloseClicked;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { nextToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            // 
            // nextToolStripMenuItem
            // 
            nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            nextToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            nextToolStripMenuItem.Text = "Next";
            nextToolStripMenuItem.Click += nextToolStripMenuItem_Click;
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            kryptonToolStrip1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            kryptonToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4 });
            kryptonToolStrip1.Location = new System.Drawing.Point(3, 0);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.Size = new System.Drawing.Size(135, 25);
            kryptonToolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click_1;
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
            // kryptonManager1
            // 
            kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
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
            // ChildForm2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 497);
            Controls.Add(toolStripContainer1);
            Controls.Add(kryptonStatusStrip1);
            Name = "ChildForm2";
            Text = "ChildForm2";
            Load += ChildForm2_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonDockableWorkspace1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            kryptonToolStrip1.ResumeLayout(false);
            kryptonToolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}