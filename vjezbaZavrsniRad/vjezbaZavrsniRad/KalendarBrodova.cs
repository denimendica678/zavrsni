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
    public partial class KalendarBrodova : Form
    {
        public KalendarBrodova()
        {
            InitializeComponent();
        }

        private void KalendarBrodova_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna fm = new Pocetna();
            fm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpisUKalendar fm = new UpisUKalendar();
            fm.Show();
        }
    }
}
