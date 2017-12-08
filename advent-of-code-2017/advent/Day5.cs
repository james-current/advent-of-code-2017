using System.Linq;
using System.Text.RegularExpressions;

namespace advent
{
    public static class Day5
    {
        public static int Problem1(string jumpList)
        {
            var jumps = ParseInput(jumpList);
            var steps = 0;
            var i = 0;
            while (true)
            {
                steps++;
                var next = jumps[i]++ + i;

                if (next < 0 || next > jumps.Length - 1)
                {
                    return steps;
                }

                i = next;
            }
        }

        public static int Problem2(string jumpList)
        {
            var jumps = ParseInput(jumpList);
            var steps = 0;
            var i = 0;
            var next = 0;
            while (true)
            {
                steps++;

                if (jumps[i] < 3)
                {
                    next = jumps[i]++ + i;
                }
                else
                {
                    next = jumps[i]-- + i;
                }

                if (next < 0 || next > jumps.Length - 1)
                {
                    return steps;
                }

                i = next;
            }
        }

        private static int[] ParseInput(string input)
        {
            var regex = new Regex(@"\n");
            return regex.Split(input).Select(int.Parse).ToArray();
        }
    }
}
