using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriOtomasyon
{
    public partial class SatışBilgileri : Form
    {
        public SatışBilgileri()
        {
            InitializeComponent();
        }


       

        public List<string> liste = new List<string>();

        private void SatışBilgileri_Load(object sender, EventArgs e)
        {

            lbAracBilgileri.DataSource = liste;
            this.Refresh();

            groupBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satış Tamamlandı");
            this.Close();
        }
    }
}
