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
    class AracIslemleri
    {
        Baglanti baglanti = new Baglanti();



       
   


        public List<string> comboBoxDoldur(string cbTip) {

            List<string> cmbListesi = new List<string>();
            DataSet ds = new DataSet();
            
            string sorgu = "SELECT * FROM TB_ARAC_"+cbTip+"";

            using (OracleConnection connection = new OracleConnection(baglanti.yol()))
            {
                OracleCommand command = new OracleCommand(sorgu, connection);
                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {

                        cmbListesi.Add ( reader.GetValue(1).ToString());
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return cmbListesi;
        
        }



        public string KayitEkle(string marka, string model, string motor, string modelyili, string renk, string yakit, string kasa, string fiyat)
        {

            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection(baglanti.yol());
                OracleCommand command = new OracleCommand("PROC_ARAC_EKLE", connect);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_MARKA", OracleDbType.Varchar2, 20).Value = marka;
                command.Parameters.Add("@P_MODEL", OracleDbType.Varchar2, 20).Value = model;
                command.Parameters.Add("@P_MOTOR", OracleDbType.Varchar2, 20).Value = motor;
                command.Parameters.Add("@P_MODELYILI", OracleDbType.Varchar2, 20).Value = modelyili;
                command.Parameters.Add("@P_RENK", OracleDbType.Varchar2, 20).Value = renk;
                command.Parameters.Add("@P_YAKIT", OracleDbType.Varchar2, 20).Value = yakit;
                command.Parameters.Add("@P_KASA", OracleDbType.Varchar2, 20).Value = kasa;
                command.Parameters.Add("@P_FIYAT", OracleDbType.Varchar2, 20).Value = fiyat;


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



        public string KayitGuncelle(string aracid, string marka, string model, string motor, string modelyili, string renk, string yakit, string kasa, string fiyat)
        {
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection(baglanti.yol());
                OracleCommand command = new OracleCommand("PROC_ARAC_GUNCELLE", connect);

                command.CommandType = CommandType.StoredProcedure;
         command.Parameters.Add("@P_ARAC_ID", OracleDbType.Varchar2, 20).Value = aracid;
                command.Parameters.Add("@P_MARKA", OracleDbType.Varchar2, 20).Value = marka;
                command.Parameters.Add("@P_MODEL", OracleDbType.Varchar2, 20).Value = model;
                command.Parameters.Add("@P_MOTOR", OracleDbType.Varchar2, 20).Value = motor;
                command.Parameters.Add("@P_MODELYILI", OracleDbType.Varchar2, 20).Value = modelyili;
                command.Parameters.Add("@P_RENK", OracleDbType.Varchar2, 20).Value = renk;
                command.Parameters.Add("@P_YAKIT", OracleDbType.Varchar2, 20).Value = yakit;
                command.Parameters.Add("@P_KASA", OracleDbType.Varchar2, 20).Value = kasa;
                command.Parameters.Add("@P_FIYAT", OracleDbType.Varchar2, 20).Value = fiyat;
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
        public string KayitSil(string aracid, string marka, string model, string motor, string modelyili, string renk, string yakit, string kasa, string fiyat)
        {
            string sonuc;
            try
            {
                OracleConnection connect = new OracleConnection(baglanti.yol());
                OracleCommand command = new OracleCommand("PROC_ARAC_SIL", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@P_ARAC_ID", OracleDbType.Varchar2, 20).Value = aracid;
                command.Parameters.Add("@P_MARKA", OracleDbType.Varchar2, 20).Value = marka;
                command.Parameters.Add("@P_MODEL", OracleDbType.Varchar2, 20).Value = model;
                command.Parameters.Add("@P_MOTOR", OracleDbType.Varchar2, 20).Value = motor;
                command.Parameters.Add("@P_MODEL_YILI", OracleDbType.Varchar2, 20).Value = modelyili;
                command.Parameters.Add("@P_RENK", OracleDbType.Varchar2, 20).Value = renk;
                command.Parameters.Add("@P_YAKIT", OracleDbType.Varchar2, 20).Value = yakit;
                command.Parameters.Add("@P_KASA", OracleDbType.Varchar2, 20).Value = kasa;
                command.Parameters.Add("@P_FIYAT", OracleDbType.Varchar2, 20).Value = fiyat;
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


        public string ozellikEkle(string tabloadi,  string sutun, string ozellik)
        {

            ozellik = ozellik.ToUpper();
           string tb_adi="TB_ARAC_";
            tb_adi=tb_adi+tabloadi;
            string sonuc;


            if (sutun == "KASA")
            {
                sutun = sutun + "_TIPI";
            }
            else if (sutun == "MODELYILI")
            {
                sutun =  "MODEL_YILI";
            }
            else if (sutun == "MOTOR")
            {
                sutun = sutun + "_HACMI";
            }
            else
                {
                sutun = sutun + "_ADI";
            }       

        List<string> cmbListesi = new List<string>();
        DataSet ds = new DataSet();

        string sorgu = "SELECT * FROM TB_ARAC_" + tabloadi + "";

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
        string update = "INSERT INTO " + tb_adi + "  (" + sutun + ") VALUES ('" + ozellik + "')";
        if (cmbListesi.Contains(ozellik) ) {
            sonuc = "Değer Listede Yer Almaktadır";
        }
        else
        {
            OracleConnection conn = new OracleConnection(baglanti.yol());
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = update;
            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
               sonuc="Özellik Eklenemedi...!";
            else
               sonuc="Özellik Eklendi";
            conn.Dispose();
        }
        return sonuc;           
        }

        public string ozellikDuzenle(string tabloadi, string sutun,string eskiveri, string ozellik)
        {

            ozellik = ozellik.ToUpper();
            string tb_adi = "TB_ARAC_";
            tb_adi = tb_adi + tabloadi;
            string sonuc;


            if (sutun == "KASA")
            {
                sutun = sutun + "_TIPI";
            }
            else if (sutun == "MODELYILI")
            {
                sutun =  "MODEL_YILI";
            }
            else if (sutun == "MOTOR")
            {
                sutun = sutun + "_HACMI";
            }
            else
            {
                sutun = sutun + "_ADI";
            }

            List<string> cmbListesi = new List<string>();
            DataSet ds = new DataSet();

            string sorgu = "SELECT * FROM TB_ARAC_" + tabloadi + " ";

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
            string update = "UPDATE "+tb_adi+" SET " + sutun + "='" + ozellik + "' WHERE " + sutun + "='"+eskiveri +"'";
            if (cmbListesi.Contains(ozellik))
            {
                sonuc = "Değişiklik Yapılmadı";
            }
            else
            {
                OracleConnection conn = new OracleConnection(baglanti.yol());
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = update;
                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0)
                    sonuc = "Özellik Düzenlenemedi...!";
                else
                    sonuc = "Özellik Düzenlendi";
                
                conn.Dispose();
            }
            return sonuc;
        }

        public string ozellikSil(string tabloadi, string sutun, string eskiveri, string ozellik)
        {

            ozellik = ozellik.ToUpper();
            string tb_adi = "TB_ARAC_";
            tb_adi = tb_adi + tabloadi;
            string sonuc;


            if (sutun == "KASA")
            {
                sutun = sutun + "_TIPI";
            }
            else if (sutun == "MODELYILI")
            {
                sutun = "MODEL_YILI";
            }
            else if (sutun == "MOTOR")
            {
                sutun = sutun + "_HACMI";
            }
            else
            {
                sutun = sutun + "_ADI";
            }
                  
            string update = "DELETE FROM " + tb_adi + " WHERE " + sutun + "='" + ozellik + "'";
           
                OracleConnection conn = new OracleConnection(baglanti.yol());
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = update;
                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0)
                    sonuc = "Özellik Silinemedi...!";
                else
                    sonuc = "Özellik Silindi";
               

                conn.Dispose();
            
            return sonuc;
        }



        public List<string> icerikEkleSutun()
        {
            List<string> ozellikListesi = new List<string>();
            ozellikListesi.Add("MARKA");
            ozellikListesi.Add("MODEL");
            ozellikListesi.Add("MODELYILI");
            ozellikListesi.Add("MOTOR");
            ozellikListesi.Add("RENK");
            ozellikListesi.Add("KASA");
            ozellikListesi.Add("YAKIT");

            return ozellikListesi;
        }

        public List<string> icerikSilSutun()
        {
            List<string> ozellikListesi = new List<string>();
            ozellikListesi.Add("MARKA");
            ozellikListesi.Add("MODEL");
            ozellikListesi.Add("MODELYILI");
            ozellikListesi.Add("MOTOR");
            ozellikListesi.Add("RENK");
            ozellikListesi.Add("KASA");
            ozellikListesi.Add("YAKIT");

            return ozellikListesi;
        }

        public List<string> icerikDuzenleSutun()
        {
            List<string> ozellikListesi = new List<string>();
            ozellikListesi.Add("MARKA");
            ozellikListesi.Add("MODEL");
            ozellikListesi.Add("MODELYILI");
            ozellikListesi.Add("MOTOR");
            ozellikListesi.Add("RENK");
            ozellikListesi.Add("KASA");
            ozellikListesi.Add("YAKIT");

            return ozellikListesi;
        }






    }
}
