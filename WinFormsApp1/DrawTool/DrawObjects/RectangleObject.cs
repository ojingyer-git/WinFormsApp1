using OpenTK.Platform.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1;
using static ScintillaNET.Style;

namespace DrawTool.DrawObjects
{
    /// <summary>
    /// 사각형을 그려주는 클래스, DrawObject를 상속 받는다.
    /// </summary>

    //클래스를 직렬화한다.
    [Serializable]
    class RectangleObject : DrawObject
    {
        #region 전역 변수
        public DrawObject inputConnectObj= null, resultConnectObj= null;
        private Rectangle rectangle;
        private Rectangle inputRect, resultRect;
        private Rectangle[] iconRect = new Rectangle[5];
        private Image[] iconImage = new Image[5];
        private Rectangle textRect;

        private int inoutSize = 12;
        private int tempBezier = 20;

        private const int inputConnectHandle = 101;
        private const int resultConnectHandel = 102;
        //private Point inputConnect = new Point(0, 0);
        private Point tempresultConnect = new Point(0, 0);

        private string instructName;
        private List<string> argumentLines = new List<string>();
        
        #endregion

        #region 생성자

        public RectangleObject() : this(0, 0, 1, 1)
		{
           
		}


        public RectangleObject(int x, int y, int width, int height)
            : base()
        {
            rectangle.X = x;
            rectangle.Y = y;
            rectangle.Width = width;
            rectangle.Height = height;

            SetInOutRect();
            Initialize();

            for (int i = 0; i < 5; i++)
                iconImage[i] = null;
        }

        #endregion

        #region 내부함수
      
        /// <summary>
        /// 이 객체를 복사한다.
        /// </summary>
        public override DrawObject Clone()
        {
            RectangleObject rectangleObject = new RectangleObject();
            rectangleObject.rectangle = this.rectangle;
            rectangleObject.inputRect = this.inputRect;
            rectangleObject.resultRect = this.resultRect;
            rectangleObject.resultConnectObj = this.resultConnectObj;
            rectangleObject.inputConnectObj = this.inputConnectObj;

            FillDrawObjectFields(rectangleObject);
            return rectangleObject;
        }


        /// <summary>
        /// 이 객체를 그려준다.
        /// </summary>
        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, PenWidth))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawRectangle(pen, RectangleObject.GetNormalizedRectangle(Rectangle));



                g.DrawRectangle(pen, RectangleObject.GetNormalizedRectangle(inputRect));
                g.DrawRectangle(pen, RectangleObject.GetNormalizedRectangle(resultRect));

                

                if (inputConnectObj != null)
                {
                    if (inputConnectObj.Deleted == false)
                    {
                        Point inputConnect = inputConnectObj.GetHandle(resultConnectHandel);
                        Point[] pBezier = new Point[4];
                        pBezier[0] = GetHandle(inputConnectHandle);

                        if (pBezier[0].X > inputConnect.X)
                        {
                            tempBezier = (pBezier[0].X - inputConnect.X) / 2;
                        }
                        pBezier[1].X = pBezier[0].X + tempBezier;
                        pBezier[1].Y = pBezier[0].Y;
                        pBezier[2].X = inputConnect.X - tempBezier;
                        pBezier[2].Y = inputConnect.Y;
                        pBezier[3] = inputConnect;
                    }
                }
                if (resultConnectObj != null)
                {
                    if (resultConnectObj.Deleted == false)
                    {
                        Point resultConnect = resultConnectObj.GetHandle(inputConnectHandle);
                        Point[] pBezier = new Point[4];
                        pBezier[0] = GetHandle(resultConnectHandel);

                        if (pBezier[0].X > resultConnect.X)
                        {
                            tempBezier = (pBezier[0].X - resultConnect.X) / 2;
                        }
                        pBezier[1].X = pBezier[0].X + tempBezier;
                        pBezier[1].Y = pBezier[0].Y;
                        pBezier[2].X = resultConnect.X - tempBezier;
                        pBezier[2].Y = resultConnect.Y;
                        pBezier[3] = resultConnect;

                        g.DrawBezier(pen, pBezier[0], pBezier[1], pBezier[2], pBezier[3]);
                    }
                }

                if (tempresultConnect != new Point(0, 0))
                {
                    Point[] pBezier = new Point[4];
                    pBezier[0] = new Point(resultRect.X + inputRect.Width, inputRect.Y + inputRect.Height / 2);

                    if (pBezier[0].X > tempresultConnect.X)
                    {
                        tempBezier = (pBezier[0].X - tempresultConnect.X) / 2;
                    }
                    pBezier[1].X = pBezier[0].X + tempBezier;
                    pBezier[1].Y = pBezier[0].Y;
                    pBezier[2].X = tempresultConnect.X - tempBezier;
                    pBezier[2].Y = tempresultConnect.Y;
                    pBezier[3] = tempresultConnect;

                    g.DrawBezier(pen, pBezier[0], pBezier[1], pBezier[2], pBezier[3]);
                }

                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    g.FillRectangle(brush, Rectangle);
                }

                //Image img = Image.FromFile("C:\\Users\\ke\\Downloads\\resize.png");

                for (int i = 0; i<5; i++)
                {
                    if (iconImage[i] != null)
                        g.DrawImage(iconImage[i], iconRect[i]);
                }

                using (Font font2 = new Font(/*"Consols"*/"Arial", 7, FontStyle.Bold, GraphicsUnit.Point))
                {
                    //g.DrawRectangle(Pens.Black, Rectangle.Round(textRect));
                    using (SolidBrush brush = new SolidBrush(SystemColors.GradientInactiveCaption))
                    {
                        g.FillRectangle(brush, textRect);
                    }

                    // Specify the text is wrapped.
                    TextFormatFlags flags = TextFormatFlags.WordBreak;
                    TextRenderer.DrawText(g, instructName.Replace(" ", "\r\n"), font2, textRect, Color.DarkRed, flags);
                    
                    //g.DrawRectangle(pen, RectangleObject.GetNormalizedRectangle(textRect));
                }


            }
        }

        //Retangle 의 크기와 위치를 설정한다.
        protected void SetRectangle(int x, int y, int width, int height)
        {
            rectangle.X = x;
            rectangle.Y = y;
            rectangle.Width = width;
            rectangle.Height = height;

            SetInOutRect();
        }

        private void SetInOutRect()
        {
            inputRect = new Rectangle(rectangle.X - inoutSize, rectangle.Y + rectangle.Height / 2 - inoutSize / 2, inoutSize, inoutSize);
            resultRect = new Rectangle(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height / 2 - inoutSize / 2, inoutSize, inoutSize);

            iconRect[0] = new Rectangle(Rectangle.X + 2, Rectangle.Y + 2, 30, 30);

            iconRect[1] = new Rectangle(iconRect[0].Right + 2, iconRect[0].Top, 13, 13);
            iconRect[2] = new Rectangle(iconRect[1].Right + 2, iconRect[0].Top, 13, 13);
            iconRect[3] = new Rectangle(iconRect[0].Right + 3, iconRect[1].Bottom + 2, 13, 13);
            iconRect[4] = new Rectangle(iconRect[1].Right + 3, iconRect[1].Bottom + 2, 13, 13);

            textRect = new Rectangle(rectangle.X, inputRect.Bottom, rectangle.Width, 25);

            //iconRect[2] = new Rectangle(iconRect[0].X + 1, iconRect[0].Bottom + 2, 13, 13);
            //iconRect[3] = new Rectangle(iconRect[2].Right + 3, iconRect[0].Bottom + 2, 13, 13);
            //iconRect[4] = new Rectangle(iconRect[3].Right + 3, iconRect[0].Bottom + 2, 13, 13);

            //textRect = new Rectangle(rectangle.X, iconRect[2].Bottom + 5, rectangle.Width, 20);
        }
        
        /// <summary>
        /// 핸들 넘버의 위치를 반환한다.
        /// </summary>
        public override Point GetHandle(int handleNumber)
        {
            int x, y, xCenter, yCenter;

            xCenter = rectangle.X + rectangle.Width/2;
            yCenter = rectangle.Y + rectangle.Height/2;
            x = rectangle.X;
            y = rectangle.Y;

            switch ( handleNumber )
            {
                case 1:
                    x = rectangle.X;
                    y = rectangle.Y;
                    break;
                case 2:
                    x = xCenter;
                    y = rectangle.Y;
                    break;
                case 3:
                    x = rectangle.Right;
                    y = rectangle.Y;
                    break;
                case 4:
                    x = rectangle.Right;
                    y = yCenter;
                    break;
                case 5:
                    x = rectangle.Right;
                    y = rectangle.Bottom;
                    break;
                case 6:
                    x = xCenter;
                    y = rectangle.Bottom;
                    break;
                case 7:
                    x = rectangle.X;
                    y = rectangle.Bottom;
                    break;
                case 8:
                    x = rectangle.X;
                    y = yCenter;
                    break;
                case inputConnectHandle:
                    x = inputRect.X;
                    y = inputRect.Y + inputRect.Height / 2;
                    
                    break;
                case resultConnectHandel:
                    x = resultRect.X + resultRect.Width;
                    y = resultRect.Y + resultRect.Height / 2;

                    break;
            }



            return new Point(x, y);

        }

        /// <summary>
        ///  마우스가 클릭된 위치가 DrawObject를 포함하는지 알려준다
        ///  -1 - no hit
        ///   0 - hit anywhere
        /// > 1 - handle number
        /// </summary>
        public override int HitTest(Point point)
        {
           // if ( Selected )
            {
                for ( int i = 1; i <= HandleCount; i++ )
                {
                    if ( GetHandleRectangle(i).Contains(point) )
                        return i;
                }

                if (resultRect.Contains(point))
                    return 102;
            }

            if ( PointInObject(point) )
                return 0;

            return -1;
        }

        /// <summary>
        /// 마우스의 위치가 DrawObject 내에 있는지 알려준다.
        /// </summary>
        protected override bool PointInObject(Point point)
        {
            return rectangle.Contains(point);
        }

        
        /// <summary>
        /// Pointer 의 HandleNumber 에 따라서 마우스 커서를 반환한다.
        /// </summary>
        public override Cursor GetHandleCursor(int handleNumber)
        {
            switch ( handleNumber )
            {
                case 1:
                    return Cursors.SizeNWSE;
                case 2:
                    return Cursors.SizeNS;
                case 3:
                    return Cursors.SizeNESW;
                case 4:
                    return Cursors.SizeWE;
                case 5:
                    return Cursors.SizeNWSE;
                case 6:
                    return Cursors.SizeNS;
                case 7:
                    return Cursors.SizeNESW;
                case 8:
                    return Cursors.SizeWE;
                case 102:
                    return Cursors.Hand;
                default:
                    return Cursors.Default;
            }
        }

        /// <summary>
        /// DrawObject 의 사이즈를 변경한다.
        /// </summary>
        public override void MoveHandleTo(Point point, int handleNumber)
        {
            int left = Rectangle.Left;
            int top = Rectangle.Top;
            int right = Rectangle.Right;
            int bottom = Rectangle.Bottom;

            switch ( handleNumber )
            {
                case 1:
                    left = point.X;
                    top = point.Y;
                    break;
                case 2:
                    top = point.Y;
                    break;
                case 3:
                    right = point.X;
                    top = point.Y;
                    break;
                case 4:
                    right = point.X;
                    break;
                case 5:
                    right = point.X;
                    bottom = point.Y;
                    break;
                case 6:
                    bottom = point.Y;
                    break;
                case 7:
                    left = point.X;
                    bottom = point.Y;
                    break;
                case 8:
                    left = point.X;
                    break;
                case resultConnectHandel:
                    tempresultConnect = point;
                    resultConnectObj = null;
                    break;
            }

            if (handleNumber > 0 && handleNumber < 100)
            {
                SetRectangle(left, top, right - left, bottom - top);
            }
                
        }

        /// <summary>
        /// DrawObject가 rectangle 에 포함되는지 알려준다.
        /// </summary>
        public override bool IntersectsWith(Rectangle rectangle)
        {
            return Rectangle.IntersectsWith(rectangle);
        }
        public override bool Contains(Point point)
        {
            return Rectangle.Contains(point);
        }

        /// <summary>
        /// DrawObject 의 위치를 이동한다.
        /// </summary>
        public override void Move(int deltaX, int deltaY)
        {
            rectangle.X += deltaX;
            rectangle.Y += deltaY;

            SetInOutRect();
        }
        
        /// <summary>
        /// DrawObject 를 새로 그리거나, 사이즈를 변경이 끝났을 때 호출된다.
        /// </summary>
        public override void Normalize()
        {
            rectangle = RectangleObject.GetNormalizedRectangle(rectangle);

            SetInOutRect();
        }

        public override void SetConnect(DrawObject obj, int handleNumber)
        {
            if (handleNumber == inputConnectHandle)
                inputConnectObj = obj;
            else if (handleNumber == resultConnectHandel)
                resultConnectObj = obj;

            tempresultConnect = new Point(0, 0);
        }

        public override void SetArgument(string instruction, List<string> argument, List<Image> iconImages)
        {
            argument.Clear();
            
            instructName = instruction;
            argumentLines.AddRange(argument);

            string[] sp = instruction.Split(' ');
            int idx = 0;
            if (sp.Length > 1)
            {
                idx = sp[1].ToUpper().ElementAt(0) - 55;
            }
            else
            {
                idx = sp[0].ToUpper().ElementAt(0) - 55;
            }

            if (idx >= 10 && idx <= 35)
                iconImage[0] = iconImages[idx];

            int n = 1;
            if (sp[0].Contains("JMP"))
            {
                iconImage[n] = WinFormsApp1.Properties.Resources.tree2;
                n++;
            }
            else if (sp[0].Contains("IDXI"))
            {
                iconImage[n] = WinFormsApp1.Properties.Resources.repeat7;
                n++;
            }

            bool[] bCheck = new bool[3];
            for (int i = 0; i < 3; i++)
                bCheck[i] = false;
            foreach (string s in argumentLines)
            {
                sp = s.Split(" ");
                foreach (string ss in sp)
                {
                    if (ss == "NOP" || ss == "XCYC")
                        continue;

                    if (ss.Contains("W"))
                        bCheck[0] = true;
                    if (ss.Contains("R"))
                        bCheck[1] = true;
                    else if (ss.Contains("<"))
                        bCheck[2] = true;
                }
            }

            bool bIcon = false;
            for (int i = 0; i<3; i++)
            {
                if (bCheck[i])
                {
                    bIcon = true;
                    switch (i)
                    {
                        case 0:
                            iconImage[n] = WinFormsApp1.Properties.Resources.W;
                            n++;
                            break;
                        case 1:
                            iconImage[n] = WinFormsApp1.Properties.Resources.R;
                            n++;
                            break;
                        case 2:
                            iconImage[n] = WinFormsApp1.Properties.Resources.pin;
                            n++;
                            break;
                    }

                }
                if (n >= 5)
                    break;
            }



            iconImage[1] = WinFormsApp1.Properties.Resources.tree2;
            iconImage[2] = WinFormsApp1.Properties.Resources.repeat7;
            iconImage[3] = WinFormsApp1.Properties.Resources.W;
            iconImage[4] = WinFormsApp1.Properties.Resources.R;
        }

        /// <summary>
        /// Retagle을 그려준다
        /// </summary>
        public static Rectangle GetNormalizedRectangle(int x1, int y1, int x2, int y2)
        {
            if ( x2 < x1 )
            {
                int tmp = x2;
                x2 = x1;
                x1 = tmp;
            }

            if ( y2 < y1 )
            {
                int tmp = y2;
                y2 = y1;
                y1 = tmp;
            }
           
            return new Rectangle(x1, y1, x2 - x1, y2 - y1);
        }

        /// <summary>
        /// Retagle을 그려준다
        /// </summary>
        public static Rectangle GetNormalizedRectangle(Point p1, Point p2)
        {
            return GetNormalizedRectangle(p1.X, p1.Y, p2.X, p2.Y);
        }

        /// <summary>
        /// Retagle을 그려준다
        /// </summary>
        public static Rectangle GetNormalizedRectangle(Rectangle r)
        {
            return GetNormalizedRectangle(r.X, r.Y, r.X + r.Width, r.Y + r.Height);
        }

        #endregion

        #region 속성

        /// <summary>
        /// 핸들의 숫자를 반환한다.
        /// </summary>
        public override int HandleCount
        {
            get
            {
                return 8;
            }
        }

        protected Rectangle Rectangle
        {
            get
            {
                return rectangle;
            }
            set
            {
                rectangle = value;
                SetInOutRect();
            }
        }

        #endregion

    }
}
