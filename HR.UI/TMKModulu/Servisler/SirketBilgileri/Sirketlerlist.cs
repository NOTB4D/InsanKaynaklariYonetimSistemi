using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Servisler.SirketBilgileri
{
    public partial class Sirketlerlist : Form
    {
        public Sirketlerlist()
        {
            InitializeComponent();
        }

        private void Sirketlerlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Sirketler.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.Sirketler.DataTable1);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
