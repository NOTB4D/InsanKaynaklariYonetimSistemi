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

namespace HR.UI.TMKModulu.Servisler.KullanıcıBilgileri
{
    public partial class KullaniciOlustur : Form
    {
        public KullaniciOlustur()
        {
            InitializeComponent();
        }
        AdvertisementRepository advrep = new AdvertisementRepository();
        
        UsersRepository ur = new UsersRepository();
        int adminmi;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Users user = new Users()
            {
                 Ad=tbAd.Text.Trim(),
                 Soyad=tbSoyad.Text.Trim(),
                 Sifre=tbSifre.Text.Trim(),
                 Email=tbEmail.Text.Trim(),
                 AdminMi=Convert.ToBoolean(cbYetki.SelectedItem)
               //  IlanAdi=ilan
            };
            ur.create(user);
            MessageBox.Show("Kullanıcı bilgileri sisteme başarıyla tanımlanmıştır.","Tebrikler",MessageBoxButtons.OK,MessageBoxIcon.Information);

            tbAd.Clear();
            tbEmail.Clear();
            tbSifre.Clear();
            tbSoyad.Clear();
        }
        public enum Yetkisi
        {
            YetkiSeçiniz,
            Admin,
            Kullanıcı
            
        }
        private void KullaniciOlustur_Load(object sender, EventArgs e)
        {
            
            //cbIlan.DisplayMember = "Name";
            //cbIlan.ValueMember = "ID";
            //cbIlan.DataSource = advrep.List();
            cbYetki.DataSource= Enum.GetValues(typeof(Yetkisi));
           
        }

        private void cbYetki_SelectionChangeCommitted(object sender, EventArgs e)
        {
            adminmi = Convert.ToInt32(cbYetki.SelectedValue.ToString());
        }

        private void cbIlan_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // ilan = Convert.ToInt32(cbIlan.SelectedValue.ToString());
        }
    }
}
