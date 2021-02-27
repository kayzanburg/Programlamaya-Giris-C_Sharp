using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrencinin_Notlarini_Yazan_Program
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] Ad = new string[3];
            int[] Sinav1 = new int[3];
            int[] Sinav2 = new int[3];
            int[] Proje = new int[3];
            float[] Ortalama = new float[3];

            for (int i = 0; i <= 2; i++)
            {
                Console.Write("\nÖğrencinin ismini giriniz : ");
                Ad[i] = Console.ReadLine();

                Console.Write("Öğrencinin Birinci Sınav Notunu Giriniz : ");
                Sinav1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Öğrencinin İkinci Sınav Notunu Giriniz : ");
                Sinav2[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Öğrencinin Proje Notunu Giriniz : ");
                Proje[i] = Convert.ToInt32(Console.ReadLine());

                Ortalama[i] =(float) (Sinav1[i] + Sinav2[i] + Proje[i]) / 3;
            }

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("\n\n\nÖğrencinin Adı : {0}\nBirinci Sinav Notu : {1}\nİkinci Sinav Notu : {2}\nProje Notu : {3}\nOrtalama : {4:#.##}", Ad[i], Sinav1[i], Sinav2[i], Proje[i], Ortalama[i]);
            }

            Console.ReadLine();
        }
    }
}
