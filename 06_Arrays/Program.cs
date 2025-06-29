using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri 
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "mavi";
            //colors[2] = "yesil";
            //colors[3] = "turuncu";
            //Console.WriteLine(colors[3]);

            //********************************
            //string[] colors = new string[10];
            //colors[0] = "kırmızı";
            //colors[1] = "mavi";
            //colors[2] = "yesil";
            //colors[3] = "turuncu";
            //Console.WriteLine(colors[4]); çağrılsaydı öyle bir değer olmadığı için dönen sonuç 0

            //********************************
            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);



            #endregion
            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "mavi", "kırmızı", "turuncu", "yesil", "beyaz", "pembe" };
            //for(int i=0; i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //***************************************
            //int[] numbers = { 67, 63, 21, 17, 98, 99, 42, 67 };
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //***************************************
            //char[] symbols = { 'a', 'b', 'c', 'd' };
            //***************************************


            //int[] myArrays = { 23, 97, 45, 76, 112, 435, 64, 29, 75, 93 };
            //int maxNumber = myArrays[0];
            //for(int i=0; i<myArrays.Length; i++)
            //{
            //    if (myArrays[i] > maxNumber)
            //    {
            //        maxNumber = myArrays[i];

            //    }
            //}
            //Console.WriteLine(maxNumber);
            //***************************************

            //string[] persons = { "ali", "mehmet", "ömer", "elif", "nur", "ayşe", "yusuf" };
            //Console.WriteLine(persons.Length);

            //***************************************
            //int[] numbers = { 34, 12, 24, 35, 56, 76, 23, 43 };
            //Array.Sort(numbers); /*küçükten büyüğe sıralama*/
            //Array.Reverse(numbers); /* dizinin girilen sırasını tam tersine sıralıyor*/
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotlar
            //string[] customers = { "ali", "merve", "gül", "fatih", "hakan", "ezgi" };
            //int index = Array.IndexOf(customers, "fatih"); // istenilen değerin dizinin hangi değerinde olduğunu söyler
            //Console.WriteLine(index);
            //#endregion

            //************************************
            //int[] numbers = { 2, 65, 34, 89, 23, 13, 34, 45 };
            //Console.WriteLine("Dizinin en büyük elemanı : " +numbers.Max() + " Dizinin en küçük elemanı : " + numbers.Min());
            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for(int i=0; i<cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehri giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //for(int i=0; i<cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //**************************************
            //int[] numbers = { 10, 20, 30 };
            //int sum = 0;
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);
            //**************************************
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.Write("Çift Sayılar : ");
            //Console.WriteLine();
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] %2==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    } 
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.Write("Tek Sayılar : ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion
            Console.Read();
        }
        

        
    }
}
