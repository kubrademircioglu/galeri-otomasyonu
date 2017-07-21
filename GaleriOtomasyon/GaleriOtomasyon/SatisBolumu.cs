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

namespace GaleriOtomasyon
{
    public partial class SatisBolumu : Form
    {
        public SatisBolumu()
        {
            InitializeComponent();
        }

        private void SatisBolumu_Load(object sender, EventArgs e)
        {
            dataGridAraclariGoster();

        }

        Baglanti baglanti = new Baglanti();
        public void dataGridAraclariGoster()
        {
            string sorgu = "SELECT * FROM VW_ARACLAR";
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglanti.yol());
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridAraclar.DataSource = ds.Tables[0];         
            baglanti.kapat();

            


            string sorgu2 = "SELECT * FROM TB_ALICI_BILGILERI";
            OracleDataAdapter oda2 = new OracleDataAdapter(sorgu2, baglanti.yol());
            DataSet ds2 = new DataSet();
            oda2.Fill(ds2);
            dataGridAliciSec.DataSource = ds2.Tables[0];
            baglanti.kapat();

            string sorgu3 = "SELECT * FROM VW_SATILMIS_ARACLAR";
            OracleDataAdapter oda3 = new OracleDataAdapter(sorgu3, baglanti.yol());
            DataSet ds3 = new DataSet();
            oda3.Fill(ds3);
            dataGridSatilmisAraclar.DataSource = ds3.Tables[0];
            baglanti.kapat();



        }
       public List<string> liste = new List<string>();

       AliciBolumu alicibolumu = new AliciBolumu();
        private void btnAracSat_Click(object sender, EventArgs e)
        {
          

            //alicibolumu.ShowDialog();
            lbAracBilgileri.DataSource = null;
            lbAracBilgileri.DataSource = liste;
            dataGridAraclariGoster();

        }

       


        SatışBilgileri satisbilgileri = new SatışBilgileri();
        SatisIslemleri satisislemleri=new SatisIslemleri();

       public string satilikaracid;
        private void dataGridAraclar_Click(object sender, EventArgs e)
        {
            liste.Clear();
           // lbAracBilgileri.

            satilikaracid = dataGridAraclar.SelectedRows[0].Cells[0].Value.ToString();
            tbMarka.Text = dataGridAraclar.SelectedRows[0].Cells[1].Value.ToString();
            tbModel.Text = dataGridAraclar.SelectedRows[0].Cells[2].Value.ToString();
            tbMotor.Text = dataGridAraclar.SelectedRows[0].Cells[3].Value.ToString();
            tbModelYili.Text = dataGridAraclar.SelectedRows[0].Cells[4].Value.ToString();
            tbRenk.Text = dataGridAraclar.SelectedRows[0].Cells[5].Value.ToString();
            tbYakit.Text = dataGridAraclar.SelectedRows[0].Cells[6].Value.ToString();
            tbKasa.Text = dataGridAraclar.SelectedRows[0].Cells[7].Value.ToString();
            tbFiyat.Text = dataGridAraclar.SelectedRows[0].Cells[8].Value.ToString();

            for (int i = 0; i < 9; i++)
            {
                liste.Add(dataGridAraclar.SelectedRows[0].Cells[i].Value.ToString());
            }

          //  lbAracBilgileri.DataSource = liste;
            
        }

        public List<string> liste2 = new List<string>();
       public string aliciid;
        private void dataGridAliciSec_Click(object sender, EventArgs e)
        {
            liste2.Clear();
            aliciid = dataGridAliciSec.SelectedRows[0].Cells[0].Value.ToString();
            tbsAd.Text = dataGridAliciSec.SelectedRows[0].Cells[1].Value.ToString();
            tbsSoyad.Text = dataGridAliciSec.SelectedRows[0].Cells[2].Value.ToString();
            tbsTelefon.Text = dataGridAliciSec.SelectedRows[0].Cells[3].Value.ToString();
            tbsEposta.Text = dataGridAliciSec.SelectedRows[0].Cells[4].Value.ToString();
            tbsAdres.Text = dataGridAliciSec.SelectedRows[0].Cells[5].Value.ToString();
            liste2.Clear();
            for (int i = 0; i < 6; i++)
            {
                
                liste2.Add(dataGridAliciSec.SelectedRows[0].Cells[i].Value.ToString());
            }
            
        }

        private void dataGridAliciSec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAliciSec_Click(object sender, EventArgs e)
        {

          //  lbAliciBilgileri.
            lbAliciBilgileri.DataSource = null;


            lbAliciBilgileri.DataSource = liste2;

        }

        private void btnSatisTamamla_Click(object sender, EventArgs e)
        {
            if (tbPlaka.Text == "" )
            {    
                MessageBox.Show("Lütfen Plaka Doldurun");
            }
            else
            {
                MessageBox.Show(satisislemleri.KayitEkle(satilikaracid, aliciid, tbPlaka.Text));
                
                
            }
            dataGridAraclariGoster();
           


            



        }

        private void btnAliciBilgileri_Click(object sender, EventArgs e)
        {
            alicibolumu.ShowDialog();
        }

        private void dataGridAraclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        RaporAl rapor = new RaporAl();
        private void btnTumSatilmisAraclar_Click(object sender, EventArgs e)
        {
            rapor.ShowDialog();
        }






    }
}
