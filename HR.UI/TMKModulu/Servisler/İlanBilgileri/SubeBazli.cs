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
    public partial class SubeBazli : Form
    {
        public SubeBazli()
        {
            InitializeComponent();
        }

        private void SubeBazli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Ilan.tb_Ilan' table. You can move, or remove it, as needed.
            this.tb_IlanTableAdapter.Fill(this.Ilan.tb_Ilan);

            this.reportViewer1.RefreshReport();
        }
    }
}
