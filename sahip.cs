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
    public partial class Sahip : Form
    {
        public Sahip()
        {
            InitializeComponent();
        }

        private void sahipBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sahipBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vtyssDataSet);

        }

        private void Sahip_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vtyssDataSet.sahip' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sahipTableAdapter.Fill(this.vtyssDataSet.sahip);

        }
    }
}
