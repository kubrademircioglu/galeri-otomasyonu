using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace GaleriOtomasyon
{
    class ServisIslemleri
    {



        Baglanti baglanti = new Baglanti();
        public List<string> comboBoxDoldur()
        {

            List<string> cmbListesi = new List<string>();
            DataSet ds = new DataSet();

            string sorgu = "SELECT PLAKA FROM TB_SATILMIS_ARACLAR";

            using (OracleConnection connection = new OracleConnection(baglanti.yol()))
            {
                OracleCommand command = new OracleCommand(sorgu, connection);
                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {

                        cmbListesi.Add(reader.GetValue(0).ToString());
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return cmbListesi;

        }

        public List<string> comboBoxDoldur2()
        {

            List<string> cmbListesi = new List<string>();
            DataSet ds = new DataSet();

            string sorgu = "SELECT * FROM TB_SERVIS_TIPLERI";

            using (OracleConnection connection = new OracleConnection(baglanti.yol()))
            {
                OracleCommand command = new OracleCommand(sorgu, connection);
                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {

                        cmbListesi.Add(reader.GetValue(1).ToString());
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return cmbListesi;

        }



        public string KayitEkle(string plaka, string servistipi, string islemler, string maliyet)
        {

            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection(baglanti.yol());
                OracleCommand command = new OracleCommand("PROC_SERVIS_KAYDET", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_PLAKA", OracleDbType.Varchar2, 20).Value = plaka;
                command.Parameters.Add("@P_SERVIS_TIPI", OracleDbType.Varchar2, 20).Value = servistipi;
                command.Parameters.Add("@P_ISLEMLER", OracleDbType.Varchar2, 20).Value = islemler;
                command.Parameters.Add("@P_MALIYET", OracleDbType.Varchar2, 20).Value = maliyet;
               


                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Kayıt Başarılı";

            }


            catch (Exception e)
            {
                sonuc = "Kayıt Hatalı";

            }


            return sonuc;

        }






    }
}
