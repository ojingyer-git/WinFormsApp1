using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit.Suite.Extended.TreeGridView;

namespace WinFormsApp1
{
    public partial class TreeGrid : Form
    {
        public TreeGrid()
        {
            InitializeComponent();


            //KryptonTreeGridNodeRow? node1 = kryptonTreeGridView1.GridNodes.Add("Using DataView filter when binding to DataGridView", "You", @"10/19/2005 1:02 AM");
            ////node1.ImageIndex = 0;
            //var node2 = node1.Nodes.Add("Re: Using DataView filter when binding to DataGridView", "Me", @"10/19/2005 1:04 AM");
            ////node2.ImageIndex = 1;
            //var node = node2.Nodes.Add("Re: Using DataView filter when binding to DataGridView", "Another", @"10/19/2005 1:20 AM");
            ////node.ImageIndex = 2;
            //node = node2.Nodes.Add("Re: Using DataView filter when binding to DataGridView", "you", @"10/19/2005 1:21 AM");
            ////node.ImageIndex = 1;
            //node = node1.Nodes.Add("Re: Using DataView filter when binding to DataGridView", "you", @"10/19/2005 1:10 AM");

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

        private string whiteReplace(string src, string repl)
        {
            string result = src.Replace(" ", repl);
            result = result.Replace("\t", repl);

            return result;
        }
    }
}
