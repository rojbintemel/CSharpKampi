using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Dört tane parametre alan bir döngüdür.

            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:In(komutu)
            //4:Liste,Koleksiyon,Dizi


            ////Dizinin bütün elemanlarını ekranda gösteren döngü
            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            ////Dizide sadece Çift sayıları yazdırdık
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            ////Dizinin içinde yer alan sayıların toplamını yazdırdık.
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);



            //Liste Yapısı,oluşturma

            ////Listenin öğelerini foreach ile yazdırdık
            //List<int> numbers = new List<int>() //numbers adında yeni liste olustur dedik
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{ 
            //Console.WriteLine(number);
            //}


            ////Bir kelimeyi harflerine ayıran foreach döngüsü kurduk
            //string word = "Merhaba";
            //foreach(char c in word)//Burda word isimdeki değişkeni char'a göre parçala ve her bir harfini c'ye atayıp  alt alta yazdır.

            //{
            //    Console.WriteLine(c);
            //}






            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Klavyeden öğrenci sayısı aldık.Bu öğrencilerin ismini aldık,sınav notlarını aldık ve ortalamalarını hesapladık

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması*****");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("--------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var:  ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");



            //Öğrenci isimlerini ve not ortalamalarını saklayacak dizileri tanımladık
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            //her öğrenci için notlarını toplayan bir for döngüsü kurduk
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;


                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli  öğrencinin {j + 1}. sınav notunu giriniz:  ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//Notları topluyoruz.
                }
                Console.WriteLine();
               
                studentExamAvg[i] = totalExamResult / 3;

            }
            //Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else 
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("------------------------------");
            }



            #endregion
            Console.Read();

        }
    }
}
