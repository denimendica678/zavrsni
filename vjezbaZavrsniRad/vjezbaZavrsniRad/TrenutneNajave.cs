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
    public partial class TrenutneNajave : Form
    {
        public TrenutneNajave()
        {
            InitializeComponent();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pocetna fm = new Pocetna();
            fm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;

            
        }
    }
}
