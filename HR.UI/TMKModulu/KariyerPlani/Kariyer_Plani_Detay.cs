using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.KariyerPlani
{
    public partial class Kariyer__Plani_Detay : Form
    {
        public Kariyer__Plani_Detay()
        {
            InitializeComponent();
        }

        private void Kariyer__Plani_Detay_Load(object sender, EventArgs e)
        {
            this.tb_SubelerTableAdapter.Fill(this.kariyerDetay.tb_Subeler);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            this.DetayTableAdapter.Fill(this.kariyerDetay.Detay,(int)comboBox1.SelectedValue);
            this.reportViewer1.RefreshReport();
        }
    }
}
