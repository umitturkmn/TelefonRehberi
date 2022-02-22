using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class Program
    {
        static Metods metod = new Metods();
        static void Main(string[] args)
        {
            
            SahteVeriEkle();
            Console.WriteLine("Telefon Rehberinize Hoşgeldiniz...");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("******************************************* ");
            Console.WriteLine("(1) Yeni Numara Kaydetmek "); //
            Console.WriteLine("(2) Varolan Numarayı Silmek "); //
            Console.WriteLine("(3) Varolan Numarayı Güncelleme ");
            Console.WriteLine("(4) Rehberi Listelemek ");
            Console.WriteLine("(5) Rehberde Arama Yapmak ");
            Console.WriteLine("(X) Çıkış ");
            
            while (true)
            {
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        metod.NumaraKaydetme(); //
                        break;
                    case "2":
                        metod.NumaraSilme(); // 
                        break;
                    case "3":
                        //NumaraGuncelleme();
                        break;
                    case "4":
                        //RehberListeleme();
                        break;
                    case "5":
                        //AramaYapma();
                        break;
                    case "X":
                    case "x":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            
        }
        static void SahteVeriEkle()
        {
            Kisiler kisi1 = new Kisiler("Ümit", "Türkmen","05378384816");
            Kisiler kisi2 = new Kisiler("Ahmet", "Türkmen","05124107456");
            Kisiler kisi3 = new Kisiler("Meliha", "Türkmen","05378384817");
            Kisiler kisi4 = new Kisiler("Mavera Seher", "Çetin","05434546678");
            Kisiler kisi5 = new Kisiler("Selami", "Hoca","05345557813");
            metod.Rehber.Add(kisi1);
            metod.Rehber.Add(kisi2);
            metod.Rehber.Add(kisi3);
            metod.Rehber.Add(kisi4);
            metod.Rehber.Add(kisi5);
            //ümit Türkmen
            Console.Write("");
            
        }
    }
}