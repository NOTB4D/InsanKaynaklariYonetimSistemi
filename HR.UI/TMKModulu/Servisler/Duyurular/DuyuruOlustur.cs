using HR.UI.HRServiceNoticeInsertApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Servisler.Duyurular
{
    public partial class DuyuruOlustur : Form
    {
        public DuyuruOlustur()
        {
            InitializeComponent();
        }

        HRServiceNoticeInsertApp.NoticeServicesSoapClient insertApp = new HRServiceNoticeInsertApp.NoticeServicesSoapClient();

        private void btEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDuyuru.Text))
            {
                MessageBox.Show("Boş geçilemez");
            }
            else
            {
                Notice notice = new Notice()
                {
                    DuyuruAdi = tbDuyuru.Text.Trim(),
                    DuyuruBaslamaTarihi = dtBaslangic.Value,
                    DuyuruBitisTarihi = dtBitis.Value,
                    DuyuruAciklama = tbAciklama.Text.Trim()
                };
                insertApp.Insert(notice);
                MessageBox.Show("Duyuru bilgisi başarıyla sisteme eklenmiştir.", "Tebrikler");

                tbAciklama.Clear();
                tbDuyuru.Clear();
            }
        }
    }
}
