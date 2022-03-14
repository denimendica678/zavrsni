using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezbaZavrsniRad
{
    public partial class UpisBrodova : Form
    {

        private string zastava;
        private string ime;
        private string vrsta;
        private string gaz;
        private string duzina;
        private string sirina;

        

        public string Ime { get => ime; set => ime = value; }
        public string Vrsta { get => vrsta; set => vrsta = value; }
        public string Zastava { get => zastava; set => zastava = value; }
        public string Duzina { get => duzina; set => duzina = value; }
        public string Sirina { get => sirina; set => sirina = value; }
        public string Gaz { get => gaz; set => gaz = value; }



        public UpisBrodova()
        {
            InitializeComponent();
    

        }

        public UpisBrodova(string zastava, string ime, string vrsta, string gaz, string duzina, string sirina)
        {
            this.zastava = zastava;
            this.ime = ime;
            this.vrsta = vrsta;
            this.gaz = gaz;
            this.duzina = duzina;
            this.sirina = sirina;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna fm = new Pocetna();
            fm.Show();
        }

        private void UpisBrodova_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upis fm = new Upis();
            fm.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
