using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace GaleriOtomasyon
{
    class SatisIslemleri
    {



        Baglanti baglanti = new Baglanti();
        public string KayitEkle(string aracid, string aliciid, string plaka)
        {
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection(baglanti.yol());
                OracleCommand command = new OracleCommand("PROC_ARAC_SATIS", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_ALICI_ID", OracleDbType.Varchar2, 20).Value = aliciid;
                command.Parameters.Add("@P_ARAC_ID", OracleDbType.Varchar2, 20).Value = aracid;
                command.Parameters.Add("@P_PLAKA", OracleDbType.Varchar2, 20).Value = plaka;
                        
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Satış Başarılı";

            }

            catch (Exception e)
            {
                sonuc = "Satış Hatalı";

            }


            return sonuc;

        }







    }
}
