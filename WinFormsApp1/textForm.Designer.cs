namespace WinFormsApp1
{
    partial class textForm
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            scintilla1 = new ScintillaNET.Scintilla();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            kryptonToolStrip1.Location = new System.Drawing.Point(0, 0);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.Size = new System.Drawing.Size(800, 25);
            kryptonToolStrip1.TabIndex = 0;
            kryptonToolStrip1.Text = "kryptonToolStrip1";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(scintilla1);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel1.Location = new System.Drawing.Point(0, 25);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(800, 425);
            kryptonPanel1.TabIndex = 1;
            // 
            // scintilla1
            // 
            scintilla1.AutocompleteListSelectedBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            scintilla1.LexerName = null;
            scintilla1.Location = new System.Drawing.Point(0, 0);
            scintilla1.Name = "scintilla1";
            scintilla1.ScrollWidth = 49;
            scintilla1.Size = new System.Drawing.Size(800, 425);
            scintilla1.TabIndex = 0;
            scintilla1.Text = "scintilla1";
            // 
            // textForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonToolStrip1);
            Name = "textForm";
            Text = "textForm";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ScintillaNET.Scintilla scintilla1;
    }
}