using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Birim
{
    public partial class BirimDetay : Form
    {
        public BirimDetay()
        {
            InitializeComponent();
        }
        
        private void btnGet_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
              // TODO: This line of code loads data into the 'BirimRapor.tb_Birim' table. You can move, or remove it, as needed.
            this.tb_BirimTableAdapter.Fill(this.BirimRapor.tb_Birim);

        }

        private void BirimDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BirimRapor.tb_Birim' table. You can move, or remove it, as needed.
            this.tb_BirimTableAdapter.Fill(this.BirimRapor.tb_Birim);

        }

    }
}
