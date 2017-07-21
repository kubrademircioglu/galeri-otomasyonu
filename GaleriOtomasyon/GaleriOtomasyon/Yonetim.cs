using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Collections.Generic;



using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.IO;


namespace GaleriOtomasyon
{
    public partial class Yonetim : Form
    {
        public Yonetim()
        {
            InitializeComponent();
        }

        private void Yonetim_Load(object sender, EventArgs e)
        {

            pnlArac.Visible = false;
            pnlKullanici.Visible = false;

            
            
            

            


           
      

        }
        Baglanti baglanti = new Baglanti();



        //KULLANICI KAYITLARI DATAGRIDLERE DOLDURULUR
        public void dataGridKayitGoster() {
            string sorgu = "SELECT * FROM TB_USERS";

            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglanti.yol());
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridKullaniciEkle.DataSource = ds.Tables[0];
            dataGridKullaniciDuzenle.DataSource = ds.Tables[0];
            dataGridKullaniciSil.DataSource = ds.Tables[0];
            baglanti.kapat();
        }



        // ARAC KAYITLARI DATAGRIDLERI DOLDURULUR
        public void dataGridAracKayitGoster()
        {
           string sorgu = "SELECT * FROM VW_ARACLAR";

            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglanti.yol());
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridAracEkle.DataSource = ds.Tables[0];
            dataGridAracDuzenle.DataSource = ds.Tables[0];
            dataGridAracSil.DataSource = ds.Tables[0];
            baglanti.kapat();
            

            string sorgu2 = "SELECT * FROM VW_SILINMIS_ARACLAR";
            baglanti.baglan();
            OracleDataAdapter oda2 = new OracleDataAdapter(sorgu2, baglanti.yol());
            DataSet ds2 = new DataSet();
            oda2.Fill(ds2);
            dataGridSilinenAraclar.DataSource = ds2.Tables[0];
            baglanti.kapat();

            /*string sorgu3 = "SELECT * FROM VW_DUZENLENEN_ARACLAR";
            baglanti.baglan();
            OracleDataAdapter oda3 = new OracleDataAdapter(sorgu3, baglanti.yol());
            DataSet ds3 = new DataSet();
            oda3.Fill(ds3);
            dataGridDuzenlenenAraclar.DataSource = ds3.Tables[0];
            baglanti.kapat();
            */
      
        }

     
       


        //KULLANICI ISLEMLERI BUTONU
        private void button1_Click(object sender, EventArgs e)
        {
            pnlKullanici.Visible = true;
            pnlArac.Visible = false;
            dataGridKayitGoster();
        }



        


       KullaniciIslemleri kullaniciislemleri = new KullaniciIslemleri();     
       AracIslemleri aracislemleri=new AracIslemleri();
       
        //    Araç İşlemleri Butonu   //
        /////////////////////////////////////////////////////////////////////////////
        private void btnArac_Click(object sender, EventArgs e)
        {
            pnlArac.Visible = true;
                pnlKullanici.Visible = false;
                dataGridAracKayitGoster();           
                ComboBoxAracEkleDoldur();
                ComboBoxAracDuzenleDoldur();

                cbEkleSutun.DataSource = aracislemleri.icerikEkleSutun();
                cbDuzenleSutun.DataSource = aracislemleri.icerikDuzenleSutun();
                cbSilSutun.DataSource = aracislemleri.icerikSilSutun();
                

        }

        public void ComboBoxAracEkleDoldur() {
            cbA_MarkaEkle.DataSource = aracislemleri.comboBoxDoldur("MARKA");
            cbA_ModelEkle.DataSource = aracislemleri.comboBoxDoldur("MODEL");
            cbA_MotorEkle.DataSource = aracislemleri.comboBoxDoldur("MOTOR");
            cbA_YilEkle.DataSource = aracislemleri.comboBoxDoldur("MODELYILI");
            cbA_RenkEkle.DataSource = aracislemleri.comboBoxDoldur("RENK");
            cbA_YakitEkle.DataSource = aracislemleri.comboBoxDoldur("YAKIT");
            cbA_KasaEkle.DataSource = aracislemleri.comboBoxDoldur("KASA");
        }
        public void ComboBoxAracDuzenleDoldur()
        {
            cbU_Marka.DataSource = aracislemleri.comboBoxDoldur("MARKA");
            cbU_Model.DataSource = aracislemleri.comboBoxDoldur("MODEL");
            cbU_Motor.DataSource = aracislemleri.comboBoxDoldur("MOTOR");
            cbU_Yil.DataSource = aracislemleri.comboBoxDoldur("MODELYILI");
            cbU_Renk.DataSource = aracislemleri.comboBoxDoldur("RENK");
            cbU_Yakit.DataSource = aracislemleri.comboBoxDoldur("YAKIT");
            cbU_Kasa.DataSource = aracislemleri.comboBoxDoldur("KASA");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnKullaniciDuzenle_Click(object sender, EventArgs e)
        {

           
        }

        


        
        private void btnKullaniciKaydet_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" && tbPassword.Text == "" && cbTip.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {

                MessageBox.Show(kullaniciislemleri.KayitEkle(tbUsername.Text, tbPassword.Text, tbAd.Text, tbSoyad.Text, tbTelefon.Text, tbEposta.Text, tbAdres.Text, cbTip.Text));
                dataGridKayitGoster();

                tbUsername.Text="";
                tbPassword.Text="";
                tbAd.Text="";
                tbSoyad.Text=""; 
                tbTelefon.Text=""; 
                tbEposta.Text="";
                tbAdres.Text = "";


            }
        }


       public string userid;
        


        // Kullanıcı Düzenle Butonu
        private void btnKullaniciDuzenle_Click_1(object sender, EventArgs e)
       {
           if (tbUsername.Text == "" && tbPassword.Text == "" && cbTip.Text == "")
           {
               MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
           }
           else
           {
               MessageBox.Show(kullaniciislemleri.KayitGuncelle(userid, tbuUsername.Text, tbuPassword.Text, tbuAd.Text, tbuSoyad.Text, tbuTelefon.Text, tbuEposta.Text, tbuAdres.Text, cbuTip.Text));
               dataGridKayitGoster();
               tbuUsername.Text = "";
               tbuPassword.Text = "";
               tbuAd.Text = "";
               tbuSoyad.Text = "";
               tbuTelefon.Text = "";
               tbuEposta.Text = "";
               tbuAdres.Text = "";
           }
            
               
        }

        private void dataGridKullaniciDuzenle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridKullaniciDuzenle_Click(object sender, EventArgs e)
        {
            userid = dataGridKullaniciDuzenle.SelectedRows[0].Cells[0].Value.ToString();
            tbuUsername.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[1].Value.ToString();              
            tbuPassword.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[2].Value.ToString();
            tbuAd.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[3].Value.ToString();  
            tbuSoyad.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[4].Value.ToString();
            tbuTelefon.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[5].Value.ToString();   
            tbuEposta.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[6].Value.ToString();
            tbuAdres.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[7].Value.ToString();     
            cbuTip.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[8].Value.ToString();
        }



        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {   
            MessageBox.Show(kullaniciislemleri.KayitSil(userid));
            dataGridKayitGoster();
            tbsUsername.Text = "";
            tbsPassword.Text = "";
            tbsAd.Text = "";
            tbsSoyad.Text = "";
            tbsTelefon.Text = "";
            tbsEposta.Text = "";
            tbsAdres.Text = "";
        }

        private void dataGridKullaniciSil_Click(object sender, EventArgs e)
        {
            userid = dataGridKullaniciDuzenle.SelectedRows[0].Cells[0].Value.ToString();
            tbsUsername.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[1].Value.ToString();
            tbsPassword.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[2].Value.ToString();
            tbsAd.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[3].Value.ToString();
            tbsSoyad.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[4].Value.ToString();
            tbsTelefon.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[5].Value.ToString();
            tbsEposta.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[6].Value.ToString();
            tbsAdres.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[7].Value.ToString();
            tbsTip.Text = dataGridKullaniciDuzenle.SelectedRows[0].Cells[8].Value.ToString();

        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }


        // Araç Ekle Butonu
        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            if (tbA_Fiyat.Text == "" )
            {    
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {
                MessageBox.Show(aracislemleri.KayitEkle(cbA_MarkaEkle.Text, cbA_ModelEkle.Text, cbA_MotorEkle.Text, cbA_YilEkle.Text, cbA_RenkEkle.Text, cbA_YakitEkle.Text, cbA_KasaEkle.Text, tbA_Fiyat.Text));
                dataGridAracKayitGoster();
                ComboBoxAracEkleDoldur();
            }


        }
        string aracid;
        private void dataGridAracDuzenle_Click(object sender, EventArgs e)
        {
            aracid = dataGridAracDuzenle.SelectedRows[0].Cells[0].Value.ToString();
            cbU_Marka.Text = dataGridAracDuzenle.SelectedRows[0].Cells[1].Value.ToString();
            cbU_Model.Text = dataGridAracDuzenle.SelectedRows[0].Cells[2].Value.ToString();
            cbU_Motor.Text = dataGridAracDuzenle.SelectedRows[0].Cells[3].Value.ToString();
            cbU_Yil.Text = dataGridAracDuzenle.SelectedRows[0].Cells[4].Value.ToString();
            cbU_Renk.Text = dataGridAracDuzenle.SelectedRows[0].Cells[5].Value.ToString();
            cbU_Yakit.Text = dataGridAracDuzenle.SelectedRows[0].Cells[6].Value.ToString();           
            cbU_Kasa.Text = dataGridAracDuzenle.SelectedRows[0].Cells[7].Value.ToString();
            tbU_Fiyat.Text = dataGridAracDuzenle.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnAracDuzenle_Click(object sender, EventArgs e)
        {
            if (tbU_Fiyat.Text == ""  )
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {
                MessageBox.Show(aracislemleri.KayitGuncelle(aracid,cbU_Marka.Text, cbU_Model.Text, cbU_Motor.Text, cbU_Yil.Text, cbU_Renk.Text, cbU_Yakit.Text, cbU_Kasa.Text, tbU_Fiyat.Text));
               
                dataGridAracKayitGoster();
               
            }
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            if (tbS_Fiyat.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {
                MessageBox.Show(aracislemleri.KayitSil(S_aracid, cbS_Marka.Text, cbS_Model.Text, cbS_Motor.Text, cbS_Yil.Text, cbS_Renk.Text, cbS_Yakit.Text, cbS_Kasa.Text, tbS_Fiyat.Text));

                dataGridAracKayitGoster();
             
            }
        }

        string S_aracid;
        private void dataGridAracSil_Click(object sender, EventArgs e)
        {
            S_aracid = dataGridAracSil.SelectedRows[0].Cells[0].Value.ToString();
            cbS_Marka.Text = dataGridAracSil.SelectedRows[0].Cells[1].Value.ToString();
            cbS_Model.Text = dataGridAracSil.SelectedRows[0].Cells[2].Value.ToString();
            cbS_Motor.Text = dataGridAracSil.SelectedRows[0].Cells[3].Value.ToString();
            cbS_Yil.Text = dataGridAracSil.SelectedRows[0].Cells[4].Value.ToString();
            cbS_Renk.Text = dataGridAracSil.SelectedRows[0].Cells[5].Value.ToString();
            cbS_Yakit.Text = dataGridAracSil.SelectedRows[0].Cells[6].Value.ToString();
            cbS_Kasa.Text = dataGridAracSil.SelectedRows[0].Cells[7].Value.ToString();
            tbS_Fiyat.Text = dataGridAracSil.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dataGridAracKayitGoster();

        }

        private void cbEkleSutun_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEIcerikSutun.DataSource = aracislemleri.comboBoxDoldur(cbEkleSutun.Text);
            label51.Text = "Yeni " + cbEkleSutun.Text+" Verisi Ekle";



        }

        private void btnOzellikEkle_Click(object sender, EventArgs e)
        {

            if (tbOzellikEkle.Text != "")
            {
                MessageBox.Show(aracislemleri.ozellikEkle(cbEkleSutun.Text, cbEkleSutun.Text, tbOzellikEkle.Text));
            }
            else MessageBox.Show("Boş Geçmeyiniz");
            tbOzellikEkle.Text = "";
        }



        private void cbDuzenleSutun_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDIcerikSutun.DataSource = aracislemleri.comboBoxDoldur(cbDuzenleSutun.Text);
           
        }
        private void cbDIcerikSutun_SelectedIndexChanged(object sender, EventArgs e)
        {
            label52.Text = cbDIcerikSutun.Text + " Verisini Düzenle";
        }
        private void btnOzellikDuzenle_Click(object sender, EventArgs e)
        {
            if (tbOzellikDuzenle.Text != "")
            {
                MessageBox.Show(aracislemleri.ozellikDuzenle(cbDuzenleSutun.Text, cbDuzenleSutun.Text,cbDIcerikSutun.Text, tbOzellikDuzenle.Text));
            }
            else MessageBox.Show("Boş Geçmeyiniz");
            tbOzellikDuzenle.Text = "";
        }

        private void cbSilSutun_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSIcerikSutun.DataSource = aracislemleri.comboBoxDoldur(cbSilSutun.Text);
            
            
        }

        private void cbSIcerikSutun_SelectedIndexChanged(object sender, EventArgs e)
        {
            label54.Text = cbSIcerikSutun.Text + " Verisini Sil";
            tbOzellikSil.Text = cbSIcerikSutun.Text;
        }

        private void btnOzellikSil_Click(object sender, EventArgs e)
        {
            if (tbOzellikSil.Text != "")
            {
                MessageBox.Show(aracislemleri.ozellikSil(cbSilSutun.Text, cbSilSutun.Text, cbSIcerikSutun.Text, tbOzellikSil.Text));
            }
            else MessageBox.Show("Boş Geçmeyiniz");
            tbOzellikDuzenle.Text = "";
        }

        SatisBolumu satis = new SatisBolumu();
        private void btnSatis_Click(object sender, EventArgs e)
        {
            //this.Hide();
            satis.ShowDialog();
          //  this.Close();
        }

        private void dataGridAracEkle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridAracDuzenle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        AliciBolumu alicibolumu = new AliciBolumu();
        private void btnAliciBilgileri_Click(object sender, EventArgs e)
        {
            alicibolumu.ShowDialog();
        }


        ServisBolumu servisbolumu = new ServisBolumu();
        private void btnServis_Click(object sender, EventArgs e)
        {
            servisbolumu.ShowDialog();
        }


        KullaniciImport ki = new KullaniciImport();
        private void btnKullaniciImport_Click(object sender, EventArgs e)
        {
           
        }


        string secim;
        private void btnAktar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnAktar_Click_1(object sender, EventArgs e)
        {
            if (cbAktar.Text == "Tüm Araçlar")
            {
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dataGridAracEkle.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridAracEkle.Columns[j].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < dataGridAracEkle.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridAracEkle.Columns.Count; j++)
                    {

                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridAracEkle[j, i].Value == null ? "" : dataGridAracEkle[j, i].Value;
                        myRange.Select();


                    }
                }
            }

         /*   else if (cbAktar.Text == "Düzenlenmiş Araçlar")
            {


                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dataGridDuzenlenenAraclar.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridDuzenlenenAraclar.Columns[j].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < dataGridDuzenlenenAraclar.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridDuzenlenenAraclar.Columns.Count; j++)
                    {

                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridDuzenlenenAraclar[j, i].Value == null ? "" : dataGridDuzenlenenAraclar[j, i].Value;
                        myRange.Select();


                    }
                }
            
            }*/
            else if (cbAktar.Text == "Silinmiş Araçlar")
            {


                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dataGridSilinenAraclar.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridSilinenAraclar.Columns[j].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < dataGridSilinenAraclar.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridSilinenAraclar.Columns.Count; j++)
                    {

                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridSilinenAraclar[j, i].Value == null ? "" : dataGridSilinenAraclar[j, i].Value;
                        myRange.Select();


                    }
                }

            }
            else cbAktar.Text = "Tablo Seçiniz";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ki.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
    //## Settings
    //Path to store the oracle dump
    string path = @"C:\backup";
    string backupFileName = "GaleriOtomasyon.dmp";
    //your ORACLE_HOME enviroment variable must be setted or you need to set the path here:
    string oracleHome = Environment.GetEnvironmentVariable("C:/oraclexe/app/oracle/product/11.2.0/server"); //ORACLE_HOME
    string oracleUser = "system";
    string oraclePassword = "123456";
    string oracleSID = "xe";
    //###

    ProcessStartInfo psi = new ProcessStartInfo();
 
    //Exp is the tool used to export data.
    //this tool is inside $ORACLE_HOME\bin directory
    psi.FileName = Path.Combine(oracleHome, "bin", "exp");
  
    psi.RedirectStandardInput = false;
    psi.RedirectStandardOutput = true;
    string dumpFile = Path.Combine(path, backupFileName);
    //The command line is: exp user/password@database file=backupname.dmp [OPTIONS....]
    psi.Arguments = string.Format(oracleUser + "/" + oraclePassword + "@" + oracleSID + " FULL=y FILE=" + dumpFile);
    psi.UseShellExecute = false;
 
    Process process = Process.Start(psi);
    process.WaitForExit();
    process.Close();
    MessageBox.Show("Database Backup Completed Successfully");
    
 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string p1 = @"d:\archives\";
            string p2 = "media";
            string p3 = "images";
            string combined = Path.Combine(p1, p2, p3);
            MessageBox.Show(combined);
        }

       


    }
}
