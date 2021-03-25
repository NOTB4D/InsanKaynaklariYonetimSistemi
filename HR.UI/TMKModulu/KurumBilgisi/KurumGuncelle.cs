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

namespace HR.UI.TMKModulu.KurumBilgisi
{
    public partial class KurumGuncelle : Form
    {
        public KurumGuncelle()
        {
            InitializeComponent();
        }

        EducationCompanyRepository repository = new EducationCompanyRepository();
        int id;

        private void Kurumsil_Load(object sender, EventArgs e)
        {
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = repository.List();

            cbKurumAdi.ValueMember = "ID";
            cbKurumAdi.DisplayMember = "Name";
            List<EducationCompany> sirket = new List<EducationCompany>() { new EducationCompany() { Name = "Egitim Kurumu Seçiniz", ID = 0 } };
            sirket.AddRange(repository.List());
            cbKurumAdi.DataSource = sirket;
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  if(listBox1.SelectedIndex!=0)
           // id = Convert.ToInt32(listBox1.SelectedValue.ToString());
        }
        private void cbKurumAdi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id = (int)cbKurumAdi.SelectedValue;
            EducationCompany education = new EducationCompany() { 
             ID=id,
              Name=cbKurumAdi.SelectedValue.ToString()
            };
            education=repository.GetOneValue(education);

            textBox1.Text = education.Name;
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text ))
            {
                MessageBox.Show("Kurum adını boş geçmeyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(MessageBox.Show("Kurum Adını güncellemek istediğinize emin misiniz?","Emi misin?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                EducationCompany education = new EducationCompany()
                {
                    ID = id,
                     Name=textBox1.Text.ToUpper().Trim()
                };
                repository.Update(education);
                textBox1.Clear();
                MessageBox.Show("Bilgileriniz başarıyla güncellenmiştir.","Tebrikler");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
