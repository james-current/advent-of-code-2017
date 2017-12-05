using System.Linq;
using System.Text.RegularExpressions;

namespace advent
{
    public static class Day2
    {
        public static int Problem1(string input)
        {
            var sum = 0;
            return sum;
        }

        public static int ProcessRow(string row)
        {
            var regex = new Regex(@"\s");
            var nums = regex.Split(row).Select(int.Parse).ToArray();
            var max = nums.Max();
            var min = nums.Min();
            return max - min;
        }
    }
}
