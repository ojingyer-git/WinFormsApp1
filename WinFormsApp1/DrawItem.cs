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
    public partial class DrawItem : UserControl
    {
        public partial class PatternItem
        {
            public Point pStart;
            public Point pEnd;
            public string instructName;
            public List<string> argumentLines;

            public PatternItem()
            {
                pStart = new Point(0,0);
                pEnd = new Point(0, 0);
                instructName = "";
                argumentLines = new List<string>();
            }
        }


        public DrawItem()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            List<PatternItem> items = new List<PatternItem>();

            PatternItem item = new PatternItem();

            item.instructName = "JMP AA_START";
            item.argumentLines.Add("NOP XCYC");
            item.argumentLines.Add("NOP XCYC");
            item.argumentLines.Add("NOP XCYC");
            item.argumentLines.Add("NOP XCYC");

            items.Add(item);

            item = new PatternItem();

            item.instructName = "NOP";
            item.argumentLines.Add("NOP XCYC");
            item.argumentLines.Add("NOP XCYC");
            item.argumentLines.Add("NOP XCYC");
            item.argumentLines.Add("NOP XCYC");

            items.Add(item);

            Point st = new Point(20, 20);
            int xSize = 50, ySize = 50;
            int dummyX = 40, dummyY = 30;
            int x = 0, y = 0;
            foreach (var i in items)
            {
                i.pStart.X = st.X + x*(xSize + dummyX);
                i.pStart.Y = st.Y + y*(ySize + dummyY);

                i.pEnd.X = i.pStart.X + xSize;
                i.pEnd.Y = i.pStart.Y + ySize;

                x++;
                if (x == 5)
                {
                    x = 0;
                    y++;
                }
            }
            
            drawBox1.AddPatItem(items);
        }
    }
}
