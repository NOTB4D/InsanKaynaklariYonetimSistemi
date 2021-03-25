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

namespace HR.UI.TMKModulu.Malzeme
{
    public partial class MalzemeSil : Form
    {
        public MalzemeSil()
        {
            InitializeComponent();
        }

        SupplyRepository supplyRep = new SupplyRepository();

        int id;

        private void MalzemeSil_Load(object sender, EventArgs e)
        {
            this.Location = new Point(310, 120);
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "SupplyName";
            listBox1.DataSource=supplyRep.GetAllSupply();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = (int)listBox1.SelectedValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Malzeme Adını silmek istiyor musunuz?","Emin misiniz",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
           
            supplyRep.Delete(id);
        }
    }
}
