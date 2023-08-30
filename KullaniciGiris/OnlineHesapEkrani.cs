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
    public partial class OnlineHesapEkrani : Form
    {
        int toplamTutarim;

        #region sipariş parametreleri
        string pideAdi;
        string pideAdedi;
        string pideTopFiyatim;

        string adanaKebapAdi;
        string adanaKebapAdedim;
        string adanaKebapTopFiyatim;

        string dönerAdi;
        string dönerAdedim;
        string dönerTopFiyatim;

        string hotDogAdi;
        string hotDogAdedim;
        string hotDogTopFiyatim;
       
        string dürümAdi;
        string dürümAdedim;
        string dürümTopFiyatim;
       
        string pizzaAdi;
        string pizzaAdedim;
        string pizzaTopFiyatim;


        string specialSpagettiAdi;
        string specialSpagettiAdedi;
        string specialSpagettiTopFiyatim;

        string salataAdi;
        string salataAdedim;
        string salataTopFiyatim;

        string simitAdi;
        string simitAdedim;
        string simitTopFiyatim;

        string kahvaltilikAdi;
        string kahvaltilikAdedim;
        string kahvaltilikTopFiyatim;

        string sushiAdi;
        string sushiAdedim;
        string sushiTopFiyatim;

        string spagettiAdi;
        string spagettiAdedim;
        string spagettiTopFiyatim;

        #endregion



        public OnlineHesapEkrani()
        {
            InitializeComponent();
        }

        public void tutarDöndür(int hesap)
        {
            toplamTutarim = hesap;
            
        }



        private void btn_ödemeYap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödemenin onaylanması için lütfen ekrandaki kodu ilgili alana girin" +
                "Kodunuz: 123456");
            OdemeOnay onay = new OdemeOnay();
            onay.Show();

        }

        private void OnlineHesapEkrani_Load(object sender, EventArgs e)
        {

            Form ekran=(Form)Application.OpenForms["OnlineSiparisMüsteriKayitEkrani"];       
            GroupBox grpOMüsteriBilgi = (GroupBox)ekran.Controls["grp_onlineMüsteriBilgi"];
                 
                lbl_siparisVerenAd.Text = ((TextBox)grpOMüsteriBilgi.Controls["txt_müsteriAdi"]).Text;
                lbl_siparisVerenAd.Text = ((TextBox)grpOMüsteriBilgi.Controls["txt_müsteriAdi"]).Text;
                lbl_siparisVerenSoyad.Text = ((TextBox)grpOMüsteriBilgi.Controls["txt_müsteriSoyadi"]).Text;
                lbl_telefon.Text = ((TextBox)grpOMüsteriBilgi.Controls["txt_telefon"]).Text;
                lbl_mahallem.Text = ((ComboBox)grpOMüsteriBilgi.Controls["cmb_mahalle"]).Text;
                lbl_sokagim.Text = ((ComboBox)grpOMüsteriBilgi.Controls["cmb_sokak"]).Text;
                lbl_kapiNo.Text = ((ComboBox)grpOMüsteriBilgi.Controls["cmb_icKapiNo"]).Text;
                lbl_ilcem.Text = ((ComboBox)grpOMüsteriBilgi.Controls["cmb_ilce"]).Text;
                lbl_il.Text = ((ComboBox)grpOMüsteriBilgi.Controls["cmb_il"]).Text;
                lbl_tarih.Text = ((DateTimePicker)grpOMüsteriBilgi.Controls["dtp_siparisTarihi"]).Text;
             lbl_tutarim.Text = Convert.ToString(toplamTutarim);


            List<OnlineSiparisBilgileri> onlineBilgi = new List<OnlineSiparisBilgileri>()
            {
                new OnlineSiparisBilgileri(){siparisAdi=pideAdi,siparisAdet=pideAdedi,siparisFiyati=pideTopFiyatim},
                new OnlineSiparisBilgileri(){siparisAdi=adanaKebapAdi,siparisAdet=adanaKebapAdedim,siparisFiyati=adanaKebapTopFiyatim},
                new OnlineSiparisBilgileri(){siparisAdi=dönerAdi,siparisAdet=dönerAdedim,siparisFiyati=dönerTopFiyatim},
                new OnlineSiparisBilgileri(){siparisAdi=hotDogAdi,siparisAdet=hotDogAdedim,siparisFiyati=hotDogTopFiyatim},
                new OnlineSiparisBilgileri(){siparisAdi=dürümAdi,siparisAdet=dürümAdedim,siparisFiyati=dürümTopFiyatim},
                new OnlineSiparisBilgileri(){siparisAdi=pizzaAdi,siparisAdet=pizzaAdedim,siparisFiyati=pizzaTopFiyatim},
                new OnlineSiparisBilgileri(){siparisAdi=specialSpagettiAdi,siparisAdet=specialSpagettiAdedi,siparisFiyati=specialSpagettiTopFiyatim},
                new OnlineSiparisBilgileri(){siparisAdi=salataAdi,siparisAdet=salataAdedim,siparisFiyati=salataTopFiyatim},
                new OnlineSiparisBilgileri(){siparisAdi=simitAdi,siparisAdet=simitAdedim,siparisFiyati=simitTopFiyatim},
                new OnlineSiparisBilgileri(){siparisAdi=simitAdi,siparisAdet=simitAdedim,siparisFiyati=simitTopFiyatim},
                new OnlineSiparisBilgileri(){siparisAdi=kahvaltilikAdi,siparisAdet=kahvaltilikAdedim,siparisFiyati=kahvaltilikTopFiyatim},
                new OnlineSiparisBilgileri(){siparisAdi=sushiAdi,siparisAdet=sushiAdedim,siparisFiyati=sushiTopFiyatim}

            };

            dataGridView1.DataSource = onlineBilgi;



        }
        #region ürünlerin  online hesaptan çekilmesi

        #region Ürün Metotları
        public void pide(string ürünAdi,string ürünAdet,string ürünTopTutar)
        {
            pideAdi = ürünAdi;
            pideAdedi = ürünAdet;
            pideTopFiyatim = ürünTopTutar;

        }

        public void adanaKebap(string ürünAdi, string ürünAdet, string ürünTopTutar)
        {
            adanaKebapAdi = ürünAdi;
            adanaKebapAdedim = ürünAdet;
            adanaKebapTopFiyatim = ürünTopTutar;

        }
        public void döner(string ürünAdi, string ürünAdet, string ürünTopTutar)
        {
            dönerAdi = ürünAdi;
            dönerAdedim = ürünAdet;
            dönerTopFiyatim = ürünTopTutar;

        }

        public void hotDog(string ürünAdi, string ürünAdet, string ürünTopTutar)
        {
            hotDogAdi = ürünAdi;
            hotDogAdedim = ürünAdet;
            hotDogTopFiyatim = ürünTopTutar;

        }

        public void dürüm(string ürünAdi, string ürünAdet, string ürünTopTutar)
        {
            dürümAdi = ürünAdi;
            dürümAdedim = ürünAdet;
            dürümTopFiyatim = ürünTopTutar;

        }

        public void pizza(string ürünAdi, string ürünAdet, string ürünTopTutar)
        {
            pizzaAdi = ürünAdi;
            pizzaAdedim = ürünAdet;
            pizzaTopFiyatim = ürünTopTutar;

        }
        public void specialSpagetti(string ürünAdi, string ürünAdet, string ürünTopTutar)
        {
            specialSpagettiAdi = ürünAdi;
            specialSpagettiAdedi = ürünAdet;
            specialSpagettiTopFiyatim = ürünTopTutar;

        }

        public void salata(string ürünAdi, string ürünAdet, string ürünTopTutar)
        {
            salataAdi = ürünAdi;
            salataAdedim = ürünAdet;
            salataTopFiyatim = ürünTopTutar;

        }
        public void simit(string ürünAdi, string ürünAdet, string ürünTopTutar)
        {
            simitAdi = ürünAdi;
            simitAdedim = ürünAdet;
            simitTopFiyatim = ürünTopTutar;

        }

        public void kahvaltilik(string ürünAdi, string ürünAdet, string ürünTopTutar)
        {
            kahvaltilikAdi = ürünAdi;
            kahvaltilikAdedim = ürünAdet;
            kahvaltilikTopFiyatim = ürünTopTutar;

        }
        public void sushi(string ürünAdi, string ürünAdet, string ürünTopTutar)
        {
            sushiAdi = ürünAdi;
            sushiAdedim = ürünAdet;
            sushiTopFiyatim = ürünTopTutar;

        }

        public void spagetti(string ürünAdi, string ürünAdet, string ürünTopTutar)
        {
            spagettiAdi = ürünAdi;
            spagettiAdedim = ürünAdet;
            spagettiTopFiyatim = ürünTopTutar;

        }
        #endregion
        #endregion

    }
}
