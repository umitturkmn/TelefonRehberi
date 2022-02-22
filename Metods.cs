using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class Metods : Program
    {
        
        public List<Kisiler> Rehber = new List<Kisiler>();
        public void NumaraKaydetme()
        {
            string isim = StringControl("İsim giriniz: ");
            string soyisim = StringControl("Soyİsim giriniz: ");
            
            while (true)
            {
                string number = NumaraKontrol("Başında 0 olacak şekilde numara giriniz: ");
                    if(number.Length ==11 && number.StartsWith("0") == true)
                    {
                        Console.WriteLine("Numaranız Kaydedilmiştir.");
                        Rehber.Add(new Kisiler(isim,soyisim,number));
                        break;
                    } else 
                    {
                        Console.WriteLine("Eksik tuşladınız. Tekrar deneyin.");
                        continue;
                    }
            }
        }

        public void NumaraSilme()
        {
            string isim = StringControl("Lütfen Silmek İstediğiniz Kişinin Adını Giriniz: ");
            string soyisim = StringControl("Soyadını Giriniz: ");
            bool kontrol = false;
            int y = 0;
            Kisiler kisi;
            foreach (Kisiler x in Rehber)
            {

                if (isim == x.Ad && soyisim == x.Soyad)
                {
                    Console.WriteLine("Silmek istediğiniz Kişinin Adı:{0} ",x.Ad);
                    Console.WriteLine("Silmek istediğiniz Kişinin Soyadı:{0} ", x.Soyad);
                    Console.WriteLine("Silmek istediğiniz Kişinin Telefon Numarası:{0} ",x.TelNo);
                    Console.WriteLine("-------------------------------------------------");
                    kisi = x;
                    y = Rehber.IndexOf(x);
                    kontrol = true;
                }
            }
            if (kontrol == true)
            {
                    
                    string secim = StringControl("Silmek istediğinize emin misiniz?(E/H)");
                    switch (secim.ToUpper())
                    {
                        case "E":
                            Console.WriteLine("Kişi Silinmiştir.");
                            Console.WriteLine("-----------------");
                            Rehber.RemoveAt(y);
                            break;
                        case "H":
                            Console.WriteLine("İşlem iptal edilmiştir.");
                            break;
                        default:
                            break;
                    }
            } else
            {
                Console.WriteLine("Aradığınız kişi bulunamadı.");
            }

        }
        public static string StringControl(string text)
        {
            string str = "";
            bool control = true;
            int num = 1;
            while (control)
            {
                Console.Write(text);
                str = FirstLetterGrowUp(Console.ReadLine());
                string str2 = "1234567890!^+-*/?*.,#%&:;()={}[]-_\"<>'\\~@|";
                foreach (char item in str)
                {
                    if (str2.Contains(str)) 
                    {
                        Console.WriteLine("Hatalı İsim Girdiniz Tekrar Deneyiniz.");
                        break;
                    }
                    if (str.Length == num)
                    {
                        control = false;
                        break;
                    }
                    num++;
                }
            }
            return str;
        }
        public static string FirstLetterGrowUp(string veri)
        {
            if (veri.Length > 0)
            {
                veri = veri.Substring(0, 1).ToUpper() + veri.Substring(1).ToLower();
                return veri;
            }
            return veri;

        }
        public static string NumaraKontrol(string text)
        {
            string str = "";
            bool control = true;
            int num = 1;
            while (control)
            {
                Console.Write(text);
                str = FirstLetterGrowUp(Console.ReadLine());
                string str2 = "qwertyuıopğüişlkjhgfdsazxcvbnmöç!^+-*/?*.,#%&:;()={}[]-_\"<>'\\~@|";
                foreach (char item in str)
                {
                    if (str2.Contains(str)) 
                    {
                        Console.WriteLine("Hatalı İsim Girdiniz Tekrar Deneyiniz.");
                        break;
                    }
                    if (str.Length == num)
                    {
                        control = false;
                        break;
                    }
                    num++;
                }
            }
            return str;
        }

        
    }
}
