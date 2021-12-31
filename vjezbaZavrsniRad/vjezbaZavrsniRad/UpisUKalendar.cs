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
    public partial class UpisUKalendar : Form
    {
        public UpisUKalendar()
        {
            InitializeComponent();
        }

        private void UpisUKalendar_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            KalendarBrodova fm = new KalendarBrodova();
            fm.Show();
        }
    }
}
