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
            MessageBox.Show("Введите текст в поле сверху.");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string text = rtbxText.Text;
            var tree = new Tree(text);
            rtbxResult.Text = tree.Start();
        }
    }
}
