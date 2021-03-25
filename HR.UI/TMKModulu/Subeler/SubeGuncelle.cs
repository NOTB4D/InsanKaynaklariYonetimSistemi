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

namespace HR.UI.TMKModulu.Subeler
{
    public partial class SubeGuncelle : Form
    {
        public SubeGuncelle()
        {
            InitializeComponent();
        }

        SectionRepository sectionRepository = new SectionRepository();
        int id;
        private void SubeGuncelle_Load(object sender, EventArgs e)
        {
            List<Section> deneme = new List<Section>() { new Section() { SectionName = "Şube Seçiniz", ID = 0 } };
            deneme.AddRange(sectionRepository.GetAllSection());
            cbSection.DataSource = deneme;
            cbSection.DisplayMember = "SectionName";
            cbSection.ValueMember = "ID";
        }

        private void cbSection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id = (int)cbSection.SelectedValue;

            Section section = new Section()
            {
                ID = id,
                Addres = tbAdres.Text.Trim(),
                Email = tbEmail.Text.ToUpper().Trim(),
                Fax = tbFax.Text.Trim(),
                PhoneNumber = tbTelefon.Text.ToUpper().Trim()
            };
            section = sectionRepository.GetOneValue(section);
            tbTelefon.Text = section.PhoneNumber;
            tbFax.Text = section.Fax;
            tbEmail.Text = section.Email;
            tbAdres.Text = section.Addres;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbAdres.Text) || string.IsNullOrEmpty(tbTelefon.Text) || string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbFax.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız...");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Sube Bilgisi güncellemek istiyor musunuz?", "Güncellenecek", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Section s = new Section()
                        {
                            Addres = tbAdres.Text.Trim(),
                            Email = tbEmail.Text.ToUpper().Trim(),
                            Fax = tbFax.Text.Trim(),
                            PhoneNumber = tbTelefon.Text.Trim(),
                            SectionName = cbSection.SelectedValue.ToString()
                        };
                        sectionRepository.Update(s);
                        MessageBox.Show("Bilgileriniz başarıyla güncellenmiştir.");
                        tbAdres.Clear();
                        tbEmail.Clear();
                        tbFax.Clear();
                        tbTelefon.Clear();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bu şube adı zaten tanımlanmış,lütfen başka bir şube adı giriniz.");
                }
            }
        }
    }
}
