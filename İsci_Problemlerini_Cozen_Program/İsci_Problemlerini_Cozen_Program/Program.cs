using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsci_Problemlerini_Cozen_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, t;
            Console.WriteLine("Neyi Hesaplamak istiyorsunuz ?   \n\n Yapılacak İşin Süresi (1)\n İş Miktarı (2)\n İşçi Sayısı (3): ");
            x = Convert.ToInt32(Console.ReadLine());
        
        if(1 <= x && x <= 3)
        { 
            if(x == 1)
            {
                Console.WriteLine("Sırasıyla Yapılacak İş Miktarı Ve İşçi Sayısını Giriniz : ");
                y = Convert.ToInt32(Console.ReadLine());        //işin süresi
                z = Convert.ToInt32(Console.ReadLine());
                t = y * z;
                Console.WriteLine("İşin Süresi : {0} dk", t);
            }

            else if(x == 2)
            {
                Console.WriteLine("Sırasıyla Yapılacak İşin Süresi (dk) Ve İşçi Sayısını Giriniz : ");
                y = Convert.ToInt32(Console.ReadLine());        //İş Miktarı
                z = Convert.ToInt32(Console.ReadLine());
                t = y / z;
                Console.WriteLine("İş Miktarı : " + t);
            }

            else
            {
                Console.WriteLine("Sırasıyla Yapılacak İşin Süresi (dk) Ve İş Miktarını Giriniz : ");
                y = Convert.ToInt32(Console.ReadLine());        //İşçi Sayısı
                z = Convert.ToInt32(Console.ReadLine());
                t = y / z;
                Console.WriteLine("İşçi Sayısı : " + t);
            }
        }
        else
        {
            Console.WriteLine("\nYanlış Bir Rakam Girdiniz");
        }
            Console.WriteLine("\n\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basınız");
            Console.ReadLine();
        }
    }
}
