using System.Collections.Generic;
using System.Numerics;

namespace Solutions
{
    public class Problem29
    {
        public object Solve()
        {
            HashSet<BigInteger> hashSetNumbers = new HashSet<BigInteger>();
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    hashSetNumbers.Add(BigInteger.Pow(i, j));
                }
            }
            int result = hashSetNumbers.Count;
            return result;
        }
    }
}