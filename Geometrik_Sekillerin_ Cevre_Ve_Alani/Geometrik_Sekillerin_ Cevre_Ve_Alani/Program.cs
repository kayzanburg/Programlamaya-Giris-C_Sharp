using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrik_Sekillerin__Cevre_Ve_Alani
{
    class Program
    {
        static void Main(string[] args)
        {
            
                double Cevre, Alan, x, y, z, t, Kenar1, Kenar2;

                Console.WriteLine("Alanını Ve Çevresini Hesaplamak İstediğiniz Geometrik Şekli Seçiniz");
            Console.WriteLine("____________________________________________________________________\n");
                Console.WriteLine(" Kare (1)\n Dikdörtgen(2)\n Üçgen(3)\n Yamuk(4) : ");
                x = Convert.ToInt32(Console.ReadLine());

                if (1 <= x && x <= 4)
                {
                    if (x == 1)
                    {
                        Console.WriteLine("Karenin Bir Kenarını Giriniz : ");
                        y = Convert.ToInt32(Console.ReadLine());

                        if (y > 0)
                        {
                            Alan = (y * y);
                            Cevre = 4 * y;

                            Console.WriteLine("\nKarenin Alanı : {0}\nKarenin Çevresi : {1}", Alan, Cevre);
                        }

                        else
                        {
                            Console.WriteLine("\nHatalı Sayı Girdiniz");
                            goto Bitis;
                        }
                        
                    }

                    else if (x == 2)
                    {
                        Console.WriteLine("Sırasıyla Dikdörtgenin Uzun Ve Kısa Kenarını Giriniz : ");
                        y = Convert.ToInt32(Console.ReadLine());
                        z = Convert.ToInt32(Console.ReadLine());

                        if ( y > 0 && z > 0)
                        {
                            Alan = y * z;
                            Cevre = 2 * (y + z);
                            Console.WriteLine("\nDikdörtgenin Alanı : {0}\nDikdörtgenin Çevresi : {1}", Alan, Cevre);
                        }

                        else
                        {
                            Console.WriteLine("\nHatalı Sayı Girdiniz");
                            goto Bitis;
                        }
                       
                    }

                    else if (x == 3)
                    {
                        Console.WriteLine("Üçgenin Sırasıyla Dik yatay Kenarını, Dik Dikey Kenarını, Ve Hipotenüsü Giriniz : \n");
                        Kenar1 = Convert.ToInt32(Console.ReadLine());
                        Kenar2 = Convert.ToInt32(Console.ReadLine());
                        z = Convert.ToInt32(Console.ReadLine());

                        if ( Kenar1 > 0 && Kenar2 > 0 && z > 0)
                        {
                            Alan = (Kenar1 * Kenar2) / 2;
                            Cevre = Kenar1 + Kenar2 + z;
                            Console.WriteLine("\nÜçgenin Alanı : {0}\nÜçgenin Çevresi : {1}", Alan, Cevre);
                        }

                        else
                        {
                            Console.WriteLine("\nHatalı Sayı Girdiniz");
                            goto Bitis;
                        }
                        
                    }

                    else if (x == 4)
                    {
                        Console.WriteLine("Yamuğun Sırasıyla alt Taban, Üst Taban, Yüksekliği, Birinci Köşenin Açısı, İkinci Köşenin Açısını Giriniz : ");
                        Kenar1 = Convert.ToInt32(Console.ReadLine());
                        Kenar2 = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
                        z = Convert.ToInt32(Console.ReadLine());
                        t = Convert.ToInt32(Console.ReadLine());

                        if(Kenar1 > 0 && Kenar2 > 0 && y > 0 && z > 0 && t > 0 )
                        {
                            Alan = (y * (Kenar1 + Kenar2)) / 2;
                            Cevre = (y * (1 / (Math.Sin((Math.PI * z) / 180))) + (1 / (Math.Sin((Math.PI * t) / 180)))) + Kenar1 + Kenar2;
                            Console.WriteLine("\nYamuğun Alanı : {0}\nYamuğun Çevresi : {1}", Alan, Cevre);
                        }

                        else
                        {
                            Console.WriteLine("\nHatalı Sayı Girdiniz");
                            goto Bitis;
                        }
                        
                    }
                }

                else
                {
                    Console.WriteLine("\nYanlış Rakam Tuşladınız");
                }

                Bitis:

                Console.Write("\n\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basınız...");
                Console.ReadLine();
                           
        }

    }
}
