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
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }

        private void btn_yetkiliGiris_Click(object sender, EventArgs e)
        {
            YetkiliGirisEkrani yetkiliGiris = new YetkiliGirisEkrani();
            yetkiliGiris.Show();
            this.Hide();
            


        }

        private void btn_müsteriGiris_Click(object sender, EventArgs e)
        {
            
           YetkiliAnaForm yetkiliAnaFormum = new YetkiliAnaForm();
           Button btnMüsteriBilgi =(Button)yetkiliAnaFormum.Controls["btn_raporlar"];
           Button btnSaticiBilgisi = (Button)yetkiliAnaFormum.Controls["btn_saticiBilgisi"];

            btnMüsteriBilgi.Enabled = false;
            btnSaticiBilgisi.Enabled = false;

            yetkiliAnaFormum.Show();

        }
    }
}
