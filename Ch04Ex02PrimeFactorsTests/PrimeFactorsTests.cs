using Xunit; 
using Ch04Ex02PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsTests
{
    public class PrimeFactorsTests
    {
        // 4 sayısının asal çarpanlarını test eder
        [Fact]
        public void TestPrimeFactorsOf4()
        {
            Assert.Equal("2 x 2", PrimeFactors.GetPrimeFactors(4));
        }

        // 7 sayısının asal çarpanlarını test eder
        [Fact]
        public void TestPrimeFactorsOf7()
        {
            Assert.Equal("7", PrimeFactors.GetPrimeFactors(7));
        }

        // 30 sayısının asal çarpanlarını test eder
        [Fact]
        public void TestPrimeFactorsOf30()
        {
            Assert.Equal("2 x 3 x 5", PrimeFactors.GetPrimeFactors(30));
        }

        // 40 sayısının asal çarpanlarını test eder
        [Fact]
        public void TestPrimeFactorsOf40()
        {
            Assert.Equal("2 x 2 x 2 x 5", PrimeFactors.GetPrimeFactors(40));
        }

        // 50 sayısının asal çarpanlarını test eder
        [Fact]
        public void TestPrimeFactorsOf50()
        {
            Assert.Equal("2 x 5 x 5", PrimeFactors.GetPrimeFactors(50));
        }

        // 1 sayısının asal çarpanlarını test eder (geçersiz durum)
        [Fact]
        public void TestPrimeFactorsOf1()
        {
            Assert.Equal("2'den küçük sayılar için asal çarpan yoktur", PrimeFactors.GetPrimeFactors(1));
        }
    }
}
