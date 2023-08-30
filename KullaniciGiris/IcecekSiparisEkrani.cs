using kafe.core.BusinessLogicLayer;
using kafe.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGiris
{
    public partial class IcecekSiparisEkrani : Form
    {
        SistemServices Bll;

        int masaNosu;
        int toplamHesabim;


        #region parametreler
        int cayArtanFiyat;
        int kupaCayArtanFiyat;
        int cappucinoArtanFiyat;
        int portakalSuyuArtanFiyat;
        int kübaKokteylArtanFiyat;
        int iceChocolateArtanFiyat;
        int hindistanCeviziArtanFiyat;
        int ejderArtanFiyat;
        int limeChocolateArtanFiyat;
        int limePortiArtanFiyat;
        int vanilaArtanFiyat;
        int PurpleJuiceArtanFiyat;
       

        int cayAzalanFiyat;
        int kupaCayAzalanFiyat;
        int cappucinoAzalanFiyat;
        int portakalSuyuAzalanFiyat;
        int kübaKokteylAzalanFiyat;
        int iceChocolateAzalanFiyat;
        int hindistanCeviziAzalanFiyat;
        int ejderAzalanFiyat;
        int limeChocolateAzalanFiyat;
        int limePortiAzalanFiyat;
        int vanilaAzalanFiyat;
        int PurpleJuiceAzalanFiyat;
        #endregion

        public IcecekSiparisEkrani()
        {
            InitializeComponent();
            Bll = new SistemServices();
        }
        public int hesapla(int adet, int fiyat, object sender)
        {
            int toplamHesap = fiyat * adet;
            return toplamHesap;
        }
        private string ürünFiyatAl(string fiyat)
        {
            if (fiyat.Length == 5)   //masa numarası tek haneli ise masa 1
            {
                char deger1 = fiyat[0];
                string ikiHane1 = Convert.ToString(deger1);
                fiyat = ikiHane1;
                return fiyat;

            }

            else if (fiyat.Length == 6)   //masa numarası iki haneli ise masa 17
            {
                char deger1 = fiyat[0];
                string Hane1 = Convert.ToString(deger1);

                char deger2 = fiyat[1];
                string Hane2 = Convert.ToString(deger2);



                fiyat = Hane1 + Hane2;
                return fiyat;
            }
            else if (fiyat.Length == 7)   //masa numarası iki haneli ise masa 17
            {
                char deger1 = fiyat[0];
                string Hane1 = Convert.ToString(deger1);

                char deger2 = fiyat[1];
                string Hane2 = Convert.ToString(deger2);

                char deger3 = fiyat[2];
                string Hane3 = Convert.ToString(deger3);

                //char deger4 = fiyat[3];
                //string Hane4 = Convert.ToString(deger3);

                fiyat = Hane1 + Hane2 + Hane3;
                return fiyat;
            }





            return fiyat;
        }

        #region Gösterge
        public void gösterCay(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatCay.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatCay.Text = Convert.ToString(hesabim);


        }
        public void gösterKupaCay(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatKupaCay.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatKupaCay.Text = Convert.ToString(hesabim);


        }
        public void gösterCappucino(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatCappucino.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatCappucino.Text = Convert.ToString(hesabim);


        }
        public void gösterPortakalSuyu(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatPortakalSuyu.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatPortakalSuyu.Text = Convert.ToString(hesabim);


        }
        public void gösterKübaKokteyl(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatKübaKokteyl.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatKübaKokteyl.Text = Convert.ToString(hesabim);


        }
        public void gösterIceChocolate(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatIceChocolate.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatIceChocolate.Text = Convert.ToString(hesabim);


        }
        public void gösterHindistanCeviz(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatHindistanCeviz.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatHindistanCeviz.Text = Convert.ToString(hesabim);


        }
        public void gösterEjder(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatEjder.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatEjder.Text = Convert.ToString(hesabim);


        }
        public void gösterLimeChocolate(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatLimeChocolate.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatLimeChocolate.Text = Convert.ToString(hesabim);


        }
        public void gösterLimePorti(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatLimePorti.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatLimePorti.Text = Convert.ToString(hesabim);


        }
        public void gösterVanila(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatVanila.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatVanila.Text = Convert.ToString(hesabim);


        }
        public void gösterPurpleJuice(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatPurpleJuice.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatPurpleJuice.Text = Convert.ToString(hesabim);


        }
        #endregion


        #region Değişimler
        private void lbl_artirCay_Click(object sender, EventArgs e)
        {
            int caySayisi = Convert.ToInt32(lbl_adetCay.Text);
            caySayisi++;
            lbl_adetCay.Text = Convert.ToString(caySayisi);

            int cayFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatCay.Text));
            cayArtanFiyat = hesapla(caySayisi, cayFiyat, sender);
            gösterCay(cayArtanFiyat, 0);
        }

        private void lbl_azaltCay_Click(object sender, EventArgs e)
        {
            int caySayisi = Convert.ToInt32(lbl_adetCay.Text);
            caySayisi--;
            lbl_adetCay.Text = Convert.ToString(caySayisi);

            int cayFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatCay.Text));
            cayAzalanFiyat = Convert.ToInt32(lbl_topFiyatCay.Text) - cayFiyat;
            gösterCay(0, cayAzalanFiyat);
        }

        private void lbl_artirKupaCay_Click(object sender, EventArgs e)
        {
            int kupaCaySayisi = Convert.ToInt32(lbl_adetKupaCay.Text);
            kupaCaySayisi++;
            lbl_adetKupaCay.Text = Convert.ToString(kupaCaySayisi);

            int kupacayFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatKupaCay.Text));
            kupaCayArtanFiyat = hesapla(kupaCaySayisi, kupacayFiyat, sender);
            gösterKupaCay(kupaCayArtanFiyat, 0);
        }

        private void lbl_azaltKupaCay_Click(object sender, EventArgs e)
        {
            int kupaCaySayisi = Convert.ToInt32(lbl_adetKupaCay.Text);
            kupaCaySayisi--;
            lbl_adetKupaCay.Text = Convert.ToString(kupaCaySayisi);

            int kupacayFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatKupaCay.Text));
            kupaCayAzalanFiyat = Convert.ToInt32(lbl_topFiyatKupaCay.Text) - kupacayFiyat;
            gösterKupaCay(0, kupaCayAzalanFiyat);
        }

        private void lbl_artirCappucino_Click(object sender, EventArgs e)
        {
            int cappucinoSayisi = Convert.ToInt32(lbl_adetCappucino.Text);
            cappucinoSayisi++;
            lbl_adetCappucino.Text = Convert.ToString(cappucinoSayisi);

            int cappucinoFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatCappucino.Text));
            cappucinoArtanFiyat = hesapla(cappucinoSayisi, cappucinoFiyat, sender);
            gösterCappucino(cappucinoArtanFiyat, 0);
        }

        private void lbl_azaltCapuccino_Click(object sender, EventArgs e)
        {
            int cappucinoSayisi = Convert.ToInt32(lbl_adetCappucino.Text);
            cappucinoSayisi--;
            lbl_adetCappucino.Text = Convert.ToString(cappucinoSayisi);

            int cappucinoFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatCappucino.Text));
            cappucinoAzalanFiyat = Convert.ToInt32(lbl_topFiyatCappucino.Text) - cappucinoFiyat;
            gösterCappucino(0, cappucinoAzalanFiyat);


        }

        private void lbl_artirPortakalSuyu_Click(object sender, EventArgs e)
        {
            int portakalSuSayisi = Convert.ToInt32(lbl_adetPortakalSuyu.Text);
            portakalSuSayisi++;
            lbl_adetPortakalSuyu.Text = Convert.ToString(portakalSuSayisi);

            int portakalSuyuFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatPortakalSuyu.Text));
            portakalSuyuArtanFiyat = hesapla(portakalSuSayisi, portakalSuyuFiyat, sender);
            gösterPortakalSuyu(portakalSuyuArtanFiyat, 0);
        }

        private void lbl_azaltPortakalSuyu_Click(object sender, EventArgs e)
        {
            int portakalSuSayisi = Convert.ToInt32(lbl_adetPortakalSuyu.Text);
            portakalSuSayisi--;
            lbl_adetPortakalSuyu.Text = Convert.ToString(portakalSuSayisi);

            int portakalSuyuFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatPortakalSuyu.Text));
            portakalSuyuAzalanFiyat = Convert.ToInt32(lbl_topFiyatPortakalSuyu.Text) - portakalSuyuFiyat;
            gösterPortakalSuyu(0, portakalSuyuAzalanFiyat);
        }

        private void lbl_artirKübaKokteyl_Click(object sender, EventArgs e)
        {
            
            int kübaKokteylSayisi = Convert.ToInt32(lbl_adetKübaKokteyl.Text);
            kübaKokteylSayisi++;
            lbl_adetKübaKokteyl.Text = Convert.ToString(kübaKokteylSayisi);

            int kübaKokteylFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatKübaKokteyl.Text));
            kübaKokteylArtanFiyat = hesapla(kübaKokteylSayisi, kübaKokteylFiyat, sender);
            gösterKübaKokteyl(kübaKokteylArtanFiyat, 0);
        }

        private void lbl_azaltKübaKokteyl_Click(object sender, EventArgs e)
        {
            int kübaKokteylSayisi = Convert.ToInt32(lbl_adetKübaKokteyl.Text);
            kübaKokteylSayisi--;
            lbl_adetKübaKokteyl.Text = Convert.ToString(kübaKokteylSayisi);

            int kübaKokteylFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatKübaKokteyl.Text));
            kübaKokteylAzalanFiyat = Convert.ToInt32(lbl_topFiyatKübaKokteyl.Text) - kübaKokteylFiyat;
            gösterKübaKokteyl(0, kübaKokteylAzalanFiyat);
        }

        private void lbl_artirIceChocolate_Click(object sender, EventArgs e)
        {
            int adetIceChocolate = Convert.ToInt32(lbl_adetIceChocolate.Text);
            adetIceChocolate++;
            lbl_adetIceChocolate.Text = Convert.ToString(adetIceChocolate);

            int iceChocolateFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatIceChocolate.Text));
            iceChocolateArtanFiyat = hesapla(adetIceChocolate, iceChocolateFiyat, sender);
            gösterIceChocolate(iceChocolateArtanFiyat, 0);
        }

        private void lbl_azaltIceChocolate_Click(object sender, EventArgs e)
        {
            int adetIceChocolate = Convert.ToInt32(lbl_adetIceChocolate.Text);
            adetIceChocolate--;
            lbl_adetIceChocolate.Text = Convert.ToString(adetIceChocolate);

            int iceChocolateFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatIceChocolate.Text));
            iceChocolateAzalanFiyat = Convert.ToInt32(lbl_topFiyatIceChocolate.Text) - iceChocolateFiyat;
            gösterIceChocolate(0, iceChocolateAzalanFiyat);
        }

        private void lbl_artirHindistanCevizi_Click(object sender, EventArgs e)
        {
            int adetHindistanCeviz = Convert.ToInt32(lbl_adetHindistanCeviz.Text);
            adetHindistanCeviz++;
            lbl_adetHindistanCeviz.Text = Convert.ToString(adetHindistanCeviz);

            int hindistanCeviziFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatHindistanSuyu.Text));
            hindistanCeviziArtanFiyat = hesapla(adetHindistanCeviz, hindistanCeviziFiyat, sender);
            gösterHindistanCeviz(hindistanCeviziArtanFiyat, 0);
        }

        private void lbl_azaltHindistanCeviziSuyu_Click(object sender, EventArgs e)
        {
            int adetHindistanCeviz = Convert.ToInt32(lbl_adetHindistanCeviz.Text);
            adetHindistanCeviz--;
            lbl_adetHindistanCeviz.Text = Convert.ToString(adetHindistanCeviz);

            int hindistanCeviziFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatHindistanSuyu.Text));
            hindistanCeviziAzalanFiyat = Convert.ToInt32(lbl_topFiyatHindistanCeviz.Text) - hindistanCeviziFiyat;
            gösterHindistanCeviz(0, hindistanCeviziAzalanFiyat);
        }

        private void lbl_artirEjder_Click(object sender, EventArgs e)
        {
            int adetEjder = Convert.ToInt32(lbl_adetEjder.Text);
            adetEjder++;
            lbl_adetEjder.Text = Convert.ToString(adetEjder);

            int ejderFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatEjder.Text));
            ejderArtanFiyat = hesapla(adetEjder, ejderFiyat, sender);
            gösterEjder(ejderArtanFiyat, 0);
        }

        private void lbl_azaltEjder_Click(object sender, EventArgs e)
        {
            int adetEjder = Convert.ToInt32(lbl_adetEjder.Text);
            adetEjder--;
            lbl_adetEjder.Text = Convert.ToString(adetEjder);

            int ejderFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatEjder.Text));
            ejderAzalanFiyat = Convert.ToInt32(lbl_topFiyatEjder.Text) - ejderFiyat;
            gösterEjder(0, ejderAzalanFiyat);
        }

        private void lbl_artirLimeChocolate_Click(object sender, EventArgs e)
        {
            int adetLimeChocolate = Convert.ToInt32(lbl_adetLimeChocolate.Text);
            adetLimeChocolate++;
            lbl_adetLimeChocolate.Text = Convert.ToString(adetLimeChocolate);

            int limeChocolateFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatLimeChocolate.Text));
            limeChocolateArtanFiyat = hesapla(adetLimeChocolate, limeChocolateFiyat, sender);
            gösterLimeChocolate(limeChocolateArtanFiyat, 0);
        }

        private void lbl_azaltLimeChocolate_Click(object sender, EventArgs e)
        {

            int adetLimeChocolate = Convert.ToInt32(lbl_adetLimeChocolate.Text);
            adetLimeChocolate--;
            lbl_adetLimeChocolate.Text = Convert.ToString(adetLimeChocolate);

            int limeChocolateFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatLimeChocolate.Text));
            limeChocolateAzalanFiyat = Convert.ToInt32(lbl_topFiyatLimeChocolate.Text) - limeChocolateFiyat;
            gösterLimeChocolate(0, limeChocolateAzalanFiyat);
        }

        private void lbl_artirLimePorti_Click(object sender, EventArgs e)
        {
            
            int adetLimePorti = Convert.ToInt32(lbl_adetLimePorti.Text);
            adetLimePorti++;
            lbl_adetLimePorti.Text = Convert.ToString(adetLimePorti);

            int limePortiFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatLimePorti.Text));
            limePortiArtanFiyat = hesapla(adetLimePorti, limePortiFiyat, sender);
            gösterLimePorti(limePortiArtanFiyat, 0);
        }
        private void lbl_azaltLimePorti_Click(object sender, EventArgs e)
        {

            int adetLimePorti = Convert.ToInt32(lbl_adetLimePorti.Text);
            adetLimePorti--;
            lbl_adetLimePorti.Text = Convert.ToString(adetLimePorti);

            int limePortiFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatLimePorti.Text));
            limePortiAzalanFiyat = Convert.ToInt32(lbl_topFiyatLimePorti.Text) - limePortiFiyat;
            gösterLimePorti(0, limePortiAzalanFiyat);
        }

        private void lbl_artirVanila_Click(object sender, EventArgs e)
        {
            int adetVanila = Convert.ToInt32(lbl_adetVanila.Text);
            adetVanila++;
            lbl_adetVanila.Text = Convert.ToString(adetVanila);

            int vanilaFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatVanila.Text));
            vanilaArtanFiyat = hesapla(adetVanila, vanilaFiyat, sender);
            gösterVanila(vanilaArtanFiyat, 0);
        }

        private void lbl_azaltVanila_Click(object sender, EventArgs e)
        {
            int adetVanila = Convert.ToInt32(lbl_adetVanila.Text);
            adetVanila--;
            lbl_adetVanila.Text = Convert.ToString(adetVanila);

            int vanilaFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatVanila.Text));
            vanilaAzalanFiyat = Convert.ToInt32(lbl_topFiyatVanila.Text) - vanilaFiyat;
            gösterVanila(0, vanilaAzalanFiyat);
        }

        private void lbl_artirPurpleJuice_Click(object sender, EventArgs e)
        {
            int adetPurpleJuice = Convert.ToInt32(lbl_adetPurpleJuice.Text);
            adetPurpleJuice++;
            lbl_adetPurpleJuice.Text = Convert.ToString(adetPurpleJuice);

            int purpleJuiceFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatPurpleJuice.Text));
            PurpleJuiceArtanFiyat = hesapla(adetPurpleJuice, purpleJuiceFiyat, sender);
            gösterPurpleJuice(PurpleJuiceArtanFiyat, 0);
        }

        private void lbl_azaltPurpleJuice_Click(object sender, EventArgs e)
        {
            int adetPurpleJuice = Convert.ToInt32(lbl_adetPurpleJuice.Text);
            adetPurpleJuice--;
            lbl_adetPurpleJuice.Text = Convert.ToString(adetPurpleJuice);

            int purpleJuiceFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatPurpleJuice.Text));
            PurpleJuiceAzalanFiyat = Convert.ToInt32(lbl_topFiyatPurpleJuice.Text) - purpleJuiceFiyat;
            gösterPurpleJuice(0, PurpleJuiceAzalanFiyat);
        }

        #endregion

        private void btn_icecekSonraki_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["MüsteriSiparisKayitEkrani"];
            Label lblMasaNo = (Label)frm.Controls["lbl_masaNumarasi"];
            masaNosu = Convert.ToInt32(lblMasaNo.Text);

           toplamHesabim = hesapla();
            #region  içecekler veri ataması
            List<MasadaSiparisBilgileri> masadaIcecekler = new List<MasadaSiparisBilgileri>()
            {
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimCay.Text,siparisAdet=lbl_adetCay.Text,siparisFiyati=lbl_topFiyatCay.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimKupaCay.Text,siparisAdet=lbl_adetKupaCay.Text,siparisFiyati=lbl_topFiyatKupaCay.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimCappucino.Text,siparisAdet=lbl_adetCappucino.Text,siparisFiyati=lbl_topFiyatCappucino.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimPortakalSuyu.Text,siparisAdet=lbl_adetCappucino.Text,siparisFiyati=lbl_topFiyatPortakalSuyu.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimKübaKokteyl.Text,siparisAdet=lbl_adetKübaKokteyl.Text,siparisFiyati=lbl_topFiyatKübaKokteyl.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimIceChocolate.Text,siparisAdet=lbl_adetIceChocolate.Text,siparisFiyati=lbl_topFiyatIceChocolate.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimHindistanCeviz.Text,siparisAdet=lbl_adetHindistanCeviz.Text,siparisFiyati=lbl_topFiyatHindistanCeviz.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimEjder.Text,siparisAdet=lbl_adetEjder.Text,siparisFiyati=lbl_topFiyatEjder.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimLimeChocolate.Text,siparisAdet=lbl_adetLimeChocolate.Text,siparisFiyati=lbl_topFiyatLimeChocolate.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimLimePorti.Text,siparisAdet=lbl_adetLimePorti.Text,siparisFiyati=lbl_topFiyatLimePorti.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimVanila.Text,siparisAdet=lbl_adetVanila.Text,siparisFiyati=lbl_topFiyatVanila.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimPurpleJuice.Text,siparisAdet=lbl_adetPurpleJuice.Text,siparisFiyati=lbl_topFiyatPurpleJuice.Text}

            };

            #endregion

            icecekEkle(masadaIcecekler);
          

            TatliSiparisEkrani tatliSiparisEkrani = new TatliSiparisEkrani();
            tatliSiparisEkrani.Show();
            this.Hide();
        }
        private void icecekEkle(List<MasadaSiparisBilgileri> masadaIcecekler)
        {

            foreach (var item in masadaIcecekler)
            {

                MasadaSiparisBilgileri icecekBilgi = new MasadaSiparisBilgileri();
                icecekBilgi.masaNo = item.masaNo;
                icecekBilgi.toplamFiyat = item.toplamFiyat;
                icecekBilgi.siparisAdi = item.siparisAdi;
                icecekBilgi.siparisAdet = item.siparisAdet;
                icecekBilgi.siparisFiyati = item.siparisFiyati;

                Bll.icecekEkleme(icecekBilgi);


            }


        }

        public int hesapla()
        {
            toplamHesabim = Convert.ToInt32(lbl_topFiyatCay.Text) + Convert.ToInt32(lbl_topFiyatKupaCay.Text) + Convert.ToInt32(lbl_topFiyatCappucino.Text)
                   + Convert.ToInt32(lbl_topFiyatPortakalSuyu.Text) + Convert.ToInt32(lbl_topFiyatKübaKokteyl.Text) + Convert.ToInt32(lbl_topFiyatIceChocolate.Text)
                   + Convert.ToInt32(lbl_topFiyatHindistanCeviz.Text) + Convert.ToInt32(lbl_topFiyatEjder.Text) + Convert.ToInt32(lbl_topFiyatLimeChocolate.Text) +
                   Convert.ToInt32(lbl_topFiyatLimePorti.Text) + Convert.ToInt32(lbl_topFiyatVanila.Text) + Convert.ToInt32(lbl_topFiyatPurpleJuice.Text);
            return toplamHesabim;
        }



        private void btn_icecekOnceki_Click(object sender, EventArgs e)
        {
            YiyecekSiparisEkrani yiyecekSiparisEkran = new YiyecekSiparisEkrani();
            yiyecekSiparisEkran.Show();
            this.Hide();
        }

        private void btn_toplam_Click(object sender, EventArgs e)
        {
           toplamHesabim = Convert.ToInt32(lbl_topFiyatCay.Text) + Convert.ToInt32(lbl_topFiyatKupaCay.Text) + Convert.ToInt32(lbl_topFiyatCappucino.Text)
                  + Convert.ToInt32(lbl_topFiyatPortakalSuyu.Text) + Convert.ToInt32(lbl_topFiyatKübaKokteyl.Text) + Convert.ToInt32(lbl_topFiyatIceChocolate.Text)
                  + Convert.ToInt32(lbl_topFiyatHindistanCeviz.Text) + Convert.ToInt32(lbl_topFiyatEjder.Text) + Convert.ToInt32(lbl_topFiyatLimeChocolate.Text) +
                  Convert.ToInt32(lbl_topFiyatLimePorti.Text) + Convert.ToInt32(lbl_topFiyatVanila.Text) + Convert.ToInt32(lbl_topFiyatPurpleJuice.Text);
            lbl_hesapIcecekTutarim.Text = Convert.ToString(toplamHesabim);
        }
    }
}
