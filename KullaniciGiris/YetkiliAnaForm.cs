using kafe.core.BusinessLogicLayer;
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
    public partial class YetkiliAnaForm : Form
    {
        SistemServices Bll;
        public YetkiliAnaForm()
        {
            InitializeComponent();
            Bll = new SistemServices();
        }

        private void btn_siparisler_Click(object sender, EventArgs e)
        {
            SiparisTürüEkrani siparisTürüEkran = new SiparisTürüEkrani();
            siparisTürüEkran.Show();
            this.Hide();


        }

        private void btn_raporlar_Click(object sender, EventArgs e)
        {

           //Bu kısma sql de yazılan sorgular eklenip DLL aracılığıyla sorgular çekilecek
            Bll.yiyecekListe();
            Bll.icecekListele();
            Bll.tatliListele();

            //Raporlar form sayfası oluşturulup orada sql den veriler çekilecek

        }
    }
}
