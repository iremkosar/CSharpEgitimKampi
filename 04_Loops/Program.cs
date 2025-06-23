using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;
            //for(i=0; i<=5; i++)
            //{
            //    Console.WriteLine("Eğitim kampı");
            //}

            //***********************

            //for (int i = 1; i<=20;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //***********************

            //for (int i = 0; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //***********************


            //Console.Write("lütfen ekrana sayı giriniz : ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for ( int i=1; i<=finishValue; i++)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region For Döngüsü İle Karar Yapıları 
            //for ( int i=1; i<=100; i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //********************

            //int toplam=0;
            //for (int i = 1; i<= 10; i++)
            //{
            //    toplam += i;

            //}
            //Console.WriteLine(toplam);

            //********************
            //int totalValue=0;
            //for (int i = 1; i<=20; i++)
            //{
            //    if(i%2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(totalValue);
            //********************
            //int count = 0;
            //for (int i = 1; i<=50; i++)
            //{
            //    if(i%7==0)
            //    {
            //        Console.WriteLine(i);
            //        count++;

            //    }
            //}
            //Console.WriteLine("------------------");
            //Console.WriteLine(count);

            //********************
            //int bacterium=1;
            //int toplam;
            //for(int i=1; i<=24;i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".ci saat sonunda oluşan bakteri : " + bacterium);

            //}

            #endregion

            #region While Döngüsü
            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("merhaba dünya");
            //    i++;
            //}
            //****************************
            //int i = 1;
            //while(i<=10)
            //{
            //    if(i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //****************************
            //int i = 1;
            //int toplam = 0;
            //while(i<=10)
            //{
            //    toplam += i;
            //    i++;
            //}
            //Console.WriteLine(toplam);


            #endregion
            #region Örnek Sınav Sorusu
            //klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan programı yazınız.
            Console.Write("sayıyı giriniz : ");
            int yuzler, birler, onlar;
            int toplam =0;
            int sayi = Convert.ToInt32(Console.ReadLine());
            yuzler = sayi / 100;
            Console.WriteLine("yüzdelik kısım: " + yuzler);
            birler = sayi % 10;
            Console.WriteLine("birlik kısım: " + birler);
            onlar = (sayi / 10) % 10;
            Console.WriteLine("onlar kısım: " + onlar);
            toplam = birler + onlar + yuzler;
            Console.WriteLine("Toplam : " + toplam);



            #endregion
            Console.Read();

        }
    }
}
