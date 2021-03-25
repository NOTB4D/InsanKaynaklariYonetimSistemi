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

namespace HR.UI.TMKModulu.Malzeme
{
    public partial class MalzemeOlustur : Form
    {
        public MalzemeOlustur()
        {
            InitializeComponent();
        }

        SupplyRepository supplyRep = new SupplyRepository();

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            tbMalzemeAdi.Focus();
            if (string.IsNullOrEmpty(tbMalzemeAdi.Text))
            {
                MessageBox.Show("Malzeme  adı boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(tbMalzemeAdi, "Zorunlu Alan");
            }
            else
            {
                try
                {
                    Supply s = new Supply()
                    {
                        SupplyName = tbMalzemeAdi.Text.ToUpperInvariant().Trim().ToUpper()
                    };
                    supplyRep.Create(s);
                    MessageBox.Show("Malzeme adı başarıyla eklendi.", "Tebrikler");
                    tbMalzemeAdi.Clear();
                }
                catch
                {
                    MessageBox.Show("Malzeme Adı daha önce oluşturulmuştur lütfen yeni bir malzeme adı giriniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void MalzemeOlustur_Load(object sender, EventArgs e)
        {
            this.Location = new Point(280, 150);
        }
    }
}
