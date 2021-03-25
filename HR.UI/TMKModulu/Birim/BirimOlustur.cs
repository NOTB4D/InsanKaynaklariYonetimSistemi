using HR.BLL;
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

namespace HR.UI.TMKModulu.Birim
{
    public partial class BirimOlustur : Form
    {
        public BirimOlustur()
        {
            InitializeComponent();
        }

        DepartmentRepository department = new DepartmentRepository();
        SectionRepository repository = new SectionRepository();
        private void BirimOlustur_Load(object sender, EventArgs e)
        {
            List<Section> deneme = new List<Section>() { new Section() { SectionName = "Şube Seçiniz", ID = 0 } };
            deneme.AddRange(repository.GetAllSection());
            comboBox1.DataSource = deneme;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "SectionName";
            
            this.Location = new Point(280, 150);
            tbBirimAdi.Focus();
        }
        int id;

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id = (int)comboBox1.SelectedValue;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbBirimAdi.Text) || string.IsNullOrEmpty(tbBirimMuduru.Text) || string.IsNullOrEmpty(tbYonetici.Text))
            {
                MessageBox.Show("Departman bilgisi boş bırakılamaz", "Uyarı");
                errorProvider1.SetError(tbBirimAdi, "Zorunlu Alan");
                errorProvider1.SetError(tbBirimMuduru, "Zorunlu Alan");
                errorProvider1.SetError(tbYonetici, "Zorunlu Alan");
            }
            else
            {
                try
                {
                    Department d = new Department()
                    {
                        DepartmentName = tbBirimAdi.Text.ToUpperInvariant().ToUpper().Trim(),
                        Director = tbYonetici.Text.ToUpper().Trim(),
                        UnitManager = tbBirimMuduru.Text.ToUpper().Trim(),
                        SectionName = id
                    };
                    department.Create(d);
                    tbBirimAdi.Clear();
                    tbBirimMuduru.Clear();
                    tbYonetici.Clear();
                    MessageBox.Show("Tebrikler birim adını başarıyla oluşturdunuz", "Tebrikler");
                }
                catch (Exception)
                {
                    MessageBox.Show("Birim adı daha önceden tanımlanmıştır yada lütfen bir birim adı seciniz");
                }
            }
        }

        private void tbBirimAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBirimMuduru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbYonetici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
