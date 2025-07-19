using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;



namespace WinFormsApp1
{
    
    public partial class ChildForm1 : Form
    {

        public ChildForm1()
        {
            InitializeComponent();

            jetProgressBar1.Minimum = 0;
            jetProgressBar1.Maximum = 100;
            jetProgressBar1.Value = 20;
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

            dataGridView1.DataSource = dt;

//            this.ResumeLayout(false);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 2 && e.RowIndex < dataGridView1.RowCount-1 && e.RowIndex >= 0)
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