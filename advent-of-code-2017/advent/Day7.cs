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

        public static int Problem2(string input)
        {
            var programs = ParseInput(input).ToArray();
            var programMap = programs.ToDictionary(GetProgramName, x => x);
            var bases = programs.Where(x => x.Contains("->")).ToArray();
            var baseMap = bases.ToDictionary(GetProgramName, GetProgramList);
            var programLocalWeights = programs.ToDictionary(GetProgramName, ParseProgramWeight);

            (string name, int offset) answer = FindUnevenWeight(programMap, baseMap);
            
            return programLocalWeights[answer.name] + answer.offset;
        }

        public static string GetProgramName(string program)
        {
            var firstSpace = program.IndexOf(' ');
            return program.Substring(0, firstSpace);
        }

        public static string[] GetProgramList(string program)
        {
            var startOfList = program.IndexOf('>') + 2;
            var regex = new Regex(@", ");
            return regex.Split(program.Substring(startOfList));
        }

        public static int GetProgramWeight(string program, Dictionary<string, string> programMap)
        {
            if (!program.Contains("->"))
            {
                return ParseProgramWeight(program);
            }

            return ParseProgramWeight(program) + GetProgramList(program).Sum(x => GetProgramWeight(programMap[x], programMap));
        }

        public static ValueTuple<string, int> FindUnevenWeight(Dictionary<string, string> programMap,
            Dictionary<string, string[]> baseMap)
        {
            for (var i = 0; i < baseMap.Count; i++)
            {
                var program = baseMap.ElementAt(i);
                var weights = program.Value.ToDictionary(x => x, x => GetProgramWeight(programMap[x], programMap));
                if (weights.All(x => weights.Values.ElementAt(0) == x.Value))
                {
                    continue;
                }
                
                var first = weights.ElementAt(0);
                var checks = weights.Values.Where(x => x == first.Value).ToArray();
                if (checks.Length == 1)
                {
                    var offset = weights.ElementAt(1).Value - first.Value;
                    return (first.Key, offset);
                }

                for (var j = 1; j < weights.Count; j++)
                {
                    var weight = weights.ElementAt(j);
                    if (weight.Value != first.Value)
                    {
                        var offset = first.Value - weight.Value;
                        return (weight.Key, offset);
                    }
                }
            }

            return ("", 0);
        }

        public static string FindUnevenWeightName(Dictionary<string, int> weights)
        {
            return "";
        }
        
        private static int ParseProgramWeight(string program)
        {
            var start = program.IndexOf('(') + 1;
            var end = program.IndexOf(')');
            return int.Parse(program.Substring(start, end - start));
        }

        public static IEnumerable<string> ParseInput(string input)
        {
            var regex = new Regex(@"\n");
            return regex.Split(input);
        }
    }
}