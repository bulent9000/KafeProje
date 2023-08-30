using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kafe.core.Entities;
using System.ComponentModel;

namespace kafe.core.BusinessLogicLayer
{
    public class SistemServices
    {
        DatabaseLogicLayer.DatabaseKontrol Dll;
        public SqlCommand cmd;
        public SqlDataReader reader;
        public int returnValue;
        public object obj;
        public List<MasadaSiparisBilgileri> yiyecekListem;
        public List<MasadaSiparisBilgileri> icecekListem;
        public List<MasadaSiparisBilgileri> tatliListem;

        public SistemServices()
        {
            Dll = new DatabaseLogicLayer.DatabaseKontrol();
        }

        public int kullaniciKontrol(string kullaniciAdi, string sifre)
        {


            cmd = new SqlCommand("select yetkiliId from YetkiliGirisi where kullaniciAdi=@kullaniciAdi and sifre=@sifre");
            cmd.Parameters.Add("@kullaniciAdi", SqlDbType.NVarChar).Value = kullaniciAdi;
            cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = sifre;
            obj = Dll.kolonGetir(cmd);
            return obj == null ? 0 : (int)obj;



        }

     
        
        
        
        #region Db ye Yiyecek ekleme  listeleme     
        public void ekleYiyecekler(MasadaSiparisBilgileri yiyecekListesi)
        {
            Dll = new DatabaseLogicLayer.DatabaseKontrol();
            cmd = new SqlCommand("insert into yiyecekKayit(masaNo,toplamTutar,siparisAdi,siparisAdet,siparisFiyati) values(@masaNo,@toplamTutar,@siparisAdi,@siparisAdet,@siparisFiyati)");
           
            cmd.Parameters.Add("@masaNo",SqlDbType.Int).Value = yiyecekListesi.masaNo;
            cmd.Parameters.Add("@toplamTutar", SqlDbType.Int).Value = yiyecekListesi.toplamFiyat;
            cmd.Parameters.Add("@siparisAdi", SqlDbType.NVarChar).Value = yiyecekListesi.siparisAdi;
            cmd.Parameters.Add("@siparisAdet", SqlDbType.NVarChar).Value = yiyecekListesi.siparisAdet;
            cmd.Parameters.Add("@siparisFiyati", SqlDbType.NVarChar).Value = yiyecekListesi.siparisFiyati;
                
            Dll.yiyecekEkleme(cmd);


        }
        public List<MasadaSiparisBilgileri> yiyecekListe()
        {
            yiyecekListem  = new List<MasadaSiparisBilgileri>();
            cmd = new SqlCommand("select * from yiyecekKayit where siparisAdet!='0'");
            SqlDataReader reader = Dll.yiyecekListele(cmd);

            while (reader.Read())
            {
                yiyecekListem.Add(new MasadaSiparisBilgileri()
                {
                    masaNo=reader.IsDBNull(0)? 0:reader.GetInt32(0),
                    toplamFiyat= reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                    siparisAdi =reader.IsDBNull(2)? string.Empty: reader.GetString(2),
                    siparisAdet= reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    siparisFiyati=reader.IsDBNull(4) ? string.Empty : reader.GetString(4)            

                });


            }

            reader.Close();
            Dll.baglantiayarla();
            return yiyecekListem;




        }

        #endregion

        #region Db ye İçecek ekleme  listeleme   
   
        public void icecekEkleme(MasadaSiparisBilgileri icecekListesi)
        {
            Dll = new DatabaseLogicLayer.DatabaseKontrol();
            cmd = new SqlCommand("insert into icecekKayit(masaNo,toplamTutar,siparisAdi,siparisAdet,siparisFiyati) values(@masaNo,@toplamTutar,@siparisAdi,@siparisAdet,@siparisFiyati)");

            cmd.Parameters.Add("@masaNo", SqlDbType.Int).Value = icecekListesi.masaNo;
            cmd.Parameters.Add("@toplamTutar", SqlDbType.Int).Value = icecekListesi.toplamFiyat;
            cmd.Parameters.Add("@siparisAdi", SqlDbType.NVarChar).Value = icecekListesi.siparisAdi;
            cmd.Parameters.Add("@siparisAdet", SqlDbType.NVarChar).Value = icecekListesi.siparisAdet;
            cmd.Parameters.Add("@siparisFiyati", SqlDbType.NVarChar).Value = icecekListesi.siparisFiyati;

            Dll.icecekEkleme(cmd);


        }
        public List<MasadaSiparisBilgileri> icecekListele()
        {
            icecekListem = new List<MasadaSiparisBilgileri>();
            cmd = new SqlCommand("select * from icecekKayit where siparisAdet!='0'");
            SqlDataReader reader = Dll.icecekListele(cmd);

            while (reader.Read())
            {
                icecekListem.Add(new MasadaSiparisBilgileri()
                {
                    masaNo = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    toplamFiyat = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                    siparisAdi = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    siparisAdet = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    siparisFiyati = reader.IsDBNull(4) ? string.Empty : reader.GetString(4)

                });


            }

            reader.Close();
            Dll.baglantiayarla();
            return icecekListem;




        }

        #endregion

        #region Db ye Tatlı ekleme  listeleme     
        public void tatliEkleme(MasadaSiparisBilgileri tatliListesi)
        {
            Dll = new DatabaseLogicLayer.DatabaseKontrol();
            cmd = new SqlCommand("insert into tatliKayit(masaNo,toplamTutar,siparisAdi,siparisAdet,siparisFiyati) values(@masaNo,@toplamTutar,@siparisAdi,@siparisAdet,@siparisFiyati)");

            cmd.Parameters.Add("@masaNo", SqlDbType.Int).Value = tatliListesi.masaNo;
            cmd.Parameters.Add("@toplamTutar", SqlDbType.Int).Value = tatliListesi.toplamFiyat;
            cmd.Parameters.Add("@siparisAdi", SqlDbType.NVarChar).Value = tatliListesi.siparisAdi;
            cmd.Parameters.Add("@siparisAdet", SqlDbType.NVarChar).Value = tatliListesi.siparisAdet;
            cmd.Parameters.Add("@siparisFiyati", SqlDbType.NVarChar).Value = tatliListesi.siparisFiyati;

        
            Dll.tatliEkleme(cmd);


        }
        public List<MasadaSiparisBilgileri> tatliListele()
        {
            tatliListem = new List<MasadaSiparisBilgileri>();
            cmd = new SqlCommand("select * from tatliKayit where siparisAdet!='0'");
            SqlDataReader reader = Dll.tatliListele(cmd);

            while (reader.Read())
            {
                tatliListem.Add(new MasadaSiparisBilgileri()
                {
                    masaNo = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    toplamFiyat = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                    siparisAdi = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    siparisAdet = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    siparisFiyati = reader.IsDBNull(4) ? string.Empty : reader.GetString(4)

                });


            }

            reader.Close();
            Dll.baglantiayarla();
            return tatliListem;




        }


        #endregion

    }
}
