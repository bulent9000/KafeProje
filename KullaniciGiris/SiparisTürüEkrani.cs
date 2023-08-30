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
    public partial class SiparisTürüEkrani : Form
    {
        public SiparisTürüEkrani()
        {
            InitializeComponent();
        }

        private void btn_masadaSiparis_Click(object sender, EventArgs e)
        {
            MasaSecimEkrani masaSecimEkran = new MasaSecimEkrani();
            masaSecimEkran.Show();
            
        }

        private void btn_onlineSiparis_Click(object sender, EventArgs e)
        {
            OnlineSiparisMüsteriKayitEkrani ekran = new OnlineSiparisMüsteriKayitEkrani();
           
           
            ekran.Show();
            this.Close();


        }
    }
}
