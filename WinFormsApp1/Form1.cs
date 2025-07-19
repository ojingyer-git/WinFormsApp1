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

    }
}
