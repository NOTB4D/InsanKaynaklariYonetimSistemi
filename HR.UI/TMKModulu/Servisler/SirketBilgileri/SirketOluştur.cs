using HR.UI.HRServiceCompanyInsertApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Servisler.SirketBilgileri
{
    public partial class SirketOluştur : Form
    {
        public SirketOluştur()
        {
            InitializeComponent();
        }
        HRServiceCompanyInsertApp.CompanyServicesSoapClient ekle = new HRServiceCompanyInsertApp.CompanyServicesSoapClient();
        private void btEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSirketAdı.Text) || string.IsNullOrEmpty(tbSirketAcılama.Text))
            {
                MessageBox.Show("Bu alanlar boş gecilemez", "Hata");
            }
            else
            {
                Company company = new Company() 
                { 
                    Email=tbEmail.Text.Trim(),
                    InternetSitesi=tbInternetSitesi.Text.Trim(),
                    SirketAciklamasi=tbSirketAcılama.Text.Trim(),
                    SirketAdi=tbSirketAdı.Text.Trim(),
                    SirketUnvani=tbUnvan.Text.Trim(),
                    Phone=tbPhone.Text.Trim(),


               
                };
                ekle.Insert(company);
                MessageBox.Show("Tebrikler bilgileriniz eklenmiştir");
                tbUnvan.Clear();
                tbSirketAdı.Clear();
                tbSirketAcılama.Clear();
                tbPhone.Clear();
                tbInternetSitesi.Clear();
                tbEmail.Clear();


            }

        }
    }
}
