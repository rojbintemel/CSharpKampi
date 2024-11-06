using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Void Metotlar

            //Bir yapının sonunda () varsa bir metottur.
            //Ayrıca üstüne basılı tutunca çıkan açıklamada mor bir küp görünür.
            //Metotlar ikiye ayrılır.

            //Geriye Değer Döndürmeyen Metotlar
            //Customer--->Listele,ekle,sil,güncelle(bu işlemlerde  ör. listenin son halıni görmek için tekrar tekrar çağırılabilir.)
            //Geriye değer  döndürmeyen metotlar programlamada void olarak tanımlanıyor

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
            //CustomerList();


            ////metot ile Toplama İşlemi yaptık
            //void Sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();




            #endregion

            #region Geriye Değer Döndürmeyen String Paremetreli Metotlar

            //void WriteMethod(string customerName)//parantez içine yazınca dışarıdan kullanıcıdan alıyoruz
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");


            ////Müşteri kartı
            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: "+ name + " " + surName);
            //}
            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Ayşegül","Kaya");


            #endregion

            #region Geriye Değer Döndürmeyen Int Paremetreli Metotlar

            ////ör.dışardan alınan 3 sayıyı toplayan metot

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);


            #endregion

            #region Geriye Değer Döndüren Metotlar
            //Burdaki metotlar  void olarak tanımlanmaz bir değişken türüyle veya bir sınıf türüyle tanımlanması gerekir

            ////Geriye string bir değer döndüren metot
            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();


            string StudentCard()
            {
                string name = "Ali";
                string surname = "Kaya";

                return name + " " + surname;
            }
            Console.WriteLine(StudentCard());
            #endregion


            Console.Read();
        }
    }
}
