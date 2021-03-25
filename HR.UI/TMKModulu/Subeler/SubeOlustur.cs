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
    public partial class SubeOlustur : Form
    {
        public SubeOlustur()
        {
            InitializeComponent();
        }

        SectionRepository section = new SectionRepository();

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            tbSube.Focus();
            if (string.IsNullOrEmpty(tbSube.Text) || string.IsNullOrEmpty(tbAdres.Text) || string.IsNullOrEmpty(tbTel.Text) || string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Şube adı boş bırakılamaz");
                errorProvider1.SetError(tbSube, "Zorunlu Alan");
                errorProvider1.SetError(tbTel, "Zorunlu Alan");
                errorProvider1.SetError(tbEmail, "Zorunlu Alan");
                errorProvider1.SetError(tbFax, "Zorunlu Alan");
                errorProvider1.SetError(tbAdres, "Zorunlu Alan");
            }
            else
            {
                try
                {
                    Section s = new Section()
                    {
                        SectionName = tbSube.Text.ToUpperInvariant().ToUpper().Trim(),
                        PhoneNumber = tbTel.Text.ToUpper().Trim(),
                        Addres = tbAdres.Text.ToUpper().Trim(),
                        Email = tbEmail.Text.ToUpper().Trim(),
                        Fax = tbFax.Text.ToUpper().Trim()
                    };
                    section.Create(s);
                    MessageBox.Show("Şube ismi başarıyla oluşturuldu.", "Tebrikler");
                    tbSube.Clear();
                    tbEmail.Clear();
                    tbFax.Clear();
                    tbTel.Clear();
                    tbAdres.Clear();
                    
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Bu şube adı zaten tanımlanmış,lütfen başka bir şube adı giriniz.");
                }
            }
        }

        private void SubeOlustur_Load(object sender, EventArgs e)
        {
            this.Location = new Point(280, 150);
        }

        private void tbSube_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
    }
}
