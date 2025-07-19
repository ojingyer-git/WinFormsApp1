using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1
{
    public class JetProgressBar : ProgressBar
    {
        public JetProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // ProgressBar의 기본 스타일을 사용하지 않도록 설정합니다.
            e.Graphics.FillRectangle(Brushes.White, e.ClipRectangle);

            // 현재 진행 상태에 따라 색상을 계산합니다.
            float percent = (float)this.Value / this.Maximum;
            Color color = GetJetColor(percent);

            // ProgressBar의 진행 부분을 그립니다.
            Rectangle rect = new Rectangle(0, 0, (int)(this.Width * percent), this.Height);
            using (SolidBrush brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            // 테두리를 그립니다.
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
        }

        // Jet 컬러 스펙트럼을 기반으로 색상을 계산하는 함수입니다.
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
    }
}