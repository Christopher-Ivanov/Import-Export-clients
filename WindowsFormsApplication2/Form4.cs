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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (comboBox1.SelectedIndex != -1)
            {
                string[] oper_name = { "Telenor", "A1", "Vivacom" };
                string[] taksa_name = { "0,24", "0,30", "0,25" };
                dataGridView1.Rows.Clear();
                FileStream fp = new FileStream("CLIENTS.DAT", FileMode.OpenOrCreate);
                BinaryReader br = new BinaryReader(fp);
                int count = 0;
                while (fp.Position < fp.Length)
                {
                    string nomer = br.ReadString();
                    string ime = br.ReadString();
                    int oper = br.ReadInt32();
                    int taksa = br.ReadInt32();
                    double price = br.ReadDouble();
                    int minuti = br.ReadInt32();
                    if (comboBox1.SelectedIndex == oper)
                        dataGridView1.Rows.Add(++count, ime, nomer, taksa, minuti, minuti * price + " BGN", minuti * price * 0.2, minuti*price + minuti * price * 0.2   );

                }


                fp.Close();
                
            }
            else MessageBox.Show("Pick Something!");
        }
        }
    }
