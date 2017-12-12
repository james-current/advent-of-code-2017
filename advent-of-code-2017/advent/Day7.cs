using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace advent
{
    public static class Day7
    {
        public static string Problem1(string input)
        {
            var programs = ParseInput(input);
            var bases = programs.Where(x => x.Contains("->")).ToArray();
            var programMap = bases.ToDictionary(GetProgramName, GetProgramList);
            return programMap.Select(x => x.Key).First(x => !programMap.Values.Any(list => list.Contains(x)));
        }

        public static string GetProgramName(string programLine)
        {
            var firstSpace = programLine.IndexOf(' ');
            return programLine.Substring(0, firstSpace);
        }

        public static string[] GetProgramList(string programLine)
        {
            var startOfList = programLine.IndexOf('>') + 2;
            var regex = new Regex(@", ");
            return regex.Split(programLine.Substring(startOfList));
        }

        private static IEnumerable<string> ParseInput(string input)
        {
            var regex = new Regex(@"\n");
            return regex.Split(input);
        }
    }
}
