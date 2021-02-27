using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harf_Notu_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int not;
            Console.Write("Notunuzu giriniz : ");
            not = Convert.ToInt32(Console.ReadLine());

            if (not > 100 || not < 0)
            {
                Console.Write("\nHatalı Giriş Yaptınız");
            }
            else if (not >= 90)
            {
                Console.Write("\nHarf notunuz: A");
            }
            else if (not >= 80)
            {
                Console.Write("\nHarf notunuz: B");
            }
            else if (not >= 70)
            {
                Console.Write("\nHarf notunuz: C");
            }
            else if (not < 70)
            {
                Console.Write("\nHarf notunuz: F");
            }

            Console.Write("\n\n\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basınız...");
            Console.ReadLine();
        }
    }
}
