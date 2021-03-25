using HR.BLL.AllRepository;
using HR.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Istek
{
    public partial class IstekOlustur : Form
    {
        public IstekOlustur()
        {
            InitializeComponent();
        }

        RequestRepository istek = new RequestRepository();

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbIstekTipi.Text.ToUpper().Trim()))
            {
                MessageBox.Show("Istek tip bilgisi boş geçilemez", "Uyarı");
                errorProvider1.SetError(tbIstekTipi, "Zorunlu Alan");
            }
            else
            {
                try
                {
                    Request request = new Request()
                    {
                        RequestName = tbIstekTipi.Text.ToUpperInvariant().ToUpper().Trim()
                    };
                    istek.Create(request);
                    tbIstekTipi.Clear();
                    MessageBox.Show("İstek tipi başarıyla oluşturuldu", "Tebrikler");
                }
                catch
                {
                    MessageBox.Show("İstek tipi bilgisi daha önce tanımlanmıştır.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void IstekOlustur_Load(object sender, EventArgs e)
        {
            this.Location = new Point(280, 150);
            tbIstekTipi.Focus();
        }

        private void tbIstekTipi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
