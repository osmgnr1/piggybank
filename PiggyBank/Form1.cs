using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class Form1 : Form
    {
        List<string> paralar = new List<string>()
        {
            "---Para seç---", "Bir Kuruş", "Beş Kuruş", "On Kuruş", "Yirmibeş Kuruş", "Elli Kuruş", "Bir TL", "Beş TL", "On TL", "Yirmi TL", "Elli TL", "Yüz TL", "İkiyüz TL"
        };

        public Form1()
        {
            InitializeComponent();
            foreach (var item in paralar)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;

        }
        decimal toplam = 0;
        double hacim = 0;
        MoneyBox moneyBox = new MoneyBox();
        List<Money> kumbara = new List<Money>();
        public static bool katlandiMi = false;
        public bool kirildiMi = false;
        
        private void btnParaEkle_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem=="---Para seç---")
            {
                MessageBox.Show("Para seç!!!");
                return;
            }
            if (hacim<MoneyBox.kpst)
            {
                string secilen = comboBox1.SelectedItem.ToString();
                Money money = new Money();
                switch (secilen)
                {
                    case "Bir Kuruş":
                        money.Isim = "Bir Kuruş";
                        money.Tur = "Coin";
                        money.Deger = Convert.ToDecimal(0.01);
                        money.Hacim = money.HacimHesapla("Bir Kuruş");
                        break;
                    case "Beş Kuruş":
                        money.Isim = "Beş Kuruş";
                        money.Tur = "Coin";
                        money.Deger = Convert.ToDecimal(0.05);
                        money.Hacim = money.HacimHesapla("Beş Kuruş");
                        break;
                    case "On Kuruş":
                        money.Isim = "On Kuruş";
                        money.Tur = "Coin";
                        money.Deger = Convert.ToDecimal(0.10);
                        money.Hacim = money.HacimHesapla("On Kuruş");
                        break;
                    case "Yirmibeş Kuruş":
                        money.Isim = "YirmiBeş Kuruş";
                        money.Tur = "Coin";
                        money.Deger = Convert.ToDecimal(0.25);
                        money.Hacim = money.HacimHesapla("Yirmibeş Kuruş");
                        break;
                    case "Elli Kuruş":
                        money.Isim = "Elli Kuruş";
                        money.Tur = "Coin";
                        money.Deger = Convert.ToDecimal(0.50);
                        money.Hacim = money.HacimHesapla("Elli Kuruş");
                        break;
                    case "Bir TL":
                        money.Isim = "Bir TL";
                        money.Tur = "Coin";
                        money.Deger = Convert.ToDecimal(1);
                        money.Hacim = money.HacimHesapla("Bir TL");
                        break;
                    case "Beş TL":
                        if (katlandiMi==true)
                        {
                            money.Isim = "Beş TL";
                            money.Tur = "Banknote";
                            money.Deger = Convert.ToDecimal(5);
                            money.Hacim = money.HacimHesapla("Beş TL");
                            katlandiMi = false;
                        }
                        else
                        {
                            MessageBox.Show("Parayı katlamadan kumbaraya atamazsınız.\nParayı katlayınız.");
                            return;
                        }
                        break;
                    case "On TL":
                        if (katlandiMi == true)
                        {
                            money.Isim = "On TL";
                            money.Tur = "Banknote";
                            money.Deger = Convert.ToDecimal(10);
                            money.Hacim = money.HacimHesapla("On TL");
                        }
                        else
                        {
                            MessageBox.Show("Parayı katlamadan kumbaraya atamazsınız.\nParayı katlayınız.");
                            return;
                        }
                        break;
                    case "Yirmi TL":
                        if (katlandiMi == true)
                        {
                            money.Isim = "Yirmi TL";
                            money.Tur = "Banknote";
                            money.Deger = Convert.ToDecimal(20);
                            money.Hacim = money.HacimHesapla("Yirmi TL");
                        }
                        else
                        {
                            MessageBox.Show("Parayı katlamadan kumbaraya atamazsınız.\nParayı katlayınız.");
                            return;
                        }
                        break;
                    case "Elli TL":
                        if (katlandiMi == true)
                        {
                            money.Isim = "Elli TL";
                            money.Tur = "Banknote";
                            money.Deger = Convert.ToDecimal(50);
                            money.Hacim = money.HacimHesapla("Elli TL");
                        }
                        else
                        {
                            MessageBox.Show("Parayı katlamadan kumbaraya atamazsınız.\nParayı katlayınız.");
                            return;
                        }
                        break;
                    case "Yüz TL":
                        if (katlandiMi == true)
                        {
                            money.Isim = "Yüz TL";
                            money.Tur = "Banknote";
                            money.Deger = Convert.ToDecimal(100);
                            money.Hacim = money.HacimHesapla("Yüz TL");
                        }
                        else
                        {
                            MessageBox.Show("Parayı katlamadan kumbaraya atamazsınız.\nParayı katlayınız.");
                            return;
                        }
                        break;
                    case "İkiyüz TL":
                        if (katlandiMi == true)
                        {
                            money.Isim = "İkiyüz TL";
                            money.Tur = "Banknote";
                            money.Deger = Convert.ToDecimal(200);
                            money.Hacim = money.HacimHesapla("İkiyüz TL");
                        }
                        else
                        {
                            MessageBox.Show("Parayı katlamadan kumbaraya atamazsınız.\nParayı katlayınız.");
                            return;
                        }
                        break;
                    default:
                        break;
                }

                if (hacim+money.Hacim>MoneyBox.kpst)
                {
                    MessageBox.Show("Kumbara kapasitesi aşılıyor...Kumbarayı sallayınız..Salladığınız halde kapasite uyarısı veriyorsa daha küçük paralar deneyiniz...");
                }
                else
                {
                    kumbara.Add(money);
                    hacim += money.Hacim;
                    toplam += money.Deger;
                    lblTutar.Text = toplam.ToString("#.##") + " TL";
                    lblHacim.Text = hacim.ToString("#.##") + " cm3";
                    moneyBox.Money = kumbara;
                }
            }
            else
            {
                MessageBox.Show("Kumbara kapasitesi aşılamaz..");
            }
            katlandiMi = false;
        }

        int kirilmaSayisi;
        List<Money> moneyKirilan = new List<Money>();
        private void btnKir_Click(object sender, EventArgs e)
        {
            if (toplam>0)
            {
                kirilmaSayisi++;
                moneyKirilan = moneyBox.Break(moneyBox.Money);
                ListeyiGetir();
                MessageBox.Show($"Kumbara kırıldı..\nToplam tutar: {toplam} TL");
                btnKir.Enabled = false;
                btnParaEkle.Enabled = false;
                btnSalla.Enabled = false;
                btnKagitParaKatla.Enabled = false;
                katlandiMi = false;
                toplam = 0;
                hacim = 0;
                kirildiMi = true;

            }
            else
            {
                MessageBox.Show("Kumbara içinde para yok. Kırmana da gerek yok!!!");;
            }
        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            if ( kirilmaSayisi<2)
            {
                KumbaraYapistir();
                btnParaEkle.Enabled = true;
                btnSalla.Enabled = true;
                btnKir.Enabled = true;
                kirildiMi = false;
            }
            else
            {
                MessageBox.Show("Kumbara ikinci defa kırıldığından kullanılamaz halde..Tekrar yapıştırılamaz.");
                btnSalla.Enabled = false;
                btnKir.Enabled = false;
                btnParaEkle.Enabled = false;
                btnKagitParaKatla.Enabled = false;
            }
            katlandiMi = false;
        }

        public void ListeyiGetir()
        {
            lstParalar.Items.Clear();
            foreach (Money item in moneyKirilan)
            {
                lstParalar.Items.Add(item);
            }
        }

        public void KumbaraYapistir()
        {
            if (kirildiMi==true)
            {
                kumbara.Clear();
                moneyBox.Money.Clear();
                moneyKirilan.Clear();
                lstParalar.Items.Clear();
                MessageBox.Show("Kumbara yapıştırıldı..\nBakiye sıfırlandı..");
                lblTutar.Text = 0.ToString();
                lblHacim.Text = 0.ToString();
                comboBox1.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show("Kumbara kırık değil. Kırmadan yapıştıramam!!!");
            }

        }

        private void btnSalla_Click(object sender, EventArgs e)
        {
            if (toplam>0)
            {
                FormTitret();
                hacim = 0;
                foreach (Money item in kumbara)
                {
                    hacim += item.GercekHacim * 1.25;
                }

                lblHacim.Text = hacim.ToString("#.##") + " cm3";
            }
            else
            {
                MessageBox.Show("Kumbara içinde para yok. Sallamana gerek yok!!!");
            }
            katlandiMi = false;
        }

        private void btnKagitParaKatla_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "---Para seç---")
            {
                MessageBox.Show("Para seç!!!");
                return;
            }
            else
            {
                katlandiMi = true;
                MessageBox.Show("Para 4'e katlandı.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen=comboBox1.SelectedItem.ToString();
            if (secilen == "Bir Kuruş" || secilen == "Beş Kuruş" || secilen == "On Kuruş" || secilen == "Yirmibeş Kuruş" || secilen == "Elli Kuruş" || secilen == "Bir TL")
            {
                btnKagitParaKatla.Enabled = false;
            }
            else if (secilen=="---Para seç---")
            {
                btnKagitParaKatla.Enabled = false;
            }
            else
            {
                btnKagitParaKatla.Enabled = true;
            }

        }

        Random r = new Random();
        int x, y;
        public void FormTitret()
        {
            int c = 0;
            Point l = this.Location;

            while (c < 50)
            {
                int x = r.Next(1, 10);
                int y = r.Next(1, 10);
                Location = new Point(l.X + x, l.Y + y);
                Thread.Sleep(20); // bu çalışan kod parçacığının belirtilen bir süre duraklatılmasını sağlar.
                c++;
            }
            this.Location = l;

        }
    }
}
