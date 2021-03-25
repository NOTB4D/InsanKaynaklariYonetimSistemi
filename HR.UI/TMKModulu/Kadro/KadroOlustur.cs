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
    public partial class KadroOlustur : Form
    {
        public KadroOlustur()
        {
            InitializeComponent();
        }

        SectionRepository section = new SectionRepository();
        StaffRepository staff = new StaffRepository();

        private void KadroOlustur_Load(object sender, EventArgs e)
        {
            this.Location = new Point(280, 150);
            List<Section> kadro = new List<Section>() { new Section() { SectionName = "Şube Seçiniz", ID = 0 } };
            kadro.AddRange(section.GetAllSection());
            cbSube.DataSource = kadro;
            cbSube.ValueMember = "ID";
            cbSube.DisplayMember = "SectionName";
        }

        int id = 0;
        private void cbSube_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id = (int)cbSube.SelectedValue;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nudPersonelSayisi.Text) || string.IsNullOrEmpty(cbSube.Text) || nudPersonelSayisi.Value == 0)
            {
                MessageBox.Show("Bu alan boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(nudPersonelSayisi, "Zorunlu Alan");
                errorProvider1.SetError(cbSube, "Zorunlu Alan");
                errorProvider1.SetError(nudPersonelSayisi, "Personel Sayısı 0 olamaz");
                return;
            }

            else
            {
                try
                {
                    Staff s = new Staff()
                    {
                        SectionID = id,
                        StaffCount = (int)nudPersonelSayisi.Value
                    };
                    staff.Create(s);
                    MessageBox.Show("Tebrikler kadro işlemi başarıyla oluşturuldu", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nudPersonelSayisi.ResetText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lütfen bir şube seçiniz...");
                }
            }
        }
    }
}
