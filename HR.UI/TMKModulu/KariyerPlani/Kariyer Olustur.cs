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

namespace HR.UI.TMKModulu.KariyerPlani
{
    public partial class Kariyer_Olustur : Form
    {
        public Kariyer_Olustur()
        {
            InitializeComponent();
        }

        int sectionID;
        int eduID;
        int comID;
        SectionRepository sectionRepository = new SectionRepository();
        EducationRepository repository = new EducationRepository();
        EducationCompanyRepository company = new EducationCompanyRepository();
        CareerPlanRepository careerPlan = new CareerPlanRepository();
        private void Kariyer_Olustur_Load(object sender, EventArgs e)
        {
            cbSection.ValueMember = "ID";
            cbSection.DisplayMember = "SectionName";
            List<Section> sube = new List<Section>() { new Section() { SectionName = "Şube Seçiniz", ID = 0 } };
            sube.AddRange(sectionRepository.GetAllSection());
            cbSection.DataSource = sube;

            cbEducation.ValueMember = "ID";
            cbEducation.DisplayMember = "EducationName";
            List<Education> egitim = new List<Education>() { new Education() { EducationName = "Egitim Seçiniz", ID = 0 } };
            egitim.AddRange(repository.List());
            cbEducation.DataSource = egitim;
            

            cbCompany.ValueMember = "ID";
            cbCompany.DisplayMember = "Name";
            List<EducationCompany> sirket = new List<EducationCompany>() { new EducationCompany() { Name = "Egitim Kurumu Seçiniz", ID = 0 } };
            sirket.AddRange(company.List());
            cbCompany.DataSource = sirket;

            this.Location = new Point(310, 80);
        }
        private void cbSection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sectionID = (int)cbSection.SelectedValue;
        }
        private void cbEducation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eduID = (int)cbEducation.SelectedValue;
        }
        private void cbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comID = (int)cbCompany.SelectedValue;
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                CareerPlan plan = new CareerPlan()
                {
                    EducationID = eduID,
                    SectionID = sectionID,
                    EduCompanyID = comID,
                    StartDate = dtStartDate.Value,
                    EndDate = dtFinishDate.Value,
                    AboutEducations = tbAciklama.Text.Trim()
                };
                careerPlan.Create(plan);
                MessageBox.Show("Tebrikler Eğitim bilgileri başarıyla oluşturuldu.");
            }
            catch
            {
                MessageBox.Show("Lütfen bütün bilgileri eksik bırakmayınız");
            }
        }
    }
}
