using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Servisler.Başvurular
{
    public partial class Sehiregore : Form
    {
        public Sehiregore()
        {
            InitializeComponent();
        }

        private void Sehiregore_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_sehir.Text))
            {
                MessageBox.Show("Lütfen Bir Şehir Giriniz", "Uyarı");
                errorProvider1.SetError(tb_sehir, "Zorunlu Alan");

            }
            else
            {
                // TODO: This line of code loads data into the 'Sehir.DataTable1' table. You can move, or remove it, as needed.
                this.DataTable1TableAdapter.Fill(this.Sehir.DataTable1, tb_sehir.Text.ToUpper());

                this.reportViewer1.RefreshReport();
            }
        }

        private void tb_sehir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
