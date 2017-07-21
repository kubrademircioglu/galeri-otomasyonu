using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace GaleriOtomasyon
{
    class KullaniciGirisi
    {

        int sonuc;
        string username;
        string password;

        private string kullaniciAdi
        {
            get { return this.kullaniciAdi; }
            set { this.kullaniciAdi = value; }
        }

        private string parola
        {
            get
            { return this.parola; }
            set { this.parola = value; }
        }


        Baglanti baglanti = new Baglanti();

     
        public string girisYap(string kullaniciAdi, string parola)
        {
          string sorgu = "SELECT * FROM TB_USERS WHERE USERNAME='"+kullaniciAdi+"' AND PASSWORD='"+parola+"'";
         
  
    using (OracleConnection connection = new OracleConnection(baglanti.yol()))
    {
        OracleCommand command = new OracleCommand(sorgu, connection);
        connection.Open();
        OracleDataReader reader = command.ExecuteReader();
        try
        {
            while (reader.Read())
            {
                
                username = reader.GetValue(8).ToString();
            }
        }
        finally
        {
            reader.Close();
        }
    }

    return username;

        }




    }
}