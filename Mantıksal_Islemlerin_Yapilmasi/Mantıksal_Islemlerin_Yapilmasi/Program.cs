using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantıksal_Islemlerin_Yapilmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;

            Console.Write("Birinci sayıyı girin: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());           
             
            if (sayi1 == sayi2)
            {
                Console.WriteLine("\n Sayılar birbirine eşittir.");
            }

            else
            {
                Console.WriteLine("\n Sayılar birbirine eşit değildir.");
            }

            if (sayi1 < sayi2)
            {
                Console.WriteLine("\n {0} sayısı {1} sayısından küçüktür.", sayi1, sayi2);
            }

            else if(sayi1 > sayi2)
            { 
                Console.WriteLine("\n {0} sayısı {1} sayısından büyüktür.", sayi1, sayi2);
            }

            Console.Write("\n\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basınız...");
            Console.ReadLine();
        }
    }
}
