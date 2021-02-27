using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_örnekleri_2
{
    class Program
    {
        static void Main(string[] args)
        {


            string mevsim;

            Console.Write("Lütfen Küçük Harf İle Bir Mevsim İsmi Giriniz : ");
            mevsim = (Console.ReadLine());

            switch (mevsim)
            {
                   case "ilkbahar" : Console.WriteLine("İlkbahar Mevsimi Ayları ( Mart - Nisan - Mayıs )");
                        break;
                   case "yaz": Console.WriteLine("Yaz Mevsimi Ayları ( Haziran - Temmuz - Ağustos )");
                        break;
                   case "sonbahar": Console.WriteLine("Sonbahar Mevsimi Ayları ( Eylül - Ekim - Kasım )");
                        break;
                   case "kış": Console.WriteLine("Kış Mevsimi Ayları( Aralık - Ocak - Şubat )");
                        break;
                   default: Console.WriteLine("Yanlış Bir İfade Tuşladınız...");
                        break;
            }

            Console.ReadLine();
        }
        
    }
}
