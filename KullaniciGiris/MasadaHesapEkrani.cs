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
    public partial class MasadaHesapEkrani : Form
    {
        SistemServices Bll;
        

        public MasadaHesapEkrani()
        {
            InitializeComponent();
            Bll = new SistemServices();
        }
        


        private void MasadaHesapEkrani_Load(object sender, EventArgs e)
        {
            Form ekranim = (Form)Application.OpenForms["MüsteriSiparisKayitEkrani"];
            lbl_siparisVerenAd.Text = ((TextBox)ekranim.Controls["txt_müsteriAdi"]).Text;
            lbl_masaNo.Text = ((Label)ekranim.Controls["lbl_masaNumarasi"]).Text;
            lbl_siparisTarihim.Text = ((DateTimePicker)ekranim.Controls["dtpSiparisZamani"]).Text;
            dgw_yiyeceklerListesi.DataSource=Bll.yiyecekListe();
            dgw_iceceklerListesi.DataSource = Bll.icecekListele();
            dgw_tatlilarListesi.DataSource = Bll.tatliListele();
                

           

          

            
        }

     

    }

}