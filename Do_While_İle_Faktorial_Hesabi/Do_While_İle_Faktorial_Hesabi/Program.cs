using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_İle_Faktorial_Hesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, sayi, Toplam = 1;
            Console.Write("Faktöriyeli Hesaplanacak Bir Sayı Giriniz : ");
            sayi = Convert.ToInt16(Console.ReadLine());

            if (sayi >= 0)
            {
                do
                {
                    Toplam *= a;
                    ++a;
                }

                while (a <= sayi);

                Console.WriteLine("\n {0}! = {1}", sayi, Toplam);
            }

            else
            {
                Console.WriteLine("\nGirdiğiniz Sayı Negatiftir Faktöriyeli Hesaplanamaz");
            }

            Console.WriteLine("\n\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basınız...");

            Console.ReadLine();
        }
    }
}
