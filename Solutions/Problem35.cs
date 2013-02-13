using System;

namespace Solutions
{
    public class Problem35
    {
        public object Solve()
        {
            int count = 13;
            for (int i = 101; i < 1000000; i += 2)
            {
                if (IsPrime(i))
                {
                    int j = (int) Math.Log10(i);
                    bool p = true;
                    int r = i;
                    for (int o = 0; o < j; o++)
                    {
                        int k = 0;
                        for (int l = 0; l <= j; l++)
                        {
                            int digit = ((r / (int)Math.Pow(10, l)) % 10);
                            if(digit % 2 == 0)
                            {
                                p = false;
                                break;
                            }
                            int m = j - ((j - l + 1) % (j + 1));
                            k += digit * (int)Math.Pow(10, m);
                        }
                        if(!p)
                        {
                            break;
                        }
                        if (!IsPrime(k))
                        {
                            p = false;
                            break;
                        }
                        r = k;
                    }
                    if(p)
                    {
                        count++;
                    }
                }
            }
            return count;
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
