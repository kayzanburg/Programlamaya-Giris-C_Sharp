using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_sayiya_Kadar_Toplam_Degeri
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, toplam = 0, Sayi;

            Console.Write("Bir Sayı Değeri Giriniz : ");
            Sayi = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= Sayi; i++)
            {
                toplam += i;
            }

            Console.WriteLine("1 den {0} Sayısına Kadar Olan Sayıların Toplamı : {1}", Sayi, toplam);

            Console.ReadLine();
        }
    }
}
