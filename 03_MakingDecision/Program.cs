using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If - Else

            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();
            //if (capital == "Ankara" && country == "Türkiye")
            //{
            //    Console.WriteLine("Başkent ve Ülke doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Başkent ve Ülke yanlış");
            //}

            //int number;
            //Console.Write("Bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if(number ==5)
            //    {
            //    Console.WriteLine("Sayı 5'e eşittir.");
            //}
            //else if (number > 5)
            //{
            //    Console.WriteLine("Sayı 5'ten büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 5'ten küçüktür.");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("1. Sınavı giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sınavı giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınavı giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 85)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Bir şehir adı giriniz: ");
            //city = Console.ReadLine();

            //if (city == "Adana" | city =="Ankara" | city== "Bursa"| city=="Trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.WriteLine("Lüften Kullanıcı Adınızı Giriniz: ");
            //string userName = Console.ReadLine();
            //if (userName == "admin") 
            //{
            //    Console.WriteLine("Kullanıcı Adı Doğru");
            //    if (userName == "admin")
            //    {
            //        Console.WriteLine("Kullanıcı Adı Doğru");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hoş Geldiniz");
            //    }


            //Console.Read();

            #endregion


            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen 1.Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result1 = number1 % number2;

            //Console.WriteLine("1. Sayının 2. Sayıya Bölümünden Kalan: " + result1);

            //    Console.WriteLine("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir.");
            //}

            #endregion

            #region char değişkenleri ile karar yapıları

            //char team;
            //Console.WriteLine("Lütfen Takımınızı Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'F' | team=='f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if (team == 'T' | team == 't')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}

            #endregion

            #region örnek proje uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran ***** ");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Lütfen Menü Numarasını Giriniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Ana Yemekler---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("1-Kızartma Tava");
            //    Console.WriteLine("1-Faulye Pilav");
            //    Console.WriteLine("1-Fırında Somon");
            //    Console.WriteLine("1-Patlıcam Musakka");
            //    Console.WriteLine("--------Ana Yemekler---------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Çorbalar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("--------Çorbalar---------");                

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Pizzalar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("2-Tavuklu Pizza");
            //    Console.WriteLine("--------Pizzalar---------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------İçecekler---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Şalgam");
            //    Console.WriteLine("--------İçecekler---------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Tatlılar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Kaymaklı Künefe");
            //    Console.WriteLine("--------Tatlılar---------");

            //    Console.WriteLine();
            //}
            #endregion

            #region switch-case

            //Console.Write("Lüften Ay Girişi Yapınız: ");
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
            //    default: Console.Write("Hatalı Giriş Yaptınız"); break;
            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("İşlemi Seçiniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result); 
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*': 
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/': 
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //    default: Console.WriteLine("Hatalı Giriş Yaptınız"); break;
            //}

            #endregion

            Console.Read();

        }
    }
}