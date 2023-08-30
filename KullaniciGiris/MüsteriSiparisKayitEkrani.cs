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
    public partial class MüsteriSiparisKayitEkrani : Form
    {
        public MüsteriSiparisKayitEkrani()
        {
            InitializeComponent();
        }

        private void btn_müsteriKayitEkrani_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_müsteriAdi.Text))
            {
                YiyecekSiparisEkrani yiyecekEkrani = new YiyecekSiparisEkrani();
                yiyecekEkrani.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Lütfen adınızı giriniz","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }




        }

        private void MüsteriSiparisKayitEkrani_Load(object sender, EventArgs e)
        {
          
            dtpSiparisZamani.Value = DateTime.Now;

        }
    }
}
