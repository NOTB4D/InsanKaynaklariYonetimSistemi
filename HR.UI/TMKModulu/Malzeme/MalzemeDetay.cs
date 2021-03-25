using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Malzeme
{
    public partial class MalzemeDetay : Form
    {
        public MalzemeDetay()
        {
            InitializeComponent();
        }

        private void MalzemeDetay_Load(object sender, EventArgs e)
        {
            this.tb_SubelerTableAdapter.Fill(this.subeBazliMalzeme.tb_Subeler);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            this.DetayTableAdapter.Fill(this.subeBazliMalzeme.Detay, (int)comboBox1.SelectedValue);
            this.reportViewer1.RefreshReport();
        }
    }
}
