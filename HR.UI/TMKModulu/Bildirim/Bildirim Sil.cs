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

namespace HR.UI.TMKModulu.Bildirim
{
    public partial class Bildirim_Sil : Form
    {
        public Bildirim_Sil()
        {
            InitializeComponent();
        }
        int id;
        NoticeRepository noticeRep = new NoticeRepository();

        private void Bildirim_Sil_Load(object sender, EventArgs e)
        {
            lstBildirim.DisplayMember = "NoticeName";
            lstBildirim.ValueMember="ID";
            lstBildirim.DataSource = noticeRep.GetAllNotice(); ;

            this.Location = new Point(320, 100);
       
        }

        private void lstBildirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = (int)lstBildirim.SelectedValue;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bildirim tipi silmek istediğinize emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                noticeRep.Delete(id);
        }
    }
}
