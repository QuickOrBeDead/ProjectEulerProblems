using System;
using System.Globalization;

namespace Solutions
{
    public class Problem36
    {
        public object Solve()
        {
            long sum = 0;
            for (int i = 1; i < 1000000; i += 2)
            {
                if (IsPalindromic(i) && IsPalindromic(Convert.ToString(i, 2)))
                {
                    sum += i;
                }
            }
            return sum;
        }

        public bool IsPalindromic(int n)
        {
            string s = n.ToString(CultureInfo.InvariantCulture);
            return IsPalindromic(s);
        }

        private static bool IsPalindromic(string s)
        {
            int len = s.Length;
            int lastIndex = len - 1;
            for (int i = 0; i < len; i++)
            {
                if (s[i] != s[lastIndex - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
