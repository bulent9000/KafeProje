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
    public partial class YetkiliGirisEkrani : Form
    {
        public YetkiliGirisEkrani()
        {
            InitializeComponent();
        }

        private void btn_yetkiliGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_kullaniciAdi.Text) && !string.IsNullOrEmpty(txt_sifre.Text))
            {

                SistemServices yetkiliGiris = new SistemServices();
                int yetkiliID = yetkiliGiris.kullaniciKontrol(txt_kullaniciAdi.Text, txt_sifre.Text);
                if (yetkiliID > 0)
                {
                    MessageBox.Show("Giriş Başarılı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    YetkiliAnaForm yetkiliAnaform = new YetkiliAnaForm();
                    yetkiliAnaform.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Hatalı bilgi girdiniz", "Bidirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            else
            {
                MessageBox.Show("Lütfen alanları eksiksiz doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
}
