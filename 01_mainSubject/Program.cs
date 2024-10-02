using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_mainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YAZDIRMA KOMUTLARI:

            //Console.Write("merhaba dünya");//imleci en sağına atarak yazar
            //Console.WriteLine("selam");// imleçi alt satıra indirir
            ////yani yerelerı degısırse yazılma sekıllerı de değişir
            ////#region komutu ekleyip bir sey yazılır daha sonra en sona #endregion yazılıp bölümlendirilebilir.

            //Console.WriteLine("*****Yemek Kategorileri******");

            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*****Yemek Kategorileri******");


            #endregion

            #region STRİNG DEĞİŞKENLER:

            ////string
            ////Değişken_türü değişken_adı;(yani string türlü değişkenler böyle yazılır)

            ////string name;
            ////name = "rojbin";
            ////Console.Write(name); 

            ////değişkenler adlandırılırken boşluk bırakılmaz.

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;//bir satırda aynı turden bır kac tane değişken tanımlanabilir virgül ile ayır.

            //customerName = "rojbin";
            //customerSurname = "temel";
            //customerPhone = "5902661448";
            //customerEmail = "deneme@gmail.com";
            //district = "kadıkoy";
            //city = "istanbul";

            //Console.WriteLine("****Rezerevasyon Kartı****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:"+ customerEmail);
            //Console.WriteLine("Adres:"+ district+ "/"+ city);
            //Console.WriteLine("--------------------------------------------------");


            //Console.WriteLine();
            //customerName = "arin";
            //customerSurname = "temel";
            //customerPhone = "5903661448";
            //customerEmail = "test@gmail.com";
            //district = "kızıltepe";
            //city = "mardin";


            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");




            #endregion

            #region INT DEĞİŞKENLER:

            //int 
            //int number = 23;
            //Console.WriteLine(number);


            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("****Restoran Menü Fiyatı****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger :" + hamburgerPrice + "TL");
            Console.WriteLine("-----Kola :" + cokePrice + "TL ");
            Console.WriteLine("-----Su :" + waterPrice + "TL");
            Console.WriteLine("-----Kızartma :" + friesPrice + "TL");
            Console.WriteLine("-----Pizza :" + pizzaPrice + "TL");
            Console.WriteLine("-----Limonata :" + lemonadePrice + "TL");

            Console.WriteLine();




            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;



            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı:" + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı:" + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı:" + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı:" + totalemonadePrice + " TL");


            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalemonadePrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
            #endregion
            Console.Read();
        }
    }
}
// ctr+d komutu ıle dırek bır satırı alt satıra kopyalayabılıyoruzZ