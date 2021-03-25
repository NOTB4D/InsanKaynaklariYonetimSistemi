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

namespace HR.UI.TMKModulu.MalzemeEksikListesi
{
    public partial class MalzemeEksikOlustur : Form
    {
        public MalzemeEksikOlustur()
        {
            InitializeComponent();
        }

        SectionRepository sectionRep = new SectionRepository();
        SupplyRepository supplyRep = new SupplyRepository();
        RequestRepository requiredRep = new RequestRepository();
        SupplyDetailsListRepository detailRep = new SupplyDetailsListRepository();
        int id, id2, id4;
        private void MalzemeEksikOlustur_Load(object sender, EventArgs e)
        {
            this.Location = new Point(310, 110);
            cbSection.ValueMember = "ID";
            cbSection.DisplayMember = "SectionName";
            List<Section> deneme = new List<Section>() { new Section() { SectionName = "Şube Seçiniz", ID = 0 } };
            deneme.AddRange(sectionRep.GetAllSection());
            cbSection.DataSource = deneme;
            

            lstMalzemeAdi.ValueMember = "ID";
            lstMalzemeAdi.DisplayMember = "SupplyName";
            lstMalzemeAdi.DataSource = supplyRep.GetAllSupply();
            
            cbRequired.ValueMember = "ID";
            cbRequired.DisplayMember = "RequestName";
            List<Request> istek = new List<Request>() { new Request() { RequestName = "İstek Seçiniz", ID = 0 } };
            istek.AddRange(requiredRep.GetAllRequest());
            cbRequired.DataSource = istek;
        }
        private void cbSection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id = (int)cbSection.SelectedValue;
        }
        private void lstMalzemeAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            id2 = (int)lstMalzemeAdi.SelectedValue;
        }

        private void cbRequired_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id4 = (int)cbRequired.SelectedValue;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {

            SupplyDetailsList list = new SupplyDetailsList()
                {
                    SectionID = id,
                    SupplyID = id2,
                    RequestID = id4
                };
            detailRep.Create(list);
            MessageBox.Show("Eksik malzeme bilgileri başarıyla kaydedildi", "Tebrikler");
        }
    }
}
