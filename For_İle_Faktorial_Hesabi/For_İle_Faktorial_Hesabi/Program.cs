using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_İle_Faktorial_Hesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sayi, Toplam = 1;
            Console.Write("Faktöriyeli Hesaplanacak Sayıyı Giriniz : "); sayi = Convert.ToInt16(Console.ReadLine());

            if (sayi >= 0)
            {
                for (a = 1; a <= sayi; ++a)
                {
                    Toplam *= a;
                }

                Console.WriteLine("\n {0}! = {1}", sayi, Toplam);

                Console.ReadLine();
            }

            else
                Console.WriteLine("\n\nGirdiğiniz Sayi Negatiftir Faktöriyeli Hesaplanamaz...");
            Console.ReadLine();
        }
    }
}
