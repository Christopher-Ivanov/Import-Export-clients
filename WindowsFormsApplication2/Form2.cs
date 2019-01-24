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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)(8)) e.KeyChar = (char)(0);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

                        e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (textBox1.Text.Length > 0 && textBox2.Text != "" && textBox3.Text != "")
        {
            FileStream f = new FileStream("CLIENTS.DAT", FileMode.Append);
            BinaryWriter bw = new BinaryWriter(f);

            string nomer = textBox1.Text.ToUpper();
            string ime = textBox2.Text.ToUpper();
            int oper = comboBox1.SelectedIndex;
            int taksa = comboBox2.SelectedIndex;
            double price = double.Parse(textBox3.Text);
            int minuti = int.Parse(textBox4.Text);

            bw.Write(nomer); bw.Write(ime); bw.Write(oper); bw.Write(taksa); bw.Write(price); bw.Write(minuti);
            f.Close();
            MessageBox.Show("Данните са записани !");
        }
        else
            {
                MessageBox.Show("Липсват попълнени данни!");
                textBox1.Focus();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: textBox3.Text = "0,24"; break;
                case 1: textBox3.Text = "0,30"; break;
                case 2: textBox3.Text = "0.25"; break;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)(8)) e.KeyChar = (char)(0);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
