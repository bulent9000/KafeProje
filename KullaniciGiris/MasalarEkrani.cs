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
    public partial class MasaSecimEkrani : Form
    {
        string masaNo;
        MüsteriSiparisKayitEkrani kayitEkraniGöster;
        public MasaSecimEkrani()
        {
            InitializeComponent();
        }

       

        private void renkDegis(object sender)
        {

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Red":
                    ctrl.BackColor = Color.LimeGreen;
                    break;
                case "LimeGreen":
                    ctrl.BackColor = Color.Red;
                    break;

               
            }
        }

        private void masa1_Click(object sender, EventArgs e)
        {
            masaNo = masa1.Text;
            masaNo=masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();

        }

        private string masaNoAl(string masaNumarasi)
        {
            if (masaNumarasi.Length == 6)   //masa numarası tek haneli ise masa 1
            {
                char deger = masaNumarasi[5];
                masaNo = Convert.ToString(deger);
                return masaNo;

            }
            else if (masaNumarasi.Length == 7)   //masa numarası iki haneli ise masa 17
            {
                char deger1 = masaNumarasi[5];
                string ikiHane1 = Convert.ToString(deger1);

                char deger2 = masaNumarasi[6];
                string ikiHane2 = Convert.ToString(deger2);

                masaNo = ikiHane1 + ikiHane2;
                return masaNo;
            }
            return masaNo; 
        }

        #region Masalar

        private void masa2_Click(object sender, EventArgs e)
        {
            masaNo = masa2.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa3_Click(object sender, EventArgs e)
        {
            masaNo = masa3.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa4_Click(object sender, EventArgs e)
        {
            masaNo = masa4.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa5_Click(object sender, EventArgs e)
        {
            masaNo = masa5.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa6_Click(object sender, EventArgs e)
        {
            masaNo = masa6.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa7_Click(object sender, EventArgs e)
        {
            masaNo = masa7.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa8_Click(object sender, EventArgs e)
        {
            masaNo = masa8.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa9_Click(object sender, EventArgs e)
        {
            masaNo = masa9.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa10_Click(object sender, EventArgs e)
        {
            masaNo = masa10.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa11_Click(object sender, EventArgs e)
        {
            masaNo = masa11.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa12_Click(object sender, EventArgs e)
        {
            masaNo = masa12.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa13_Click(object sender, EventArgs e)
        {
            masaNo = masa13.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa14_Click(object sender, EventArgs e)
        {
            masaNo = masa14.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa15_Click(object sender, EventArgs e)
        {
            masaNo = masa15.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa16_Click(object sender, EventArgs e)
        {
            masaNo = masa16.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa17_Click(object sender, EventArgs e)
        {
            masaNo = masa17.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa18_Click(object sender, EventArgs e)
        {
            masaNo = masa18.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa19_Click(object sender, EventArgs e)
        {
            masaNo = masa19.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa20_Click(object sender, EventArgs e)
        {
            masaNo = masa20.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa21_Click(object sender, EventArgs e)
        {
            masaNo = masa21.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa22_Click(object sender, EventArgs e)
        {
            masaNo = masa22.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa23_Click(object sender, EventArgs e)
        {
            masaNo = masa23.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa24_Click(object sender, EventArgs e)
        {
            masaNo = masa24.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa25_Click(object sender, EventArgs e)
        {
            masaNo = masa25.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa26_Click(object sender, EventArgs e)
        {
            masaNo = masa26.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa27_Click(object sender, EventArgs e)
        {
            masaNo = masa27.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa28_Click(object sender, EventArgs e)
        {
            masaNo = masa28.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa29_Click(object sender, EventArgs e)
        {
            masaNo = masa29.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }

        private void masa30_Click(object sender, EventArgs e)
        {
            masaNo = masa30.Text;
            masaNo = masaNoAl(masaNo);
            renkDegis(sender);
            kayitEkraniGöster = new MüsteriSiparisKayitEkrani();
            ((Label)kayitEkraniGöster.Controls["lbl_masaNumarasi"]).Text = masaNo;
            kayitEkraniGöster.Show();
        }
        #endregion
    }

}
