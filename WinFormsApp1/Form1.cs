﻿using System;
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
        }
    }
}
