using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvanBarınağı
{
    public partial class Ana : Form
    {
        public Ana()
        {
            InitializeComponent();
        }
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Win7\Desktop\vtyss.accdb
        private void Ana_Load(object sender, EventArgs e)
        {

        }

        private void hayvanlarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hayvan h = new Hayvan();
            h.ShowDialog();
        }

        private void sahiplerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sahip s = new Sahip();
            s.ShowDialog();
        }

        private void çalışanlarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Çalışan c = new Çalışan();
            c.ShowDialog();
        }

        private void bölümlerimizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departman d = new Departman();
            d.ShowDialog();
        }

        private void bulunduğumuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bölge bo = new Bölge();
            bo.ShowDialog();
        }

        private void barınağımızaBağıçtaBulunanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bagışçı ba = new Bagışçı();
            ba.ShowDialog();

        }
    }
}
