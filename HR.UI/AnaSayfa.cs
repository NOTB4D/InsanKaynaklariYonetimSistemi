using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void şubeOluştur_Click(object sender, EventArgs e)
        {
            TMKModulu.Subeler.SubeOlustur section = new TMKModulu.Subeler.SubeOlustur();
            section.MdiParent = this;
            section.Show();
        }

        private void birimOluştur_Click(object sender, EventArgs e)
        {
            TMKModulu.Birim.BirimOlustur olustur = new TMKModulu.Birim.BirimOlustur();
            olustur.MdiParent = this;
            olustur.Show();
        }
        private void kadroOluştur_Click(object sender, EventArgs e)
        {
            TMKModulu.Kadro.KadroOlustur kadro = new TMKModulu.Kadro.KadroOlustur();
            kadro.MdiParent = this;
            kadro.Show();
        }
        private void kariyerOluştur_Click(object sender, EventArgs e)
        {
            TMKModulu.KariyerPlani.Kariyer_Olustur olustur = new TMKModulu.KariyerPlani.Kariyer_Olustur();
            olustur.MdiParent = this;
            olustur.Show();
        }
        private void malzemeOluştur_Click(object sender, EventArgs e)
        {
            TMKModulu.Malzeme.MalzemeOlustur malzemeOlustur = new TMKModulu.Malzeme.MalzemeOlustur();
            malzemeOlustur.MdiParent = this;
            malzemeOlustur.Show();
        }
        private void malzemeİptal_Click(object sender, EventArgs e)
        {
            TMKModulu.Malzeme.MalzemeSil malzemeSil = new TMKModulu.Malzeme.MalzemeSil();
            malzemeSil.MdiParent = this;
            malzemeSil.Show();
        }
        private void malzemeDetayOluştur_Click(object sender, EventArgs e)
        {
            TMKModulu.MalzemeDetay.MalzemeDetayOlustur malzemeDetay = new TMKModulu.MalzemeDetay.MalzemeDetayOlustur();
            malzemeDetay.MdiParent = this;
            malzemeDetay.Show();
        }
        private void kadroSil_Click(object sender, EventArgs e)
        {
            TMKModulu.Kadro.Kadro_Iptal kadroIptal = new TMKModulu.Kadro.Kadro_Iptal();
            kadroIptal.MdiParent = this;
            kadroIptal.Show();
        }
        private void istekTipiOluştur_Click(object sender, EventArgs e)
        {
            TMKModulu.Istek.IstekOlustur olustur = new TMKModulu.Istek.IstekOlustur();
            olustur.MdiParent = this;
            olustur.Show();
        }
        private void istekTipiSil_Click(object sender, EventArgs e)
        {
            TMKModulu.Istek.IstekTipiSil sil = new TMKModulu.Istek.IstekTipiSil();
            sil.MdiParent = this;
            sil.Show();
        }
        private void malzemeEksikListesiOluştur_Click(object sender, EventArgs e)
        {
            TMKModulu.MalzemeEksikListesi.MalzemeEksikOlustur olustur = new TMKModulu.MalzemeEksikListesi.MalzemeEksikOlustur();
            olustur.MdiParent = this;
            olustur.Show();
        }
        private void şubeDetay_Click(object sender, EventArgs e)
        {
            TMKModulu.Subeler.SubeDetay detay = new TMKModulu.Subeler.SubeDetay();
            detay.MdiParent = this;
            detay.Show();
        }
        private void birimDetay_Click(object sender, EventArgs e)
        {
            TMKModulu.Birim.BirimDetay rapor = new TMKModulu.Birim.BirimDetay();
            rapor.MdiParent = this;
            rapor.Show();
        }
        private void kadroDetay_Click(object sender, EventArgs e)
        {
            TMKModulu.Kadro.Kadro_Detay detay = new TMKModulu.Kadro.Kadro_Detay();
            detay.MdiParent = this;
            detay.Show();
        }
        private void kariyerPlaniDetay_Click(object sender, EventArgs e)
        {
            TMKModulu.KariyerPlani.Kariyer__Plani_Detay detay = new TMKModulu.KariyerPlani.Kariyer__Plani_Detay();
            detay.MdiParent = this;
            detay.Show();
        }
        private void kadroGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TMKModulu.Kadro.Sube_Guncelle guncelle = new TMKModulu.Kadro.Sube_Guncelle();
            guncelle.MdiParent = this;
            guncelle.Show();
        }
        private void malzemeDetay_Click(object sender, EventArgs e)
        {
            TMKModulu.Malzeme.MalzemeDetay detay = new TMKModulu.Malzeme.MalzemeDetay();
            detay.MdiParent = this;
            detay.Show();
        }
        private void egitimOluştur_Click(object sender, EventArgs e)
        {
            TMKModulu.Egitimler.EgitimOlustur olustur = new TMKModulu.Egitimler.EgitimOlustur();
            olustur.MdiParent = this;
            olustur.Show();
        }
        private void eğitimSil_Click(object sender, EventArgs e)
        {
            TMKModulu.Egitimler.EgitimGuncelle sil = new TMKModulu.Egitimler.EgitimGuncelle();
            sil.MdiParent = this;
            sil.Show();
        }
        private void eğitimKurumuOluştur_Click(object sender, EventArgs e)
        {
            TMKModulu.KurumBilgisi.KurumOlustur olustur = new TMKModulu.KurumBilgisi.KurumOlustur();
            olustur.MdiParent = this;
            olustur.Show();
        }
        private void eğitimKurumuSil_Click(object sender, EventArgs e)
        {
            TMKModulu.KurumBilgisi.KurumGuncelle sil = new TMKModulu.KurumBilgisi.KurumGuncelle();
            sil.MdiParent = this;
            sil.Show();
        }
        private void şubeGüncelle_Click(object sender, EventArgs e)
        {
            TMKModulu.Subeler.SubeGuncelle guncelle = new TMKModulu.Subeler.SubeGuncelle();
            guncelle.MdiParent = this;
            guncelle.Show();
        }
        private void birimGüncelle_Click(object sender, EventArgs e)
        {
            TMKModulu.Birim.BirimGuncelle guncelle = new TMKModulu.Birim.BirimGuncelle();
            guncelle.MdiParent = this;
            guncelle.Show();
        }

        private void AnaSayfa_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized==WindowState)
            {
                Hide();
                notifyIcon1.ShowBalloonTip(10);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void uygulamaHakkında_Click(object sender, EventArgs e)
        {
            TMKModulu.Hakkinda hk = new TMKModulu.Hakkinda();
            hk.ShowDialog();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void malzemeEksikDetayListele_Click(object sender, EventArgs e)
        {
            TMKModulu.MalzemeEksikListesi.MalzemeDetay detay = new TMKModulu.MalzemeEksikListesi.MalzemeDetay();
            detay.MdiParent = this;
            detay.Show();
        }

        private void malzemeEksikDetayListele_Click_1(object sender, EventArgs e)
        {
            TMKModulu.MalzemeEksikListesi.MalzemeEksikDetayListesi eksikListesi = new TMKModulu.MalzemeEksikListesi.MalzemeEksikDetayListesi();
            eksikListesi.MdiParent = this;
            eksikListesi.Show();
        }

        private void eğitimDetayListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TMKModulu.Egitimler.EgitimDetayListele listele = new TMKModulu.Egitimler.EgitimDetayListele();
            listele.MdiParent = this;
            listele.Show();
        }

        private void şirketListele_Click(object sender, EventArgs e)
        {
            TMKModulu.Servisler.SirketBilgileri.Sirketlerlist listele = new TMKModulu.Servisler.SirketBilgileri.Sirketlerlist();
            listele.MdiParent = this;
            listele.Show();
        }

        private void şirketListeleTool_Click(object sender, EventArgs e)
        {
            TMKModulu.Servisler.SirketBilgileri.SirketOluştur olustur = new TMKModulu.Servisler.SirketBilgileri.SirketOluştur();
            olustur.MdiParent = this;
            olustur.Show();
        }

        private void IlanOlustur_Click(object sender, EventArgs e)
        {
            TMKModulu.Servisler.İlanBilgileri.IlanEkle ekle = new TMKModulu.Servisler.İlanBilgileri.IlanEkle();
            ekle.MdiParent = this;
            ekle.Show();
        }

        

        private void duyuruOluştur_Click(object sender, EventArgs e)
        {
            TMKModulu.Servisler.Duyurular.DuyuruOlustur olustur = new TMKModulu.Servisler.Duyurular.DuyuruOlustur();
            olustur.MdiParent = this;
            olustur.Show();
        }

        private void duyuruListele_Click(object sender, EventArgs e)
        {
            TMKModulu.Servisler.Duyurular.DuyuruListele listele = new TMKModulu.Servisler.Duyurular.DuyuruListele();
            listele.MdiParent = this;
            listele.Show();
        }

        private void kullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TMKModulu.Servisler.KullanıcıBilgileri.KullaniciListele listele = new TMKModulu.Servisler.KullanıcıBilgileri.KullaniciListele();
            listele.MdiParent = this;
            listele.Show();

        }

        private void yetkilendirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TMKModulu.Servisler.KullanıcıBilgileri.KullaniciOlustur ekle = new TMKModulu.Servisler.KullanıcıBilgileri.KullaniciOlustur();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void şubeBazlıİlanMiktarıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TMKModulu.Servisler.İlanBilgileri.SubeBazli liste = new TMKModulu.Servisler.İlanBilgileri.SubeBazli();
            liste.MdiParent = this;
            liste.Show();
        }

        private void şirketlereGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TMKModulu.Servisler.İlanBilgileri.SubeVeSirket liste = new TMKModulu.Servisler.İlanBilgileri.SubeVeSirket();
            liste.MdiParent = this;
            liste.Show();
        }

        private void şubelereGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TMKModulu.Servisler.İlanBilgileri.SubelerIcin liste = new TMKModulu.Servisler.İlanBilgileri.SubelerIcin();
            liste.MdiParent = this;
            liste.Show();
        }

        private void başvuruListesi_Click(object sender, EventArgs e)
        {
            
        }

        private void şehirselListeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void şehirselListeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TMKModulu.Servisler.Başvurular.Sehiregore liste = new TMKModulu.Servisler.Başvurular.Sehiregore();
            liste.MdiParent = this;
            liste.Show();

        }

        private void işeAlınanlar_Click(object sender, EventArgs e)
        {
            TMKModulu.Servisler.Başvurular.IseAlinanlar liste = new TMKModulu.Servisler.Başvurular.IseAlinanlar();
            liste.MdiParent = this;
            liste.Show();
        }

        private void başvuruListesi_Click_1(object sender, EventArgs e)
        {
            TMKModulu.Servisler.Başvurular.Basvuran liste = new TMKModulu.Servisler.Başvurular.Basvuran();
            liste.MdiParent = this;
            liste.Show();
        }
    }
}
