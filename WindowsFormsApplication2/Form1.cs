using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void новКлиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void настоящиКлиентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void операторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void търсенеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void данниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form6().Show();
        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
