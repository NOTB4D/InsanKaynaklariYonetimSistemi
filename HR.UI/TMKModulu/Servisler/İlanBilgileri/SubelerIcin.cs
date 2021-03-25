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
    public partial class SubelerIcin : Form
    {
        public SubelerIcin()
        {
            InitializeComponent();
        }

        private void SubelerIcin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SubeyeGore.tb_Ilan' table. You can move, or remove it, as needed.
            this.tb_IlanTableAdapter.Fill(this.SubeyeGore.tb_Ilan);

            this.reportViewer1.RefreshReport();
        }
    }
}
