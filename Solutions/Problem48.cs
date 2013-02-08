using System.Numerics;

namespace Solutions
{
    public class Problem48
    {
        public object Solve()
        {
            const long mask = 10000000000;
            long last10Digits = 0;
            for (long i = 1; i <= 1000; i++)
            {
                long temp = i;
                for (long j = 1; j < i; j++)
                {
                    temp *= i;
                    temp = temp % mask;
                }
                last10Digits += temp;
                last10Digits = last10Digits % mask;
            }
            last10Digits.ToString();
            return last10Digits;
        }
    }
}
