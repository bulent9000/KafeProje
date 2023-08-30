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
    public partial class TatliSiparisEkrani : Form
    {
        SistemServices Bll;
        int toplamHesabim;
        int masaNosu;

        #region parametreler
        int cilekliTartArtanFiyat;
        int frenchBonbonArtanFiyat;
        int muffinArtanFiyat;
        int panCakeArtanFiyat;
        int choBerryArtanFiyat;
        int waffleArtanFiyat;
        int specialBasilsArtanFiyat;
        int limonluCakeArtanFiyat;
        int vaniChoArtanFiyat;
        int cupCherryArtanFiyat;
        int vaniCupArtanFiyat;
        int nutsCakeArtanFiyat;


        int cilekliTartAzalanFiyat;
        int frenchBonbonAzalanFiyat;
        int muffinAzalanFiyat;
        int panCakeAzalanFiyat;
        int choBerryAzalanFiyat;
        int waffleAzalanFiyat;
        int specialBasilsAzalanFiyat;
        int limonluCakeAzalanFiyat;
        int vaniChoAzalanFiyat;
        int cupCherryAzalanFiyat;
        int vaniCupAzalanFiyat;
        int nutsCakeAzalanFiyat;
        #endregion
        public TatliSiparisEkrani()
        {
            InitializeComponent();
            Bll = new SistemServices();
        }
        public int hesapla(int adet, int fiyat, object sender)
        {
            int toplamHesap = fiyat * adet;
            return toplamHesap;
        }

        private void btn_tatliOnceki_Click(object sender, EventArgs e)
        {
            IcecekSiparisEkrani icecekSiparisEkrani = new IcecekSiparisEkrani();
            icecekSiparisEkrani.Show();
            this.Hide();
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
        public void gösterCilekliTart(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatCilekliTart.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatCilekliTart.Text = Convert.ToString(hesabim);


        }
        public void gösterFrenchBonbon(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatFrenchBonbon.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatFrenchBonbon.Text = Convert.ToString(hesabim);


        }
        public void gösterMuffin(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatMuffin.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatMuffin.Text = Convert.ToString(hesabim);


        }
        public void gösterPanCake(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatPanCake.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatPanCake.Text = Convert.ToString(hesabim);


        }
        public void gösterChoBerry(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatChoBerry.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatChoBerry.Text = Convert.ToString(hesabim);


        }
        public void gösterWaffle(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatWaffle.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatWaffle.Text = Convert.ToString(hesabim);


        }
        public void gösterSpecialBasils(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatSpecialBasils.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatSpecialBasils.Text = Convert.ToString(hesabim);


        }
        public void gösterLimonluCake(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatLimonluCake.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatLimonluCake.Text = Convert.ToString(hesabim);


        }
        public void gösterVaniCho(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatVaniCho.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatVaniCho.Text = Convert.ToString(hesabim);


        }
        public void gösterCupCherry(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatCupCherry.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatCupCherry.Text = Convert.ToString(hesabim);


        }
        public void gösterVaniCup(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatVaniCup.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatVaniCup.Text = Convert.ToString(hesabim);


        }
        public void gösterNutsCake(int artanUrünFiyati, int azalanUrünfiyati)
        {
            int hesabim = Convert.ToInt32(lbl_topFiyatNutsCake.Text);

            hesabim = artanUrünFiyati - azalanUrünfiyati;
            hesabim = Math.Abs(hesabim);

            lbl_topFiyatNutsCake.Text = Convert.ToString(hesabim);


        }
        #endregion

        #region Adet Değişim

        private void lbl_artirCilekli_Click(object sender, EventArgs e)
        {
            int cilekliTartSayisi = Convert.ToInt32(lbl_adetCilekliTart.Text);
            cilekliTartSayisi++;
            lbl_adetCilekliTart.Text = Convert.ToString(cilekliTartSayisi);

            int fiyatCilekliTart = Convert.ToInt32(ürünFiyatAl(lbl_fiyatCilekliTart.Text));
            cilekliTartArtanFiyat = hesapla(cilekliTartSayisi, fiyatCilekliTart, sender);
            gösterCilekliTart(cilekliTartArtanFiyat, 0);

        }

        private void lbl_azaltCilekli_Click(object sender, EventArgs e)
        {
            int caySayisi = Convert.ToInt32(lbl_adetCilekliTart.Text);
            caySayisi--;
            lbl_adetCilekliTart.Text = Convert.ToString(caySayisi);

            int fiyatCilekliTart = Convert.ToInt32(ürünFiyatAl(lbl_fiyatCilekliTart.Text));
            cilekliTartAzalanFiyat = Convert.ToInt32(lbl_topFiyatCilekliTart.Text) - fiyatCilekliTart;
            gösterCilekliTart(0, cilekliTartAzalanFiyat);
        }

        private void lbl_artirFrenchBonbon_Click(object sender, EventArgs e)
        {
            int adetFrenchBonbon = Convert.ToInt32(lbl_adetFrenchBonbon.Text);
            adetFrenchBonbon++;
            lbl_adetFrenchBonbon.Text = Convert.ToString(adetFrenchBonbon);

            int frenchBonbonFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatFrenchBonbon.Text));
            frenchBonbonArtanFiyat = hesapla(adetFrenchBonbon, frenchBonbonFiyat, sender);
            gösterFrenchBonbon(frenchBonbonArtanFiyat, 0);
        }

        private void lbl_azaltFrenchBonbon_Click(object sender, EventArgs e)
        {
            int adetFrenchBonbon = Convert.ToInt32(lbl_adetFrenchBonbon.Text);
            adetFrenchBonbon--;
            lbl_adetFrenchBonbon.Text = Convert.ToString(adetFrenchBonbon);

            int frenchBonbonFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatFrenchBonbon.Text));
            frenchBonbonAzalanFiyat = Convert.ToInt32(lbl_topFiyatFrenchBonbon.Text) - frenchBonbonFiyat;
            gösterFrenchBonbon(0, frenchBonbonAzalanFiyat);
        }

        private void lbl_artirMuffin_Click(object sender, EventArgs e)
        {
            int adetMuffin = Convert.ToInt32(lbl_adetMuffin.Text);
            adetMuffin++;
            lbl_adetMuffin.Text = Convert.ToString(adetMuffin);

            int muffinFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatMuffin.Text));
            muffinArtanFiyat = hesapla(adetMuffin, muffinFiyat, sender);
            gösterMuffin(muffinArtanFiyat, 0);
        }

        private void lbl_azaltMuffin_Click(object sender, EventArgs e)
        {

            int adetMuffin = Convert.ToInt32(lbl_adetMuffin.Text);
            adetMuffin--;
            lbl_adetMuffin.Text = Convert.ToString(adetMuffin);

            int muffinFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatMuffin.Text));
            muffinAzalanFiyat = Convert.ToInt32(lbl_topFiyatMuffin.Text) - muffinFiyat;
            gösterMuffin(0, muffinAzalanFiyat);
        }

        private void lbl_artirPanCake_Click(object sender, EventArgs e)
        {
            int adetPanCake = Convert.ToInt32(lbl_adetPanCake.Text);
            adetPanCake++;
            lbl_adetPanCake.Text = Convert.ToString(adetPanCake);

            int panCakeFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatPanCake.Text));
            panCakeArtanFiyat = hesapla(adetPanCake, panCakeFiyat, sender);
            gösterPanCake(panCakeArtanFiyat, 0);
        }

        private void lbl_azaltPanCake_Click(object sender, EventArgs e)
        {
            int adetPanCake = Convert.ToInt32(lbl_adetPanCake.Text);
            adetPanCake--;
            lbl_adetPanCake.Text = Convert.ToString(adetPanCake);

            int panCakeFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatPanCake.Text));
            panCakeAzalanFiyat = Convert.ToInt32(lbl_topFiyatPanCake.Text) - panCakeFiyat;
            gösterPanCake(0, panCakeAzalanFiyat);
        }

        private void lbl_artirChoBerry_Click(object sender, EventArgs e)
        {
            int adetChoBerry = Convert.ToInt32(lbl_adetChoBerry.Text);
            adetChoBerry++;
            lbl_adetChoBerry.Text = Convert.ToString(adetChoBerry);

            int choBerryFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatChoBerry.Text));
            choBerryArtanFiyat = hesapla(adetChoBerry, choBerryFiyat, sender);
            gösterChoBerry(choBerryArtanFiyat, 0);
        }

        private void lbl_azaltChoBerry_Click(object sender, EventArgs e)
        {
            int adetChoBerry = Convert.ToInt32(lbl_adetChoBerry.Text);
            adetChoBerry--;
            lbl_adetChoBerry.Text = Convert.ToString(adetChoBerry);

            int choBerryFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatChoBerry.Text));
            choBerryAzalanFiyat = Convert.ToInt32(lbl_topFiyatChoBerry.Text) - choBerryFiyat;
            gösterChoBerry(0, choBerryAzalanFiyat);
        }

        private void lbl_artirWaffle_Click(object sender, EventArgs e)
        {
            int adetWaffle = Convert.ToInt32(lbl_adetWaffle.Text);
            adetWaffle++;
            lbl_adetWaffle.Text = Convert.ToString(adetWaffle);

            int waffleFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatWaffle.Text));
            waffleArtanFiyat = hesapla(adetWaffle, waffleFiyat, sender);
            gösterWaffle(waffleArtanFiyat, 0);
        }

        private void lbl_azaltWaffle_Click(object sender, EventArgs e)
        {
            int adetWaffle = Convert.ToInt32(lbl_adetWaffle.Text);
            adetWaffle--;
            lbl_adetWaffle.Text = Convert.ToString(adetWaffle);

            int waffleFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatWaffle.Text));
            waffleAzalanFiyat = Convert.ToInt32(lbl_topFiyatWaffle.Text) - waffleFiyat;
            gösterWaffle(0, waffleAzalanFiyat);
        }

        private void lbl_artirSpecialBasilis_Click(object sender, EventArgs e)
        {
            int adetSpecialBasils = Convert.ToInt32(lbl_adetSpecialBasils.Text);
            adetSpecialBasils++;
            lbl_adetSpecialBasils.Text = Convert.ToString(adetSpecialBasils);

            int specialBasilsFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatSpecialBasilis.Text));
            specialBasilsArtanFiyat = hesapla(adetSpecialBasils, specialBasilsFiyat, sender);
            gösterSpecialBasils(specialBasilsArtanFiyat, 0);
        }

        private void lbl_azaltSpecialBasilis_Click(object sender, EventArgs e)
        {
            int adetSpecialBasils = Convert.ToInt32(lbl_adetSpecialBasils.Text);
            adetSpecialBasils--;
            lbl_adetSpecialBasils.Text = Convert.ToString(adetSpecialBasils);

            int specialBasilsFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatSpecialBasilis.Text));
            specialBasilsAzalanFiyat = Convert.ToInt32(lbl_topFiyatSpecialBasils.Text) - specialBasilsFiyat;
            gösterSpecialBasils(0, specialBasilsAzalanFiyat);
        }

        private void lbl_artirLimonluCake_Click(object sender, EventArgs e)
        {
            int adetLimonluCake = Convert.ToInt32(lbl_adetLimonluCake.Text);
            adetLimonluCake++;
            lbl_adetLimonluCake.Text = Convert.ToString(adetLimonluCake);

            int limonluCakeFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatLimonluCake.Text));
            limonluCakeArtanFiyat = hesapla(adetLimonluCake, limonluCakeFiyat, sender);
            gösterLimonluCake(limonluCakeArtanFiyat, 0);
        }

        private void lbl_azaltLimonluCake_Click(object sender, EventArgs e)
        {
            int adetLimonluCake = Convert.ToInt32(lbl_adetLimonluCake.Text);
            adetLimonluCake--;
            lbl_adetLimonluCake.Text = Convert.ToString(adetLimonluCake);

            int limonluCakeFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatLimonluCake.Text));
            limonluCakeAzalanFiyat = Convert.ToInt32(lbl_topFiyatLimonluCake.Text) - limonluCakeFiyat;
            gösterLimonluCake(0, limonluCakeAzalanFiyat);
        }

        private void lbl_artirVaniCho_Click(object sender, EventArgs e)
        {
            int adetVaniCho = Convert.ToInt32(lbl_adetVaniCho.Text);
            adetVaniCho++;
            lbl_adetVaniCho.Text = Convert.ToString(adetVaniCho);

            int vaniChoFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatVaniCho.Text));
            vaniChoArtanFiyat = hesapla(adetVaniCho, vaniChoFiyat, sender);
            gösterVaniCho(vaniChoArtanFiyat, 0);
        }

        private void lbl_azaltVaniCho_Click(object sender, EventArgs e)
        {
            int adetVaniCho = Convert.ToInt32(lbl_adetVaniCho.Text);
            adetVaniCho--;
            lbl_adetVaniCho.Text = Convert.ToString(adetVaniCho);

            int vaniChoFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatVaniCho.Text));
            vaniChoAzalanFiyat = Convert.ToInt32(lbl_topFiyatVaniCho.Text) - vaniChoFiyat;
            gösterVaniCho(0, vaniChoAzalanFiyat);
        }

        private void lbl_artirCupCherry_Click(object sender, EventArgs e)
        {
            int adetCupCherry = Convert.ToInt32(lbl_adetCupCherry.Text);
            adetCupCherry++;
            lbl_adetCupCherry.Text = Convert.ToString(adetCupCherry);

            int cupCherryFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatCupCherry.Text));
            cupCherryArtanFiyat = hesapla(adetCupCherry, cupCherryFiyat, sender);
            gösterCupCherry(cupCherryArtanFiyat, 0);
        }

        private void lbl_azaltCupCherry_Click(object sender, EventArgs e)
        {
            int adetCupCherry = Convert.ToInt32(lbl_adetCupCherry.Text);
            adetCupCherry--;
            lbl_adetCupCherry.Text = Convert.ToString(adetCupCherry);

            int cupCherryFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatCupCherry.Text));
            cupCherryAzalanFiyat = Convert.ToInt32(lbl_topFiyatCupCherry.Text) - cupCherryFiyat;
            gösterCupCherry(0, cupCherryAzalanFiyat);
        }

        private void lbl_artirVaniCup_Click(object sender, EventArgs e)
        {
            int adetVaniCup = Convert.ToInt32(lbl_adetVaniCup.Text);
            adetVaniCup++;
            lbl_adetVaniCup.Text = Convert.ToString(adetVaniCup);

            int vaniCupFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatVaniCup.Text));
            vaniCupArtanFiyat = hesapla(adetVaniCup, vaniCupFiyat, sender);
            gösterVaniCup(vaniCupArtanFiyat, 0);
        }

        private void lbl_azaltVaniCup_Click(object sender, EventArgs e)
        {
            int adetVaniCup = Convert.ToInt32(lbl_adetVaniCup.Text);
            adetVaniCup--;
            lbl_adetVaniCup.Text = Convert.ToString(adetVaniCup);

            int vaniCupFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatVaniCup.Text));
            vaniCupAzalanFiyat = Convert.ToInt32(lbl_topFiyatVaniCup.Text) - vaniCupFiyat;
            gösterVaniCup(0, vaniCupAzalanFiyat);
        }

        private void lbl_artirNutsCake_Click(object sender, EventArgs e)
        {
            int adetNutsCake = Convert.ToInt32(lbl_adetNutsCake.Text);
            adetNutsCake++;
            lbl_adetNutsCake.Text = Convert.ToString(adetNutsCake);

            int nutsCakeFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatNutsCake.Text));
            nutsCakeArtanFiyat = hesapla(adetNutsCake, nutsCakeFiyat, sender);
            gösterNutsCake(nutsCakeArtanFiyat, 0);
        }

        private void lbl_azaltNutsCake_Click(object sender, EventArgs e)
        {
            int adetNutsCake = Convert.ToInt32(lbl_adetNutsCake.Text);
            adetNutsCake--;
            lbl_adetNutsCake.Text = Convert.ToString(adetNutsCake);

            int nutsCakeFiyat = Convert.ToInt32(ürünFiyatAl(lbl_fiyatNutsCake.Text));
            nutsCakeAzalanFiyat = Convert.ToInt32(lbl_topFiyatNutsCake.Text) - nutsCakeFiyat;
            gösterNutsCake(0, nutsCakeAzalanFiyat);
        }

        #endregion

        private void btn_toplamTatliTutar_Click(object sender, EventArgs e)
        {
            toplamHesabim = hesapla();
           
        }

        private void btn_tatliSonraki_Click(object sender, EventArgs e)
        {

            Form frm = (Form)Application.OpenForms["MüsteriSiparisKayitEkrani"];
            Label lblMasaNo = (Label)frm.Controls["lbl_masaNumarasi"];
            masaNosu = Convert.ToInt32(lblMasaNo.Text);
            toplamHesabim = hesapla();

            #region  Tatlılara veri ataması
            List<MasadaSiparisBilgileri> masadaTatli = new List<MasadaSiparisBilgileri>()
            {
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimCilekliTart.Text,siparisAdet=lbl_adetCilekliTart.Text,siparisFiyati=lbl_topFiyatCilekliTart.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimFrencBonbon.Text,siparisAdet=lbl_adetFrenchBonbon.Text,siparisFiyati=lbl_topFiyatFrenchBonbon.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimMuffin.Text,siparisAdet=lbl_adetMuffin.Text,siparisFiyati=lbl_topFiyatMuffin.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimPanCake.Text,siparisAdet=lbl_adetPanCake.Text,siparisFiyati=lbl_topFiyatPanCake.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimChoBerry.Text,siparisAdet=lbl_adetChoBerry.Text,siparisFiyati=lbl_topFiyatChoBerry.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimWaffle.Text,siparisAdet=lbl_adetWaffle.Text,siparisFiyati=lbl_topFiyatWaffle.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimSpecialBasilis.Text,siparisAdet=lbl_adetSpecialBasils.Text,siparisFiyati=lbl_topFiyatSpecialBasils.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimLimonluCake.Text,siparisAdet=lbl_adetLimonluCake.Text,siparisFiyati=lbl_topFiyatLimonluCake.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimVaniCho.Text,siparisAdet=lbl_adetVaniCho.Text,siparisFiyati=lbl_topFiyatVaniCho.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimCupCherry.Text,siparisAdet=lbl_adetCupCherry.Text,siparisFiyati=lbl_topFiyatCupCherry.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimVaniCup.Text,siparisAdet=lbl_adetVaniCup.Text,siparisFiyati=lbl_topFiyatVaniCup.Text},
                new MasadaSiparisBilgileri(){masaNo=masaNosu,toplamFiyat=toplamHesabim,siparisAdi=lbl_isimNutsCake.Text,siparisAdet=lbl_adetNutsCake.Text,siparisFiyati=lbl_topFiyatNutsCake.Text}

            };

            #endregion


            tatliEkle(masadaTatli);


            MasadaHesapEkrani onlineSiparisim = new MasadaHesapEkrani();
            onlineSiparisim.Show();
            this.Hide();

        }
        private void tatliEkle(List<MasadaSiparisBilgileri> masadaTatlilar)
        {

            foreach (var item in masadaTatlilar)
            {

                MasadaSiparisBilgileri tatliBilgi = new MasadaSiparisBilgileri();
                tatliBilgi.masaNo = item.masaNo;
                tatliBilgi.toplamFiyat = item.toplamFiyat;
                tatliBilgi.siparisAdi = item.siparisAdi;
                tatliBilgi.siparisAdet = item.siparisAdet;
                tatliBilgi.siparisFiyati = item.siparisFiyati;

                Bll.tatliEkleme(tatliBilgi);


            }

            
        }

        public int hesapla()
        {
            toplamHesabim = Convert.ToInt32(lbl_topFiyatCilekliTart.Text) + Convert.ToInt32(lbl_topFiyatFrenchBonbon.Text) + Convert.ToInt32(lbl_topFiyatMuffin.Text)
                   + Convert.ToInt32(lbl_topFiyatPanCake.Text) + Convert.ToInt32(lbl_topFiyatChoBerry.Text) + Convert.ToInt32(lbl_topFiyatWaffle.Text)
                   + Convert.ToInt32(lbl_topFiyatSpecialBasils.Text) + Convert.ToInt32(lbl_topFiyatLimonluCake.Text) + Convert.ToInt32(lbl_topFiyatVaniCup.Text) +
                   Convert.ToInt32(lbl_topFiyatCupCherry.Text) + Convert.ToInt32(lbl_topFiyatVaniCup.Text) + Convert.ToInt32(lbl_topFiyatNutsCake.Text);
            return toplamHesabim;
        }

    }
}
