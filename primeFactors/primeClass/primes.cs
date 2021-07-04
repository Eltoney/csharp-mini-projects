using System;
using System.Collections.Generic;

namespace packet
{
    public class primes
    {
        public string printPrimeFactors(int n)
        {
            if (n < 2)
            {
                return "NO prime factors";
            }
            List<int> factors = new List<int>();
            for (int i = 2, d = 1; i * i <= n; i += d, d = 2)
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
            }
            if (n != 1)
                factors.Add(n);
            string ans = factors[0].ToString();
            for (int i = 1; i < factors.Count; i++)
            {
                ans += " ";
                ans += factors[i].ToString();
                // if (i != factors.Count - 1)
                // {
                //     ans += " ";
                // }
            }
            return ans;

        }
    }
}
