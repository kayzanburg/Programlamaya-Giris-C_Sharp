using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohm_Kanunu
{
    class Program
    {
        static void Main(string[] args)
        {
            double E, R, i;

            Console.Write("Gerilim Değeri Giriniz : ");
            E = Convert.ToDouble(Console.ReadLine());

            Console.Write("Direnc Değeri Giriniz : ");
            int girdi2 = Convert.ToInt32(Console.ReadLine());

            if (girdi2 == 0)
            {
                Console.WriteLine("Bu İşlemin Sonucu Yoktur.");
            }
            else
            {
                R = Convert.ToDouble(girdi2);
                i = (E / R);

                Console.WriteLine("\nAkım Değeri = " + i);
            }

            Console.Write("\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basın...");
            Console.ReadLine();
        }
    }
}
