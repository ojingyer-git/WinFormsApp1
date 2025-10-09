using AdvancedDataGridView;
using Krypton.Toolkit.Suite.Extended.TreeGridView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TreeGrid : Form
    {
        public TreeGrid()
        {
            InitializeComponent();

            treeGridView1.DoubleBuffered(true);
            //KryptonTreeGridNodeRow? node1 = kryptonTreeGridView1.GridNodes.Add("Using DataView filter when binding to DataGridView", "You", @"10/19/2005 1:02 AM");
            ////node1.ImageIndex = 0;
            //var node2 = node1.Nodes.Add("Re: Using DataView filter when binding to DataGridView", "Me", @"10/19/2005 1:04 AM");
            ////node2.ImageIndex = 1;
            //var node = node2.Nodes.Add("Re: Using DataView filter when binding to DataGridView", "Another", @"10/19/2005 1:20 AM");
            ////node.ImageIndex = 2;
            //node = node2.Nodes.Add("Re: Using DataView filter when binding to DataGridView", "you", @"10/19/2005 1:21 AM");
            ////node.ImageIndex = 1;
            //node = node1.Nodes.Add("Re: Using DataView filter when binding to DataGridView", "you", @"10/19/2005 1:10 AM");

            kTreeGrid();
            iTreedGrid();

        }

        private void kTreeGrid()
        {
            List<KryptonTreeGridNodeRow> nodes = new List<KryptonTreeGridNodeRow>();

            int preTab = 0, nextTab = -1;
            StreamReader infile = new StreamReader("C:\\Users\\ke\\Downloads\\text.txt");
            string strLine;
            int n = 0;
            while ((strLine = infile.ReadLine()) != null)
            {
                string[] sp = strLine.Split(";");
                int tabCount = sp[0].Count(c => c == '\t');
                n++;

                if (tabCount == preTab)
                {
                    if (tabCount == 0)
                        kryptonTreeGridView1.GridNodes.Add(whiteReplace(sp[0], ""), n.ToString(), sp[1]);
                    else
                    {
                        nodes[tabCount - 1].Nodes.Add(whiteReplace(sp[0], ""), n.ToString(), sp[1]);
                    }
                }
                else if (tabCount > preTab)
                {
                    if (nodes.Count < tabCount)
                    {
                        if (nodes.Count == 0)
                        {
                            KryptonTreeGridNodeRow? node = kryptonTreeGridView1.GridNodes.Add(whiteReplace(sp[0], ""), n.ToString(), sp[1]);
                            nodes.Add(node);
                        }
                        else
                        {
                            KryptonTreeGridNodeRow? node = nodes[preTab - 1].Nodes.Add(whiteReplace(sp[0], ""), n.ToString(), sp[1]);
                            nodes.Add(node);
                        }
                    }
                    else
                    {
                        nodes[tabCount - 1] = nodes[preTab - 1].Nodes.Add(whiteReplace(sp[0], ""), n.ToString(), sp[1]);
                    }

                    preTab = tabCount;
                }
                else if (tabCount < preTab)
                {
                    nodes[tabCount - 1].Nodes.Add(whiteReplace(sp[0], ""), n.ToString(), sp[1]);
                    preTab = tabCount;
                }

            }
            infile.Close();

            kryptonTreeGridView1.ExpandAll();
        }

        private void iTreedGrid()
        {
            List<TreeGridNode> nodes = new List<TreeGridNode>();

            int preTab = 0, nextTab = -1;
            StreamReader infile = new StreamReader("C:\\Users\\ke\\Downloads\\text.txt");
            string strLine;
            int n = 0;

            for (int i = 0; i < 43; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = "PIN_" + i.ToString();
                column.HeaderText = "PIN_" + i.ToString();
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.Width = 20;
                

                treeGridView1.Columns.Add(column);
            }
            //treeGridView1.Columns.Add()

            string[] rows = new string[43 + 3];
            while ((strLine = infile.ReadLine()) != null)
            {
                string[] sp = strLine.Split(";");
                int tabCount = sp[0].Count(c => c == '\t');
                n++;

                rows[0] = whiteReplace(sp[0], "");
                rows[1] = n.ToString();
                rows[2] = sp[1];
                for (int j = 0; j < sp[1].Length; j++)
                    rows[j + 3] = sp[1].ElementAt(j).ToString();

                if (tabCount == preTab)
                {
                    if (tabCount == 0)
                    {
                        treeGridView1.Nodes.Add(rows);

                    }
                    else
                    {
                        nodes[tabCount - 1].Nodes.Add(rows);
                    }
                }
                else if (tabCount > preTab)
                {
                    if (nodes.Count < tabCount)
                    {
                        if (nodes.Count == 0)
                        {
                            TreeGridNode? node = treeGridView1.Nodes.Add(rows);
                            nodes.Add(node);
                            //node.Expand();
                        }
                        else
                        {
                            TreeGridNode? node = nodes[preTab - 1].Nodes.Add(rows);
                            nodes.Add(node);
                            //node.Expand();  
                        }
                    }
                    else
                    {
                        nodes[tabCount - 1] = nodes[preTab - 1].Nodes.Add(rows);
                    }

                    preTab = tabCount;
                }
                else if (tabCount < preTab)
                {
                    nodes[tabCount - 1].Nodes.Add(rows);
                    preTab = tabCount;
                }

            }
            infile.Close();

            treeGridView1.ExpandAll();
        }

        private string whiteReplace(string src, string repl)
        {
            string result = src.Replace(" ", repl);
            result = result.Replace("\t", repl);

            return result;
        }

        private void treeGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // 열 헤더인 경우에만
            if (e.RowIndex == -1 && e.ColumnIndex >= 3)
            {
                e.Handled = true; // 기본 그리기 방지

                // 배경색과 테두리 그리기
                e.PaintBackground(e.ClipBounds, true);

                // 텍스트 그리기
                using (SolidBrush brush = new SolidBrush(e.CellStyle.ForeColor))
                using (StringFormat sf = new StringFormat())
                {
                    // 텍스트 중앙 정렬
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    // 그래픽 변환: 텍스트 회전
                    e.Graphics.TranslateTransform(e.CellBounds.X + (e.CellBounds.Width / 2), e.CellBounds.Y + (e.CellBounds.Height / 2));
                    e.Graphics.RotateTransform(90); // -90도 회전

                    // 텍스트 그리기
                    e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, brush, 0, 0, sf);

                    // 그래픽 변환 원상복귀
                    e.Graphics.ResetTransform();
                }
            }
        }
    }
}
public static class ExtensionMethods1
{
    public static void DoubleBuffered(this TreeGridView dgv, bool setting)
    {
        Type dgvType = dgv.GetType();
        PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
        BindingFlags.Instance | BindingFlags.NonPublic);
        pi.SetValue(dgv, setting, null);
    }
}