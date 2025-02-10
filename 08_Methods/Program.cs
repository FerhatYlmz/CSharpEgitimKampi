using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //()
            //Geriye değer döndürmeyen metotlar
            //Customer--> Listele, Ekle, Sil, Güncelle
            //void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int number1 = 20;
            //    int number2 = 30;
            //    int result = number1 + number2;
            //    Console.WriteLine("Result: " + result);
            //}

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine("Name: " + customerName);

            //}

            //WriteMethod("Ali Yıldız");


            //void CusomerCard(string customerName, string customerSurname,
            //    int customerAge)
            //{
            //    Console.WriteLine("Name: " + customerName);
            //    Console.WriteLine("Surname: " + customerSurname);
            //    Console.WriteLine("Age: " + customerAge);
            //}

            //CusomerCard("Ali", "Yıldız", 25);




            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2+ number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);





            #endregion

            #region Geriye Değer Döndüren Metotlar

            // string CustomerName()
            // {
            //     return "Buse Yıldız";
            // }

            //CustomerName();

            //string StudentName()
            //{
            //   string name= "Ali";
            //   string surname= "Yıldız";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentName());




            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " +
            //        capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adı: ");
            //x = Console.ReadLine();

            //Console.Write("Başkent: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengi: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı- Beyaz"));




            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 65));
            //Console.WriteLine(Sum(56, 67));
            //Console.WriteLine(Sum(55, 66));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(15, 26));


            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " İsimli öğrenci Geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " İsimli öğrenci Kaldı " + "Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali", 45, 65, 75));
            //Console.WriteLine(ExamResult("Ayşe", 5, 65, 75));
            #endregion 



            Console.Read();
        }
    }
}
