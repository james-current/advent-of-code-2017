using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace advent
{
    public static class Day2
    {
        public static int Problem1(string input)
        {
            return SplitTable(input)
                .Select(ProcessRow1)
                .Sum();
        }

        public static int Problem2(string input)
        {
            return SplitTable(input)
                .Select(ProcessRow2)
                .Sum();
        }

        private static IEnumerable<string> SplitTable(string input)
        {
            var regex = new Regex(@"\n");
            return regex.Split(input);
        }

        public static int ProcessRow1(string row)
        {
            var nums = SplitRow(row);
            var max = nums.Max();
            var min = nums.Min();
            return max - min;
        }

        public static int ProcessRow2(string row)
        {
            var nums = SplitRow(row);
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] % nums[j] == 0)
                    {
                        return nums[i] / nums[j];
                    }
                    if (nums[j] % nums[i] == 0)
                    {
                        return nums[j] / nums[i];
                    }
                }
            }
            return 0;
        }

        private static int[] SplitRow(string row)
        {
            var regex = new Regex(@"\s");
            return regex.Split(row).Select(int.Parse).ToArray();
        }
    }
}
