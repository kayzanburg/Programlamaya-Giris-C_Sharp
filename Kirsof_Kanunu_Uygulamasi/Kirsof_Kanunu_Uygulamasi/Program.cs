using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirsof_Kanunu_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            double R1, R2, R3, Rx, I, I1, I2, V, V1, V2, Res;

//--------------------------------------------------------------------------------------------------
//                           Kullanıcıdan Bilgiler Alınır
//--------------------------------------------------------------------------------------------------
            Console.WriteLine("| KİRŞOF KANUNU UYGULAMASI |");
            Console.WriteLine(" -------------------------");
            Console.Write("\nV Değerini Giriniz = "); V = Convert.ToDouble(Console.ReadLine());
            Console.Write("R1 Değerini Giriniz = "); R1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("R2 Değerini Giriniz = "); R2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("R3 Değerini Giriniz = "); R3 = Convert.ToDouble(Console.ReadLine());
//--------------------------------------------------------------------------------------------------
//                                İşlemler Yapılır
//--------------------------------------------------------------------------------------------------
            Rx = (R2 * R3) / (R2 + R3);                                   // Rx Hesaplanır
            Res = R1 + Rx;                                                // Res Hesaplanır
            I = V / Res;                                                  // Akım(Toplam)
            V1 = I * R1;                                                  // V1 Gerilimi
            V2 = I * Rx;                                                  // V2 Gerilimi
            I1 = V2 / R2;                                                 // I1 Akımı
            I2 = V2 / R3;                                                 // I2 Akımı
//--------------------------------------------------------------------------------------------------
//                          Ekrana Yazdırma İşlemi Yapılır
//--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\n\nHesaplama Sonuçları :");
            Console.WriteLine("---------------------");

            Console.WriteLine("V1 Değeri = {0} V", V1);
            Console.WriteLine("V2 Değeri = {0} V", V2);
            Console.WriteLine("I Değeri = {0} A", I);
            Console.WriteLine("I1 Değeri = {0} A", I1);
            Console.WriteLine("I2 Değeri = {0} A", I2);
            Console.WriteLine("Res Değeri = {0} ohm ", Res);
//--------------------------------------------------------------------------------------------------
//                          Program Sonlandırılır...
//--------------------------------------------------------------------------------------------------

            Console.Write("\n\n\nProgram Sonlandı. Bir Tuşa Basınız ...");
            Console.ReadLine();

        }
    }
}
