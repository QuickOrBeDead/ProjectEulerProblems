namespace Solutions
{
    public class Problem28
    {
        public object Solve()
        {
            long result = 1;
            for (int i = 3; i <= 1001; i+=2)
            {
                long n = i*i;
                result += 4*n - 6*(i - 1);
            }
            return result;
        }
    }
}