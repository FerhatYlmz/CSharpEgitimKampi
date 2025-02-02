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
            #region Temel dizi Örnekleri

            //2.4.6.8
            //sarı, mavi, yeşil, kırmızı
            //Adana, Ankara, İstanbul, İzmir
            //DeğişkenTürü[] diziAdı = new DeğişkenTürü[ElemanSayısı];

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Adana";
            //cities[1] = "Ankara";
            //cities[2] = "İstanbul";
            //cities[3] = "İzmir";
            //cities[4] = "Bursa";

            //Console.WriteLine(cities[3]);

            //int[] numbers = new int[10];
            //numbers[0] = 10;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 745;
            //numbers[7] = 25;
            //numbers[9] = 66;

            //Console.WriteLine(numbers[7]);

            //string[] cities = { "Adana", "Ankara", "İstanbul", "İzmir", "Bursa" };
            //Console.WriteLine(cities[1]);


            #endregion


            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Kırmızı", "Sarı", "Beyaz", "Mavi" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 10, 48, 698, 745, 25, 66 , 7456 , 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3== 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] characters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            //for (int i = 0; i < characters.Length; i++)
            //{
            //    Console.WriteLine(characters[i]);
            //}

            //int[] myArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "Ali", "Veli", "Ayşe", "Fatma", "Mehmet", "Zeynep" };
            //Console.WriteLine("Dizideki kişi sayısı: " + persons.Length);

            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Veli", "Ayşe", "Fatma", "Mehmet", "Zeynep" };
            //int index = Array.IndexOf(customers, "Ayşe");
            //Console.WriteLine("Aranan elemanın index numarası: " + index);

            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() +
            //    "Dizini En Küçük Elemanı: " + numbers.Min());



            #endregion


            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehir Adı Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine("Dizinin Toplamı: " + sum);

            //int[] numbers = { 15, 88, 55, 66, 99, 88, 77, 111, 258, 369 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}           
            #endregion


            Console.Read();
        }
    }
}
