using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Subeler
{
    public partial class SubeDetay : Form
    {
        public SubeDetay()
        {
            InitializeComponent();
        }

        private void SubeDetay_Load(object sender, EventArgs e)
        {
          
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SubeRapor.tb_Subeler' table. You can move, or remove it, as needed.
            this.tb_SubelerTableAdapter.Fill(this.SubeRapor.tb_Subeler);

            this.reportViewer1.RefreshReport();
        }
    }
}
