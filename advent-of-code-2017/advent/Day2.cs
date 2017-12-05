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
            var sum = 0;
            return sum;
        }

        private static string[] SplitTable(string input)
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
            var sum = 0;
            return sum;
        }

        private static int[] SplitRow(string row)
        {
            var regex = new Regex(@"\s");
            return regex.Split(row).Select(int.Parse).ToArray();
        }
    }
}
