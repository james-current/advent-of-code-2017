using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace advent
{
    public static class Day6
    {
        public static int Problem1(string input)
        {
            var memBanks = ParseInput(input);
            var seen = new HashSet<int[]>(new IntArrayEqualityComparer()) {(int[]) memBanks.Clone()};
            var steps = 0;

            while (true)
            {
                steps++;
                var max = memBanks.Max();
                var indexOfMax = Array.IndexOf(memBanks, max);
                memBanks[indexOfMax] = 0;

                var startIndex = indexOfMax == memBanks.Length - 1 ? 0 : indexOfMax + 1;

                for (var i = startIndex; max > 0; max--)
                {
                    memBanks[i]++;

                    if (++i == memBanks.Length)
                    {
                        i = 0;
                    }
                }

                if (seen.Contains(memBanks))
                {
                    return steps;
                }

                seen.Add((int[]) memBanks.Clone());
            }
        }

        private static int[] ParseInput(string input)
        {
            var regex = new Regex(@"\s");
            return regex.Split(input).Select(int.Parse).ToArray();
        }
    }

    internal class IntArrayEqualityComparer : IEqualityComparer<int[]>
    {
        public bool Equals(int[] x, int[] y)
        {
            if (x == null)
            {
                return y == null;
            }
            return !x.Where((t, i) => t != y[i]).Any();
        }

        public int GetHashCode(int[] obj)
        {
            return obj.Aggregate(17, (current, i) => current * 23 + i);
        }
    }
}