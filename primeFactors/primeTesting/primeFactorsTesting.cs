using Xunit;
using packet;


namespace primeTesting
{
    public class primeFactorsTesting
    {
        [Fact]
        public void testingFive()
        {
            string ans = "5";
            var compute = new primes();
            string actual = compute.printPrimeFactors(5);
            Assert.Equal(ans , actual);
        }
        [Fact]
        public void testingTwo()
        {
            string ans = "2";
            var compute = new primes();
            string actual = compute.printPrimeFactors(2);
            Assert.Equal(ans , actual);
        }

        [Fact]
        public void testingNine()
        {
            string ans = "3 3";
            var compute = new primes();
            string actual = compute.printPrimeFactors(9);
            Assert.Equal(ans , actual);
        }

        [Fact]
        public void testingSixity()
        {
            string ans = "2 2 3 5";
            var compute = new primes();
            string actual = compute.printPrimeFactors(60);
            Assert.Equal(ans , actual);
        }

        [Fact]
        public void testingOne()
        {
            string ans = "NO prime factors";
            var compute = new primes();
            string actual = compute.printPrimeFactors(1);
            Assert.Equal(ans , actual);
        }
    }
}
