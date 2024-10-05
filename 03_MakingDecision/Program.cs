using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //VE +İF

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi girirniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı ");
            //}
            //else
            //{ 
            //Console.WriteLine("hatalı bilgi ");
            //}



            //if (number == 5) {
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}


            //ÇOĞUL İF + BAŞTAN BİR DEĞER ATAMA

            //int exam1, exam2, exam3, avarge;
            //string result = "hata!!";

            //Console.Write("Sınav1:");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("Sınav2:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3:");
            //exam3 = int.Parse(Console.ReadLine());


            //avarge = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması:" + avarge);


            //if (avarge > 0 & avarge <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (avarge > 50 & avarge <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (avarge > 70 & avarge <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (avarge > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //Console.WriteLine(result);


            //VEYA

            //string city;
            //Console.Write("Lütfen Şehir girirşiyapınız : ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "mardin" | city == "izmir" | city == "antalya")
            //{
            //    Console.WriteLine("Şehir mevcuttur.");
            //}
            //else {
            //    Console.WriteLine("Şehir mevcut değildir.");
            //}


            //EŞİT DEĞİLSE

            //Console.Write("Lütfen kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz ");
            //}




            #endregion

            #region Mod İşlemleri

            //BİRİNCİ ÖRNEK:

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //İKİNCİ ÖRNEK:

            //Console.Write("Lütfen 1. sayıyı girirniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2=int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.Sayının 2.Sayıya bölümünden kalan: " + result);


            //BİR SAYININ TEKLİK ÇİFTLİK DURUMU

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir.");
            //}


            #endregion

            #region  Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen Takım sembolü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team =='g'| team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if(team =='f' | team=='F')
            //{ 
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}


            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("******* C# Eğitim Kampı Restoran *******");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");

            //string menuIltem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuIltem = Console.ReadLine();

            //if(menuIltem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");

            //    Console.WriteLine();
            //}
            //if (menuIltem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("------------Çorbalar------------");

            //    Console.WriteLine();
            //}
            //if (menuIltem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("------------Pizzalar------------");

            //    Console.WriteLine();
            //}
            //if (menuIltem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------İçecekler------------");

            //    Console.WriteLine();
            //}
            //if (menuIltem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------------Tatlılar------------");

            //    Console.WriteLine();
            //}




            #endregion

            #region Switch Case
            //Sayıya Göre Yılın Aylarını veren Uygulama

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1:Console.WriteLine("Ocak");break;//Eğer ay değeri bir gelirse ocak yaz ve bitir.
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default:Console.WriteLine("Hatalı Veri Girişi");break;//Eğer verilen değerler haricinde bir değer girirlirse
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("1.Sayıyı Giriniz: ");
            number1=int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol=char.Parse(Console.ReadLine());

            switch(symbol)
            {
                case '+':
                    result=number1+ number2;
                    Console.WriteLine("Toplam: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;

                

            }





            #endregion


            Console.Read();
        }
    }
}
