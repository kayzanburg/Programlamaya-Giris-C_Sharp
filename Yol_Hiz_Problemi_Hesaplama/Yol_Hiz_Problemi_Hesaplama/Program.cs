using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yol_Hiz_Problemi_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            float mesafe, hiz, sure, x;            

            Console.WriteLine("Neyi Hesaplamak istiyorsunuz ?   \n\n Mesafe (1)\n Hız (2)\n Süre (3): ");
            x = Convert.ToInt32(Console.ReadLine());
      
      if(1 <= x && x <= 3)
      { 
            if (x == 1)
            {
                Console.WriteLine("\nSırasıyla Hız (km/h) Ve Süre (sa) Giriniz : ");
                hiz = Convert.ToInt32(Console.ReadLine());        //mesafe
                sure = Convert.ToInt32(Console.ReadLine());
                mesafe = hiz * sure;
                Console.WriteLine("mesafe : {0} km", mesafe);
            }

            else if (x == 2)
            {
                Console.WriteLine("\nSırasıyla Mesafe (km) Ve Süre (sa) Giriniz : ");
                mesafe = Convert.ToInt32(Console.ReadLine());        //hız
                sure = Convert.ToInt32(Console.ReadLine());
                hiz = mesafe / sure;
                Console.WriteLine("Hız : {0} (km/h)", hiz);
            }

            else
            {
                Console.WriteLine("\nSırasıyla Mesafe (km) Ve Hız (km/h) Giriniz : ");
                mesafe = Convert.ToInt32(Console.ReadLine());        //Süre
                hiz = Convert.ToInt32(Console.ReadLine());
                sure = mesafe / hiz;
                Console.WriteLine("Süre : {0} Saattir.", sure);
            }
      }
      
      else
      {
          Console.WriteLine("\nYanlış Bir Rakam Tuşladınız");
      }
           
            Console.Write("\n\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basınız...");
            Console.ReadLine();
        }
    }
}
