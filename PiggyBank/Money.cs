using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Money
    {
        public string Isim { get; set; }

        private double _hacim;
        public double Hacim
        {
            get { return _hacim; }
            set { _hacim = value; }
        }

        private decimal _deger;
        public decimal Deger
        {
            get { return _deger; }

            set { _deger = value; }
        }
        public static double piSayisi = 3.14;

        private string _tur;
        public string Tur
        {
            get { return _tur; }
            set { _tur = value; }
        }
        double fazladanKapladigiHacim;
        public double HacimHesapla(string isim)
        {
            switch (isim)
            {
                case "Bir Kuruş":
                    hacim = piSayisi * (1.7 / 2) * (1.7 / 2) * 0.165; //cm3 cinsinden
                    break;
                case "Beş Kuruş":
                    hacim = piSayisi * (1.7 / 2) * (1.7 / 2) * 0.17; //cm3 cinsinden
                    break;
                case "On Kuruş":
                    hacim = piSayisi * (1.925 / 2) * (1.925 / 2) * 0.17; //cm3 cinsinden
                    break;
                case "Yirmibeş Kuruş":
                    hacim = piSayisi * (2.15 / 2) * (2.15 / 2) * 0.19; //cm3 cinsinden
                    break;
                case "Elli Kuruş":
                    hacim = piSayisi * (2.385 / 2) * (2.385 / 2) * 0.195; //cm3 cinsinden
                    break;
                case "Bir TL":
                    hacim = piSayisi * (2.615 / 2) * (2.615 / 2) * 0.195; //cm3 cinsinden
                    break;
                case "Beş TL":
                    hacim = 6.4 * 3.25 * 1; //cm3 cinsinden
                    break;
                case "On TL":
                    hacim = 6.4 * 3.4 * 1; //cm3 cinsinden
                    break;
                case "Yirmi TL":
                    hacim = 6.8 * 3.55 * 1; //cm3 cinsinden
                    break;
                case "Elli TL":
                    hacim = 6.8 * 3.7 * 1; //cm3 cinsinden
                    break;
                case "Yüz TL":
                    hacim = 7.2 * 3.85 * 1; //cm3 cinsinden
                    break;
                case "İkiyüz TL":
                    hacim = 7.2 * 4 * 1; //cm3 cinsinden
                    break;

                default:
                    break;
            }
            
            Random random = new Random();
            _salla = Convert.ToByte(random.Next(25, 76));
            fazladanKapladigiHacim = hacim + hacim * ((double)_salla / 100);
            return fazladanKapladigiHacim;
        }

        private byte _salla;
        private byte Salla
        {
            get { return _salla; }

        }

        double hacim;
        public double GercekHacim
        {
            get { return hacim; }

        }

        public override string ToString()
        {
            return Isim + " >>>> " +Deger +" TL" + " >>>> " +  " Tür: " + Tur;
        }
    }
}
