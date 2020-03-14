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
    public partial class Çalışan : Form
    {
        public Çalışan()
        {
            InitializeComponent();
        }

        private void calisanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.calisanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vtyssDataSet);

        }

        private void Çalışan_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vtyssDataSet.calisan' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.calisanTableAdapter.Fill(this.vtyssDataSet.calisan);

        }
    }
}
