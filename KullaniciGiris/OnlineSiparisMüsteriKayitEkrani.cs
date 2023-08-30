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
    public partial class OnlineSiparisMüsteriKayitEkrani : Form
    {
        List<Ilceler> ilceler;
        List<Mahalleler> mahalleler;
        List<Sokaklar> sokaklar;
        public OnlineSiparisMüsteriKayitEkrani()
        {
            InitializeComponent();

           
        }

        private void cmb_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region iller
            ilceler = new List<Ilceler>();

            if (cmb_il.SelectedItem is "Adana")
            {
             
                ilceler.Add(new Ilceler
                { ilceAdi = "Ceyhan" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Çukurova" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Karaisalı" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Kozan" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Pozantı" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Seyhan" });
               
             
                cmb_ilce.DataSource = ilceler;
            }


            else if (cmb_il.SelectedItem is "Ankara")
            {

                ilceler.Add(new Ilceler
                { ilceAdi = "Yenimahalle" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Keçiören" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Kızılay" });            
                ilceler.Add(new Ilceler
                { ilceAdi = "Etimesgut" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Mamak" });


                cmb_ilce.DataSource = ilceler;
            }
            else if (cmb_il.SelectedItem is "Antalya")
            {

                ilceler.Add(new Ilceler
                { ilceAdi = "Akseki" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Alanya" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Elmalı" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Manavgat" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Serik" });


                cmb_ilce.DataSource = ilceler;
            }
           
            else if (cmb_il.SelectedItem is "Bursa")
            {

                ilceler.Add(new Ilceler
                { ilceAdi = "Nilüfer" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Gemlik" });
                ilceler.Add(new Ilceler
                { ilceAdi = "İnegöl" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Karacabey" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Kemal Paşa" });


                cmb_ilce.DataSource = ilceler;
            }
            else if (cmb_il.SelectedItem is "Gaziantep")
            {

                ilceler.Add(new Ilceler
                { ilceAdi = "İslahiye" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Nizip" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Nurdağı" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Şahinbey" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Şehit Kamil" });


                cmb_ilce.DataSource = ilceler;
            }

            else if (cmb_il.SelectedItem is "İstanbul")
            {

                ilceler.Add(new Ilceler
                { ilceAdi = "Ataşehir" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Beşiktaş" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Kadıköy" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Şişli" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Bakırköy" });


                cmb_ilce.DataSource = ilceler;
            }
            else if (cmb_il.SelectedItem is "İzmir")
            {

                ilceler.Add(new Ilceler
                { ilceAdi = "Balçova" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Bayraklı" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Çeşme" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Foça" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Menemen" });


                cmb_ilce.DataSource = ilceler;
            }
            else if (cmb_il.SelectedItem is "Kocaeli")
            {

                ilceler.Add(new Ilceler
                { ilceAdi = "Çayırova" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Darıca" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Derince" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Gebze" });
                ilceler.Add(new Ilceler
                { ilceAdi = "İzmit" });


                cmb_ilce.DataSource = ilceler;
            }
            else if (cmb_il.SelectedItem is "Samsun")
            {

                ilceler.Add(new Ilceler
                { ilceAdi = "Alaçam" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Atakum" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Bafra" });
                ilceler.Add(new Ilceler
                { ilceAdi = "İlkadım" });
                ilceler.Add(new Ilceler
                { ilceAdi = "Terme" });


                cmb_ilce.DataSource = ilceler;
            }
            

            #endregion
        }

       

        private void cmb_ilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            mahalleler = new List<Mahalleler>();
            #region İlçeler
            #region Adana ilçeleri


            #region Ceyhan Mahalleleri
            if (cmb_ilce.Text== "Ceyhan")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Namık Kemal Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "İstiklal Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Ulus Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Mithat Paşa Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Burhaniye Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Gazi Osman Paşa Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Küçük Kırım Mah." });
                cmb_mahalle.DataSource = mahalleler;

            }
            #endregion
            else if (cmb_ilce.Text == "Çukurova")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Belediye Evleri Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Beyaz Evler Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Bozcalar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Dörtler Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Esentepe Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Gökkuyu Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Güzelyalı Mah." });
                cmb_mahalle.DataSource = mahalleler;

            }
            else if (cmb_ilce.Text == "Karaisalı")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Akçalı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Aktaş Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Altınova Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Aşağıyörükler Mah." });
                cmb_mahalle.DataSource = mahalleler;

            }

            else if (cmb_ilce.Text == "Kozan")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Akdam Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Alapınar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Akarca Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Acarmantaş Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            else if (cmb_ilce.Text == "Pozantı")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Cumhuriyet Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Gökbez Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Hamidiye Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Aşçıbekirli Mah." });
                cmb_mahalle.DataSource = mahalleler;

            }
            else if (cmb_ilce.Text == "Seyhan")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Aydınlar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Alidede Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Barbaros Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "DörtAğaç Mah." });
                cmb_mahalle.DataSource = mahalleler;

            }
            #endregion

            #region Ankara ilçeleri




            if (cmb_ilce.Text == "Yenimahalle")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Barış Tepe Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Karşıyaka Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Gayrettepe Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Güven Tepe Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Demetevler Mah." });
                cmb_mahalle.DataSource = mahalleler;

            }
            else if (cmb_ilce.Text == "Keçiören")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Sancaktepe Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Yükseltepe Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Basınevleri Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Ayvalı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Etlik Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            else if (cmb_ilce.Text == "Kızılay")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Namık Kemal Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Meşrutiyet Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Kocatepe Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Fidanlık Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Devlet Mah." });

                cmb_mahalle.DataSource = mahalleler;

            }
            else if (cmb_ilce.Text == "Etimesgut")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Alsancak Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Eryaman Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Etiler Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Süvari Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Topçu Mah." });
                cmb_mahalle.DataSource = mahalleler;

            }
            else if (cmb_ilce.Text == "Mamak")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Altıağaç Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çiğiltepe Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Derbent Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Ekin Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Karaağaç Mah." });

                cmb_mahalle.DataSource = mahalleler;
            }



            #endregion

            #region  Antalya ilçeleri


            if (cmb_ilce.Text == "Akseki")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Alaçeşme Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Bademli Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Belenalan Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Boğaz  Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Bucakalan Mah." });
                cmb_mahalle.DataSource = mahalleler;

            }
            else if (cmb_ilce.Text == "Alanya")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Akdam Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Yeşilöz Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çamlıca Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Yaylalı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Konaklı Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            else if (cmb_ilce.Text == "Elmalı")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Kızılca Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Tavullar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Sarılar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Düdenköy Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Kocapınar Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            else if (cmb_ilce.Text == "Manavgat")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Hisar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Pazarcı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çeltikçi Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Altınkaya Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Boztepe Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            else if (cmb_ilce.Text == "Serik")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Aşağıoba Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çandır Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Gebiz Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Haspınar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Yumaklar Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            #endregion

            #region Bursa İlçeleri

            if (cmb_ilce.Text == "Nilüfer")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Hasanağa Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Ataevler Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Doğanköy Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Gölyazı  Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Gümüştepe Mah." });
                cmb_mahalle.DataSource = mahalleler;

            }
            else if (cmb_ilce.Text == "Gemlik")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Balıkpazarı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Fevziye Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Güvenli Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Haydariye Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Narlı Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            else if (cmb_ilce.Text == "İnegöl")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Akbaşlar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Bahariye Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çiftli Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Doğan Yurdu Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Elmaçayır Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            else if (cmb_ilce.Text == "Karacabey")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Akçakoyun Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Akhisar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Hürriyet Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "İnkaya Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Taşpınar Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            else if (cmb_ilce.Text == "Kemal Paşa")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Behram Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Güllüce Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Demirdere Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Doğancı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Eskibalçık Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            #endregion

            #region Gaziantep İlçeleri
            if (cmb_ilce.Text == "İslahiye")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Alaca Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Altınüzüm Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Bayraktepe Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çamlıca  Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Karacaören Mah." });
                cmb_mahalle.DataSource = mahalleler;

            }
            else if (cmb_ilce.Text == "Nizip")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Dayıdağı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Fevzi Paşa Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Fırat Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Gülkaya Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Kaleköy Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Nurdağı")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Aslanlı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Belpınar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Nogaylar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Sakçagözü Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Yaylacık Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            else if (cmb_ilce.Text == "Şahinbey")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "60.yıl Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Alleben Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Beyzalar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Binevler Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çağdaş Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            else if (cmb_ilce.Text == "Şehit Kamil")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Bağbaşı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Batıkent Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Durnalık Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Güvenevler Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Işıklı Mah." });
                cmb_mahalle.DataSource = mahalleler;


            }
            #endregion

            #region İstanbul İlçeleri
            if (cmb_ilce.Text == "Ataşehir")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Ferhatpaşa Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "İçerenköy Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "İnönü Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Kayışdağı  Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Yeni Çamlıca Mah." });
                cmb_mahalle.DataSource = mahalleler;

            }
            else if (cmb_ilce.Text == "Bakırköy")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Cevizlik Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Kartaltepe Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Osmaniye Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Şenlikköy Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Yeşilköy Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Beşiktaş")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Akat Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Balmumcu Paşa Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Dikilitaş Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Etiler Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Gayrettepe Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Kadıköy")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Acıbadem Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Caferağa Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Dumlupınar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Eğitim Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Fikirtepe Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Şişli")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Esentepe Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Fulya Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Gülbahar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "İzzet Paşa Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Mecidiyeköy Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            #endregion

            #region İzmir ilçeleri
            if (cmb_ilce.Text == "Balçova")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Bahçelerarası Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çetin Emeç Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Korutürk Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Onur Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Teleferik Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Bayraklı")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Adalet Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çay Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Manavkuyu Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Mansuroğlu Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Osmangazi Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Çeşme")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Alaçatı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Dalyan Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Germiyan Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Karaköy Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Yalı Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Foça")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Hacıveli Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "İlpınar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Kozbeyli Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Yenibağarası Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Yeniköy Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Menemen")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Ahıhıdır Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Buruncuk Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Esatpaşa Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Gölcük Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Irmak Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }

            #endregion

            #region Kocaeli ilçeleri
            if (cmb_ilce.Text == "Çayırova")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Akse Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Atatürk Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Emek Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "İnönü Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Özgürlük Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Darıca")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Bağlarbaşı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Bayramoğlu Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Kazımkarabekir Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Nenehatun Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Osmangazi Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Derince")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çavuşlu Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çenedağ Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Deniz Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "İbni Sina Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Sırrı Paşa Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Gebze")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Arapçeşme Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Barış Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Güzeller Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Köşklü Çeşme Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Mevlana Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "İzmit")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Akçakoca Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çukurbağ Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Doğan Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Kocatepe Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Körfez Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }


            #endregion

            #region Samsun ilçeleri
            if (cmb_ilce.Text == "Alaçam")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Akbulut Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Göçkün Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Umutlu Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Yeşilköy Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Yukarıelma Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Atakum")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Aksu Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Büyükoyumca Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çobanlı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Denizevleri Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Esenevler Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Bafra")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Adaköy Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Balıklar Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Elifli Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Gerzeliler Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Kelikler Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "İlkadım")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Ahulu Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Çatalarmut Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Hançerli Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Kalkancı Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Liman Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            else if (cmb_ilce.Text == "Terme")
            {
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Akçay Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Altunlu Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Dereyol Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "İlimdağ Mah." });
                mahalleler.Add(new Mahalleler
                { mahalleAdi = "Sarayköy Mah." });
                cmb_mahalle.DataSource = mahalleler;
            }
            #endregion

            #endregion

        }
        private void cmb_mahalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            sokaklar = new List<Sokaklar>();
            #region Mahalleler

            #region Adana ili sokakları
            #region Ceyhan Sokakları
            if (cmb_mahalle.Text == "Namık Kemal Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Nesrin Olgun sk" });
                sokaklar.Add(new Sokaklar
                { sokakAdi= "Borsa Cad." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "İstiklal Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Debboy Cad." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Bakım Yurdu Cad." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Meydan Cad." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Ulus Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Abidinpaşa Cad." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Kızılay Cad." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Pazarlar Cad." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Mithat Paşa Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Defne Cad." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Ray sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "51154 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Burhaniye Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Adnan Menderes Bulv." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "İlyas Taner Cad." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Günsazak Cad." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Gazi Osman Paşa Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Fatih Cad." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Kemalpaşa Cad." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Galeri Cad." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Küçük Kırım Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "İbrahim Koruklu sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Şht. Kasım Solak sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Ahmet Zabit Zade sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            #endregion

            #region Çukurova Sokakları
            if (cmb_mahalle.Text == "Belediye Evleri Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Zahit Akdağ Bulv." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Çoban Yurtçu Bulv." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Beyaz Evler Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Bozcalar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Dörtler Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Esentepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "28506 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "19860 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "14025 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25300 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Gökkuyu Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "56200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "53250 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "65320 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Güzelyalı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "72502 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "68900 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "63205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45741 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Karaisalı Sokakları

            if (cmb_mahalle.Text == "Akçalı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Zahit Akdağ Bulv." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Çoban Yurtçu Bulv." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Aktaş Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Altınova Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Aşağıyörükler Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }



            #endregion

            #region Kozan Sokakları
            if (cmb_mahalle.Text == "Akdam Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Zahit Akdağ Bulv." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Çoban Yurtçu Bulv." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Alapınar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Akarca Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Acamantaş Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Pozantı Sokakları
            if (cmb_mahalle.Text == "Cumhuriyet Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Zahit Akdağ Bulv." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Çoban Yurtçu Bulv." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Gökbez Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Hamidiye Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Aşçıbekirli Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            #endregion

            #region Seyhan sokakları
            if (cmb_mahalle.Text == "Aydınlar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Zahit Akdağ Bulv." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Çoban Yurtçu Bulv." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Alidede Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Barbaros Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Dörtağaç Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            #endregion

            #endregion

            #region Ankara ili sokakları
            #region Yenimahalle Sokakları
            if (cmb_mahalle.Text == "Barış Tepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7250. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7854 .sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Karşıyaka Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5620. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4850. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2623. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Gayrettepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7280. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8960. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Güven Tepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7841. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8963. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2630. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Demetevler Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4201. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4350. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4802. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
           
            #endregion

            #region Keçiören Sokakları
            if (cmb_mahalle.Text == "Sancaktepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5210. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3692. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8740. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Yükseltepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8510 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "11205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "15420 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "23502 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Basınevleri Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8521 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7841 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Ayvalı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7412 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7415 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Etlik Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7965 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
          
            

            #endregion

            #region Kızılay Sokakları

            if (cmb_mahalle.Text == "Namık Kemal Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Meşrutiyet Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Kocatepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Fidanlık Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Devlet Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Etimesgut Sokakları
            if (cmb_mahalle.Text == "Alsancak Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2026 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2310 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2104 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
           
           
            else if (cmb_mahalle.Text == "Eryaman Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3850 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Mamak Sokakları
            if (cmb_mahalle.Text == "Altıağaç Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Zahit Akdağ Bulv." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "Çoban Yurtçu Bulv." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Çiğiltepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Derbent Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Ekin Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4100 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4320 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Karaağaç Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5620. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8740. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9860. sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion



            #endregion

            #region Antalya ili sokakları
            #region Akseki Sokakları
            if (cmb_mahalle.Text == "Alaçeşme Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8452. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9620 .sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Bademli Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5620. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4850. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2623. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Belenalan Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7280. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8960. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Boğaz Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7841. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8963. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2630. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Bucakalan Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4201. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4350. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4802. sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Alanya Sokakları
            if (cmb_mahalle.Text == "Akdam Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5210. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3692. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8740. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Yeşilöz Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8510 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "11205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "15420 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "23502 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Çamlıca Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8521 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7841 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Yaylalı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7412 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7415 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Konaklı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7965 sk." });
                cmb_sokak.DataSource = sokaklar;
            }



            #endregion

            #region Elmalı Sokakları

            if (cmb_mahalle.Text == "Kızılca Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Tavullar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Sarılar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Düdenköy Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Kocapınar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Manavgat Sokakları
            if (cmb_mahalle.Text == "Hisar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2026 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2310 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2104 sk." });
                cmb_sokak.DataSource = sokaklar;
            }


            else if (cmb_mahalle.Text == "Pazarcı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3850 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Serik Sokakları
            if (cmb_mahalle.Text == "Aşağıoba Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45620. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9856. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9630. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8741. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5620. sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Çandır Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Gebiz Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Haspınar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Yumaklar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            #endregion



            #endregion

            #region Bursa ili sokakları
            #region Nilüfer Sokakları
            if (cmb_mahalle.Text == "Hasanağa Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8452. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9620 .sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Ataevler Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5620. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4850. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2623. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Doğanköy Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7280. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8960. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Gölyazı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7841. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8963. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2630. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Gümüştepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4201. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4350. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4802. sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Gemlik Sokakları
            if (cmb_mahalle.Text == "Balıkpazarı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5210. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3692. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8740. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Fevziye Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8510 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "11205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "15420 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "23502 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Güvenli Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8521 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7841 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Haydariye Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7412 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7415 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Narlı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7965 sk." });
                cmb_sokak.DataSource = sokaklar;
            }



            #endregion

            #region İnegöl Sokakları

            if (cmb_mahalle.Text == "Akbaşlar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Bahariye Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Çiftli Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Doğan Yurdu Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Elmaçayır Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Karacabey Sokakları
            if (cmb_mahalle.Text == "Akçakoyun Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2026 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2310 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2104 sk." });
                cmb_sokak.DataSource = sokaklar;
            }


            else if (cmb_mahalle.Text == "Akhisar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3850 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Kemal Paşa Sokakları
            if (cmb_mahalle.Text == "Behram Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45620. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9856. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9630. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8741. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5620. sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Güllüce Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Demirdere Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Doğancı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Eskibalçık Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }




            #endregion



            #endregion

            #region Gaziantep ili sokakları
            #region Islahiye Sokakları
            if (cmb_mahalle.Text == "Alaca Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Altınüzüm Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Bayraktepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Çamlıca Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Karacaören Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
         

            #endregion

            #region Nizip Sokakları
            if (cmb_mahalle.Text == "Dayıdağı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5210. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3692. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8740. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Fevzi Paşa Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8510 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "11205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "15420 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "23502 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Fırat Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8521 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7841 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Gülkaya Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7412 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7415 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Kaleköy Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7965 sk." });
                cmb_sokak.DataSource = sokaklar;
            }



            #endregion

            #region Nurdağı Sokakları

            if (cmb_mahalle.Text == "Aslanlı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Belpınar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Nogaylar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Sakçagözü Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Yaylacık Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Şahinbey Sokakları
            if (cmb_mahalle.Text == "60.yıl Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2026 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2310 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2104 sk." });
                cmb_sokak.DataSource = sokaklar;
            }


            else if (cmb_mahalle.Text == "Alleben Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3850 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Şehit Kamil Sokakları
            if (cmb_mahalle.Text == "Bağbaşı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45620. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9856. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9630. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8741. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5620. sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Batıkent Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Durnalık Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Güvenevler Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6541 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8450 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "1200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "1203 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Işıklı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8502 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "920 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "1204 sk." });
                cmb_sokak.DataSource = sokaklar;
            }




            #endregion



            #endregion

            #region İstanbul ili sokakları
            #region Ataşehir Sokakları
            if (cmb_mahalle.Text == "Ferhatpaşa Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "İçerenköy Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "İnönü Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Kayışdağı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Yeni Çamlıca Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }


            #endregion

            #region Beşiktaş Sokakları
            if (cmb_mahalle.Text == "Akat Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5210. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3692. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8740. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Balmumcu Paşa Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8510 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "11205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "15420 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "23502 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Dikilitaş Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8521 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7841 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Etiler Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7412 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7415 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Gayrettepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7965 sk." });
                cmb_sokak.DataSource = sokaklar;
            }



            #endregion

            #region Kadıköy Sokakları

            if (cmb_mahalle.Text == "Acıbadem Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Caferağa Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Dumlupınar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Eğitim Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Fikirtepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Şişli Sokakları
            if (cmb_mahalle.Text == "Esentepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2026 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2310 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2104 sk." });
                cmb_sokak.DataSource = sokaklar;
            }


            else if (cmb_mahalle.Text == "Fulya Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3850 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Bakırköy Sokakları
            if (cmb_mahalle.Text == "Cevizlik Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45620. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9856. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9630. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8741. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5620. sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Kartaltepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Osmaniye Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Şenlikköy Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3700 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3650 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Yeşilköy Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "741 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "985 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "1520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "652 sk." });
                cmb_sokak.DataSource = sokaklar;
            }






            #endregion



            #endregion

            #region İzmir ili sokakları
            #region Balçova Sokakları
            if (cmb_mahalle.Text == "Bahçelerarası Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Çetin Emeç Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Korutürk Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Onur Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Teleferik Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }


            #endregion

            #region Bayraklı Sokakları
            if (cmb_mahalle.Text == "Adalet Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5210. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3692. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8740. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Çay Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8510 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "11205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "15420 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "23502 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Manavkuyu Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8521 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7841 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Mansuroğlu Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7412 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7415 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Osmangazi Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7965 sk." });
                cmb_sokak.DataSource = sokaklar;
            }



            #endregion

            #region Çeşme Sokakları

            if (cmb_mahalle.Text == "Alaçatı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Dalyan Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Germiyan Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Karaköy Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Yalı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Foça Sokakları
            if (cmb_mahalle.Text == "Hacıveli Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2026 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2310 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2104 sk." });
                cmb_sokak.DataSource = sokaklar;
            }


            else if (cmb_mahalle.Text == "İlpınar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3850 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Kozbeyli Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "854 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "458 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "632 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "231 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Yenibağarası Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "874 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "320 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "560 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "785 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Yeniköy Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "741 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "320 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "235 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "236 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Menemen Sokakları
            if (cmb_mahalle.Text == "Ahıhıdır Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45620. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9856. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9630. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8741. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5620. sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Buruncuk Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Esatpaşa Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Gölcük Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3700 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3650 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Irmak Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "741 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "985 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "1520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "652 sk." });
                cmb_sokak.DataSource = sokaklar;
            }






            #endregion




            #endregion

            #region Kocaeli ili sokakları
            #region Çayırova Sokakları
            if (cmb_mahalle.Text == "Akse Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Atatürk Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Emek Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "İnönü Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Özgürlük Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }


            #endregion

            #region Darıca Sokakları
            if (cmb_mahalle.Text == "Bağlarbaşı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5210. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3692. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8740. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Bayramoğlu Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8510 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "11205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "15420 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "23502 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Kazımkarabekir Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8521 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7841 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Nenehatun Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7412 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7415 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Osmangazi Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7965 sk." });
                cmb_sokak.DataSource = sokaklar;
            }



            #endregion

            #region Derince Sokakları

            if (cmb_mahalle.Text == "Çavuşlu Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Çenedağ Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Deniz Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "İbni Sina Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Sım Paşa Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Gebze Sokakları
            if (cmb_mahalle.Text == "Arapçeşme Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2026 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2310 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2104 sk." });
                cmb_sokak.DataSource = sokaklar;
            }


            else if (cmb_mahalle.Text == "Barış Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3850 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Güzeller Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "854 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "458 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "632 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "231 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Köşklü Çeşme Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "874 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "320 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "560 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "785 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Mevlana Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "741 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "320 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "235 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "236 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region İzmit Sokakları
            if (cmb_mahalle.Text == "Akçakoca Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45620. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9856. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9630. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8741. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5620. sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Çukurbağ Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Doğan Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Kocatepe Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3700 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3650 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Körfez Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "741 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "985 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "1520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "652 sk." });
                cmb_sokak.DataSource = sokaklar;
            }






            #endregion




            #endregion

            #region Samsun ili sokakları
            #region Alaçam Sokakları
            if (cmb_mahalle.Text == "Akbulut Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Göçkün Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Umutlu Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Yeşilköy Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Yukanelma Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }


            #endregion

            #region Atakum Sokakları
            if (cmb_mahalle.Text == "Aksu Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5210. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3692. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8740. sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Büyükoyumca Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8510 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "11205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "15420 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "23502 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Çobanlı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8521 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7841 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Denizevleri Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7412 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7415 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "4620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Esenevler Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7965 sk." });
                cmb_sokak.DataSource = sokaklar;
            }



            #endregion

            #region Bafra Sokakları

            if (cmb_mahalle.Text == "Adaköy Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "54202 sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Balıklar Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "62500 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "74201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "88960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "78410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Elifli Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "6520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5200 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Gerzeliler Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45602 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38692 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "25360 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "47500 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            else if (cmb_mahalle.Text == "Kelikler Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2052 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7410 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region ilkadım Sokakları
            if (cmb_mahalle.Text == "Ahulu Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2026 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2310 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "2104 sk." });
                cmb_sokak.DataSource = sokaklar;
            }


            else if (cmb_mahalle.Text == "Çatalarmut Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3205 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3850 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3620 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Hançerli Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "854 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "458 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "632 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "231 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Kalkancı Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "874 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "320 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "560 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "785 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Liman Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "741 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "320 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "235 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "236 sk." });
                cmb_sokak.DataSource = sokaklar;
            }

            #endregion

            #region Terme Sokakları
            if (cmb_mahalle.Text == "Akçay Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "7850. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45620. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9856. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "9630. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "8741. sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "5620. sk." });

                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Altunlu Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "45038 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48120 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "38960 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "49025 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Dereyol Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "37600 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "22054 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "36480 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "48700 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "İlimdağ Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3700 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3201 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "3650 sk." });
                cmb_sokak.DataSource = sokaklar;
            }
            else if (cmb_mahalle.Text == "Sarayköy Mah.")
            {
                sokaklar.Add(new Sokaklar
                { sokakAdi = "741 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "985 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "1520 sk." });
                sokaklar.Add(new Sokaklar
                { sokakAdi = "652 sk." });
                cmb_sokak.DataSource = sokaklar;
            }






            #endregion




            #endregion
            #endregion







        }

        private void btn_onlineKayit_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_tcKimlikNo.Text) && !string.IsNullOrEmpty(txt_müsteriAdi.Text) &&
                !string.IsNullOrEmpty(txt_müsteriSoyadi.Text) && !string.IsNullOrEmpty(txt_telefon.Text) &&
                !string.IsNullOrEmpty(cmb_il.Text) && !string.IsNullOrEmpty(cmb_ilce.Text) &&
                !string.IsNullOrEmpty(cmb_mahalle.Text) && !string.IsNullOrEmpty(cmb_sokak.Text) &&
                !string.IsNullOrEmpty(cmb_icKapiNo.Text))
                
            {

                OnlineYiyecekSiparisEkrani siparisEkranimGöster = new OnlineYiyecekSiparisEkrani();
                siparisEkranimGöster.Show();
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }



        }
     
    }
}


