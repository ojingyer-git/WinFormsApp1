namespace WinFormsApp1
{
    partial class OptionForm
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonTreeView1 = new Krypton.Toolkit.KryptonTreeView();
            kryptonManager1 = new Krypton.Toolkit.KryptonManager(components);
            grid1 = new FlexCell.Grid();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(grid1);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(281, 450);
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new System.Drawing.Point(287, 12);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new System.Drawing.Size(90, 25);
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            kryptonButton1.Values.Text = "kryptonButton1";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonTreeView1
            // 
            kryptonTreeView1.Location = new System.Drawing.Point(319, 69);
            kryptonTreeView1.Name = "kryptonTreeView1";
            kryptonTreeView1.Size = new System.Drawing.Size(308, 369);
            kryptonTreeView1.TabIndex = 2;
            // 
            // kryptonManager1
            // 
            kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            // 
            // grid1
            // 
            grid1.DataSource = null;
            grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            grid1.Location = new System.Drawing.Point(0, 0);
            grid1.MouseWheelSpeed = 3;
            grid1.Name = "grid1";
            grid1.Size = new System.Drawing.Size(281, 450);
            grid1.TabIndex = 0;
            // 
            // OptionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(639, 450);
            Controls.Add(kryptonTreeView1);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonPanel1);
            Name = "OptionForm";
            Text = "OptionForm";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTreeView kryptonTreeView1;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private FlexCell.Grid grid1;
    }
}