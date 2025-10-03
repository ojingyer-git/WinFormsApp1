using ExcelDataReader;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Excel = Microsoft.Office.Interop.Excel;
using sct = ScottPlot;

namespace WinFormsApp1
{

    public partial class ChildForm1 : Form
    {
        private DataTable bk_dt = new DataTable();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private string filePath = "";
        private DataObject dataObj1, dataObj2;
        private WaitForm waitForm = new WaitForm();



        public ChildForm1()
        {
            InitializeComponent();

            jetProgressBar1.Minimum = 0;
            jetProgressBar1.Maximum = 100;
            jetProgressBar1.Value = 20;

            closeButtonImage = Properties.Resources.Close;


        }

        class DerivedDataGridView : DataGridView
        {
            public DerivedDataGridView()
            {
                DoubleBuffered = true;
            }
        }

        private void ChildForm1_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);
            //            toolStripProgressBar1.Width = 350;
            timer.Interval = 1000; // 1초마다

            timer.Tick += Timer_Tick;
        }

        private sct.Color sctGetJetColor(float value)
        {
            value = Math.Max(0, Math.Min(1, value));

            var cmap = new ScottPlot.Colormaps.Turbo();
            return cmap.GetColor(value);
        }
        private Color GetJetColor(float value)
        {
            // 입력 값을 0에서 1 사이로 정규화합니다.
            value = Math.Max(0, Math.Min(1, value));

            var cmap = new ScottPlot.Colormaps.MellowRainbow();//Turbo();
            sct.Color cl = cmap.GetColor(value);
            return Color.FromArgb(cl.Alpha, cl.Red, cl.Green, cl.Blue);

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

        private Form ShowActiveForm(Form form, Type t)
        {
            if (form == null)
            {
                form = (Form)Activator.CreateInstance(t);
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.MdiParent = this;
                    form.WindowState = FormWindowState.Maximized;
                    form.Show();
                }
                else
                {
                    form.Activate();
                }
            }

            return form;
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //            this.SuspendLayout();
            DataTable dt = new DataTable();
            string sTemp;

            dt.Columns.Add("lotid", typeof(string));
            dt.Columns.Add("wf", typeof(string));
            dt.Columns.Add("item", typeof(string));
            for (int i = 0; i < 32; i++)
                dt.Columns.Add(string.Format("ch {0}", i + 1), typeof(string));

            for (int r = 0; r < 800; r++)
            {
                DataRow row = dt.NewRow();
                row["lotid"] = "XE30004P";
                row["wf"] = "10";
                row["item"] = string.Format("test item {0}", r + 1);

                for (int i = 0; i < 32; i++)
                {
                    sTemp = string.Format("ch {0}", i + 1);
                    row[sTemp] = "3.400 / 3";
                }

                dt.Rows.Add(row);
            }

            bk_dt = dt.Copy();
            dataGridView1.DataSource = dt;

            //            this.ResumeLayout(false);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 2 && e.RowIndex < dataGridView1.RowCount - 1 && e.RowIndex >= 0)
            {
                string val = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (val.IndexOf("/") != -1)
                {
                    val = val.Replace(" ", "");
                    string[] word = val.Split('/');

                    if (word[1] != "0")
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                }
            }
        }

        static Excel.Application excelApp = null;
        static Excel.Workbook workBook = null;
        static Excel.Worksheet workSheet = null;

        private void excel저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  // 바탕화면 경로
            string path = Path.Combine(desktopPath, "Excel.xlsx");                              // 엑셀 파일 저장 경로

            excelApp = new Excel.Application();                             // 엑셀 어플리케이션 생성
            workBook = excelApp.Workbooks.Add();                            // 워크북 추가
            workSheet = workBook.Worksheets.get_Item(1) as Excel.Worksheet;

            for (int r = 0; r < dataGridView1.RowCount - 1; r++)
            {
                for (int c = 0; c < dataGridView1.ColumnCount; c++)
                {
                    workSheet.Cells[r + 1][c + 1] = dataGridView1.Rows[r].Cells[c].Value.ToString();
                }
            }

            workSheet.Columns.AutoFit();                                    // 열 너비 자동 맞춤
            workBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault);    // 엑셀 파일 저장
            workBook.Close(true);
            excelApp.Quit();

        }

        [STAThread]
        private void excel클리보드로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitForm.ShowDialog();
            return;
            //    Export_Excel(dataGridView1, "excel_test");

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls;*.xlsx";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Export Excel File";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName == "")
            {
                return;
            }
            filePath = saveFileDialog.FileName;


            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 60;
            toolStripProgressBar1.Value = 0;

            backgroundWorker1.RunWorkerAsync();
            timer.Start();

            SetTextSafe("");
            Export_Excel();

        }



        void Export_Excel()
        {
            if (dataObj1 != null && dataObj2 != null)
            {
                excelApp = new Excel.Application();                             // 엑셀 어플리케이션 생성
                workBook = excelApp.Workbooks.Add();                            // 워크북 추가
                workSheet = workBook.Worksheets.get_Item(1) as Excel.Worksheet;

                Clipboard.SetDataObject(dataObj1);
                Excel.Range CR = (Excel.Range)workSheet.Cells[1, 1];
                CR.Select();
                workSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                Excel.Worksheet workSheet2;
                if (workBook.Worksheets.Count == 1)
                    workSheet2 = (Excel.Worksheet)workBook.Worksheets.Add();
                else
                    workSheet2 = workBook.Worksheets.get_Item(2) as Excel.Worksheet;

                Clipboard.SetDataObject(dataObj2);
                Excel.Range CR2 = (Excel.Range)workSheet2.Cells[1, 1];
                CR2.Select();
                workSheet2.PasteSpecial(CR2, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);


                workSheet.Columns.AutoFit();                                    // 열 너비 자동 맞춤
                workBook.SaveAs(filePath, Excel.XlFileFormat.xlWorkbookDefault);    // 엑셀 파일 저장
                workBook.Close(true);
                excelApp.Quit();

                ReleaseObject(CR);
                ReleaseObject(CR2);
                ReleaseObject(workSheet);
                ReleaseObject(workSheet2);
                ReleaseObject(workBook);
                ReleaseObject(excelApp);

                MessageBox.Show("저장완료");
            }

            waitForm.Close();
        }
        void Export_Excel(DataGridView grid, string fileName = "")
        {
            string val;
            string[] word;
            //           dataGridView1.DataSource = bk_dt.Copy();

            for (int r = 0; r < dataGridView1.RowCount - 1; r++)
            {
                for (int c = 3; c < dataGridView1.ColumnCount; c++)
                {
                    val = dataGridView1.Rows[r].Cells[c].Value.ToString();
                    if (val.IndexOf("/") != -1)
                    {
                        val = val.Replace(" ", "");
                        word = val.Split('/');
                        dataGridView1.Rows[r].Cells[c].Value = word[1];
                    }

                }
            }



            string path = filePath;
            //xls는 65536, xlsx는 1048575

            bool bMultiSel = grid.MultiSelect;
            bool bRowHeader = grid.RowHeadersVisible;
            bool bAllowUser = grid.AllowUserToAddRows;


            grid.MultiSelect = true;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.SelectAll();
            grid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = grid.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
                grid.ClearSelection();
                Excel.Application xlexcel;
                Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = false;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                grid.ClearSelection();
                Excel.Worksheet worksheet2 = (Excel.Worksheet)xlWorkBook.Worksheets.Add();
                worksheet2.Name = "kjo";
                dataGridView1.DataSource = bk_dt.Copy();
                for (int r = 0; r < dataGridView1.RowCount - 1; r++)
                {
                    for (int c = 3; c < dataGridView1.ColumnCount; c++)
                    {
                        val = dataGridView1.Rows[r].Cells[c].Value.ToString();
                        if (val.IndexOf("/") != -1)
                        {
                            val = val.Replace(" ", "");
                            word = val.Split('/');
                            dataGridView1.Rows[r].Cells[c].Value = word[0];
                        }

                    }
                }

                grid.SelectAll();
                grid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                DataObject dataObj2 = grid.GetClipboardContent();
                Excel.Range CR2 = (Excel.Range)worksheet2.Cells[1, 1];
                CR2.Select();
                worksheet2.PasteSpecial(CR2, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                grid.MultiSelect = bMultiSel;
                grid.RowHeadersVisible = bRowHeader;
                grid.AllowUserToAddRows = bAllowUser;

                if (path.Contains(".xlsx"))
                {
                    xlWorkBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault, null, null, false, false,
                    Excel.XlSaveAsAccessMode.xlShared, false, false, null, null, null);
                }
                else
                {
                    xlWorkBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookNormal, null, null, false, false,
                    Excel.XlSaveAsAccessMode.xlShared, false, false, null, null, null);
                }
                grid.ClearSelection();
                xlexcel.Quit();
                ReleaseObject(CR);
                ReleaseObject(CR2);
                ReleaseObject(xlWorkSheet);
                ReleaseObject(worksheet2);
                ReleaseObject(xlWorkBook);
                ReleaseObject(xlexcel);
            }
#if false
            else
            {
                Microsoft.Office.Interop.Excel.Application xlexcel = null;
                Workbook xlWorkBook = null;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = false;
                //Workbook 생성
                xlWorkBook = xlexcel.Workbooks.Add();
                Worksheet xlWorkSheet = xlWorkBook.ActiveSheet;
                for (int col = 0; col < grid.Columns.Count; col++)
                {
                    Range cell = xlWorkSheet.Cells[1, col + 1];
                    cell.Value = grid.Columns[col].HeaderText;
                }
                for (int row = 0; row < grid.Rows.Count; row++)
                {
                    for (int col = 0; col < grid.Columns.Count; col++)
                    {
                        Range cell = xlWorkSheet.Cells[row + 2, col + 1];
                        cell.Value = grid[col, row].Value == null ? "" : grid[col, row].Value.ToString();
                        //cell.Font.Color = dgvData[col, row].Style.BackColor;
                        //cell.Interior.Color = dgvData[col, row].Style.ForeColor;
                    }
                }
                if (path.Contains(".xlsx"))
                {
                    xlWorkBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault, null, null, false, false,
                    Excel.XlSaveAsAccessMode.xlShared, false, false, null, null, null);
                }
                else
                {
                    xlWorkBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookNormal, null, null, false, false,
                    Excel.XlSaveAsAccessMode.xlShared, false, false, null, null, null);
                }
                xlexcel.Quit();
                ReleaseObject(xlWorkSheet);
                ReleaseObject(xlWorkBook);
                ReleaseObject(xlexcel);
            }
#endif
            MessageBox.Show("저장완료");

            dataGridView1.DataSource = bk_dt.Copy();
        }


#if false
        void Import_Excel(DataGridView grid, string fileName = "")
        {
            if (File.Exists(fileName) == false)
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel workbook|*.xlsx;*.xls", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        fileName = ofd.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            FileInfo fi = new FileInfo(fileName);
            if ((fi.Extension == ".xls" | fi.Extension == ".xlsx") == false)
            {
                return;
            }
            FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs);
            DataSet result = reader.AsDataSet();
            reader.Close();
            if (result == null)
            {
                return;
            }
            DataTable dt = result.Tables[0];
            bool i = false;
            foreach (DataRow row in dt.Rows)
            {
                if (!i)
                {
                    i = true;
                    continue;
                }
                if (DBNull.Value.Equals(row.ItemArray[0]) == false)
                {
                    grid.Rows.Add(row.ItemArray);
                }
            }
        }
#endif

        static void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);  // 액셀 객체 해제
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();   // 가비지 수집
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value++;
            if (toolStripProgressBar1.Value == 60)
                toolStripProgressBar1.Value = 0;
        }
        private delegate void SetTextSafeDelegate(string text);
        private void SetTextSafe(string text)
        {
            if (dataGridView1.InvokeRequired)
            {
                SetTextSafeDelegate del = new SetTextSafeDelegate(SetTextSafe);
                this.Invoke(del, new object[] { text });
                return;
            }

            string val;
            string[] word;

            for (int r = 0; r < dataGridView1.RowCount - 1; r++)
            {
                for (int c = 3; c < dataGridView1.ColumnCount; c++)
                {
                    val = dataGridView1.Rows[r].Cells[c].Value.ToString();
                    if (val.IndexOf("/") != -1)
                    {
                        val = val.Replace(" ", "");
                        word = val.Split('/');
                        dataGridView1.Rows[r].Cells[c].Value = word[1];
                    }

                }
            }

            bool bMultiSel = dataGridView1.MultiSelect;
            bool bRowHeader = dataGridView1.RowHeadersVisible;
            bool bAllowUser = dataGridView1.AllowUserToAddRows;

            dataGridView1.MultiSelect = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectAll();
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataObj1 = dataGridView1.GetClipboardContent();


            dataGridView1.ClearSelection();
            dataGridView1.DataSource = bk_dt.Copy();
            for (int r = 0; r < dataGridView1.RowCount - 1; r++)
            {
                for (int c = 3; c < dataGridView1.ColumnCount; c++)
                {
                    val = dataGridView1.Rows[r].Cells[c].Value.ToString();
                    if (val.IndexOf("/") != -1)
                    {
                        val = val.Replace(" ", "");
                        word = val.Split('/');
                        dataGridView1.Rows[r].Cells[c].Value = word[0];
                    }

                }
            }

            dataGridView1.SelectAll();
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataObj2 = dataGridView1.GetClipboardContent();

            dataGridView1.ClearSelection();
            dataGridView1.MultiSelect = bMultiSel;
            dataGridView1.RowHeadersVisible = bRowHeader;
            dataGridView1.AllowUserToAddRows = bAllowUser;
            dataGridView1.DataSource = bk_dt.Copy();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            waitForm.ShowDialog();
            //Thread staThread = new Thread(new ThreadStart(DoSTAWork));
            //staThread.SetApartmentState(ApartmentState.STA);
            //staThread.Start();
            //staThread.Join(); // 작업 완료까지 대기
        }
        private void DoSTAWork()
        {
            SetTextSafe("");
            // STA 모드에서만 작동하는 작업 (예: WebBrowser 컨트롤 사용 등)
            Export_Excel();
        }
        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private Image closeButtonImage;
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //Graphics g = e.Graphics;
            //TabPage tabPage = tabControl1.TabPages[e.Index];
            //Rectangle tabRect = tabControl1.GetTabRect(e.Index);

            //// 탭 텍스트 그리기
            //g.DrawString(tabPage.Text, tabControl1.Font, Brushes.Black, tabRect.Left + 2, tabRect.Top + 2);

            //// 닫기 버튼 그리기
            //int closeButtonX = tabRect.Right - closeButtonImage.Width - 2;
            //int closeButtonY = tabRect.Top + (tabRect.Height - closeButtonImage.Height) / 2;
            //g.DrawImage(closeButtonImage, closeButtonX, closeButtonY, closeButtonImage.Width, closeButtonImage.Height);
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            //for (int i = 0; i < tabControl1.TabPages.Count; i++)
            //{
            //    Rectangle tabRect = tabControl1.GetTabRect(i);
            //    int closeButtonX = tabRect.Right - closeButtonImage.Width - 2;
            //    int closeButtonY = tabRect.Top + (tabRect.Height - closeButtonImage.Height) / 2;
            //    Rectangle closeButtonRect = new Rectangle(closeButtonX, closeButtonY, closeButtonImage.Width, closeButtonImage.Height);

            //    if (closeButtonRect.Contains(e.Location))
            //    {
            //        tabControl1.TabPages.RemoveAt(i);
            //        break; // 하나의 탭만 닫도록
            //    }
            //}
        }

        private void 탭추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage("New Tab");
            tabControl1.TabPages.Add(newTabPage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            timer.Stop();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ScottPlot.Palettes.Category10 palette = new();

            formsPlot1.Plot.Clear();

            // create 5 groups of stacked bars
            for (int i = 0; i < 10; i++)
            {
                // create 3 individual bars with stacking
                List<ScottPlot.Bar> bars = [];
                double valueBase = 0;
                double[] heights = ScottPlot.SampleData.MaleHeights();
                var hist = ScottPlot.Statistics.Histogram.WithBinSize(2, heights);

                for (int j = 0; j < hist.Counts.Length; j++)
                {
                    double barSize = hist.Counts.Length / 2;//sct.Generate.RandomInteger(10, 20);
                    double ran = sct.Generate.RandomInteger(10, 100);
                    ScottPlot.Bar bar1 = new()
                    {
                        FillColor = sctGetJetColor((float)(hist.Counts[j] - hist.Counts.Min()) / (hist.Counts.Max() - hist.Counts.Min())), //palette.GetColor(j),
                        Position = i,
                        ValueBase = valueBase,
                        Value = valueBase + barSize,
                        //    Label = $"{barSize}",
                        //    CenterLabel = true,
                    };

                    bars.Add(bar1);
                    valueBase += barSize;
                }

                // plot the stacked bars
                var barPlot = formsPlot1.Plot.Add.Bars(bars);
                barPlot.Horizontal = true;
            }

            formsPlot1.Plot.Axes.Margins(left: 0);

            // add custom group labels
            double[] tickPositions = sct.Generate.Consecutive(5);
            string[] tickLabels = Enumerable.Range(1, 5).Select(x => $"Worker #{x}").ToArray();
            formsPlot1.Plot.Axes.Left.SetTicks(tickPositions, tickLabels);
            formsPlot1.Refresh();
        }

        private void plot1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();

            List<(string name, double[] edges)> ranges =
            [
                ("Ontario", [-9, 3, 7, 13, 27]),
                ("England", [4, 7, 12, 16, 24]),
                ("Kentucky", [-4, 7, 13, 20, 30]),
            ];

            formsPlot1.Plot.Add.StackedRanges(ranges, horizontal: true);
            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }

        sct.Coordinates[] DataPoints;
        sct.Coordinates MouseDownCoordinates;
        sct.Coordinates MouseNowCoordinates;
        sct.CoordinateRect MouseSlectionRect => new(MouseDownCoordinates, MouseNowCoordinates);
        bool MouseIsDown = false;
        ScottPlot.Plottables.Rectangle RectanglePlot;

        private void plot2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();



            for (int i = 0; i < 5; i++)
            {
                double[] values = ScottPlot.SampleData.MaleHeights();//sct.Generate.RandomNormal(10, mean: 3 + i);
                var pop = formsPlot1.Plot.Add.Population(values, x: i);

                // disable visibility of the bar symbol
                pop.Bar.IsVisible = false;

                // enable visibility of the box symbol
                pop.Box.IsVisible = true;
                pop.Box.FillColor = pop.Marker.MarkerLineColor.WithAlpha(.5);
                //    pop.Marker.MarkerSize = 7;

            }

            sct.Tick[] ticks =
            {
                new(0, "First Long Title"),
                new(1, "Second Long Title"),
                new(2, "Third Long Title"),
                new(3, "Fourth Long Title"),
                new(4, "Fifth Long Title"),
                new(5, "Sixth Long Title")
            };
            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Alignment = sct.Alignment.MiddleLeft;

            // determine the width of the largest tick label
            float largestLabelWidth = 0;
            //using sct.SKPaint paint = new();
            foreach (sct.Tick tick in ticks)
            {
                sct.PixelSize size = formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Measure(tick.Label).Size;
                largestLabelWidth = Math.Max(largestLabelWidth, size.Width);
            }

            // ensure axis panels do not get smaller than the largest label
            formsPlot1.Plot.Axes.Bottom.MinimumSize = largestLabelWidth;
            formsPlot1.Plot.Axes.Right.MinimumSize = largestLabelWidth;

            // refine appearance of the plot
            formsPlot1.Plot.HideGrid();

            RectanglePlot = formsPlot1.Plot.Add.Rectangle(0, 0, 0, 0);
            RectanglePlot.FillStyle.Color = sct.Colors.Red.WithAlpha(.2);

            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }

        private void plot3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();

            // create a bar plot
            double[] values = { 5, 10, 7, 13, 25, 60 };
            formsPlot1.Plot.Add.Bars(values);
            formsPlot1.Plot.Axes.Margins(bottom: 0);

            // create a tick for each bar
            sct.Tick[] ticks =
            {
                new(0, "First Long Title"),
                new(1, "Second Long Title"),
                new(2, "Third Long Title"),
                new(3, "Fourth Long Title"),
                new(4, "Fifth Long Title"),
                new(5, "Sixth Long Title")
            };
            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Alignment = sct.Alignment.MiddleLeft;

            // determine the width of the largest tick label
            float largestLabelWidth = 0;
            //using sct.SKPaint paint = new();
            foreach (sct.Tick tick in ticks)
            {
                sct.PixelSize size = formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Measure(tick.Label).Size;
                largestLabelWidth = Math.Max(largestLabelWidth, size.Width);
            }

            // ensure axis panels do not get smaller than the largest label
            formsPlot1.Plot.Axes.Bottom.MinimumSize = largestLabelWidth;
            formsPlot1.Plot.Axes.Right.MinimumSize = largestLabelWidth;

            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();

        }

        private void formsPlot1_MouseDown(object sender, MouseEventArgs e)
        {
            //MouseIsDown = true;
            //RectanglePlot.IsVisible = true;
            //MouseDownCoordinates = formsPlot1.Plot.GetCoordinates(e.X, e.Y);
            //formsPlot1.UserInputProcessor.Disable();
        }

        private void formsPlot1_MouseUp(object sender, MouseEventArgs e)
        {
            //MouseIsDown = false;
            //RectanglePlot.IsVisible = false;

            //formsPlot1.Plot.Remove<ScottPlot.Plottables.Marker>();

            //MouseDownCoordinates = sct.Coordinates.NaN;
            //MouseNowCoordinates = sct.Coordinates.NaN;

            //// update the plot
            //formsPlot1.Refresh();
            //formsPlot1.UserInputProcessor.Enable();
        }

        private void formsPlot1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (!MouseIsDown)
            //    return;

            //MouseNowCoordinates = formsPlot1.Plot.GetCoordinates(e.X, e.Y);
            //RectanglePlot.CoordinateRect = MouseSlectionRect;
            //formsPlot1.Refresh();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (odAnyFile.ShowDialog() == DialogResult.OK)
                scintillaDiffControl1.TextLeft = File.ReadAllText(odAnyFile.FileName);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (odAnyFile.ShowDialog() == DialogResult.OK)
                scintillaDiffControl1.TextRight = File.ReadAllText(odAnyFile.FileName);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            OptionForm from = new OptionForm();
            from.ShowDialog();

        }
    }
}

public static class ExtensionMethods
{
    public static void DoubleBuffered(this DataGridView dgv, bool setting)
    {
        Type dgvType = dgv.GetType();
        PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
        BindingFlags.Instance | BindingFlags.NonPublic);
        pi.SetValue(dgv, setting, null);
    }
}