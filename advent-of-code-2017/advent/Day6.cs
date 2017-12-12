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
            var seen = new HashSet<string>() {string.Join("", memBanks)};
            MemCycle(seen, memBanks);
            return seen.Count;
        }

        public static int Problem2(string input)
        {
            var memBanks = ParseInput(input);
            var seen = new HashSet<string>() {string.Join("", memBanks)};
            var dupe = MemCycle(seen, memBanks);
            var dupeIndex = seen.ToList().IndexOf(dupe);
            return seen.Count - dupeIndex;
        }

        private static string MemCycle(ISet<string> seen, int[] memBanks)
        {
            while (true)
            {
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

                var memBanksString = string.Join("", memBanks);

                if (seen.Contains(memBanksString))
                {
                    return memBanksString;
                }

                seen.Add(memBanksString);
            }
        }

        private static int[] ParseInput(string input)
        {
            var regex = new Regex(@"\s");
            return regex.Split(input).Select(int.Parse).ToArray();
        }
    }
}
