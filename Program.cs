using System;
using System.Linq;

namespace FarkHesaplamaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n tane sayı girin:");
            int[] sayilar = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            FarkHesaplayici farkHesaplayici = new FarkHesaplayici();
            int sonuc = farkHesaplayici.FarklariHesapla(sayilar);

            Console.WriteLine("Sonuç: " + sonuc);
        }
    }

    class FarkHesaplayici
    {
        public int FarklariHesapla(int[] sayilar)
        {
            int toplamFark = 0;

            foreach (int sayi in sayilar)
            {
                if (sayi < 67)
                {
                    toplamFark += 67 - sayi;
                }
                else
                {
                    toplamFark += (int)Math.Pow(sayi - 67, 2);
                }
            }

            return toplamFark;
        }
    }
}
