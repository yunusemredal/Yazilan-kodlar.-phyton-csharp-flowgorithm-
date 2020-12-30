using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201307021Yunusemredalhafta12ödev10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir  sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            string bölünenler="";
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                   
                    bölünenler += i.ToString() + ' ';
                    //hocam bölünenler += i.ToString() + "+"; şeklinde yaptığımda fazla bir + işareti oluyordu ondan boluk bıraktırdım 

                }
            }
            Console.WriteLine(bölünenler);
            if (toplam == sayi)
            {
                
                Console.WriteLine(sayi + " sayısı mükemmel  sayıdır");
                Console.WriteLine(bölünenler + "= "+sayi);
            }
            else
            {
                Console.WriteLine(sayi + "sayısı mükemmel  sayı değildir");
            }
            
            Console.ReadLine();
        }
    }
}
