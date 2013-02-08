using System.Collections.Generic;

namespace Solutions
{
    public static class Problem24
    {
        private static class FactorialCache
        {
            private static readonly Dictionary<int, int> s_Dictonary = new Dictionary<int, int>();

            public static int CalculateFactorial(int n)
            {
                int result;
                if (s_Dictonary.TryGetValue(n, out result))
                {
                    return result;
                }
                result = Factorial(n);
                s_Dictonary.Add(n, result);
                return result;
            }

            private static int Factorial(int n)
            {
                int result;
                if (s_Dictonary.TryGetValue(n, out result))
                {
                    return result;
                }
                if (n == 1)
                {
                    return 1;
                }
                return n * Factorial(n - 1);
            }
        }

        //2783915460
        public static void Solve()
        {
            string result = GetValue(10, 1000000);
            result.ToString();
        }

        private static string GetValue(int length, int count)
        {
            List<int> digits = new List<int>();
            for (int i = 0; i < length; i++)
            {
                digits.Add(i);
            }
            int[] factors = new int[length];
            count = count - 1;
            for (int i = length - 1; i > 0; i--)
            {
                int factorial = FactorialCache.CalculateFactorial(i);
                if (factorial > count)
                {
                    continue;
                }
                int digit = count/factorial;
                factors[length - i - 1] = digit;
                count = count%factorial;
            }
            string result = string.Empty;
            for (int i = 0; i < factors.Length; i++)
            {
                int index = factors[i];
                result += digits[index].ToString();
                digits.RemoveAt(index);
            }
            return result;
        }
    }
}