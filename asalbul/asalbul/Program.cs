using System;

namespace asalbul
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int girilenSayi = 1, sira, kacinci = 0; 
               
                Console.Write("Kaçıncı sıradaki asal sayıyı öğrenmek istiyorsunuz: ");
                sira = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= girilenSayi; i++)
                {
                    int sayac = 0;
                    for (int y = 1; y <= girilenSayi; y++)
                    {
                        if (i % y == 0) sayac += 1;
                    }
                    if (sayac == 2)
                    {
                        kacinci++;

                        if (kacinci == sira)
                        {
                            Console.WriteLine("{0}. sıradaki asal Sayı={1}", kacinci, i);
                            break;
                        }
                    }
                    girilenSayi++;
                }
            }
        }
    }
}
