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
    public partial class EgitimOlustur : Form
    {
        public EgitimOlustur()
        {
            InitializeComponent();
        }

        EducationRepository edRepository = new EducationRepository();
        private void EgitimOlustur_Load(object sender, EventArgs e)
        {
            tbEgitim.Focus();

            comboBox1.DataSource = Enum.GetValues(typeof(Seviyeler));
        }
        public enum Seviyeler
        {
          SeviyeSeçiniz,
          Giriş,
          OrtaSeviye,
          İleriSeviye
        }

        private void btnEgitim_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbEgitim.Text))
            {
                MessageBox.Show("Eğitim adı bilgisini boş bırakamazsınız", "Uyarı");

            }
            else
            {
                Education edu = new Education()
                {
                    EducationName = tbEgitim.Text.ToUpperInvariant().ToUpper().Trim(),
                     EducationLevel=comboBox1.SelectedItem.ToString()
                };
                edRepository.Create(edu);
                tbEgitim.Clear();
                MessageBox.Show("Bilgileriniz başarıyla eklendi", "Tebrikler");
            }
        }
    }
}
