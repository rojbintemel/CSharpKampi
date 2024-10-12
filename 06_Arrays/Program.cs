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
            //Dizi :aynı veri tipindeki  çok sayıda veriyi bir arada tutmak için kullanılan yapılardır.
            //ör:çift sayılar kendi içinde  bir dizidir --2,4,6
            //sarı,kırmızı,mavi,turuncu,beyaz--renkler dizisi
            //adana,ankara,istanbul,bursa--şehirler dizisi

            //Diziler oluşturulurken:
            //Değişken Türü[] DiziAdı=new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);



            ////Çift Sayılar Dizisi:
            //int[] numbers=new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);//Bir indeks'e değer atamazsak default olarak 0 çıktısını verir.


            ////Aynı olay başka yöntem
            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);



            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //for döngüsü ile kullanarak sıralama
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++) 
            //{
            //  Console.WriteLine(colors[i]);
            //}



            ////3'e tam bölünen sayıları listeleyelim
            //int[] numbers= { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for(int i=0;i<numbers.Length;i++)////düngü+değişken tanımlama
            //{
            //    if (numbers[i] %3==0)////kara yapısı
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            ////char değişkenlerle örnek tek fark tek tırnak kullanmak
            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for(int i=0;i<symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            ////Dizideki en büyük elemanları bulan yapı

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];//maxNumber değerine sıfırıncı değeri atadık

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)//burda sırayla 47 den buyuklerı buluyor en son en buyugu yani maxNumber değeri en büyük olan oluyor 
            //    {
            //        maxNumber = myArray[i];//burda ılk degerden buyukse yeni maxNumber bu diyoruz
            //    }
            //}
            //Console.WriteLine(maxNumber);


            #endregion

            #region Dizi Metotları


            ////length metotu:dizinin eleman sayısı yani uzunluğu verir.
            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);


            ////Sort metotu:Küçükten büyüğe doğru sıralar.
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            ////Reverse metotu:Diziyi tersten sıralar
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //// IndexOf:Dizi içinde herhangi bir aranan değerin index sırasını döndürür.
            //string[] customers = { "ali", "buse", "ayşegül", "lorin", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "lorin");
            //Console.WriteLine(index);



            //// Max-Min metotu:İstediğimiz dizide  direkt olarak en büyüğü ve en küçüğünü bulabiliriz.
            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: "+ numbers.Max() + "   Dizinin En Küçük Elemanı: " + numbers.Min()); 


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Şehri Giriniz: ");//$ bu sembol açıklamın solunda paramtresiz süslü parantez ile çağırılabilir yapıyor artıyı kullanmamıza gerek kalmıyor.
            //    cities[i] = Console.ReadLine();//i. eleman eşittir konsoldan gelen değer
            //}

            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}




            ////Bir tam sayı dizisi oluşturulup dizideki tüm elemanların toplamını bulma.
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}  
            //Console.WriteLine(sum);



            //Dizi içindeki sayıları tek ve çift olarak ayrı ayrı listeleme
            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }




            #endregion

            Console.Read();

        }
    }
}

