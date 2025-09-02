//using Krypton.Docking;
//using Krypton.Navigator;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ChildForm2 : Form
    {
        private int _count = 1;
        public ChildForm2()
        {
            InitializeComponent();
        }

        //private KryptonPage NewPage(string name, int image, Control content)
        //{
        //    // Create new page with title and image
        //    KryptonPage p = new KryptonPage();
        //    p.Text = name + _count.ToString();
        //    p.TextTitle = name + _count.ToString();
        //    p.TextDescription = name + _count.ToString();
        //    p.UniqueName = p.Text;
        //    //p.ImageSmall = imageListSmall.Images[image];

        //    // Add the control for display inside the page
        //    content.Dock = DockStyle.Fill;
        //    p.Controls.Add(content);

        //    _count++;
        //    return p;
        //}
        //private KryptonPage NewDocument()
        //{
        //    KryptonPage page = NewPage("Document ", 0, new UserControl1());

        //    // Document pages cannot be docked or auto hidden
        //    page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden | KryptonPageFlags.DockingAllowDocked);
        //    ButtonSpecAny bsa = new ButtonSpecAny();
        //    bsa.Tag = page;
        //    bsa.Type = PaletteButtonSpecStyle.Close;
        //    bsa.Click += new EventHandler(OnClosePage);
        //    page.ButtonSpecs.Add(bsa);
            
        //    return page;
        //}
        //private void OnClosePage(object sender, EventArgs e)
        //{
        //    // Find the page this button is contained within
        //    ButtonSpecAny bsa = (ButtonSpecAny)sender;

        //    // Close the page
        //    //CloseMemoPage((KryptonPage)bsa.Tag);
        //}

        //private KryptonPage NewPropertyGrid()
        //{
        //    return NewPage("Properties ", 2, new ContentPropertyGrid());
        //}

        //private KryptonPage NewInput()
        //{
        //    return NewPage("Input ", 1, new UserControl3());
        //}

        private void ChildForm2_Load(object sender, EventArgs e)
        {
            //KryptonDockingWorkspace w = kryptonDockingManager.ManageWorkspace(kryptonDockableWorkspace);
            //kryptonDockingManager.ManageControl(kryptonPanel, w);
            //kryptonDockingManager.ManageFloating(this);

            //// Add initial docking pages
            //kryptonDockingManager.AddToWorkspace("Workspace", new KryptonPage[] { NewDocument(), NewDocument(), NewDocument(), NewDocument() });
            //kryptonDockingManager.AddDockspace("Control", DockingEdge.Left, new KryptonPage[] { NewPropertyGrid() });
            //kryptonDockingManager.AddDockspace("Control", DockingEdge.Bottom, new KryptonPage[] { NewInput() });

            

            //kryptonManager.GlobalPaletteMode = PaletteMode.Microsoft365Silver;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //kryptonDockableWorkspace.ApplyGridPages(false);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //kryptonDockableWorkspace.ApplySingleCell();
        }
    }
}
