using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Sayinin_Pozitif_Tam_Bolenleri_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            Console.Write("Bir sayı Giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n{0} Sayısını Tam Bölen Pozitif Tam Sayılar", sayi);
            Console.WriteLine("-------------------------------------------");
            
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            
            Console.ReadLine();
        }
    }
}
