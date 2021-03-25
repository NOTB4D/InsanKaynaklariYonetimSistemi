using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.MalzemeEksikListesi
{
    public partial class MalzemeDetay : Form
    {
        public MalzemeDetay()
        {
            InitializeComponent();
        }

        private void MalzemeEksikDetay_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
