using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace GaleriOtomasyon
{
    public partial class KullaniciImport : Form
    {
        public KullaniciImport()
        {
            InitializeComponent();
        }

        
      
        private void KullaniciImport_Load(object sender, EventArgs e)
        {
            


        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\excel_dosya.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
            baglanti.Open();  //www.ahmetcansever.com
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Sayfa1$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridImport.DataSource = dt.DefaultView;
            baglanti.Close();
     
        }


        KullaniciIslemleri ki = new KullaniciIslemleri();
        private void BtnKayitEkle_Click(object sender, EventArgs e)
        {
            try
            {
                 for (int i = 0; i < dataGridImport.RowCount - 1; i++)
                    {
                     MessageBox.Show( ki.KayitEkle(dataGridImport[0,i].Value.ToString(),dataGridImport[1,i].Value.ToString(),dataGridImport[2,i].Value.ToString(),dataGridImport[3,i].Value.ToString(),dataGridImport[4,i].Value.ToString(),dataGridImport[5,i].Value.ToString(),dataGridImport[6,i].Value.ToString(),dataGridImport[7,i].Value.ToString()));
                      
                    }
                    
             }
            catch (Exception exp)
            {

                MessageBox.Show(exp.ToString());
            }
        }
    }
}
