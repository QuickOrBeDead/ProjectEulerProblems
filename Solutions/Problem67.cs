using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Solutions
{
    public class Problem67
    {
        public static object Solve()
        {
            int result = Problem18.CalculateMaxTrianglePathSum(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\triangle.txt")));
            return result;
        }
    }
}
