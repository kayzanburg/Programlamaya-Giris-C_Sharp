using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_Buyuk_Sayiyi_Bulan_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dizi = new int[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("{0}.Sayiyi Giriniz : ", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            int EnBüyükSayi;

            EnBüyükSayi = dizi[0];

            for (int i = 0; i <= 4; i++)
            {

                if (EnBüyükSayi < dizi[i])
                {
                    EnBüyükSayi = dizi[i];
                }
            }

            Console.WriteLine("\nEn Büyük Sayi Değeri : {0}", EnBüyükSayi);
            Console.ReadLine();
        }
    }
}
