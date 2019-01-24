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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] oper = { "Telenor", "A1", "Vivacom" };
            double[] price = new double[3];
            
            int[] minuti = new int[3];
            FileStream f = new FileStream("CLIENTS.DAT", FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(f);
            int count = 0;
            while (f.Position < f.Length)
            {
                string nomer = br.ReadString();
                string ime = br.ReadString();
                int o = br.ReadInt32();
                int taksa = br.ReadInt32();
                double p = br.ReadDouble();
                int min = br.ReadInt32();

                minuti[o] += min;
                price[o] += min * p;

                
            }
            f.Close();
            StreamWriter txt = new StreamWriter("Otchet.txt");
            
            txt.WriteLine("ОБОБЩЕН ОТЧЕТ НА МОБИЛНИТЕ ОПЕРАТОРИ");
            txt.WriteLine();
            txt.WriteLine("-------------------------------------");
            txt.WriteLine("              МИНУТИ   СУМА");
            txt.WriteLine("--------------------------------------");
            double ssss = 0;
            for (int x = 0; x < 3; x++)
            {


                txt.WriteLine(oper[x] + "\t" + minuti[x] + "\t" + price[x]);
                ssss += price[x];
            }
            txt.WriteLine("--------------------------------------");
            txt.WriteLine("\t\t\t ОБЩО:" + ssss);
            txt.WriteLine("--------------------------------------");
            txt.WriteLine();
            txt.WriteLine();
            txt.WriteLine();
            txt.WriteLine(DateTime.Now);
            txt.WriteLine("\t\t\t");
            txt.Close();
            MessageBox.Show("Файлът OTCHET.TXT e създаден");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("OTCHET.txt"))
            {
                StreamReader p = new StreamReader("OTCHET.txt");
                listBox1.Items.Clear();
                while (!p.EndOfStream)
                {
                    string line = p.ReadLine();
                    listBox1.Items.Add(line);
                }
                p.Close();
            }
        }
    }
}
