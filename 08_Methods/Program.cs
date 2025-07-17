using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            // Geriye değer döndürmeyen metotlar
            // Customer ->  Listele , ekle,sil,güncelle
            // Void
            //void CustomerList ()
            //{
            //    Console.WriteLine("irem koşar");
            //    Console.WriteLine("murat karut");
            //    Console.WriteLine("deniz mert");
            //    Console.WriteLine("gökhan sert");

            //}
            //CustomerList();

            //***********************************************************
            //void Sum()
            //{
            //    int x = 10;
            //    int y = 24;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion
            #region Geriye değer döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("irem kosar");

            //*******************************************
            //void customerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri : " + name + " " + surName);

            //}
            //customerCard("Yıldız", "Ocaklı");
            //customerCard("Aysegül", "Çelen");
            #endregion
            #region Geriye değer döndürmeyen Int Parametreli Metotlar
            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(12, 29, 45);
            #endregion
            #region Geriye değer döndüren Metotlar
            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion
            #region Geriye değer döndüren String parametreli Metotlar
            //string countryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = " Ülke : " + countryName + " - Başkent : " + capital + " - Bayrak Rengi : " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz : ");
            //x = Console.ReadLine();
            //Console.Write("Başkenti giriniz : ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz : ");
            //z = Console.ReadLine();
            //Console.WriteLine(countryCard(x, y, z));
            #endregion
            #region Geriye değer döndüren Int parametreli Metotlar
            //int Sum(int number1,int number2)
            //{
            //    int sum = number1 + number2;
            //    return sum;
            //}
            //Console.WriteLine(Sum(24,35));
            //Console.WriteLine(Sum(12, 78));
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(46, 32));
            #endregion
            #region Örnek Uygulama
            //string ExamResult(string studentName, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return studentName + " isimli öğrenci sınavı geçti " + " Ortalaması : " + result;
            //    }
            //    else
            //    {
            //        return studentName + " isimki öğrenci sınavı geçemedi " + " Ortalaması : " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("İrem", 60, 90, 100));
            //Console.WriteLine(ExamResult("Uğur", 23, 45, 12));
            #endregion
            Console.Read();
        }
    }
}
