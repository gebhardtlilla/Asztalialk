using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2025_01_31_FormAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string)comboBox1.Items[0] == "+")
            {
                int osszeg = (int)szam1NUD.Value + (int)szam2NUD.Value;
                EredmenyLabel.Text = "" + osszeg;
            }
            if((string)comboBox1.Items[1] == "-")
            {
                int kivonas = (int)szam1NUD.Value - (int)szam2NUD.Value;
                EredmenyLabel.Text = "" + kivonas;
            }
            if((string)comboBox1.Items[2] == "*")
            {
                int szorzat = (int)szam1NUD.Value * (int)szam2NUD.Value;
                EredmenyLabel.Text = "" + szorzat;
            }
            if ((string)comboBox1.Items[3] == "/")
            {
                int osztas = (int)szam1NUD.Value / (int)szam2NUD.Value;
                EredmenyLabel.Text = "" + osztas;
            }
            if ((string)comboBox1.Items[4] == "maradék")
            {
                int maradek = (int)szam1NUD.Value / (int)szam2NUD.Value;
                EredmenyLabel.Text = "" + maradek;
            }
            if ((string)comboBox1.Items[5] == "hatvány")
            {
                double hatvany = Math.Pow(Convert.ToDouble(szam1NUD.Value), Convert.ToDouble(szam2NUD.Value));
                EredmenyLabel.Text = "" + hatvany;
            }






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = ""+comboBox1.Items[0];
        }
    }
}
