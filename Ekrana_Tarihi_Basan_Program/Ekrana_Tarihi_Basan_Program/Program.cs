using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekrana_Tarihi_Basan_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman;
            zaman = DateTime.Now;
            Console.WriteLine("Tarih : {0}", zaman);
            Console.Write("\nÇıkış Yapmak İçin Bir Tuşa Basınız...");
            Console.ReadLine();
        }
    }
}
