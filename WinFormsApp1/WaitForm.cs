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
    public partial class WaitForm : Form
    {
        private Image gifImage;
        private bool isAnimating = false;

        public WaitForm()
        {
            InitializeComponent();
  
        }

        private void WaitForm_Load(object sender, EventArgs e)
        {
            try
            {
               
                     
                pictureBox1.BackColor = Color.Transparent;

                gifImage = Image.FromFile("your_gif_image.gif");
                pictureBox1.Image = gifImage;
                StartAnimation();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading GIF: {ex.Message}");
            }
        }

        private void StartAnimation()
        {
            if (!isAnimating && gifImage != null)
            {
                isAnimating = true;
                ImageAnimator.Animate(gifImage, OnFrameChanged);
                Application.Idle += Application_Idle; // 애니메이션을 위해 Application.Idle 이벤트에 핸들러 추가
            }
        }
        private void StopAnimation()
        {
            if (isAnimating)
            {
                isAnimating = false;
                ImageAnimator.StopAnimate(gifImage, OnFrameChanged);
                Application.Idle -= Application_Idle; // 이벤트 핸들러 제거
            }
        }


        private void OnFrameChanged(object sender, EventArgs e)
        {
            // PictureBox를 다시 그리도록 요청
            pictureBox1.Invalidate();
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            if (isAnimating && gifImage != null)
            {
                // 다음 프레임으로 이동
                ImageAnimator.UpdateFrames();
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (gifImage != null)
            {
                // 현재 프레임 그리기
                ImageAnimator.UpdateFrames();
                pe.Graphics.DrawImage(gifImage, pictureBox1.Location);
            }
        }

        private void WaitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAnimation();
            gifImage?.Dispose(); // 리소스 해제
        }
    }
}
