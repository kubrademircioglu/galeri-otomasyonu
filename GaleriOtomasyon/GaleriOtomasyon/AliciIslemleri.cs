using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;
using System.Data;

namespace GaleriOtomasyon
{
    class AliciIslemleri
    {
        public string username;
        public string password;

        Baglanti baglanti = new Baglanti();
       
        
        public string KayitEkle( string ad, string soyad, string telefon, string eposta, string adres)
        {
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection(baglanti.yol());
                OracleCommand command = new OracleCommand("PROC_ALICI_EKLE", connect);
                command.CommandType = CommandType.StoredProcedure;           
                command.Parameters.Add("@P_AD", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_SOYAD", OracleDbType.Varchar2, 20).Value = soyad;
                command.Parameters.Add("@P_TELEFON", OracleDbType.Varchar2, 20).Value = telefon;
                command.Parameters.Add("@P_EPOSTA", OracleDbType.Varchar2, 20).Value = eposta;
                command.Parameters.Add("@P_ADRES", OracleDbType.Varchar2, 20).Value = adres;
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




        public string KayitGuncelle(string userid, string ad, string soyad, string telefon, string eposta, string adres)
        {
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection(baglanti.yol());
                OracleCommand command = new OracleCommand("PROC_ALICI_GUNCELLE", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_ALICI_ID", OracleDbType.Varchar2, 20).Value = userid;
                command.Parameters.Add("@P_AD", OracleDbType.Varchar2, 20).Value = ad;
                command.Parameters.Add("@P_SOYAD", OracleDbType.Varchar2, 20).Value = soyad;
                command.Parameters.Add("@P_TELEFON", OracleDbType.Varchar2, 20).Value = telefon;
                command.Parameters.Add("@P_EPOSTA", OracleDbType.Varchar2, 20).Value = eposta;
                command.Parameters.Add("@P_ADRES", OracleDbType.Varchar2, 20).Value = adres;    
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Düzenleme Başarılı";
            }
            catch (Exception e)
            {
                sonuc = "Düzenleme Hatalı";
            }
            return sonuc;

        }

        public string KayitSil(string userid)
        {
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection(baglanti.yol());
                OracleCommand command = new OracleCommand("PROC_ALICI_SIL", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_ALICI_ID", OracleDbType.Varchar2, 20).Value = userid;
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                sonuc = "Silme İşlemi Başarılı";
            }
            catch (Exception e)
            {
                sonuc = "Silme İşlemi Hatalı";
            }
            return sonuc;
        }











    }
}
