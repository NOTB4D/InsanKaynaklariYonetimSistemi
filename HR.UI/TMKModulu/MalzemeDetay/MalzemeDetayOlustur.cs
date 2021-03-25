using HR.BLL;
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

namespace HR.UI.TMKModulu.MalzemeDetay
{
    public partial class MalzemeDetayOlustur : Form
    {
        public MalzemeDetayOlustur()
        {
            InitializeComponent();
        }
        
        SupplyRepository supplyRep = new SupplyRepository();
        SectionRepository sectionRep = new SectionRepository();
        DepartmentRepository departmentRep = new DepartmentRepository();
        SupplyDetailsRepository supplyDetailRep = new SupplyDetailsRepository();
        int secID, supID, DepID;
        private void MalzemeDetayOlustur_Load(object sender, EventArgs e)
        {
            this.Location = new Point(310, 110);
            cbSupply.ValueMember = "ID";
            cbSupply.DisplayMember = "SupplyName";
            List<Supply> esya = new List<Supply>() { new Supply() { SupplyName = "Malzeme Adı Seçiniz", ID = 0 } };
            esya.AddRange(supplyRep.GetAllSupply());
            cbSupply.DataSource = esya;

            List<Section> deneme = new List<Section>() { new Section() { SectionName = "Şube Seçiniz", ID = 0 } };
            deneme.AddRange(sectionRep.GetAllSection());
            cbSection.ValueMember = "ID";
            cbSection.DisplayMember = "SectionName";
            cbSection.DataSource = deneme;

            List<Department> birim = new List<Department>() { new Department() { DepartmentName = "Birim Seçiniz", ID = 0 } };
            birim.AddRange(departmentRep.GetAllDepartment());
            cbDepartment.ValueMember = "ID";
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.DataSource = birim;
        }

        private void cbSupply_SelectionChangeCommitted(object sender, EventArgs e)
        {
            supID = (int)cbSupply.SelectedValue;
        }

        private void cbSection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            secID = (int)cbSection.SelectedValue;
        }

        private void cbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DepID = (int)cbDepartment.SelectedValue;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (nudAmount.Value==0)
            {
                MessageBox.Show("Miktar 0'dan büyük olmak zorundadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                SupplyDetails supply = new SupplyDetails()
                {
                    SupplyID = supID,
                    SectionID = secID,
                    DepartmentID = DepID,
                    Amount = (int)nudAmount.Value
                };
                supplyDetailRep.Create(supply);
                MessageBox.Show("Malzeme detay bilgisi başarıyla oluşturulmuştur.", "Tebrikler");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
