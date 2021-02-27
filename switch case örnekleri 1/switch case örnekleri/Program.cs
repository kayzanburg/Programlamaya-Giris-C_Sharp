using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_örnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int gun;


            Console.Write("1-7 Arası bir Sayı Giriniz : ");
            gun=Convert.ToInt16(Console.ReadLine());

            switch(gun)
            {

                case 1: Console.WriteLine("Haftanın Birinci Günü Pazatesi Günüdür.");
                    break;
                case 2: Console.WriteLine("Haftanın İkinci Günü Salı Günüdür.");
                    break;
                case 3: Console.WriteLine("Haftanın üçüncü günü Çarşamba Günüdür.");
                    break;
                case 4: Console.WriteLine("Haftanın Dördüncü Günü Perşembe Günüdür.");
                    break;
                case 5: Console.WriteLine("Haftanın Beşinci Günü Cuma Günüdür.");
                    break;
                case 6: Console.WriteLine("Haftanın Altıncı Günü Cumartesi Günüdür.");
                    break;
                case 7: Console.WriteLine("Haftanın Yedinci Günü Pazar Günüdür.");
                    break;
                default: Console.WriteLine("Hatalı Bir Sayı Girdiniz...");
                    break;
            }

            Console.ReadLine();
        }
    }
}
