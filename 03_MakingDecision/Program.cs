using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifreyi giriniz : ");
            //string password;
            //password = Console.ReadLine();
            //if(password=="abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //***********************

            //string capital, country;
            //Console.Write("Başkenti giriniz : ");

            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz : ");

            //country = Console.ReadLine();

            //if(capital=="ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Verileriniz doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //***********************

            //int number;
            //Console.Write("sayıyı giriniz : ");
            //number = int.Parse(Console.ReadLine());
            //if(number==5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //}

            //***********************

            //int exam1, exam2, exam3, average;
            //string result = "Hata";
            //Console.Write("Sınav 1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);
            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuç iyi";

            //}
            //if (average > 84)
            //{
            //    result = "sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //***********************

            //string city;
            //Console.Write("Lütfen şehir giriniz : ");
            //city = Console.ReadLine();


            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("mevcut değil");
            //}

            //***********************

            //Console.Write("kullanıcı adınızı giriniz : ");
            //string username = Console.ReadLine();


            //if(username!="admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz!");
            //}

            //Console.Read();











            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;

            //int result = number % 5;
            //Console.Write(result);

            //****************************

            //Console.Write("Lütfen 1. sayıyı giriniz : ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz : ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number % number2;
            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan : " + result);

            //*********************************

            //Console.Write("bir sayı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());
            //if (sayi%2==0)
            //{
            //    Console.WriteLine("sayı çift");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tek");
            //}

            #endregion

            #region Char Değişkenleri İle Karar Yapıları

            //char team;
            //Console.Write("Tuttuğunuzun takımın sembolünü giriniz : ");
            //team = char.Parse(Console.ReadLine());
            //if(team=='g' | team=='G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team=='f' | team=='F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if(team=='b' | team=='B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("******* Restoran *******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine(" 1 - Ana Yemekler");
            //Console.WriteLine(" 2 - Çorbalar");
            //Console.WriteLine(" 3 - Pizzalar");
            //Console.WriteLine(" 4 - İçecekler");
            //Console.WriteLine(" 5 - Tatlılar");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menüyü seçiniz : ");
            //menuItem = Console.ReadLine();

            //if(menuItem=="1")
            //{
            //    Console.WriteLine("--------------------------");
            //    Console.WriteLine("******** Ana Yemekler ********");
            //    Console.WriteLine("Köri Soslu Tavuk");
            //    Console.WriteLine("Kızartma Tabağı");
            //    Console.WriteLine("Fasulye Pilav");
            //    Console.WriteLine("Fırında Somon");
            //    Console.WriteLine("Patlican Musakka");
            //    Console.WriteLine("******** Ana Yemekler ********");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine("--------------------------");
            //    Console.WriteLine("******** Çorbalar ********");
            //    Console.WriteLine("Mercimek Çorbası");
            //    Console.WriteLine("Ezogelin Çorbası");
            //    Console.WriteLine("******** Çorbalar ********");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine("--------------------------");
            //    Console.WriteLine("******** Pizzalar ********");
            //    Console.WriteLine("Akdeniz Pizza");
            //    Console.WriteLine("Margaritha");
            //    Console.WriteLine("Tavuklu Pizza");
            //    Console.WriteLine("******** Pizzalar ********");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine("--------------------------");
            //    Console.WriteLine("******** İçecekler ********");
            //    Console.WriteLine("Kola");
            //    Console.WriteLine("Ayran");
            //    Console.WriteLine("Su");
            //    Console.WriteLine("******** İçecekler ********");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine("--------------------------");
            //    Console.WriteLine("******** Tatlılar ********");
            //    Console.WriteLine("Triliçe");
            //    Console.WriteLine("Kazandibi");
            //    Console.WriteLine("Sütlaç");
            //    Console.WriteLine("******** Tatlılar ********");

            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case
            //Console.Write("Lütfen ay girişi yapınız : ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı sayı girişi"); break;
            //}
            #endregion

            #region Switch Case Hesap Makinası
            //int number1, number2, result;
            //char symbol;
            //Console.Write("1. sayıyı giriniz : ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz : ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz : ");
            //symbol = char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '+': result = number1 + number2; Console.WriteLine("Tıoplam : " + result);break;
            //    case '-': result = number1 - number2; Console.WriteLine("Fark : " + result); break;
            //    case '*': result = number1 * number2; Console.WriteLine("Çarpım : " + result); break;
            //    case '/': result = number1 / number2; Console.WriteLine("Bölüm : " + result); break;
                    
            //}


            #endregion

            Console.Read();
        }
    }
}
