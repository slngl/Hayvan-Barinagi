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
    public partial class Departman : Form
    {
        public Departman()
        {
            InitializeComponent();
        }

        private void departmanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vtyssDataSet);

        }

        private void Departman_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vtyssDataSet.departman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmanTableAdapter.Fill(this.vtyssDataSet.departman);

        }
    }
}
