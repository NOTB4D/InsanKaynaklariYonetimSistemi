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
namespace HR.UI
{
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        LoginRepository repository = new LoginRepository();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login l = repository.Login(tbEmail.Text, tbSifre.Text,true);
            
            if (l!=null)
            {
                AnaSayfa frm = new AnaSayfa();
                frm.label1.Text = "Merhaba Sayın :   "+ tbEmail.Text;
                this.Hide();
                frm.Show();
                Clear();
            }
            else if (string.IsNullOrEmpty(tbEmail.Text)||string.IsNullOrEmpty(tbSifre.Text))
            {

                MessageBox.Show("Kullanci adı veya şifre bilgilerini boş geçemezsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();  
            }
            else
            {
                MessageBox.Show("Kullanıcı adı,şifreniz eksik veya hatalıdır. Lütfen kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
        }

        private void Clear()
        {
            tbSifre.Clear();
            tbEmail.Clear();
        }
        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            tbEmail.Focus();
        }
    }
}
