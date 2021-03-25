using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Servisler.Duyurular
{
    public partial class DuyuruListele : Form
    {
        public DuyuruListele()
        {
            InitializeComponent();
        }

        private void DuyuruListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Duyurular.tb_Duyurular' table. You can move, or remove it, as needed.
            this.tb_DuyurularTableAdapter.Fill(this.Duyurular.tb_Duyurular);

            this.reportViewer1.RefreshReport();
        }
    }
}
