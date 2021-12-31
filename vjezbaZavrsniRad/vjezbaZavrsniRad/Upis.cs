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
    public partial class Upis : Form
    {
        public Upis()
        {
            InitializeComponent();
        }

        private void Upis_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpisBrodova fm = new UpisBrodova();
            fm.Show();
        }
    }
}
