using System.Numerics;
namespace Solutions
{
    public static class Problem15
    {
        private static BigInteger Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        public static object Solve()
        {
            BigInteger result = Factorial(40) / (Factorial(20) * Factorial(20));
            return result;
        }
    }
}
