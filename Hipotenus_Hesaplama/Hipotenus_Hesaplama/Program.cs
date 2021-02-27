using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hipotenus_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int Kenar1, Kenar2, Hipotenus;

            Console.Write("Birinci Kenar Uzunluğunu Girin : ");
            Kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci Kenar Uzunluğunu Giriniz : ");
            Kenar2 = Convert.ToInt32(Console.ReadLine());

            Hipotenus = (int)Math.Sqrt(Math.Pow(Kenar1, 2) + Math.Pow(Kenar2, 2));
            Console.WriteLine("\n Hipotenüs : "+ Hipotenus);

            Console.WriteLine("\n\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basınız...");
            Console.ReadLine();
        }
    }
}
