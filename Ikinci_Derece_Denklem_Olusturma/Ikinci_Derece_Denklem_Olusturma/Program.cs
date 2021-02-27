using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikinci_Derece_Denklem_Olusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double Delta;

            Console.WriteLine("Ax^2+Bx+C ifadesinin ");

            int[] Dizi = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("Sırasıyla A , B ve C değerini Giriniz : ");
                Dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            a = Dizi[0];
            b = Dizi[1];
            c = Dizi[2];

            Delta = (b * b) - (4 * a * c);

            if (Delta > 0)
            {
                double x1 = (-b + Math.Sqrt(Delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(Delta)) / (2 * a);
                Console.WriteLine("\nDenklemin İki Kökü Vardır     x1 : {0}     x2 : {1}", x1, x2);
            }

            else if (Delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Denklemin Bir Kökü Vardır ve x = " + x);
            }

            else
            {
                Console.WriteLine("Reel Kök yoktur.");
            }

            Console.WriteLine("\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basınız...");

            Console.ReadLine();
        }
    }
}
