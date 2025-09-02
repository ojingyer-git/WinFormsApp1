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
            kryptonToolStrip = new Krypton.Toolkit.KryptonToolStrip();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            //kryptonDockingManager = new Krypton.Docking.KryptonDockingManager();
            kryptonManager = new Krypton.Toolkit.KryptonManager(components);
            kryptonPanel = new Krypton.Toolkit.KryptonPanel();
            //kryptonDockableWorkspace = new Krypton.Docking.KryptonDockableWorkspace();
            kryptonToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel).BeginInit();
            kryptonPanel.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)kryptonDockableWorkspace).BeginInit();
            SuspendLayout();
            // 
            // kryptonToolStrip
            // 
            kryptonToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            kryptonToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1, toolStripButton2 });
            kryptonToolStrip.Location = new System.Drawing.Point(0, 0);
            kryptonToolStrip.Name = "kryptonToolStrip";
            kryptonToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            kryptonToolStrip.Size = new System.Drawing.Size(1134, 25);
            kryptonToolStrip.TabIndex = 0;
            kryptonToolStrip.Text = "kryptonToolStrip1";
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
            // kryptonPanel
            // 
            //kryptonPanel.Controls.Add(kryptonDockableWorkspace);
            kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel.Location = new System.Drawing.Point(0, 25);
            kryptonPanel.Name = "kryptonPanel";
            kryptonPanel.Size = new System.Drawing.Size(1134, 551);
            kryptonPanel.TabIndex = 1;
            // 
            // kryptonDockableWorkspace
            // 
            //kryptonDockableWorkspace.ActivePage = null;
            //kryptonDockableWorkspace.CompactFlags = Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences | Krypton.Workspace.CompactFlags.PromoteLeafs;
            //kryptonDockableWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            //kryptonDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            //kryptonDockableWorkspace.Location = new System.Drawing.Point(0, 0);
            //kryptonDockableWorkspace.Name = "kryptonDockableWorkspace";
            //// 
            //// 
            //// 
            //kryptonDockableWorkspace.Root.UniqueName = "0c35d7be7e0a4475b9cb012e73398ae7";
            //kryptonDockableWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile;
            //kryptonDockableWorkspace.ShowMaximizeButton = false;
            //kryptonDockableWorkspace.Size = new System.Drawing.Size(1134, 551);
            //kryptonDockableWorkspace.SplitterWidth = 5;
            //kryptonDockableWorkspace.TabIndex = 0;
            //kryptonDockableWorkspace.TabStop = true;
            // 
            // ChildForm2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1134, 576);
            Controls.Add(kryptonPanel);
            Controls.Add(kryptonToolStrip);
            Name = "ChildForm2";
            Text = "ChildForm2";
            Load += ChildForm2_Load;
            kryptonToolStrip.ResumeLayout(false);
            kryptonToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel).EndInit();
            kryptonPanel.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)kryptonDockableWorkspace).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        //private Krypton.Docking.KryptonDockingManager kryptonDockingManager;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Toolkit.KryptonPanel kryptonPanel;
        //private Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace;
    }
}