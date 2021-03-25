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

namespace HR.UI.TMKModulu.Egitimler
{
    public partial class EgitimGuncelle : Form
    {
        public EgitimGuncelle()
        {
            InitializeComponent();
        }
        EducationRepository repository = new EducationRepository();
        int id;
        private void EgitimSil_Load(object sender, EventArgs e)
        {
            List<Education> egitim = new List<Education>() { new Education() { EducationName = "Egitim Seçiniz", ID = 0 } };
            egitim.AddRange(repository.List());
            cbEgitimAdi.ValueMember = "ID";
            cbEgitimAdi.DisplayMember = "EducationName";
            cbEgitimAdi.DataSource = egitim;

            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "EducationName";
            listBox1.DataSource = repository.List();


            comboBox1.DataSource = Enum.GetValues(typeof(Seviyeler));
        }

        public enum Seviyeler
        {
            SeviyeSeciniz,
            Giriş,
            OrtaSeviye,
            İleriSeviye
        }
        private void cbEgitimAdi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id = (int)cbEgitimAdi.SelectedValue;

            Education edu = new Education() { 
             ID=id

            };
            edu = repository.GetOneValue(edu);
            tbYeniEgitimAdi.Text = edu.EducationName;
          
        }

        private void btnEgitimler_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbYeniEgitimAdi.Text))
            {
                MessageBox.Show("Eğitim bilgisi boş geçilemez","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else  if (MessageBox.Show("Eğitim bilgisini güncellemek istiyor musunuz?", "Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Education education =new Education(){
                 ID=id,
                 EducationName = tbYeniEgitimAdi.Text.ToUpperInvariant().ToUpper().Trim(),
                   EducationLevel=comboBox1.SelectedItem.ToString()
                };
                repository.Update(education);
                MessageBox.Show("Eğitim bilgisi başarıyla güncellenmiştir.","Tebrikler");
                tbYeniEgitimAdi.Clear();
            }
        }
    }
}
