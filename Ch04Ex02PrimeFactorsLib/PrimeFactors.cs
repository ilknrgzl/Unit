using System;
using System.Collections.Generic;
using System.Text;

namespace Ch04Ex02PrimeFactorsLib
{
    // Asal çarpan hesaplama sınıfı
    public static class PrimeFactors
    {
        // Verilen sayının asal çarpanlarını döndürür
        public static string GetPrimeFactors(int number)
        {
            if (number < 2)
                return "2'den küçük sayılar için asal çarpan yoktur";

            StringBuilder result = new StringBuilder(); // Sonucu tutacak
            List<int> factors = new List<int>(); // Asal çarpanları saklamak için liste
            int divisor = 2; // İlk asal çarpan

            while (number > 1)
            {
                while (number % divisor == 0)
                {
                    factors.Add(divisor); // Çarpanı ekle
                    number /= divisor; // Sayıyı böl
                }
                divisor++; // Sonraki asal çarpana geç
            }

            result.Append(string.Join(" x ", factors)); // Çarpanları birleştir
            return result.ToString(); // Sonucu döndür
        }
    }
}
