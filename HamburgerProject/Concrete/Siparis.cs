using HamburgerProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerProject.Concrete
{
    public class Siparis
    {

        public Siparis()
        {
            EkstraMalzemeler = new List<EkstraMalzeme> { }; //null reference hatasını düzeltti
        }


        public Menu Menu { get; set; }

        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }

        public Boy Boy { get; set; }

        public int Adet { get; set; }



        public decimal Toplam               // olusturduğum siparişin toplam fiyatı
        {
            get                             // sadece get metodunu ihtiyacım var dışardan birşey set edilemesin istiyorum
            {
                decimal toplam = 0;

                if (Boy == Boy.Orta)
                {
                    toplam += Menu.Fiyat * 1.1m; //1.1m decimal olduğunu belirttik
                    
                }
                else if (Boy == Boy.Buyuk)
                {
                    toplam += Menu.Fiyat * 1.2m;
                    
                }
                else
                {
                    toplam = Menu.Fiyat;
                    
                }

                toplam += ToplamEkstraMalzemeFiyatiGetir();

                toplam *= Adet;

                return toplam;

            }

        }


        public decimal ToplamEkstraMalzemeFiyatiGetir() // EK MALZEME FİYATLARINI TOPLAYAN METOD
        {
            decimal toplam = 0;

            foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
            {
                toplam += ekstra.Fiyat;
            }
            return toplam;
        } 





        public override string ToString()
        {
            string bilgi = string.Empty;

            bilgi += Adet + " Adet " + Menu + " " + Boy + " ";

            string ekstraMalzemeIsimleri = EkstraMalzemeleriGetir();

            bilgi += ekstraMalzemeIsimleri;

            bilgi += " => " + Toplam;

            return bilgi;
        }

        private string EkstraMalzemeleriGetir()
        {
            string ekstraMalzemeler = string.Empty;

            foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
            {

                ekstraMalzemeler += ekstra.Ad + ", ";
            }

            return ekstraMalzemeler;
        }

    }
}
