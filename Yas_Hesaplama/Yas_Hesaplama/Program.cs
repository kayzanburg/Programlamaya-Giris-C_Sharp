using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yas_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int Gun, Ay, Yıl;
            Console.WriteLine("Lüften Doğum Tarihinizi Sırasıyla gün-ay-yıl Şeklinde Giriniz : ");
            Gun = Convert.ToInt32(Console.ReadLine());
            Ay = Convert.ToInt32(Console.ReadLine());
            Yıl = Convert.ToInt32(Console.ReadLine());

            DateTime bugun = DateTime.Today;
            DateTime DogumGunu = new DateTime(Yıl, Ay, Gun);            
            TimeSpan span = bugun.Subtract(DogumGunu);
            Console.WriteLine("\nHayatta Olduğun Gün sayısı : " + span.TotalDays);

            int yıl = (int)span.TotalDays / 365;                              //  yıl
            int ay = (int)(span.TotalDays - (yıl * 365)) / 30;                //  ay
            int gun = (int)((span.TotalDays - (yıl * 365)) - (ay * 30));      //  gün


            Console.WriteLine(" \n{0} yıl  {1} ay  {2} gün dür yaşıyorsun...", yıl, ay, gun);
            Console.ReadLine();
        }
    }
}
