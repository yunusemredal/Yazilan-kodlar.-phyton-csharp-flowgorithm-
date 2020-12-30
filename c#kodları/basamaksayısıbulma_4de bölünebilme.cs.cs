using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201307021YunusEmredalhafta11ödev9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*basamak sayısını , 3 basamaklı ise her rakamın toplamı , 4 basamaklı ise 4 ile bölünüp bölünmediği bulan program*/

            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi, basamaksayisi;

            sayi = Convert.ToInt32(Console.ReadLine());

            basamaksayisi = Convert.ToString(sayi).Length;

            Console.WriteLine("Basamak sayısı: " + basamaksayisi);

            if (basamaksayisi == 3)
            {
                int yüzler, onlar, birler, kareleritop;
                yüzler = sayi / 100;
                onlar = (sayi - (yüzler * 100)) / 10;
                birler = (((sayi - (yüzler * 100)) - (onlar * 10)));
                kareleritop = (yüzler * yüzler) + (onlar * onlar) + (birler * birler);
                Console.WriteLine(sayi + " sayısının  basamak kareleri toplamı: " + kareleritop);


            }
            else if (basamaksayisi == 4) 

            {
               
                int mod = sayi % 4;
                /* Hocam bu kısım if ile kullanarak yaptım. swicth case yapısını denemek için onuda kulladım . İki yapıda aşağıda mevcut . Biri aktif diğeri aktif değildir.  
                  if (mod==0)
                {
                    Console.WriteLine("Sayı 4'e tam bölünür.");
                }
                else
                {
                    Console.WriteLine("Sayı 4'e tam bölünmez.");
                }*/
                switch (mod)
                {
                    case 0:
                        Console.WriteLine("Sayı 4'e tam bölünür.");
                        break;
                    default:
                        Console.WriteLine("Sayı 4'e tam bölünmez.");
                        break;


                }
            }
            else
            {
                Console.WriteLine("Geçersiz sayı girdiniz.");

            }
            Console.ReadKey();
        }
    }
}
