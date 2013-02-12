using System;

namespace Solutions
{
    public class Problem30
    {
        public object Solve()
        {
            long result = 0;
            for (long i = 2; i < 1000000; i++)
            {
                if (i == GetSumOf5ThPowerOfDigits(i))
                {
                    result += i;
                }
            }
            return result;
        }

        private static long GetSumOf5ThPowerOfDigits(long n)
        {
            long sum = 0;
            while (n > 0)
            {
                long d = n%10;
                sum += (long) Math.Pow(d, 5);
                n = n/10;
            }
            return sum;
        }
    }
}