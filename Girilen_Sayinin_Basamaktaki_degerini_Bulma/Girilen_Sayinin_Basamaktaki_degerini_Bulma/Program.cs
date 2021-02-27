using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Sayinin_Basamaktaki_degerini_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sayi1, sayi2, sayi3;

            Console.Write("Lütfen Üç Basamaklı Bir Sayı Giriniz : ");
            sayi = (Convert.ToInt32(Console.ReadLine()));

            sayi1 = sayi / 100; Console.WriteLine("Yüzler Basamağı : "+sayi1);
            sayi2 = (sayi / 10);
            sayi2 = (sayi2 % 10); Console.WriteLine("Onlar Basamağı : "+sayi2);
            sayi3 = sayi % 10; Console.WriteLine("Birler Basamağı : "+sayi3);

            Console.ReadLine();
        }
    }
}
