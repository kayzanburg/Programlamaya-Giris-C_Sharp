using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dik_Ucken_Alan_Ve_Cevre_Hesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            float Kenar1, Kenar2, Alan, Cevre, Hipotenus;

            Console.Write("1. Dik Kenarı Giriniz : ");
            Kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Dik Kenarı Giriniz : ");
            Kenar2 = Convert.ToInt32(Console.ReadLine());

            Hipotenus = (float)Math.Sqrt(Math.Pow(Kenar1, 2) + Math.Pow(Kenar2, 2));

            Alan = (Kenar1 * Kenar2) / 2;
            Cevre = Kenar1 + Kenar2 + Hipotenus;

            Console.WriteLine("\n Üçgenin Alanı : {0}\n Üçgenin Çevresi : {1}", Alan, Cevre);
            
            Console.Write("\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basınız...");
            Console.ReadLine();




        }
    }
}
