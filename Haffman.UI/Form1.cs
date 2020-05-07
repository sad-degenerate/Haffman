using Haffman.BL;
using System;
using System.Windows.Forms;

namespace Haffman.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string text = rtbxText.Text;
            var tree = new Tree(text);
            var res = tree.Start();
            rtbxResult.Text = res.Item1;
            rtbxAlph.Text = res.Item2;
        }
    }
}
