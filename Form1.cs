using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void giớiThiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("chương trình tiện ích","thông tin",MessageBoxButtons .OK); 
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          giaiPTbac2  giaiPTbac2=new giaiPTbac2();
            giaiPTbac2.ShowDialog();

        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dinhdang din = new dinhdang();
            dinhdang.ShowDialog();
        }
    }
}
