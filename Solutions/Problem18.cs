using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    public static class Problem18
    {
        private const string TREE_TEXT = @"75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";

        public static object Solve()
        {
            int result = CalculateMaxTrianglePathSum(TREE_TEXT);
            return result;
        }

        public static int CalculateMaxTrianglePathSum(string treeText)
        {
            List<List<int>> treeData = GetTreeData(treeText);
            for (int i = treeData.Count - 1; i >= 0; i--)
            {
                List<int> ints = treeData[i];
                for (int j = 0; j < ints.Count - 1; j++)
                {
                    int n = Math.Max(ints[j], ints[j + 1]);
                    treeData[i - 1][j] += n;
                }
            }
            int result = treeData[0][0];
            return result;
        }

        private static List<List<int>> GetTreeData(string treeText)
        {
            string[] lines = treeText.Split(new[] {"\r\n", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            List<List<int>> treeData = new List<List<int>>();
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] numbers = line.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                treeData.Add(numbers.Select(int.Parse).ToList());
            }
            return treeData;
        }
    }
}
