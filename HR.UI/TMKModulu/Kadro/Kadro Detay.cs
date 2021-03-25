using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Kadro
{
    public partial class Kadro_Detay : Form
    {
        public Kadro_Detay()
        {
            InitializeComponent();
        }

        private void Kadro_Detay_Load(object sender, EventArgs e)
        {
            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KadroRapor.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.KadroRapor.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
