using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpim_Tablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n **** Çarpım Tablosu ****");
            Console.WriteLine(" ______________________");

            for (int i = 0; i <= 10; i++ )
            { 
                for(int j = 0 ; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2} \n", i, j, (i*j));
                }
                Console.WriteLine("_______________________________\n");
            }
                Console.ReadLine();
        }
    }
}
