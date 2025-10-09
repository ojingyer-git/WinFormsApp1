using DrawTool.Controller;
using DrawTool.DrawObjects;
using DrawTool.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DrawBox : UserControl, IObserver
    {
        private bool allowResize = false;
        private DrawObject selectObject;
        private int selectObjectHandle;

        private Point pStart = new Point(0, 0);
        private Point pEnd = new Point(0, 0);
        private Point pMoveMaxEnd = new Point(0, 0);
        private Point pFocusStart = new Point(0, 0);
        private Point pFocusEnd = new Point(0, 0);
        private const int MinDistance = 15 * 15;

        public DrawBox()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.UpdateStyles();
            this.DoubleBuffered = true;

            MainController.Instance.Subscribe(this);
            MainController.Instance.Notify(ObserverAction.Select);
            MainController.Instance.DrawObjectType = DrawObjectType.Select;
        }

        /// <summary>
        /// 수신된 ObserverAction 에 따라서 처리 한다.
        /// </summary>
        public void OnNext(ObserverAction action)
        {
            switch (action)
            {
                case ObserverAction.Invalidate: this.Invalidate(false); return;
                case ObserverAction.FileLoad: this.Invalidate(false); return;
                case ObserverAction.New: this.Invalidate(false); return;
            }
        }

        /// <summary>
        /// 수신된 ObserverClass 와 Action 에 따라서 처리한다.
        /// </summary>
        public void OnNext(ObserverClass observer)
        {
            switch (observer.Action)
            {
                case ObserverAction.Invalidate: this.Invalidate(false); return;
                case ObserverAction.FileLoad: this.Invalidate(false); return;
                case ObserverAction.New: this.Invalidate(false); return;
            }
        }

        private void UnSelectAll(bool bSelect = false)
        {
            foreach (DrawObject o in MainController.Instance.GraphicModel.GrapList)
            {
                o.Selected = bSelect;
            }
        }

        private void Delete(bool bAllDelete = false)
        {
            if (MainController.Instance.GraphicModel.GrapList.Count <= 0)
                return;

            MainController.Instance.Command.AddCommand(MainController.Instance.GraphicModel.GrapList);

            if (bAllDelete == true)
            {
                MainController.Instance.GraphicModel.GrapList.Clear();
            }
            else
            {
                while (true)
                {
                    bool bCheck = false;
                    for (int i = 0; i < MainController.Instance.GraphicModel.GrapList.Count; i++)
                    {
                        if (MainController.Instance.GraphicModel.GrapList[i].Selected)
                        {
                            MainController.Instance.GraphicModel.GrapList[i].Deleted = true;
                            MainController.Instance.GraphicModel.GrapList.RemoveAt(i);
                            bCheck = true;
                        }
                    }
                    if (bCheck == false)
                        break;
                }
                
            }

            //DrawBox 가 새롭게 그리게끔 Observer에게 알린다.
            MainController.Instance.Notify(ObserverAction.Invalidate);
        }



        public void AddPatItem(List<DrawItem.PatternItem> items)
        {
            List<Image> tempImage = new List<Image>();
            foreach (Image img in imageList1.Images)
            {
                tempImage.Add(img);
            }


            foreach (var i in items)
            {
                RectangleObject obj = new RectangleObject(i.pStart.X, i.pStart.Y, 1, 1);
                obj.SetArgument(i.instructName, i.argumentLines, tempImage);
                MainController.Instance.GraphicModel.GrapList.Insert(0, obj);
                MainController.Instance.GraphicModel.GrapList[0].MoveHandleTo(i.pEnd, 5);
                MainController.Instance.GraphicModel.GrapList[0].Normalize();
                MainController.Instance.GraphicModel.GrapList[0].IndexOf = MainController.Instance.GraphicModel.GrapList.Count;
            }

            MainController.Instance.Command.AddCommand(MainController.Instance.GraphicModel.GrapList);
            this.Invalidate(false);

            MainController.Instance.Notify(ObserverAction.Select);
            UnSelectAll();
        }

        private void DrawBox_MouseDown(object sender, MouseEventArgs e)
        {

            //마우스 왼쪽 클릭이고, DrawObjectType 이 선택하기가 아닐 때
            if (e.Button == MouseButtons.Left && MainController.Instance.DrawObjectType == DrawObjectType.Select)
            {
                //현재 DrawBox 상태를 아무것도 지정하지 않는다.
                MainController.Instance.SelectMode = SelectMode.None;

                foreach (DrawObject ob in MainController.Instance.GraphicModel.GrapList)
                {
                    int handleNumber = ob.HitTest(e.Location); //현재 클릭된 위치의 handleNumber 를 반환한다.

                    //handleNumber 가 0보다 크다면 DrawObject 가 선택 된 것이다.
                    if (handleNumber > 0)
                    {
                        if (handleNumber > 100)
                        {
                            MainController.Instance.SelectMode = SelectMode.Connect;
                        }
                        //else
                        //{
                        //    //현재 DrawBox 상태를 사이즈 변경 모드로 변경한다.
                        //    MainController.Instance.SelectMode = SelectMode.Size;
                        //}

                        selectObject = ob;
                        selectObjectHandle = handleNumber;

                        //DrawBox 그려진 모든 DrawObject 의 선택을 해제한다.
                        UnSelectAll();

                        //현재 클릭된 DrawObejct 를 선택한다.
                        ob.Selected = true;

                        break;
                    }
                }

                if (MainController.Instance.SelectMode == SelectMode.None)
                {
                    foreach (DrawObject o in MainController.Instance.GraphicModel.GrapList)
                    {
                        if (o.HitTest(e.Location) == 0)
                        {
                            //Ctrl 키가 눌러지지 않은 상태에서 DrawObject 를 선택하면 모든 DrawObjec의 선택을 해제하고 현재 DrawObject 를 선택한다.
                            if ((Control.ModifierKeys & Keys.Control) == 0 && !o.Selected)
                            {
                                UnSelectAll();
                                o.Selected = true;
                            }
                            else if ((Control.ModifierKeys & Keys.Control) != 0 && o.Selected)
                            {
                                //이미 선택된 DrawObject 라면 선택을 해제한다.
                                o.Selected = false;
                            }
                            else
                            {
                                //Ctrl 키가 눌러진 상태라면 기존 선택을 해제하지 않고 추가로 현재 DrawObject 를 선택한다.
                                o.Selected = true;
                            }

                            //마우스 커서를 바꿔준다.
                            this.Cursor = Cursors.SizeAll;

                            //DrawBox 상태를 이동으로 변경한다.
                            MainController.Instance.SelectMode = SelectMode.Move;

                            break;
                        }
                    }
                }


                //DrawBox 의 상태가 아무것도 지정되지 않고 키보드를 누른 상태가 아니라면 DrawBox 에 선택된 모든 객체를 해제한다.
                if (MainController.Instance.SelectMode == SelectMode.None)
                {
                    if ((Control.ModifierKeys & Keys.Control) == 0)
                        UnSelectAll();

                    //DrawBox 의 상태를 영역으로 선택하기로 변경한다.
                    MainController.Instance.SelectMode = SelectMode.NetSelection;
                }

                //현재의 마우스 위치를 저장한다.
                pStart = pEnd = e.Location;
                pFocusStart = pFocusEnd = e.Location;

                //마우스를 캡쳐한다.
                this.Capture = true;

                //DrawBox의 상태가 영역으로 선택하기 일떄, 영역 그리기를 시작한다.
                if (MainController.Instance.SelectMode == SelectMode.NetSelection)
                {
                    this.Invalidate();
                }

            }
            //마우스의 왼쪽을 클릭하고, DrawObjectType 이 선택하기가 아니라면 선택 DrawObject 를 그리기 시작한다.
            //else if (e.Button == MouseButtons.Left && !(MainController.Instance.DrawObjectType == DrawObjectType.Select))


        }

        private void DrawBox_MouseMove(object sender, MouseEventArgs e)
        {
            //마우스 왼쪽 클릭이고, DrawObjectType 이 선택하기 일때
            if (e.Button == MouseButtons.Left && MainController.Instance.DrawObjectType == DrawObjectType.Select)
            {
                //마우스의 현재 위치에서 마지막 위치를 뺀 값을 저장한다.
                int distanceX = e.X - pEnd.X;
                int distanceY = e.Y - pEnd.Y;

                pEnd = e.Location;

                switch (MainController.Instance.SelectMode)
                {
                    //case SelectMode.Size:
                    case SelectMode.Connect:
                        if (selectObject != null)
                        {
                            selectObject.MoveHandleTo(e.Location, selectObjectHandle);

                            //DrawBox의 Paint 이벤트를 호출한다.
                            this.Invalidate(false);
                        }
                        break;
                    case SelectMode.Move:
                        pMoveMaxEnd = new Point(0, 0);
                        //선택된 모든 DrawObject의 위치를 이동한다.
                        foreach (DrawObject o in MainController.Instance.GraphicModel.GrapList)
                        {

                            if (o.Selected)
                            {
                                o.Move(distanceX, distanceY);
                                //userCtrlList[o.IndexOf-1].Location = o.GetHandle(1);

                                Point end = o.GetHandle(5);

                                if (pMoveMaxEnd.X < end.X)
                                    pMoveMaxEnd.X = end.X + 20;

                                if (pMoveMaxEnd.Y < end.Y)
                                    pMoveMaxEnd.Y = end.Y + 20;
                            }
                        }

                        //마우스 커서를 변경한다.
                        this.Cursor = Cursors.SizeAll;

                        //DrawBox 의 Paint 이벤트를 호출한다.
                        this.Invalidate(false);
                        break;
                    case SelectMode.NetSelection:
                        pFocusEnd = e.Location;
                        this.Invalidate(false);
                        break;

                }

            }
            //마우스가 클릭이 된 것이 없고, DrawObjectType 이 선택하기 일때
            else if (e.Button == System.Windows.Forms.MouseButtons.None && MainController.Instance.DrawObjectType == DrawObjectType.Select)
            {
                this.Cursor = Cursors.Default;
            }
            //마우스 왼쪽 클릭이고, DrawObjectType 이 선택하기가 아닐 때
            //else if (e.Button == MouseButtons.Left && MainController.Instance.DrawObjectType != DrawObjectType.Select)
        }

        private void DrawBox_MouseUp(object sender, MouseEventArgs e)
        {
            //마우스 왼쪽 버튼이 클릭된 상태였고, DrawObjectType 이 선택하기가 아닐 때,
            //if (e.Button == MouseButtons.Left && !(MainController.Instance.DrawObjectType == DrawObjectType.Select))

            ////DrawBox 의 상태가 영역으로 선택하기 일 때
            if (MainController.Instance.SelectMode == SelectMode.NetSelection)
            {
                //모든 DrawObject 의 선택을 해제한다.
                UnSelectAll();

                //마우스의 처음과 마지막 위치 만큼의 Rectangle 을 생성한다.
                Rectangle rect = RectangleObject.GetNormalizedRectangle(pStart, pEnd);

                //rec 의 영역에 DrawObject 가 포함된다면 선택된걸로 설정한다.
                foreach (DrawObject o in MainController.Instance.GraphicModel.GrapList)
                {
                    if (o.IntersectsWith(rect))
                        o.Selected = true;
                }

                //DrawBox 의 상태를 아무것도 지정하지 않는다.
                MainController.Instance.SelectMode = SelectMode.None;
            }
            else if (MainController.Instance.SelectMode == SelectMode.Connect)
            {
                if (selectObject != null)
                {
                    Rectangle rec = RectangleObject.GetNormalizedRectangle(pStart, pEnd);
                    bool bConnected = false;

                    //rec 의 영역에 DrawObject 가 포함된다면 선택된걸로 설정한다.
                    foreach (DrawObject o in MainController.Instance.GraphicModel.GrapList)
                    {
                        if (o == selectObject)
                            continue;
                        if (o.Contains(pEnd))
                        {    //o.Selected = true;
                            o.Deleted = false;

                            selectObject.SetConnect(o, selectObjectHandle);
                            if (selectObjectHandle == 101)
                                o.SetConnect(selectObject, 102);
                            else if (selectObjectHandle == 102)
                                o.SetConnect(selectObject, 101);
                            bConnected = true;
                            break;
                        }
                    }

                    if (bConnected == false)
                        selectObject.SetConnect(null, selectObjectHandle);
                    MainController.Instance.SelectMode = SelectMode.None;
                }
            }

            if (e.Button == MouseButtons.Left && MainController.Instance.SelectMode == SelectMode.Move)
            {
                this.Width = Math.Max(this.Width, pMoveMaxEnd.X);
                this.Height = Math.Max(this.Height, pMoveMaxEnd.Y);
            }

            //DrawObjec 의 사이즈 변경 변수가 Null 이 아니라면 변경된 된 크기만큼 최종적으로 설정해준다.
            if (selectObject != null)
            {
                selectObject.Normalize();
                selectObject = null;
            }

            pStart = pEnd;
            pFocusStart = pFocusEnd;

            //DrawBox 의 Paint 이벤트를 호출한다.
            this.Invalidate(false);

            //마우스 캡쳐를 해제한다.
            this.Capture = false;
        }
        private void DrawBox_Paint(object sender, PaintEventArgs e)
        {
            //그려진 DrawObject가 하나 이상 일때
            if (MainController.Instance.GraphicModel.GrapList.Count > 0)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255)))
                {
                    //e.Graphics.FillRectangle(brush, this.ClientRectangle);

                    foreach (DrawObject ob in MainController.Instance.GraphicModel.GrapList)
                    {
                        //DrawObject 를 그려준다.
                        ob.Draw(e.Graphics);

                        //DrawObject 가 선택되었다면 선택된 DrawObject 를 표시하기 위한 Pointer를 그려준다
                        if (ob.Selected == true)
                        {
                            ob.DrawPointer(e.Graphics);
                        }
                    }
                }
            }

            if (pFocusStart != pFocusEnd)
            {
                ControlPaint.DrawFocusRectangle(e.Graphics, RectangleObject.GetNormalizedRectangle(pFocusStart, pFocusEnd));
            }
        }
        private void pictureBox_resize_MouseDown(object sender, MouseEventArgs e)
        {
            allowResize = true;
        }

        private void pictureBox_resize_MouseMove(object sender, MouseEventArgs e)
        {
            if (allowResize)
            {
                this.Height = pictureBox_resize.Top + e.Y;
                this.Width = pictureBox_resize.Left + e.X;
            }
        }

        private void pictureBox_resize_MouseUp(object sender, MouseEventArgs e)
        {
            allowResize = false;
        }

        private void DrawBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
