using Krypton.Docking;
using Krypton.Navigator;
using Krypton.Toolkit;
using Krypton.Workspace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ChildForm2 : Form
    {
        public ChildForm2()
        {
            InitializeComponent();
        }

        private void ChildForm2_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonPanel1, w);
            kryptonDockingManager1.ManageFloating(this);

            // Add initial docking pages
            //kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewDocument(), NewDocument() });
            KryptonDockingDockspace temp = kryptonDockingManager1.AddDockspace("Control", DockingEdge.Left, new KryptonPage[] { NewPage("tree", 0, new treeForm()) });


            kryptonDockingManager1.AddDockspace("Control", DockingEdge.Bottom, new KryptonPage[] { NewPage("output", 0, new outForm()) });

        }

        private KryptonPage NewDocument()
        {
            KryptonPage page = NewPage("Document ", 0, new ContentDocument());

            // Document pages cannot be docked or auto hidden
            page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden | KryptonPageFlags.DockingAllowDocked);

            return page;
        }

        private KryptonPage NewDocument(string name)
        {
            KryptonPage p = new KryptonPage();
            p.Text = name + "_" + kryptonDockableWorkspace1.CellCount.ToString();
            p.TextTitle = name;
            p.TextDescription = name;
            //p.ImageSmall = imageListSmall.Images[image];

            // Add the control for display inside the page
            TreeGrid textF = new TreeGrid();
            textF.Dock = DockStyle.Fill;
            textF.TopLevel = false; // 최상위 폼이 아님을 설정
            textF.FormBorderStyle = FormBorderStyle.None; // 폼의 테두리 없애기
            p.Controls.Add(textF);

            return p;

            // Document pages cannot be docked or auto hidden
            //page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden | KryptonPageFlags.DockingAllowDocked);
        }

        private KryptonPage NewPage(string name, int image, Control content)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage();
            p.Text = name;
            p.TextTitle = name;
            p.TextDescription = name;
            //p.ImageSmall = imageListSmall.Images[image];

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);

            return p;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            TreeGrid tr = new TreeGrid();
            tr.ShowDialog();
            //KryptonWorkspaceCell cell = kryptonDockableWorkspace1.ActiveCell;
            //if (cell == null)
            //{
            //    cell = new KryptonWorkspaceCell();
            //    kryptonDockableWorkspace1.Root.Children.Add(cell);
            //}

            //// Create new document to be added into workspace
            //KryptonPage page = NewDocument("new");
            //cell.Pages.Add(page);

            //// Make the new page the selected page
            //cell.SelectedPage = page;


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            KryptonWorkspaceCell cell = kryptonDockableWorkspace1.ActiveCell;
            if (cell == null)
            {
                cell = new KryptonWorkspaceCell();
                kryptonDockableWorkspace1.Root.Children.Add(cell);
            }

            // Create new document to be added into workspace
            KryptonPage page = NewDocument();
            cell.Pages.Add(page);

            // Make the new page the selected page
            cell.SelectedPage = page;
        }

        private void kryptonDockableWorkspace1_PageCloseClicked(object sender, UniqueNameEventArgs e)
        {

            MessageBox.Show("close");
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string exeFilePath = Application.ExecutablePath;
            try
            {
                // FileVersionInfo 인스턴스 가져오기
                FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(exeFilePath);


                // 파일 버전 및 제품 버전 가져오기
                string fileVersion = myFileVersionInfo.FileVersion;
                string productVersion = myFileVersionInfo.ProductVersion;

                Console.WriteLine($"파일 버전: {fileVersion}");
                Console.WriteLine($"제품 버전: {productVersion}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("해당 경로에 .exe 파일이 없습니다.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"오류 발생: {ex.Message}");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            KryptonWorkspaceCell cell = kryptonDockableWorkspace1.ActiveCell;
            if (cell == null)
            {
                cell = new KryptonWorkspaceCell();
                kryptonDockableWorkspace1.Root.Children.Add(cell);
            }

            // Create new document to be added into workspace
            KryptonPage page = NewPage("Draw ", 0, new DrawItem());
            cell.Pages.Add(page);

            // Make the new page the selected page
            cell.SelectedPage = page;
        }
    }
}
