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
    public partial class Bagışçı : Form
    {
        public Bagışçı()
        {
            InitializeComponent();
        }

        private void bagisciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bagisciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vtyssDataSet);

        }

        private void Bagışçı_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vtyssDataSet.bagisci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bagisciTableAdapter.Fill(this.vtyssDataSet.bagisci);

        }
    }
}
