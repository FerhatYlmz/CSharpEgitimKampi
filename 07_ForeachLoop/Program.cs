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

            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste,Koleksiyon,Dizi


            //int[] numbers = { 145245, 24653, 37245, 42158, 5645, 68, 758, 8365, 9875 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers2 = { 145245, 24653, 37245, 42158, 5645, 68, 758, 8365, 9875 };

            //foreach (int number in numbers2)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);                    
            //    }
            //}


            //int[] numbers = { 145245, 24653, 37245, 42158, 5645, 68, 758, 8365, 9875 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,54,62,22,45
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Hello World";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}






            #endregion


            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            ////Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfta kaç Öğrenci Var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");


            ////Öğrenci Adı ve not Ortalamasını saklayacak diziler
            //string[] studentsNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. Öğrenci Adı: ");
            //    studentsNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;


            //    //Öğrencinin 3 sınav notunu alıp ortalama hesaplama
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentsNames[i]} isimli öğrencinin {j + 1}. Sınav Notu: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;//notları toplama
            //    }

            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            ////Sınav ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentsNames[i]} isimli öğrencinin ortalama notu:" +
            //   $" {studentExamAvg[i]} ve durumu: {(studentExamAvg[i] >= 50 ? "Geçti" : "Kaldı")}");
            //}



            #endregion
            Console.Read();
        }
    }
}
