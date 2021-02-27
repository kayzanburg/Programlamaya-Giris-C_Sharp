using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Sayinin_Basamak_Sayisini_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bir Sayı Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamak = 0;

            if (sayi > 0)
            {
                
                while (sayi > 0)
                {
                    
                    basamak++;
                    sayi = sayi / 10;
                }             
                    Console.WriteLine("Girdiğiniz sayı " + basamak + " basamaklıdır.");            
            }
           
            else if (sayi < 0)
            {
                
                while (sayi < 0)
                {

                    basamak++;
                    sayi =(int) sayi / 10;                    
                }
                    Console.WriteLine("Girdiğiniz sayı " + basamak + " basamaklıdır.");
            }       
            
            else
            {
                Console.WriteLine("Girilen Sayı 0'dır Ve 1 Basamaklıdır");
            }

            Console.ReadLine();
        }
    }
}
