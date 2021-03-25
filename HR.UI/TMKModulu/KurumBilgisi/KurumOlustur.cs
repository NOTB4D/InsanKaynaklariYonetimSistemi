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

namespace HR.UI.TMKModulu.KurumBilgisi
{
    public partial class KurumOlustur : Form
    {
        public KurumOlustur()
        {
            InitializeComponent();
        }
        EducationCompanyRepository repository = new EducationCompanyRepository();
        private void KurumOlustur_Load(object sender, EventArgs e)
        {
            tbKurumAdi.Focus();
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKurumAdi.Text))
            {
                MessageBox.Show("Kurum Adı boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EducationCompany company = new EducationCompany()
                {
                    Name = tbKurumAdi.Text.ToUpperInvariant().ToUpper().Trim()
                };
                repository.Create(company);
                tbKurumAdi.Clear();
                MessageBox.Show("Kurum Adı bilgisi başarıyla oluşturuldu.","Tebrikler");
            }
        }

        private void tbKurumAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        } 
    }
}
