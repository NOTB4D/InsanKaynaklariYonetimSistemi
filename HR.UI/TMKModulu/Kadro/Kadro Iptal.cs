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
    public partial class Kadro_Iptal : Form
    {
        public Kadro_Iptal()
        {
            InitializeComponent();
        }

        int id;
        SectionRepository secRep = new SectionRepository();
        StaffRepository staffRep = new StaffRepository();
        private void Kadro_Iptal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(280, 150);
            cbSection.ValueMember = "ID";
            cbSection.DisplayMember = "SectionName";
            List<Section> kadro = new List<Section>() { new Section() { SectionName = "Şube Seçiniz", ID = 0 } };
            kadro.AddRange(secRep.GetAllSection());
            cbSection.DataSource = kadro;
            

        }
        Staff staff;
        private void cbSection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id = (int)cbSection.SelectedValue;

           
                staff = new Staff()
                {
                    SectionID = id
                };

                staff = staffRep.GetOneValue(staff);

                textBox1.Text = staff.StaffCount.ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Kadro bilgilerini silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    staffRep.Delete(id);
            
        }
    }
}
