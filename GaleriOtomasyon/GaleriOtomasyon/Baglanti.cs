using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;



namespace GaleriOtomasyon
{
    class Baglanti
    {

        public string id = "HR";
        public string password = "system1";
        public string path="127.0.0.1:1521";

        public string sonuc;
        




        OracleConnection connection = new OracleConnection();
        OracleCommand cmd = new OracleCommand();



        public void baglan() {
            string connection_string = "user id=" + id + ";password=" + password + ";data source=" + path + ";";

            try
            {
                connection.ConnectionString = connection_string;
                sonuc = "Bağlantı Başarılı";
                connection.Open();
            }
            catch (Exception exp)
            {
                sonuc = "Bağlantı Hatalı";
            }
            //return sonuc;
        }

        public void kapat()
        {

            try
            {
                connection.Close();
                sonuc = "Baglanti Kapandı";
            }
            catch (Exception exp)
            {
                sonuc = "Bağlantı Kapanma Hatası";
            }
         //   return sonuc;

        }


        public string yol()
        {
            string connection_string = "user id=" + id + ";password=" + password + ";data source=" + path + ";";
            return connection_string;
           
        }


    }
}
