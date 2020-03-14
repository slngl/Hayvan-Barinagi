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
    public partial class Bölge : Form
    {
        public Bölge()
        {
            InitializeComponent();
        }

        private void bolgeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bolgeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vtyssDataSet);

        }

        private void Bölge_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vtyssDataSet.bolge' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolgeTableAdapter.Fill(this.vtyssDataSet.bolge);

        }
    }
}
