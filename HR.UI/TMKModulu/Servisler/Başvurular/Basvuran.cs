using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Servisler.Başvurular
{
    public partial class Basvuran : Form
    {
        public Basvuran()
        {
            InitializeComponent();
        }

        private void Basvuran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Basvuranlar.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.Basvuranlar.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
