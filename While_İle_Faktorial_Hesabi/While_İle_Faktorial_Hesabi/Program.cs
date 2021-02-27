using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_İle_Faktorial_Hesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, sayi, Toplam = 1;
            Console.Write("Faktöriyeli Hesaplanacak Sayıyı Giriniz : "); sayi = Convert.ToInt16(Console.ReadLine());

            if (sayi >= 0)
            {
                while (a <= sayi)
                {
                    Toplam *= a;
                    ++a;
                }

                Console.WriteLine("\n {0}! = {1}", sayi, Toplam);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("\n\nGirdiğiniz Sayı Negatiftir Faktöriyel Değeri Hesaplanamaz...");
            }
            Console.ReadLine();
        }
    }
}
