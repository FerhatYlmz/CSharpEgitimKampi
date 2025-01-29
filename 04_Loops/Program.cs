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
            //Döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //For(x;y;z)
            //x: Başlangıç 
            //y: Bitiş 
            //z: Artış azalış

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i +=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Lütfen Ekrana Yazılmasını istediğiniz Adedi giriniz");
            //int finisValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finisValue; i++)
            //{
            //    Console.WriteLine("Ne Mutlu Türküm Diyene");
            //}


            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalvalue = 0;
            //for (int i = 1; i <= 10; i++)
            //{

            //    totalvalue += i;              
            //}
            //Console.WriteLine("Toplam Değer: " + totalvalue);


            //int totalvalue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine("Çift Sayıların Toplamı: " + totalvalue);


            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;

            //    }                
            //}

            //Console.WriteLine("7'ye Bölünen Sayı Adedi: " + count);



            //1-2-3-4-8-16
            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}


            #endregion

            #region While Döngüsü

            //While(şart)
            //{
            // işlemler
            //}

            //int i = 1;
            //while (i <=20)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //    i++;
            //}


            //int i = 1;
            //while (i <= 20)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("Çift Sayıların Toplamı: " + sum);



            #endregion


            #region Sınav Sorusu

            //Klavyeden girilien 3 basamaklı sayının basamakları toplamını hesaplayan
            //kodu yazınız

            //456

            //Console.WriteLine("Lütfen 3 Basamaklı Bir Sayı Giriniz");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;
                    
            //Console.WriteLine(ones +"-" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;
            //Console.WriteLine("Basamakların Toplamı: " + sum);

            #endregion


            Console.Read();
        }
    }
}
