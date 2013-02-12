namespace Solutions
{
    public class Problem34
    {
        public object Solve()
        {
            long sum = 0;
            for (int i = 3; i <= 99999; i++)
            {
                if (i == GetSumOfDigitFactorials(i))
                {
                    sum += i;
                }
            }
            return sum;
        }

        private static long GetSumOfDigitFactorials(long n)
        {
            long sum = 0;
            while (n > 0)
            {
                long d = n % 10;
                sum += Factorial(d);
                n = n / 10;
            }
            return sum;
        }

        private static long Factorial(long n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}