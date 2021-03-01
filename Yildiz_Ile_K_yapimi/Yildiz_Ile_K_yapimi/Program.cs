using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yildiz_Ile_K_yapimi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0 ; i <= 13 ; i++)
            {

                for (int t = 13; i <= t; t--)
                {
                    Console.Write("*");
                }
                
                Console.Write("\n");
            }

            for (int i = 0; i <= 13; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadLine();


        }
    }
}
