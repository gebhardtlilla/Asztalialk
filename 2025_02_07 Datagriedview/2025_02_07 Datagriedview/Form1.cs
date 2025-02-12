using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_02_07_Datagriedview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TablaBeallitasok();
            TablaAdatok();
        }

        private int aktsor = 0;
        private void TablaAdatok()
        {
            tablaDGV.Rows[0].Cells[0].Value = "0,0";

            tablaDGV.Rows[0].HeaderCell.Value = "12222";
            //tablaDGV.Columns[0].HeaderCell.Value = "név";
            tablaDGV.Columns[0].HeaderText = "név";

            
        }

        void TablaBeallitasok()
        {
            tablaDGV.RowCount = 10;
            tablaDGV.ColumnCount = 5;

            int magassag = 30;
            //int szelesseg = 30;
            SorMagassagBeallitasa(magassag);
            //OszlopSzelessegBeallitasa(szelesseg);
            //tablaDGV.ColumnHeadersVisible = false;
            //tablaDGV.RowHeadersVisible = false;
            //tablaDGV.Width = tablaDGV.ColumnCount * szelesseg + 3;
            //tablaDGV.Height = tablaDGV.RowCount * magassag + 3;

        }

        private void OszlopSzelessegBeallitasa(int szelesseg)
        {
            for (int i = 0; i < tablaDGV.ColumnCount; i++)
            {
                tablaDGV.Columns[i].Width = szelesseg;
            }
        }

        private void SorMagassagBeallitasa(int magassag)
        {
            for (int i = 0; i < tablaDGV.RowCount; i++)
            {
                tablaDGV.Rows[i].Height = magassag;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Fajlbeolvasas("eredmenyek.csv");
        }

        private void Fajlbeolvasas(string path)
        {
            //StreamReader f = new StreamReader(path);
            //f.Close();
            string[] sorok = File.ReadAllLines(path);
            FejlecbeIras(sorok[0]);
            AdatokKiiratasa(sorok);
        }

        private void AdatokKiiratasa(string[] sorok)
        {
            tablaDGV.RowCount = sorok.Length - 1;
            for (int i = 1; i < sorok.Length; i++)
            {
                string[] st = sorok[i].Split(';');
                for (int j = 0; j < st.Length; j++)
                {
                    tablaDGV.Rows[i-1].Cells[j].Value = st[j];
                }
            }
        }

        private void FejlecbeIras(string fejlec)
        {
            string[] st = fejlec.Split(';');
            tablaDGV.ColumnCount = st.Length;
            for (int i = 0; i < st.Length; i++)
                tablaDGV.Columns[i].HeaderCell.Value = st[i];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablaDGV.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void tablaDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sor = tablaDGV.CurrentCell.RowIndex;
            int oszlop = tablaDGV.CurrentCell.ColumnIndex;
            Sorszinezes(sor, Color.Red);
            Sorszinezes(aktsor, Color.White);
            aktsor = sor;
            tablaDGV.ClearSelection();
            //MessageBox.Show($"{sor} {oszlop}");
        }

        private void Sorszinezes(int sor, Color szin)
        {
            for (int i = 0; i < tablaDGV.ColumnCount; i++)
            {

                tablaDGV.Rows[sor].Cells[i].Style.BackColor = szin;
            }
        }
    }
}
