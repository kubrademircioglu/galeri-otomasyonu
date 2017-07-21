using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;


namespace GaleriOtomasyon
{
    public partial class ServisBolumu : Form
    {
        public ServisBolumu()
        {
            InitializeComponent();
        }


        Baglanti baglanti = new Baglanti();






        public void plakaDoldur()
        {
            string sorgu = "SELECT PLAKA FROM TB_SATILMIS_ARACLAR";

            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglanti.yol());
            DataSet ds = new DataSet();
            oda.Fill(ds);
            cbPlaka.DataSource = ds.Tables[0];
            baglanti.kapat();

        }

        ServisIslemleri servisislemleri = new ServisIslemleri();

        private void ServisBolumu_Load(object sender, EventArgs e)
        {
            cbPlaka.DataSource = servisislemleri.comboBoxDoldur();
            cbServisTipi.DataSource = servisislemleri.comboBoxDoldur2();
            cbPlaka.Text = "";
            dataGridServisGoster();
        }

        private void cbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void dataGridServisGoster()
        {
            string sorgu = "SELECT * FROM TB_SERVIS_ISLEMLERI WHERE TARIH=(to_date(sysdate,'dd mm yyyy'))";
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglanti.yol());
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridServis.DataSource = ds.Tables[0];
            baglanti.kapat();


            string sorgu2 = "SELECT * FROM TB_SERVIS_ISLEMLERI ";
            OracleDataAdapter oda2 = new OracleDataAdapter(sorgu2, baglanti.yol());
            DataSet ds2 = new DataSet();
            oda2.Fill(ds2);
            dataGridTumServis.DataSource = ds2.Tables[0];
            baglanti.kapat();

        }

        private void btnAracSec_Click(object sender, EventArgs e)
        {
            lblPlaka.Text = cbPlaka.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbServisTipi.Text = "";
            cbPlaka.Text = "";
            rtbIsler.Text = "";
            tbMaliyet.Text = "";
            lblPlaka.Text = "";
        }


        public string plaka;
        public string islemler;
        public string maliyet;
        public string servistipi;
        private void btnKaydet_Click(object sender, EventArgs e)
        {

             plaka = lblPlaka.Text;
             servistipi = cbServisTipi.Text;
             islemler = rtbIsler.Text;
             maliyet = tbMaliyet.Text;


             if (plaka == "" || servistipi=="" ||islemler=="" || maliyet=="")
             {
                 MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
             }
             else
             {
                 MessageBox.Show(servisislemleri.KayitEkle(plaka, servistipi, islemler, maliyet));
                
             
             
             dataGridServisGoster();
             }
        }
        ServisTumRaporla str = new ServisTumRaporla();

        TumServisRaporla tumrapor = new TumServisRaporla();
        private void btnTumRapor_Click(object sender, EventArgs e)
        {
            
            tumrapor.ShowDialog();

        }


        TekServisRaporla tsr = new TekServisRaporla();
        private void btnTekServis_Click(object sender, EventArgs e)
        {
            tsr.ShowDialog();
        }
    }
}
