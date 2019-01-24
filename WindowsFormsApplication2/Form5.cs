using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string[] oper_name = { "Telenor", "A1", "Vivacom" };

                string[] taksa_name = { "0,24", "0,30", "0,25" };

                FileStream fp = new FileStream("CLIENTS.DAT", FileMode.Open);
                BinaryReader br = new BinaryReader(fp);
                listBox1.Items.Clear();
                int count = 0;
                while (fp.Position < fp.Length)
                {
                    string nomer = br.ReadString();
                    string ime = br.ReadString();
                    int oper = br.ReadInt32();
                    int taksa = br.ReadInt32();
                    double price = br.ReadDouble();
                    int minuti = br.ReadInt32();
                    if (nomer.Contains(textBox1.Text.ToUpper()))
                        listBox1.Items.Add(nomer + "\t" +  ime + "\t"  + price + "\t" + minuti + "\t" + price * minuti + "BGN.");
                }


                fp.Close();

            }
            else MessageBox.Show("Nothing for searching!");
        }
    }
}
