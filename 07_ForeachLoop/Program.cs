using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}
            //***************************************
            //int[] numbers = { 10, 27, 45, 97, 23, 46, 78, 23, 56, 76, 97, 28, 59, 24, 573 };
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //***************************************
            //int[] numbers = { 10, 27, 45, 97, 23, 46, 78, 23, 56, 76, 97, 28, 59, 24, 573 };
            //foreach(int number in numbers)
            //{
            //    if(number %2 ==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //***************************************
            //int[] numbers = { 10, 27, 45, 97, 23, 46, 78, 23, 56, 76, 97, 28, 59, 24, 573 };
            //int toplam = 0;
            //foreach(int number in numbers)
            //{
            //    toplam += number;
            //}
            //Console.WriteLine(toplam);
            //***************************************
            //List<int> numbers = new List<int>()
            //{
            //    1,2,4,5,6,7,19
            //};
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //***************************************
            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion
            #region Örnek Sınav Sistemi Uygulaması
            Console.Write("Sınıfta kaç kişi olduğunu giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            Console.Write("Öğrenci isimlerini giriniz : ");
            Console.WriteLine();
            for (int i = 1; i <= sayi; i++)
            {
                Console.Write(i + ". öğrenci ismi : ");
                string names = Console.ReadLine();
            }
            Console.Write("notlarını giriniz : ");
            Console.WriteLine();
            int toplam = 0;
            for (int i = 1; i <= sayi; i++)
            {
                Console.Write(i + ". öğrencinin notu : ");
                int notes = int.Parse(Console.ReadLine());
                toplam += notes;
            }
            Console.WriteLine();
            Console.WriteLine("Öğrencilerin notlarının toplamının ortalaması : " + toplam / sayi);
            //*************************************************************
            Console.Write("******* C# Eğitim Kampı Sınav Uygulaması *******");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine();
            Console.Write("Sınıfınızda kaç öğrenci var : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            //öğrenci isimlerini ve not ortalamalarını tutacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;
                // her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;

                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }
            //Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentExamAvg[i]}");
                // öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti ");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçemedi");
                }
                Console.WriteLine("---------------------------------------------------");
            }






            #endregion
            //Console.Read();
        }
    }



