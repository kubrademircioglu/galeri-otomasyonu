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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



      

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }
        Baglanti bag = new Baglanti();
        KullaniciGirisi kullanicigirisi = new KullaniciGirisi();
        
        Yonetim yonetim = new Yonetim();
        SatisBolumu satis = new SatisBolumu();
        ServisBolumu servis = new ServisBolumu();


        RaporAl rapor = new RaporAl();
        private void btnGiris_Click(object sender, EventArgs e)
        {
           string sonuc= kullanicigirisi.girisYap(tbKullaniciAdi.Text,tbParola.Text);
         
           if (sonuc == "Yönetim")
           {
               yonetim.lblKullaniciID.Text = tbKullaniciAdi.Text;
               this.Hide();

               yonetim.ShowDialog();


               this.Close();


           }
           else if (sonuc == "Satış")
           {
               yonetim.lblKullaniciID.Text = tbKullaniciAdi.Text;
               this.Hide();
               satis.ShowDialog();
               this.Close();

           }
           else if (sonuc == "Servis")
           {
               yonetim.lblKullaniciID.Text = tbKullaniciAdi.Text;
               this.Hide();
               servis.ShowDialog();
               this.Close();

           }
           else
           {
               MessageBox.Show("Yanlış Kullanıcı Adi veya Şifre Girişi...");
               tbKullaniciAdi.Text = "";
               tbParola.Text = "";
           }
            
         //   rapor.ShowDialog();
            

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
