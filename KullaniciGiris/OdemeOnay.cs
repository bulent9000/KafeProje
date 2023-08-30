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
    public partial class OdemeOnay : Form
    {
        public OdemeOnay()
        {
            InitializeComponent();
        }

        private void btn_koduGönder_Click(object sender, EventArgs e)
        {

            if (msk_kod.Text == "123456")
            {

                MessageBox.Show("Ödemeniz başarıyla tamamlanmıştır.Bizi tercih ettiğiniz için teşekkür ederiz");
            }
            else
            {
                MessageBox.Show("Ödemeniz yapılamamıştır");
            }


        }
    }
}
