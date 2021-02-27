using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yildizlardan_Ucgen_Yapma
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1 ; i <= 13 ; i++)
            {
                for(int j = 1; j <= i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
