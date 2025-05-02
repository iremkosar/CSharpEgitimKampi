using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya"); //bunu yazdıktan sonra imleç bir alt satıra iner
            //Console.Write("Selam");

            //*************

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            //***************
            #endregion

            #region String Değişkenler

            //string name;
            //name = "irem";
            //Console.Write(name);

            //*******************************

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "irem";
            //customerSurname = "kosar";
            //customerPhone = "+9050654387113";
            //customerEmail = "iremkosar94@gmail.com";
            //district = "Hatay";
            //city = "İskenderun";

            //Console.WriteLine("***** Rezervasyon Kart *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");

            //Console.WriteLine();

            //customerName = "Nur";
            //customerSurname="sabahoglu";
            //customerPhone = "+905056739827";
            //customerEmail = "haticenur460@gmail.com";
            //district = "istanbul";
            //city = "kadıköy";

            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");

            //******************************************










            #endregion

            #region Int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + " TL ");
            Console.WriteLine("-----Kola Fiyatı: " + cokePrice + " TL ");
            Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + " TL ");
            Console.WriteLine("-----Limonata Fiyatı: " + lemonadePrice + " TL ");
            Console.WriteLine("-----Kızartma Fiyatı: " + friesPrice + " TL ");
            Console.WriteLine("-----Su Fiyatı: " + waterPrice + " TL ");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            Console.WriteLine("----------------------");
            Console.WriteLine("Hamburger Tutarı : " + totalHamburgerPrice + " TL ");
            Console.WriteLine("Kola Tutarı : " + totalCokePrice + " TL ");
            Console.WriteLine("Su Tutarı : " + totalWaterPrice + " TL ");
            Console.WriteLine("Kızartma Tutarı : " + totalFriesPrice + " TL ");
            Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + " TL ");
            Console.WriteLine("Limonata Tutarı : " + totalLemonadePrice + " TL ");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice; ;
            Console.WriteLine("Toplam Tutar : " + totalPrice + " TL ");


            #endregion


            Console.Read();
        }
    }
}
