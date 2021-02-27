using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dik_Ucgen_Testi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Birinci Kenarı Giriniz : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci Kenarı Giriniz : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üçüncü Kenarı Giriniz : ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a*a) + (b*b) == (c*c))
            {
                Console.WriteLine("\n  Bu Üçgen Diktir.");
            }
            else
            {
                Console.WriteLine("\n  Bu Üçgen Dik Değildir.");
            }

            Console.ReadLine();
        }
    }
}
