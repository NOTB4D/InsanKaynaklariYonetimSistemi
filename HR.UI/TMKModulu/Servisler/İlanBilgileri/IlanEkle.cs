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

namespace HR.UI.TMKModulu.Servisler.İlanBilgileri
{
    public partial class IlanEkle : Form
    {
        public IlanEkle()
        {
            InitializeComponent();
        }
        CompanyListRepository repository = new CompanyListRepository();
        JustSectionRepository sectionRep = new JustSectionRepository();
        AdvertisementRepository advrep = new AdvertisementRepository();
        private void IlanEkle_Load(object sender, EventArgs e)
        {
            List<Company> kadro = new List<Company>() { new Company() { Name = "Şirket Seçiniz", ID = 0 } };
            kadro.AddRange(repository.List());
            cbSirketAdi.DisplayMember = "Name";
            cbSirketAdi.ValueMember = "ID";
            cbSirketAdi.DataSource = repository.List();

            List<JustSection> sube = new List<JustSection>() { new JustSection() { Name = "Şube Seçiniz", ID = 0 } };
            sube.AddRange(sectionRep.List());
            cbSubeAdi.DisplayMember = "Name";
            cbSubeAdi.ValueMember = "ID";
            cbSubeAdi.DataSource = sectionRep.List();
        }
        int SubeID, SirketID;
        private void btEkle_Click(object sender, EventArgs e)
        {
            Advertisement adv = new Advertisement()
            {
                CompanyID = SirketID,
                SectionID = SubeID,
                Description = tbAciklama.Text.Trim(),
                NumberOfPersonel = Convert.ToInt32(tbPersonelSayi.Text.Trim()),
                Name = tbIlan.Text.Trim()
            };
            advrep.Create(adv);
            MessageBox.Show("Tebrikler");
        }

        private void cbSirketAdi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SirketID = Convert.ToInt32(cbSirketAdi.SelectedValue.ToString());
        }

        private void cbSubeAdi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SubeID = Convert.ToInt32(cbSubeAdi.SelectedValue.ToString());
        }
    }
}
