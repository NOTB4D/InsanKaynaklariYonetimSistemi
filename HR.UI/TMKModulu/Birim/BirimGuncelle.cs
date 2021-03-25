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
    public partial class BirimGuncelle : Form
    {
        public BirimGuncelle()
        {
            InitializeComponent();
        }

        SectionRepository section = new SectionRepository();
        DepartmentRepository department = new DepartmentRepository();
        private void BirimGuncelle_Load(object sender, EventArgs e)
        {
            List<Section> deneme = new List<Section>() { new Section() { SectionName = "Şube Seçiniz", ID = 0 } };
            deneme.AddRange(section.GetAllSection());
            comboBox1.DataSource = deneme;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "SectionName";


            tbYonetici.Enabled = false;
            tbBirimMuduru.Enabled = false;
            tbBirimAdi.Enabled = false;
        }
        int id;
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
 
            id = (int)comboBox1.SelectedValue;

            try
            {
                Department d = new Department()
                {
                    SectionName = id,
                    DepartmentName = tbBirimAdi.Text,
                    Director = tbYonetici.Text,
                    UnitManager = tbBirimMuduru.Text
                };
                d = department.GetOneValue(d);
                tbBirimAdi.Clear();
                tbBirimMuduru.Clear();
                tbYonetici.Clear();
                tbBirimAdi.Text = d.DepartmentName;
                tbBirimMuduru.Text = d.UnitManager;
                tbYonetici.Text = d.Director;

            }
            catch
            {
                MessageBox.Show("Bu Şubeye bağlı herhangi bilgi bulunmamaktadır","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            tbBirimAdi.Enabled = true;
            tbBirimMuduru.Enabled = true;
            tbYonetici.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bilgileri güncellemek istiyor musunuz?", "Değişiklik", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Department dep = new Department()
                {
                    SectionName = id,
                    DepartmentName = tbBirimAdi.Text.ToUpperInvariant().ToUpper().Trim(),
                    Director = tbYonetici.Text.ToUpper().Trim(),
                    UnitManager = tbBirimMuduru.Text.ToUpper().Trim()
                };
                department.Update(dep);
                MessageBox.Show("Bilgiler başarıyla güncellenmiştir.");
                tbBirimAdi.Clear();
                tbBirimMuduru.Clear();
                tbYonetici.Clear();
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
