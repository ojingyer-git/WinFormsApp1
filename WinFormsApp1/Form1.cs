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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            jetProgressBar1.Minimum = 0;
            jetProgressBar1.Maximum = 100;
            jetProgressBar1.Value = 20;
        }

        private Color GetJetColor(float value)
        {
            // 입력 값을 0에서 1 사이로 정규화합니다.
            value = Math.Max(0, Math.Min(1, value));

            // Jet 컬러 스펙트럼을 정의합니다.
            float r, g, b;
            if (value < 0.25)
            {
                r = 0;
                g = value * 4;
                b = 1;
            }
            else if (value < 0.5)
            {
                r = 0;
                g = 1;
                b = (0.5f - value) * 4;
            }
            else if (value < 0.75)
            {
                r = (value - 0.5f) * 4;
                g = 1;
                b = 0;
            }
            else
            {
                r = 1;
                g = (1 - value) * 4;
                b = 0;
            }

            // 색상을 반환합니다.
            return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Graphics g = e.Graphics;

            int nSteps = 24;

            float fStep;
            fStep = (float)pb.Width / nSteps;

            Rectangle rectFill = new Rectangle();
            for (int iOnBand = 0; iOnBand < nSteps; iOnBand++)
            {
                rectFill.X = iOnBand * (int)fStep;
                rectFill.Y = 0;
                rectFill.Width = (int)fStep;
                rectFill.Height = pb.Height;

                float percent = (float)iOnBand / nSteps;
                Color clr = GetJetColor(percent);

                g.FillRectangle(new SolidBrush(clr), rectFill);
            }
        }
    }
}
