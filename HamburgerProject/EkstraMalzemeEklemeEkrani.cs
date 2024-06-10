using HamburgerProject.Concrete;
using HamburgerProject.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerProject
{
    public partial class EkstraMalzemeEklemeEkrani : Form
    {
        public EkstraMalzemeEklemeEkrani()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string EkMalzAd = txtAd.Text;
            decimal EkMalzfiyat = nudFiyat.Value;

            if (string.IsNullOrEmpty(EkMalzAd) || EkMalzfiyat <= 0 )
            {
                MessageBox.Show("Menu Adı boş olamaz\nFiyat 0 yada daha az olamaz");
                return;
                
            }

            EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();

            ekstraMalzeme.Ad = EkMalzAd;
            ekstraMalzeme.Fiyat = EkMalzfiyat;

            AnaEkran.EkstraMalzemeler.Add(ekstraMalzeme);

            Helper.Temizle(this.Controls);
            

        }
    }
}
