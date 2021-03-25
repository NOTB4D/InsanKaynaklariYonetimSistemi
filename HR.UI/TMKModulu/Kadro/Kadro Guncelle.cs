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

namespace HR.UI.TMKModulu.Kadro
{
    public partial class Sube_Guncelle : Form
    {
        public Sube_Guncelle()
        {
            InitializeComponent();
        }

        SectionRepository sectionRep = new SectionRepository();
        StaffRepository staffRep = new StaffRepository();
        int id;

        private void Sube_Guncelle_Load(object sender, EventArgs e)
        {
            List<Section> kadro = new List<Section>() { new Section() { SectionName = "Şube Seçiniz", ID = 0 } };
            kadro.AddRange(sectionRep.list());
            cbSection.DataSource = kadro;
            cbSection.ValueMember = "ID";
            cbSection.DisplayMember = "SectionName";
            
            this.Location = new Point(280, 150);
        }


        private void cbSection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id = (int)cbSection.SelectedValue;

            Staff staff = new Staff()
            {
                SectionID = id,
                StaffCount = (int)nudAmount.Value
            };
            staff = staffRep.GetOneValue(staff);

            nudAmount.Value = staff.StaffCount;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(nudAmount.Value==0)
            {
                MessageBox.Show("Veri 0 a eşit olamaz");
                return;
            }
            try
            {
                Staff s = new Staff()
                {
                    SectionID = (int)cbSection.SelectedValue,
                    StaffCount = (int)nudAmount.Value
                };
                staffRep.Update(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Bilgieriniz başarıya güncellenmiştir.");
            }
        }
    }
}
