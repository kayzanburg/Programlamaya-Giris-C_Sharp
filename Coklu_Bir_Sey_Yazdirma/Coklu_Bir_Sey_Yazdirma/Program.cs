using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coklu_Bir_Sey_Yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sayi;
            Console.Write("Kaç Kere Yazdırılsın ? ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < sayi; i++)
            {
                Console.WriteLine("\n{0}-) Çanakkale Geçilmez...", i + 1);
            }

            Console.ReadLine();
        }
    }
}
