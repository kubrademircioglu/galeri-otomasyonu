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


using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace GaleriOtomasyon
{
    public partial class AliciBolumu : Form
    {
        public AliciBolumu()
        {
            InitializeComponent();
        }



        Baglanti baglanti = new Baglanti();

        public void dataGridKayitGoster()
        {
            string sorgu = "SELECT * FROM TB_ALICI_BILGILERI";

            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglanti.yol());
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridAliciEkle.DataSource = ds.Tables[0];
            dataGridAliciDuzenle.DataSource = ds.Tables[0];
            dataGridAliciSil.DataSource = ds.Tables[0];
            baglanti.kapat();
        }



        private void AliciBolumu_Load(object sender, EventArgs e)
        {
            dataGridKayitGoster();
        }



        AliciIslemleri aliciislemleri = new AliciIslemleri();

        private void btnAliciKaydet_Click(object sender, EventArgs e)
        {
            if (tbEAd.Text == "" && tbESoyad.Text == "" && tbEAdres.Text == "" && tbEEposta.Text == "" && tbETelefon.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {

                MessageBox.Show(aliciislemleri.KayitEkle(tbEAd.Text, tbESoyad.Text, tbETelefon.Text, tbEEposta.Text,  tbEAdres.Text));
                dataGridKayitGoster();
                tbEAd.Text = "";
                tbESoyad.Text = "";
                tbETelefon.Text = "";
                tbEEposta.Text = "";
                tbEAdres.Text = "";


            }
        }

        private void btnAliciDuzenle_Click(object sender, EventArgs e)
        {
            if (tbDAd.Text == "" && tbDSoyad.Text == "" && tbDAdres.Text == "" && tbDEposta.Text == "" && tbDTelefon.Text == "")
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
            }
            else
            {

                MessageBox.Show(aliciislemleri.KayitGuncelle(aliciid,  tbDAd.Text, tbDSoyad.Text, tbDTelefon.Text, tbDEposta.Text, tbDAdres.Text));
                dataGridKayitGoster();
                tbDAd.Text = "";
                tbDSoyad.Text = "";
                tbDTelefon.Text = "";
                tbDEposta.Text = "";
                tbDAdres.Text = "";


            }

        }
        string aliciid;

        private void dataGridAliciDuzenle_Click(object sender, EventArgs e)
        {
            aliciid = dataGridAliciDuzenle.SelectedRows[0].Cells[0].Value.ToString();
            tbDAd.Text = dataGridAliciDuzenle.SelectedRows[0].Cells[1].Value.ToString();
            tbDSoyad.Text = dataGridAliciDuzenle.SelectedRows[0].Cells[2].Value.ToString();
            tbDTelefon.Text = dataGridAliciDuzenle.SelectedRows[0].Cells[3].Value.ToString();
            tbDEposta.Text = dataGridAliciDuzenle.SelectedRows[0].Cells[4].Value.ToString();
            tbDAdres.Text = dataGridAliciDuzenle.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void dataGridAliciSil_Click(object sender, EventArgs e)
        {
            aliciid = dataGridAliciSil.SelectedRows[0].Cells[0].Value.ToString();          
            tbsAd.Text = dataGridAliciSil.SelectedRows[0].Cells[1].Value.ToString();
            tbsSoyad.Text = dataGridAliciSil.SelectedRows[0].Cells[2].Value.ToString();
            tbsTelefon.Text = dataGridAliciSil.SelectedRows[0].Cells[3].Value.ToString();
            tbsEposta.Text = dataGridAliciSil.SelectedRows[0].Cells[4].Value.ToString();
            tbsAdres.Text = dataGridAliciSil.SelectedRows[0].Cells[5].Value.ToString();
           
        }

        private void btnAliciSil_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aliciislemleri.KayitSil(aliciid));
            dataGridKayitGoster();
            tbsAd.Text = "";
            tbsSoyad.Text = "";
            tbsTelefon.Text = "";
            tbsEposta.Text = "";
            tbsAdres.Text = "";

        }

        private void dataGridAliciSil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbsAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbsTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbsEposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbsSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbsAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
        TumAliciRaporla tal = new TumAliciRaporla();
        private void btnTumAlici_Click(object sender, EventArgs e)
        {
            tal.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridAliciEkle.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridAliciEkle.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridAliciEkle.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridAliciEkle.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridAliciEkle[j, i].Value == null ? "" : dataGridAliciEkle[j, i].Value;
                    myRange.Select();


                }
            }
        }
    }
}
