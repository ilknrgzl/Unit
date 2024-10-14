using System;
using Ch04Ex02PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı girin:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                string primeFactors = PrimeFactors.GetPrimeFactors(number);
                Console.WriteLine($"Asal çarpanları: {primeFactors}");
            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
            }
        }
    }
}
