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
    public partial class OnlineYiyecekSiparisEkrani : Form
    {
      


        int toplamHesabim;
        #region parametreler
        int pideArtanFiyat;
        int pideAzalanFiyat;
        int adanaKebapArtanFiyat;
        int adanaKebapAzalanFiyat;
        int dönerArtanFiyat;
        int hotDogArtanFiyat;
        int dürümArtanFiyat;
        int pizzaArtanFiyat;
        int specialSpagettiArtanFiyat;
        int salataArtanFiyat;
        int simitArtanFiyat;
        int kahvaltilikArtanFiyat;
        int sushiArtanFiyat;
        int spagettiArtanFiyat;

        int dönerAzalanFiyat;
        int hotDogAzalanFiyat;
        int dürümAzalanFiyat;
        int pizzaAzalanFiyat;
        int specialSpagettiAzalanFiyat;
        int salataAzalanFiyat;
        int simitAzalanFiyat;
        int kahvaltilikAzalanFiyat;
        int sushiAzalanFiyat;
        int spagettiAzalanFiyat;

        #endregion
        public OnlineYiyecekSiparisEkrani()
        {
            InitializeComponent();
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
        public void gösterPide(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatPide.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatPide.Text = Convert.ToString(hesabim);


        }
        public void gösterAdanaKebap(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatAdanaKebap.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatAdanaKebap.Text = Convert.ToString(hesabim);


        }
        public void gösterDöner(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatDöner.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatDöner.Text = Convert.ToString(hesabim);


        }
        public void gösterHotdog(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatHotdog.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatHotdog.Text = Convert.ToString(hesabim);


        }
        public void gösterDürüm(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatDürüm.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatDürüm.Text = Convert.ToString(hesabim);


        }
        public void gösterPizza(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatPizza.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatPizza.Text = Convert.ToString(hesabim);


        }
        public void gösterSpecialSpagetti(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatSpecialSpagetti.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatSpecialSpagetti.Text = Convert.ToString(hesabim);


        }
        public void gösterSalata(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatSalata.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatSalata.Text = Convert.ToString(hesabim);


        }
        public void gösterSimit(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatSimit.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatSimit.Text = Convert.ToString(hesabim);


        }
        public void gösterKahvaltilik(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatKahvaltilik.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatKahvaltilik.Text = Convert.ToString(hesabim);


        }
        public void gösterSushi(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatSushi.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatSushi.Text = Convert.ToString(hesabim);


        }
        public void gösterSpagetti(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatSpagetti.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatSpagetti.Text = Convert.ToString(hesabim);


        }
        #endregion

        #region değişim
        private void lbl_artirPide_Click(object sender, EventArgs e)
        {
            int pideSayisi = Convert.ToInt32(lbl_adetPide.Text);   //ÇALIŞIYOR HEPSİNİ BU ŞEKİLDE YAP
            pideSayisi++;
            lbl_adetPide.Text = Convert.ToString(pideSayisi);

            int pideFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatPide.Text));
            pideArtanFiyat = hesapla(pideSayisi, pideFiyat, sender);
            gösterPide(pideArtanFiyat, 0);


        }

        private void lbl_artirAdanaKebap_Click(object sender, EventArgs e)
        {
            int adanaSayisi = Convert.ToInt32(lbl_adetAdanaKebap.Text);
            adanaSayisi++;
            lbl_adetAdanaKebap.Text = Convert.ToString(adanaSayisi);

            int fiyatAdanaKebap = Convert.ToInt32(ürünFiyatAl(lbl_fiyatAdanaKebap.Text));
            adanaKebapArtanFiyat = hesapla(adanaSayisi, fiyatAdanaKebap, sender);
            gösterAdanaKebap(adanaKebapArtanFiyat, 0);
        }

        private void lbl_artirDöner_Click(object sender, EventArgs e)
        {
            int dönerSayisi = Convert.ToInt32(lbl_adetDöner.Text);
            dönerSayisi++;
            lbl_adetDöner.Text = Convert.ToString(dönerSayisi);


            int dönerFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatDöner.Text));
            dönerArtanFiyat = hesapla(dönerSayisi, dönerFiyat, sender);
            gösterDöner(dönerArtanFiyat, 0);
        }

        private void lbl_artirHotdog_Click(object sender, EventArgs e)
        {
            int hotdogSayisi = Convert.ToInt32(lbl_adetHotdog.Text);
            hotdogSayisi++;
            lbl_adetHotdog.Text = Convert.ToString(hotdogSayisi);

            int hotDogFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatHotdog.Text));
            hotDogArtanFiyat = hesapla(hotdogSayisi, hotDogFiyat, sender);
            gösterHotdog(hotDogArtanFiyat, 0);
        }

        private void lbl_artirDürüm_Click(object sender, EventArgs e)
        {
            int dürümSayisi = Convert.ToInt32(lbl_adetDürüm.Text);
            dürümSayisi++;
            lbl_adetDürüm.Text = Convert.ToString(dürümSayisi);

            int dürümFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatDürüm.Text));
            dürümArtanFiyat = hesapla(dürümSayisi, dürümFiyat, sender);
            gösterDürüm(dürümArtanFiyat, 0);
        }

        private void lbl_artirPizza_Click(object sender, EventArgs e)
        {
            int pizzaSayisi = Convert.ToInt32(lbl_adetPizza.Text);
            pizzaSayisi++;
            lbl_adetPizza.Text = Convert.ToString(pizzaSayisi);

            int pizzaFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatPizza.Text));
            pizzaArtanFiyat = hesapla(pizzaSayisi, pizzaFiyat, sender);
            gösterPizza(pizzaArtanFiyat, 0);
        }

        private void lbl_artirSpecialSpagetti_Click(object sender, EventArgs e)
        {
            int specialSpagettiSayisi = Convert.ToInt32(lbl_adetSpecialSpagetti.Text);
            specialSpagettiSayisi++;
            lbl_adetSpecialSpagetti.Text = Convert.ToString(specialSpagettiSayisi);

            int specialSpagettiFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatSpecialSpagetti.Text));
            specialSpagettiArtanFiyat = hesapla(specialSpagettiSayisi, specialSpagettiFiyat, sender);
            gösterSpecialSpagetti(specialSpagettiArtanFiyat, 0);
        }

        private void lbl_artirSalata_Click(object sender, EventArgs e)
        {
            int salataSayisi = Convert.ToInt32(lbl_adetSalata.Text);
            salataSayisi++;
            lbl_adetSalata.Text = Convert.ToString(salataSayisi);

            int salataFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatSalata.Text));
            salataArtanFiyat = hesapla(salataSayisi, salataFiyat, sender);
            gösterSalata(salataArtanFiyat, 0);
        }

        private void lbl_artirSimit_Click(object sender, EventArgs e)
        {
            int simitSayisi = Convert.ToInt32(lbl_adetSimit.Text);
            simitSayisi++;
            lbl_adetSimit.Text = Convert.ToString(simitSayisi);

            int simitFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatSimit.Text));
            simitArtanFiyat = hesapla(simitSayisi, simitFiyat, sender);
            gösterSimit(simitArtanFiyat, 0);
        }

        private void lbl_artirKahvaltilik_Click(object sender, EventArgs e)
        {
            int kahvaltilikSayisi = Convert.ToInt32(lbl_adetKahvaltilik.Text);
            kahvaltilikSayisi++;
            lbl_adetKahvaltilik.Text = Convert.ToString(kahvaltilikSayisi);

            int kahvaltilikFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatKahvaltilik.Text));
            kahvaltilikArtanFiyat = hesapla(kahvaltilikSayisi, kahvaltilikFiyat, sender);
            gösterKahvaltilik(kahvaltilikArtanFiyat, 0);
        }

        private void lbl_artirSushi_Click(object sender, EventArgs e)
        {
            int sushiSayisi = Convert.ToInt32(lbl_adetSushi.Text);
            sushiSayisi++;
            lbl_adetSushi.Text = Convert.ToString(sushiSayisi);

            int sushiFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatSushi.Text));
            sushiArtanFiyat = hesapla(sushiSayisi, sushiFiyat, sender);
            gösterSushi(sushiArtanFiyat, 0);
        }

        private void lbl_artirSpagetti_Click(object sender, EventArgs e)
        {
            int spagettiSayisi = Convert.ToInt32(lbl_adetSpagetti.Text);
            spagettiSayisi++;
            lbl_adetSpagetti.Text = Convert.ToString(spagettiSayisi);

            int spagettiFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatSpagetti.Text));
            spagettiArtanFiyat = hesapla(spagettiSayisi, spagettiFiyat, sender);
            gösterSpagetti(spagettiArtanFiyat, 0);
        }

        private void lbl_azaltPide_Click(object sender, EventArgs e)
        {
            int pideSayisi = Convert.ToInt32(lbl_adetPide.Text);
            pideSayisi--;
            lbl_adetPide.Text = Convert.ToString(pideSayisi);

            int pideFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatPide.Text));
            pideAzalanFiyat = Convert.ToInt32(lbl_topFiyatPide.Text) - pideFiyat;
            gösterPide(0, pideAzalanFiyat);
        }

        private void lbl_azaltAdanaKebap_Click(object sender, EventArgs e)
        {
            int adanaSayisi = Convert.ToInt32(lbl_adetAdanaKebap.Text);
            adanaSayisi--;
            lbl_adetAdanaKebap.Text = Convert.ToString(adanaSayisi);

            int adanaKebapFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatAdanaKebap.Text));
            adanaKebapAzalanFiyat = Convert.ToInt32(lbl_topFiyatAdanaKebap.Text) - adanaKebapFiyat;
            gösterAdanaKebap(0, adanaKebapAzalanFiyat);
        }

        private void lbl_azaltDöner_Click(object sender, EventArgs e)
        {
            int dönerSayisi = Convert.ToInt32(lbl_adetDöner.Text);
            dönerSayisi--;
            lbl_adetDöner.Text = Convert.ToString(dönerSayisi);

            int dönerFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatDöner.Text));
            dönerAzalanFiyat = Convert.ToInt32(lbl_topFiyatDöner.Text) - dönerFiyat;
            gösterDöner(0, dönerAzalanFiyat);
        }

        private void lbl_azaltHotdog_Click(object sender, EventArgs e)
        {
            int hotdogSayisi = Convert.ToInt32(lbl_adetHotdog.Text);
            hotdogSayisi--;
            lbl_adetHotdog.Text = Convert.ToString(hotdogSayisi);

            int hotDogFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatHotdog.Text));
            hotDogAzalanFiyat = Convert.ToInt32(lbl_topFiyatHotdog.Text) - hotDogFiyat;
            gösterHotdog(0, hotDogAzalanFiyat);
        }

        private void lbl_azaltDürüm_Click(object sender, EventArgs e)
        {
            int dürümSayisi = Convert.ToInt32(lbl_adetDürüm.Text);
            dürümSayisi--;
            lbl_adetDürüm.Text = Convert.ToString(dürümSayisi);

            int dürümFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatDürüm.Text));
            dürümAzalanFiyat = Convert.ToInt32(lbl_topFiyatDürüm.Text) - dürümFiyat;
            gösterDürüm(0, dürümAzalanFiyat);
        }

        private void lbl_azaltPizza_Click(object sender, EventArgs e)
        {
            int pizzaSayisi = Convert.ToInt32(lbl_adetPizza.Text);
            pizzaSayisi--;
            lbl_adetPizza.Text = Convert.ToString(pizzaSayisi);

            int pizzaFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatPizza.Text));
            pizzaAzalanFiyat = Convert.ToInt32(lbl_topFiyatPizza.Text) - pizzaFiyat;
            gösterPizza(0, pizzaAzalanFiyat);
        }

        private void lbl_azaltSpecialSpagetti_Click(object sender, EventArgs e)
        {
            int specialSpagettiSayisi = Convert.ToInt32(lbl_adetSpecialSpagetti.Text);
            specialSpagettiSayisi--;
            lbl_adetSpecialSpagetti.Text = Convert.ToString(specialSpagettiSayisi);

            int specialSpagettiFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatSpecialSpagetti.Text));
            specialSpagettiAzalanFiyat = Convert.ToInt32(lbl_topFiyatSpecialSpagetti.Text) - specialSpagettiFiyat;
            gösterSpecialSpagetti(0, specialSpagettiAzalanFiyat);
        }

        private void lbl_azaltSalata_Click(object sender, EventArgs e)
        {
            int salataSayisi = Convert.ToInt32(lbl_adetSalata.Text);
            salataSayisi--;
            lbl_adetSalata.Text = Convert.ToString(salataSayisi);

            int salataFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatSalata.Text));
            salataAzalanFiyat = Convert.ToInt32(lbl_topFiyatSalata.Text) - salataFiyat;
            gösterSalata(0, salataAzalanFiyat);
        }

        private void lbl_azaltSimit_Click(object sender, EventArgs e)
        {
            int simitSayisi = Convert.ToInt32(lbl_adetSimit.Text);
            simitSayisi--;
            lbl_adetSimit.Text = Convert.ToString(simitSayisi);

            int simitFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatSimit.Text));
            simitAzalanFiyat = Convert.ToInt32(lbl_topFiyatSimit.Text) - simitFiyat;
            gösterSimit(0, simitAzalanFiyat);
        }

        private void lbl_azaltKahvaltilik_Click(object sender, EventArgs e)
        {
            int kahvaltilikSayisi = Convert.ToInt32(lbl_adetKahvaltilik.Text);
            kahvaltilikSayisi--;
            lbl_adetKahvaltilik.Text = Convert.ToString(kahvaltilikSayisi);

            int kahvaltilikFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatKahvaltilik.Text));
            kahvaltilikAzalanFiyat = Convert.ToInt32(lbl_topFiyatKahvaltilik.Text) - kahvaltilikFiyat;
            gösterKahvaltilik(0, kahvaltilikAzalanFiyat);
        }

        private void lbl_azaltSushi_Click(object sender, EventArgs e)
        {
            int sushiSayisi = Convert.ToInt32(lbl_adetSushi.Text);
            sushiSayisi--;
            lbl_adetSushi.Text = Convert.ToString(sushiSayisi);

            int sushiFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatSushi.Text));
            sushiAzalanFiyat = Convert.ToInt32(lbl_topFiyatSushi.Text) - sushiFiyat;
            gösterSushi(0, sushiAzalanFiyat);
        }

        private void lbl_azaltSpagetti_Click(object sender, EventArgs e)
        {
            int spagettiSayisi = Convert.ToInt32(lbl_adetSpagetti.Text);
            spagettiSayisi--;
            lbl_adetSpagetti.Text = Convert.ToString(spagettiSayisi);

            int spagettiFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatSpagetti.Text));
            spagettiAzalanFiyat = Convert.ToInt32(lbl_topFiyatSpagetti.Text) - spagettiFiyat;
            gösterSpagetti(0, spagettiAzalanFiyat);
        }
        #endregion
        private void btn_toplam_Click(object sender, EventArgs e)
        {
            toplamHesabim=hesapla();
            lbl_hesapTutarim.Text = Convert.ToString(toplamHesabim);
        }
        private void btn_yemekOnceki_Click(object sender, EventArgs e)
        {
            OnlineSiparisMüsteriKayitEkrani oMüsteriKayit = new OnlineSiparisMüsteriKayitEkrani();
            oMüsteriKayit.Show();

        }
        private void btn_yemekSonraki_Click(object sender, EventArgs e)
        {
            toplamHesabim=hesapla();
            OnlineHesapEkrani onlineSiparisim = new OnlineHesapEkrani();

            onlineSiparisim.tutarDöndür(toplamHesabim); //Bu sayfadaki toplam sipariş fiyatı ödeme ekranına yollandı.

            //Bu sayfada siparişler ve müşteri bilgileri DB ye gönderilecek

            #region değer gönderme

            if (!string.IsNullOrEmpty(lbl_adetPide.Text))
            {
                onlineSiparisim.pide(lbl_pide.Text,lbl_adetPide.Text,lbl_topFiyatPide.Text);

            }

            if (!string.IsNullOrEmpty(lbl_adetAdanaKebap.Text))
            {

                onlineSiparisim.adanaKebap(lbl_adanaKebap.Text, lbl_adetAdanaKebap.Text, lbl_topFiyatAdanaKebap.Text);

            }

            if (!string.IsNullOrEmpty(lbl_adetDöner.Text))
            {
                onlineSiparisim.döner(lbl_Döner.Text, lbl_adetDöner.Text, lbl_topFiyatDöner.Text);

            }

            if (!string.IsNullOrEmpty(lbl_adetHotdog.Text))
            {

                onlineSiparisim.hotDog(lbl_hotdog.Text, lbl_adetHotdog.Text, lbl_topFiyatHotdog.Text);

            }
            if (!string.IsNullOrEmpty(lbl_adetDürüm.Text))
            {
                onlineSiparisim.dürüm(lbl_Dürüm.Text, lbl_adetDürüm.Text, lbl_topFiyatDürüm.Text);

            }

            if (!string.IsNullOrEmpty(lbl_adetPizza.Text))
            {

                onlineSiparisim.pizza(lbl_pizza.Text, lbl_adetPizza.Text, lbl_topFiyatPizza.Text);

            }
            if (!string.IsNullOrEmpty(lbl_adetSpecialSpagetti.Text))
            {
                onlineSiparisim.specialSpagetti(lbl_specialSpagetti.Text, lbl_adetSpecialSpagetti.Text, lbl_topFiyatSpagetti.Text);

            }

            if (!string.IsNullOrEmpty(lbl_adetSalata.Text))
            {

                onlineSiparisim.salata(lbl_salata.Text, lbl_adetSalata.Text, lbl_topFiyatSalata.Text);

            }
            if (!string.IsNullOrEmpty(lbl_adetSimit.Text))
            {
                onlineSiparisim.simit(lbl_simit.Text, lbl_adetSimit.Text, lbl_topFiyatSimit.Text);

            }

            if (!string.IsNullOrEmpty(lbl_adetKahvaltilik.Text))
            {

                onlineSiparisim.kahvaltilik(lbl_kahvaltilik.Text, lbl_adetKahvaltilik.Text, lbl_topFiyatKahvaltilik.Text);

            }
            if (!string.IsNullOrEmpty(lbl_adetSushi.Text))
            {
                onlineSiparisim.sushi(lbl_sushi.Text, lbl_adetSushi.Text, lbl_topFiyatSushi.Text);

            }

            if (!string.IsNullOrEmpty(lbl_adetSpagetti.Text))
            {

                onlineSiparisim.spagetti(lbl_adetSpagetti.Text, lbl_adetSpagetti.Text, lbl_topFiyatSpagetti.Text);

            }


            #endregion


            onlineSiparisim.Show();
        }

        public int hesapla()
        {
            toplamHesabim = Convert.ToInt32(lbl_topFiyatPide.Text) + Convert.ToInt32(lbl_topFiyatAdanaKebap.Text) + Convert.ToInt32(lbl_topFiyatDöner.Text)
                   + Convert.ToInt32(lbl_topFiyatHotdog.Text) + Convert.ToInt32(lbl_topFiyatDürüm.Text) + Convert.ToInt32(lbl_topFiyatPizza.Text)
                   + Convert.ToInt32(lbl_topFiyatSpecialSpagetti.Text) + Convert.ToInt32(lbl_topFiyatSalata.Text) + Convert.ToInt32(lbl_topFiyatSimit.Text) +
                   Convert.ToInt32(lbl_topFiyatKahvaltilik.Text) + Convert.ToInt32(lbl_topFiyatSushi.Text) + Convert.ToInt32(lbl_topFiyatSpagetti.Text);
            return toplamHesabim;
        }




        //public void siparisBilgisiKayit()
        //{

        //    if (!string.IsNullOrEmpty(lbl_adetPide.Text))
        //    {
        //        adetPidem = Convert.ToInt32(lbl_adetPide.Text);

        //    }
        //    else
        //    {
        //        adetPidem = 0;
        //    }





        //    Form ekran = (Form)Application.OpenForms["OnlineSiparisMüsteriKayitEkrani"];
        //    GroupBox grpOMüsteriBilgi = (GroupBox)ekran.Controls["grp_onlineMüsteriBilgi"];

            

        //    List<OnlineSiparisMüsteriBilgileri> siparisMüsteriBilgileri = new List<OnlineSiparisMüsteriBilgileri>()
        //    {
        //        new OnlineSiparisMüsteriBilgileri()
        //        {
        //            tcKimlikNo=((TextBox)grpOMüsteriBilgi.Controls["txt_tcKimlikNo"]).Text,
        //            müsteriAdi=((TextBox)grpOMüsteriBilgi.Controls["txt_müsteriAdi"]).Text,
        //            soyadi=((TextBox)grpOMüsteriBilgi.Controls["txt_müsteriSoyadi"]).Text,
        //            telefon=((TextBox)grpOMüsteriBilgi.Controls["txt_telefon"]).Text,
        //            siparisTarihi=Convert.ToDateTime((DateTimePicker)grpOMüsteriBilgi.Controls["dtp_siparisTarihi"]),
        //            mahalle=((ComboBox)grpOMüsteriBilgi.Controls["cmb_mahalle"]).Text,
        //            sokak=((ComboBox)grpOMüsteriBilgi.Controls["cmb_sokak"]).Text,
        //            icKapiNo=((ComboBox)grpOMüsteriBilgi.Controls["cmb_icKapiNo"]).Text,
        //            ilce=((ComboBox)grpOMüsteriBilgi.Controls["cmb_ilce"]).Text,
        //            il= ((ComboBox)grpOMüsteriBilgi.Controls["cmb_il"]).Text
        //        }

        //    };
        //    List<OnlineSiparisBilgileri> onlineSiparisBilgileri = new List<OnlineSiparisBilgileri>()
        //    {
                

        // new OnlineSiparisBilgileri (){ siparisAdi = lbl_pide.Text,siparisAdet = adetPidem, siparisFiyati = Convert.ToInt32(lbl_topFiyatPide.Text)},
        // new OnlineSiparisBilgileri (){ siparisAdi = lbl_pide.Text,siparisAdet = adetPidem, siparisFiyati = Convert.ToInt32(lbl_topFiyatPide.Text)},
        // new OnlineSiparisBilgileri (){ siparisAdi = lbl_pide.Text,siparisAdet = adetPidem, siparisFiyati = Convert.ToInt32(lbl_topFiyatPide.Text)},
        // new OnlineSiparisBilgileri (){ siparisAdi = lbl_pide.Text,siparisAdet = adetPidem, siparisFiyati = Convert.ToInt32(lbl_topFiyatPide.Text)},
        // new OnlineSiparisBilgileri (){ siparisAdi = lbl_pide.Text,siparisAdet = adetPidem, siparisFiyati = Convert.ToInt32(lbl_topFiyatPide.Text)},
        // new OnlineSiparisBilgileri (){ siparisAdi = lbl_pide.Text,siparisAdet = adetPidem, siparisFiyati = Convert.ToInt32(lbl_topFiyatPide.Text)},
        // new OnlineSiparisBilgileri (){ siparisAdi = lbl_pide.Text,siparisAdet = adetPidem, siparisFiyati = Convert.ToInt32(lbl_topFiyatPide.Text)},
        // new OnlineSiparisBilgileri (){ siparisAdi = lbl_pide.Text,siparisAdet = adetPidem, siparisFiyati = Convert.ToInt32(lbl_topFiyatPide.Text)},
        // new OnlineSiparisBilgileri (){ siparisAdi = lbl_pide.Text,siparisAdet = adetPidem, siparisFiyati = Convert.ToInt32(lbl_topFiyatPide.Text)},
        // new OnlineSiparisBilgileri (){ siparisAdi = lbl_pide.Text,siparisAdet = adetPidem, siparisFiyati = Convert.ToInt32(lbl_topFiyatPide.Text)},
        // new OnlineSiparisBilgileri (){ siparisAdi = lbl_pide.Text,siparisAdet = adetPidem, siparisFiyati = Convert.ToInt32(lbl_topFiyatPide.Text)},
        // new OnlineSiparisBilgileri (){ siparisAdi = lbl_pide.Text,siparisAdet = adetPidem, siparisFiyati = Convert.ToInt32(lbl_topFiyatPide.Text)},


        //    };

           

        //}
        
        
     }
           
           

}






