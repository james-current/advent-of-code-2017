using System.Linq;
using System.Text.RegularExpressions;

namespace advent
{
    public static class Day5
    {
        public static int Problem1(string jumpList)
        {
            var regex = new Regex(@"\n");
            var jumps = regex.Split(jumpList).Select(int.Parse).ToArray();
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
    }
}