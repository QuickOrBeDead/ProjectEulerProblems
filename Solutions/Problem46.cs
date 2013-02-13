using System;
using System.Collections.Generic;

namespace Solutions
{
    public class Problem46
    {
        public object Solve()
        {
            List<int> primes = Primes(10000);
            int result = 0;
            for (int i = 5; i < 10000; i+=2)
            {
                bool b = true;
                for (int j = 0; j < primes.Count; j++)
                {
                    int prime = primes[j];
                    if(i >= prime)
                    {
                        if(IsSquare((i - prime) / 2))
                        {
                            b = false;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if(b)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        private static bool IsSquare(int n)
        {
            double sqrt = Math.Sqrt(n);
            return sqrt == (int)sqrt;
        }

        private static List<int> Primes(int n)
        {
            List<int> primes = new List<int>();
            for (int i = 3; i <= n; i+=2)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private static bool IsPrime(long n)
        {
            long upperBoundary = (long)Math.Sqrt(n);
            for (long i = 2; i <= upperBoundary; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}