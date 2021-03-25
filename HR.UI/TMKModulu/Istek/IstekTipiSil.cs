using HR.BLL.AllRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.UI.TMKModulu.Istek
{
    public partial class IstekTipiSil : Form
    {
        public IstekTipiSil()
        {
            InitializeComponent();
        }

        RequestRepository requestRep = new RequestRepository();
        int id;
        private void IstekTipiSil_Load(object sender, EventArgs e)
        {
            lstIstekTipi.ValueMember = "ID";
            lstIstekTipi.DisplayMember = "RequestName";
            lstIstekTipi.DataSource = requestRep.GetAllRequest();
            this.Location = new Point(310, 100);
        }
        private void lstIstekTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = (int)lstIstekTipi.SelectedValue;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İstek tipi silmek istediğinize emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                requestRep.Delete(id);
            MessageBox.Show("İstek Tipi bilgisi başarıyla silinmiştir.");
        }
    }
}
