using HamburgerProject.Concrete;
using HamburgerProject.Enums;
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
    public partial class SiparisOlusturEkrani : Form
    {
        public SiparisOlusturEkrani()
        {
            InitializeComponent();
        }

        List<Siparis> OnaylanmamısSiparisler = new List<Siparis>();

        decimal genelToplam = 0; // toplanan siparisleri genel toplamda toplamak icin

        private void SiparisOlusturEkrani_Load(object sender, EventArgs e)
        {

            foreach (Menu menu in AnaEkran.Menuler)
            {
                cboxMenu.Items.Add(menu);
            }
            foreach (EkstraMalzeme ekstra in AnaEkran.EkstraMalzemeler)
            {
                CheckBox cbox = new CheckBox();
                cbox.Tag = ekstra;
                cbox.Text = ekstra.Ad;

                flpEkstraMalzemeler.Controls.Add(cbox);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            siparis.Menu = (Menu)cboxMenu.SelectedItem;

            foreach (CheckBox cbox in flpEkstraMalzemeler.Controls)
            {
                if (cbox.Checked)
                {
                    siparis.EkstraMalzemeler.Add((EkstraMalzeme)cbox.Tag);
                }
            }

            if (rbKucuk.Checked)
            {
                siparis.Boy = Boy.Kucuk;
            }
            else if (rbOrta.Checked)
            {
                siparis.Boy = Boy.Orta;
            }
            else siparis.Boy = Boy.Buyuk;



            siparis.Adet = (int)nudAdet.Value;

            OnaylanmamısSiparisler.Add(siparis);

            lboxSiparisler.Items.Add(siparis);

            genelToplam += siparis.Toplam;

            lblToplam.Text = genelToplam.ToString("C2");

            Helper.Temizle(this.Controls);

        }

        private void btnSiparisOnay_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show("Siparişi Onaylıyormusunuz ?", "Onay Mesajı",MessageBoxButtons.OKCancel);

            if (dr == DialogResult.Cancel)
                return;

            else if (dr == DialogResult.OK)
            {
                AnaEkran.Siparisler.AddRange(OnaylanmamısSiparisler);
            }

            lboxSiparisler.Items.Clear();

            OnaylanmamısSiparisler.Clear();

            genelToplam = 0;

            lblToplam.Text = genelToplam.ToString("C2");

            
        }
    }
}
