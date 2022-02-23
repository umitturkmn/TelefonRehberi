﻿using System;
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
            Console.WriteLine("**********************************************");
            Console.WriteLine("*************-Numara Ekleme-******************");
            Console.WriteLine("**********************************************");
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
            Console.WriteLine("**********************************************");
            Console.WriteLine("***************-Numara Silme-*****************");
            Console.WriteLine("**********************************************");
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
        public void NumaraGuncelleme()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("*****************-Kişi Güncelleme-************");
            Console.WriteLine("**********************************************");
            Console.WriteLine("Değiştirmek istemediklerinizi boş bırakın.");
            string isim = GuncellemeKontrol("Lütfen Güncellemek İstediğiniz Kişinin Adını Giriniz: ");
            foreach (Kisiler kisi in Rehber)
            {
                if (isim == kisi.Ad)
                {
                    
                    string ad = FirstLetterGrowUp(GuncellemeKontrol("Yeni Adı Giriniz: "));
                    if(ad.Length > 0) kisi.Ad = ad;
                    string soyad = FirstLetterGrowUp(GuncellemeKontrol("Yeni Soyadı Giriniz: "));
                    if(soyad.Length > 0) kisi.Soyad = soyad;
                    Console.Write("Yeni Numarayı Giriniz: ");
                    string no = FirstLetterGrowUp(Console.ReadLine());
                    if(no.Length > 0 && no.Length == 11 && no.StartsWith("0") == true) kisi.TelNo = no;
                    else Console.WriteLine("Numara hatalı girildiği için kaydedilemedi.");
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığını kişi bulunamadı.");
                }
                break;
            }
        }

        public void RehberListeleme()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("***************-Telefon Rehberi-**************");
            Console.WriteLine("**********************************************");
            foreach (Kisiler item in Rehber)
            {
                Console.WriteLine("İsim: {0}",item.Ad);
                Console.WriteLine("Soyisim: {0}",item.Soyad);
                Console.WriteLine("Telefon Numarası: {0}",item.TelNo);
                Console.WriteLine("------------------------------------------");
            }
        }
        public void AramaYapma()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    string giris = StringControl("Aramak istediğiniz ismi veya soyisiimi girin: ");
                    foreach (Kisiler item in Rehber)
                    {
                        if (giris == item.Ad || giris == item.Soyad)
                        {
                            Console.WriteLine("Arama Sonuçlarınız:");
                            Console.WriteLine("**********************************************");
                            Console.WriteLine("İsim: {0}",item.Ad);
                            Console.WriteLine("Soyisim: {0}",item.Soyad);
                            Console.WriteLine("Telefon Numarası: {0}",item.TelNo);
                            Console.WriteLine("**********************************************");
                        
                        } else 
                        {
                            Console.WriteLine("Bu isim veya soyisimde kimse bulunumadı.");
                            break;
                        }
                    }
                    break;
                case "2":
                    string no = NumaraKontrol("Aramak istediğiniz numarayı giriniz: ");
                    if(no.Length ==11 && no.StartsWith("0") == true)
                    {
                        foreach (Kisiler item in Rehber)
                        {
                           if (no == item.TelNo)
                           {
                                Console.WriteLine("Arama Sonuçlarınız:");
                                Console.WriteLine("**********************************************");
                                Console.WriteLine("İsim: {0}",item.Ad);
                                Console.WriteLine("Soyisim: {0}",item.Soyad);
                                Console.WriteLine("Telefon Numarası: {0}",item.TelNo);
                                Console.WriteLine("**********************************************");
                                break;
                           } 
                           else
                           {
                                Console.WriteLine("Bu numarada kimse bulunumadı.");
                                break;
                           }
                        }
                        break;
                    } else 
                    {
                        Console.WriteLine("Hatalı tuşladınız. Tekrar deneyin.");
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("Hatalı Tuşladınız.");
                    break;
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
                        Console.WriteLine("Hatalı Numara Girdiniz Tekrar Deneyiniz.");
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

        public static string GuncellemeKontrol(string text)
        {
            string str = "";
            bool control = true;
            int num = 1;
            while (control)
            {
                Console.Write(text);
                str = FirstLetterGrowUp(Console.ReadLine());
                string str2 = "1234567890!^+-*/?*.,#%&:;()={}[]-_\"<>'\\~@|";
                if (str.Length > 0)
                {
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
                else if (str.Length == 0)
                {
                    control = false;
                    break;
                }

                
            }
            return str;
        }
        
    }
}
