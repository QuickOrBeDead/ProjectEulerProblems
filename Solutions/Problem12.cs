using System;
namespace Solutions
{
    public class Problem12
    {
        private static int CalculateNumberOfDivisors(long n)
        {
            int numberOfDivisors = 0;
            long upperBoundary = (long)Math.Sqrt(n);
            for (long i = 1; i <= upperBoundary; i++)
            {
                if (n % i == 0)
                {
                    numberOfDivisors++;
                }
            }
            return numberOfDivisors * 2;
        }

        public object Solve()
        {
            long triangleNumber = 1;
            long n = 1;

            while (CalculateNumberOfDivisors(triangleNumber) < 500)
            {
                n++;
                triangleNumber += n;
            }
            return triangleNumber;
        }
    }
}
