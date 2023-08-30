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
    public partial class YiyecekSiparisEkrani : Form
    {
        SistemServices Bll;

        

        int toplamHesabim;
        int masaNosu;

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

        public YiyecekSiparisEkrani()
        {
            InitializeComponent();
            Bll = new SistemServices();
            
        }

        private void btn_yemekOnceki_Click(object sender, EventArgs e)
        {
            YetkiliAnaForm yetkiliAnaform = new YetkiliAnaForm();
            yetkiliAnaform.Show();
            this.Hide();

        }

        public int hesapla(int adet,int fiyat,object sender)
        {          
           int toplamHesap = fiyat * adet;       
            return toplamHesap;
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

        #region Adet Değişim
        private void lbl_artirPide_Click(object sender, EventArgs e)
        {
            
            int pideSayisi = Convert.ToInt32(lbl_adetPide.Text);   //ÇALIŞIYOR HEPSİNİ BU ŞEKİLDE YAP
            pideSayisi++;
            lbl_adetPide.Text = Convert.ToString(pideSayisi);              
           
            int pideFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatPide.Text));
            pideArtanFiyat=hesapla(pideSayisi,pideFiyat,sender);
            gösterPide(pideArtanFiyat,0);

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
       


        #region Degerler

        private void lbl_artirAdanaKebap_Click(object sender, EventArgs e)
        {

            int adanaSayisi = Convert.ToInt32(lbl_adetAdanaKebap.Text);
            adanaSayisi++;
            lbl_adetAdanaKebap.Text = Convert.ToString(adanaSayisi);
           
            int fiyatAdanaKebap = Convert.ToInt32(ürünFiyatAl(lbl_fiyatAdanaKebap.Text));
            adanaKebapArtanFiyat = hesapla(adanaSayisi,fiyatAdanaKebap,sender);
            gösterAdanaKebap(adanaKebapArtanFiyat,0);
           
            
        }

        private void lbl_azaltAdanaKebap_Click(object sender, EventArgs e)
        {
            int adanaSayisi = Convert.ToInt32(lbl_adetAdanaKebap.Text);
            adanaSayisi--;
            lbl_adetAdanaKebap.Text = Convert.ToString(adanaSayisi);

            int adanaKebapFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatAdanaKebap.Text));
            adanaKebapAzalanFiyat= Convert.ToInt32(lbl_topFiyatAdanaKebap.Text) - adanaKebapFiyat;
            gösterAdanaKebap(0,adanaKebapAzalanFiyat);

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

        private void lbl_azaltDöner_Click(object sender, EventArgs e)
        {
            int dönerSayisi = Convert.ToInt32(lbl_adetDöner.Text);
            dönerSayisi--;
            lbl_adetDöner.Text = Convert.ToString(dönerSayisi);

            int dönerFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatDöner.Text));
            dönerAzalanFiyat = Convert.ToInt32(lbl_topFiyatDöner.Text) - dönerFiyat;
            gösterDöner(0, dönerAzalanFiyat);
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

        private void lbl_azaltHotdog_Click(object sender, EventArgs e)
        {
            int hotdogSayisi = Convert.ToInt32(lbl_adetHotdog.Text);
            hotdogSayisi--;
            lbl_adetHotdog.Text = Convert.ToString(hotdogSayisi);

            int hotDogFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatHotdog.Text));
            hotDogAzalanFiyat = Convert.ToInt32(lbl_topFiyatHotdog.Text) - hotDogFiyat;
            gösterHotdog(0, hotDogAzalanFiyat);
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

        #endregion


        private void btn_yemekSonraki_Click(object sender, EventArgs e)
        {

            Form frm = (Form)Application.OpenForms["MüsteriSiparisKayitEkrani"];
            Label lblMasaNo=(Label)frm.Controls["lbl_masaNumarasi"];
            masaNosu = Convert.ToInt32(lblMasaNo.Text);


            //MasadaSiparisBilgileri
            toplamHesabim = hesapla();  //sql e yollanacak

            #region yiyecekler veri ataması
            List<MasadaSiparisBilgileri> masadaYiyecek = new List<MasadaSiparisBilgileri>()
            {
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_pide.Text,siparisAdet=lbl_adetPide.Text,siparisFiyati=lbl_topFiyatPide.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_adanaKebap.Text,siparisAdet=lbl_adetAdanaKebap.Text,siparisFiyati=lbl_topFiyatAdanaKebap.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_Döner.Text,siparisAdet=lbl_adetDöner.Text,siparisFiyati=lbl_topFiyatDöner.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_hotdog.Text,siparisAdet=lbl_adetHotdog.Text,siparisFiyati=lbl_topFiyatHotdog.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_Dürüm.Text,siparisAdet=lbl_adetDürüm.Text,siparisFiyati=lbl_topFiyatDürüm.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_pizza.Text,siparisAdet=lbl_adetPizza.Text,siparisFiyati=lbl_topFiyatPizza.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_specialSpagetti.Text,siparisAdet=lbl_adetSpecialSpagetti.Text,siparisFiyati=lbl_topFiyatSpecialSpagetti.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_salata.Text,siparisAdet=lbl_adetSalata.Text,siparisFiyati=lbl_topFiyatSalata.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_simit.Text,siparisAdet=lbl_adetSimit.Text,siparisFiyati=lbl_topFiyatSimit.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_kahvaltilik.Text,siparisAdet=lbl_adetKahvaltilik.Text,siparisFiyati=lbl_topFiyatKahvaltilik.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_sushi.Text,siparisAdet=lbl_adetSushi.Text,siparisFiyati=lbl_topFiyatSushi.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_spagetti.Text,siparisAdet=lbl_adetSpagetti.Text,siparisFiyati=lbl_topFiyatSpagetti.Text}

            };

            #endregion

            //masadaYiyecek listesi Bll e yollanacak
            yiyecekEkle(masadaYiyecek);
           



            IcecekSiparisEkrani icecekSiparisEkran = new IcecekSiparisEkrani();
            icecekSiparisEkran.Show();
            this.Hide();


        }
        private void yiyecekEkle(List<MasadaSiparisBilgileri> masadaYiyecekler)
        {

            foreach (var item in masadaYiyecekler)
            {

                MasadaSiparisBilgileri yiyecekBilgi = new MasadaSiparisBilgileri();
                yiyecekBilgi.masaNo = item.masaNo;
                yiyecekBilgi.toplamFiyat = item.toplamFiyat;
                yiyecekBilgi.siparisAdi = item.siparisAdi;
                yiyecekBilgi.siparisAdet = item.siparisAdet;
                yiyecekBilgi.siparisFiyati = item.siparisFiyati;

                Bll.ekleYiyecekler(yiyecekBilgi);


            }


        }



        public int hesapla()
        {
            toplamHesabim = Convert.ToInt32(lbl_topFiyatPide.Text) + Convert.ToInt32(lbl_topFiyatAdanaKebap.Text) + Convert.ToInt32(lbl_topFiyatDöner.Text)
                   + Convert.ToInt32(lbl_topFiyatHotdog.Text) + Convert.ToInt32(lbl_topFiyatDürüm.Text) + Convert.ToInt32(lbl_topFiyatPizza.Text)
                   + Convert.ToInt32(lbl_topFiyatSpecialSpagetti.Text) + Convert.ToInt32(lbl_topFiyatSalata.Text) + Convert.ToInt32(lbl_topFiyatSimit.Text) +
                   Convert.ToInt32(lbl_topFiyatKahvaltilik.Text) + Convert.ToInt32(lbl_topFiyatSushi.Text) + Convert.ToInt32(lbl_topFiyatSpagetti.Text);
            return toplamHesabim;
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

        private void btn_toplam_Click(object sender, EventArgs e)
        {

            toplamHesabim = hesapla();
         

        }
    }
}
