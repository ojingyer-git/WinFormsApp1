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
            public Color backColor;

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

        public static Color GetRandomColor()
        {
            Random randomGen = new Random();
            // 0부터 255 사이의 무작위 정수 값을 R, G, B 각 채널에 할당합니다.
            int r = randomGen.Next(256); // 0부터 255까지의 정수
            int g = randomGen.Next(256);
            int b = randomGen.Next(256);

            // 생성된 RGB 값으로 Color 객체를 생성합니다.
            return Color.FromArgb(100, r, g, b);
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
            item.backColor = GetRandomColor();
            items.Add(item);

            item = new PatternItem();

            item.instructName = "NOP";
            item.argumentLines.Add("NOP XCYC");
            item.argumentLines.Add("NOP XCYC");
            item.argumentLines.Add("NOP XCYC");
            item.argumentLines.Add("NOP XCYC");
            item.backColor = GetRandomColor();

            items.Add(item);

            Point st = new Point(20, 20);
            int xSize = 65, ySize = 61;
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
