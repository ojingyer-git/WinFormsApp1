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
        private ChildForm1 mChildForm1 = null;
        private ChildForm2 mChildForm2 = null;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mChildForm1 = new ChildForm1();
            mChildForm1.MdiParent = this;
            mChildForm1.WindowState = FormWindowState.Maximized;
            mChildForm1.Show();

            mChildForm2 = new ChildForm2();
            mChildForm2.MdiParent = this;
            mChildForm2.WindowState = FormWindowState.Maximized;
            mChildForm2.Show();
        }
    }
}
