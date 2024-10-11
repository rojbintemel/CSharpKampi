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
            // donguler sayesınde uzun uzun  verıler dırek  uzun uzun toplanmaz  oncekı verılerın toplamı + sonrakı verı seklınde ılerler
            //1+2+3+4+5+6=21 dıye toplmaz
            //1+2=3+3=6+4=10+5=15+6=21 şeklinde toplar.

            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;
            //for(i=1;i<=5;i++)
            //{
            //    Console.WriteLine(" C# Eğitim Kampı");
            //}
            ////burda 5 defa' C# Eğitim Kampı ' yazdırdık


            //for (int i = 1; i <= 20; i++)
            //{ 
            //  Console.WriteLine(i);
            //}
            ////burda 1 den 20 ye kadar sayıları yazdırdık.



            //for (int i= 3; i <= 50;i+=3)
            //{
            //    Console.WriteLine(i);
            //}
            ////bu işlem bize 0-50 arasında 3'e tam bölünen sayıları vericek.


            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());//bir değişken oluşturduk

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            ////burdaki işlem sayesinde bizim ekrana yazdığımız sayı adedi kadar yaşasın cumhuriyet yazdırılıcak.


            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 01; i <= 100; i++) 
            //{
            //    if (i % 5 == 0) ////i'den gelen değer 5'e bölündüğünde kalan 0'sa i değerini yazdır.
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            ////1-100 arasında 5 'tam bölünen sayıları yazdıran for döngüsü kurduk.


            //int totalValue = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);
            ////1-10 arasındaki ardışık sayıları topladık
            ///

            //int totalValue = 0;
            //for (int i = 1; i < 20; i ++) 
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);//burdsa ilk önce 2 ye tam bölünen sayıları yazdırdı
            //    }
            //}
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine(totalValue);//toplamlarını yazdırdık.
            //// Bu döngü 1-20 arasındaki çift sayıların toplamını hesapladı.



            //int count = 0;
            //for (int i = 1;i<=50;i++)
            //{
            //    if (i % 7 == 0)//eğer değisken 7 ye tam bölünüyorsa
            //    {
            //        count++;//count değişken değerini bir arttır.
            //    }
            //}
            //Console.WriteLine(count);

            ////1-50 arasında 7'ye bölünen kaç tane sayı olduğunu bulduk.



            ////1-2-4-8-16.... şeklinde çoğalma
            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)//for döngüsü bize saat değerini tutar.
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}
            ////bir bakteri var her saatin sonunda 2'ye bölünerek çoğalıyor.
            ////24 saat'in sonunda bu ortamda kaç bakteri olduğunu hesaplayan program.



            #endregion

            #region While Döngüsü

            ////While yapısı:

            ////While(Şart)
            ////{
            ////işlemler
            ////}

            ////while döngüsü işlem sağlandığı müdettçe devam ettirir.

            //int i = 1;
            //while (i <= 10)//i(değişken) 10'dan küçük ve eşit olduğu müdettçe
            //{ 
            //  Console.WriteLine("Merhaba Döngüler");//'Merhaba Döngüler' yazdır
            //    i++;//i değerini bir bir arttır 
            //}



            //int i = 1;
            //while (i <= 10)
            //{ 
            // if(i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }//yukardaki şart sağlanıyorsa i'yi bir arttır.
            // i++;
            //}
            ////1-10 arasında 3'e tam bölünen sayıları bulan while döngüsü



            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            ////1-10 arasındaki sayıların toplamı


            #endregion

            #region Örnek Sınav Sorusu

            ////Klavyeden girilen  3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            ////456

            //Console.Write("Lütefen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            
            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;//normalde 4.56 yazması gerekır ama değişken türü int olduğu için-->4 yazılır

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //sum=ones+tens+hundreds;
            //Console.WriteLine(sum);




            #endregion

            Console.Read();
        }
    }
}
