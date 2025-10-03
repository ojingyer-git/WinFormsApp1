using Krypton.Toolkit;
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
    public partial class OptionForm : Form
    {
        private OptionProperty m_property;
        private MyComponent myObject = new MyComponent();
        private int _next = 0;


        public class MyComponent
        {
            private Color _BackgroundColor;
            //[DisplayName("배경색")] // PropertyGrid에 표시될 속성 이름
            //[Category("Appearance")] // 속성 카테고리
            public Color BackgroundColor
            {
                get
                {
                    return _BackgroundColor;
                }
                set
                {
                    _BackgroundColor = value;
                }
            } // 기본값을 White로 설정
        }
        public OptionForm()
        {
            InitializeComponent();

            m_property = new OptionProperty();
            myObject.BackgroundColor = Color.FromArgb(123, 14, 211);

            TreeNode node = CreateNewItem();
            kryptonTreeView1.Nodes.Add(node);
            if (kryptonTreeView1.SelectedNode == null)
                kryptonTreeView1.SelectedNode = node;
            if (kryptonTreeView1.SelectedNode != null)
            {
                kryptonTreeView1.SelectedNode.Nodes.Add(CreateNewItem());
                kryptonTreeView1.SelectedNode.Nodes.Add(CreateNewItem());
                kryptonTreeView1.SelectedNode.Nodes.Add(CreateNewItem());
                kryptonTreeView1.SelectedNode.Expand();
            }

            kryptonTreeView1.Nodes.Add(node);
            kryptonTreeView1.SelectedNode = node;
            kryptonTreeView1.SelectedNode.Nodes.Add(CreateNewItem());
            kryptonTreeView1.SelectedNode.Nodes.Add(CreateNewItem());
            kryptonTreeView1.SelectedNode.Nodes.Add(CreateNewItem());
            kryptonTreeView1.SelectedNode.Expand();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            m_property.Dock = DockStyle.Fill;
            m_property.Set(myObject);
            kryptonPanel1.Controls.Add(m_property);
        }

        private KryptonTreeNode CreateNewItem()
        {
            KryptonTreeNode item = new KryptonTreeNode();
            item.Text = "Item " + (_next++).ToString();
            //item.ImageIndex = _rand.Next(imageList.Images.Count - 1);
            //item.SelectedImageIndex = 0;
            return item;
        }
    }
}
