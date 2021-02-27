using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Hesabi_Yapan_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sayi, a;

            Console.Write("Ekrana Bir Sayı Giriniz : ");
            Sayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bölecek Sayıyı Giriniz : ");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Sayi; i++)
            {
                if (i % a == 0)
                {
                    Console.WriteLine("\n{0} Sayısı {1} Sayısını Tam Böler", a, i);
                }
            }

            Console.Write("\n\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basınız...");
            Console.ReadLine();
        }
    }
}
