using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizinin_Tum_Elemanlarini_Yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, A;

            Console.WriteLine("\n **** Dizinin Tüm Elemanları****");
            Console.WriteLine("|--------------------------------|");

            int[] dizi = new int[10];
            for (i = 0; i <= 9; i++)
            {
                dizi[i] = i + 1;
                Console.WriteLine("dizi[{0}] = {1}", i, i + 1);

            }


            Console.WriteLine("\niki ile çarpılmış halleri");

            for (j = 0; j <= 9; j++)
            {

                A = 2 * (dizi[j]);
                Console.Write(A + "-");

            }

            Console.ReadLine();
        }
    }
}
