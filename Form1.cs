using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void 編輯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 用黑洞吸掉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.money = 777;
            DialogResult result = form.ShowDialog();            
            var money = form.money;
        }

        private void SeverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsever formsever = new formsever();
            DialogResult result = formsever.ShowDialog();
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formclient formclient = new formclient();
            DialogResult result = formclient.ShowDialog();
        }
    }
}
