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

namespace HR.UI.TMKModulu.Bildirim
{
    public partial class Bildirim_Olustur : Form
    {
        public Bildirim_Olustur()
        {
            InitializeComponent();
        }

        NoticeRepository notice = new NoticeRepository();
  
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBildirim.Text))
            {
                MessageBox.Show("Bildirim tipi bilgisi boş geçilemez", "Uyarı");
                errorProvider1.SetError(tbBildirim, "Zorunlu Alan");
            }
            else
            {
                try
                {
                    Notice n = new Notice()
                    {
                        NoticeName = tbBildirim.Text.ToUpper().Trim()
                    };
                    notice.Create(n);
                    MessageBox.Show("Bildirim tipi başarıyla eklenmiştir.");
                    tbBildirim.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Bildirim_Olustur_Load(object sender, EventArgs e)
        {
            this.Location = new Point(280, 150);
        }
    }
}
