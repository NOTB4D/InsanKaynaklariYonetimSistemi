using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Servisler.KullanıcıBilgileri
{
    public partial class KullaniciListele : Form
    {
        public KullaniciListele()
        {
            InitializeComponent();
        }

        private void KullanıcıDetaycs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Kullanici.tb_Kullanicilar' table. You can move, or remove it, as needed.
            this.tb_KullanicilarTableAdapter.Fill(this.Kullanici.tb_Kullanicilar);

            this.reportViewer1.RefreshReport();
        }
    }
}
