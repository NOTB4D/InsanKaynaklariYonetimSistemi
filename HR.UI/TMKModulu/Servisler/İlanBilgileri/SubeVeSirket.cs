using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Servisler.İlanBilgileri
{
    public partial class SubeVeSirket : Form
    {
        public SubeVeSirket()
        {
            InitializeComponent();
        }

        private void SubeVeSirket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SubeSirket.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.SubeSirket.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
