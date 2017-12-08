using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace advent
{
    public static class Day4
    {
        public static int Problem1(string passphrases)
        {
            var regex = new Regex(@"\n");
            return regex.Split(passphrases).Select(IsValidPassphrase).Count(x => x);
        }

        public static bool IsValidPassphrase(string passphrase)
        {
            var regex = new Regex(@"\s");
            var words = regex.Split(passphrase);
            var wordsSet = new HashSet<string>(words);
            return words.Length == wordsSet.Count;
        }
    }
}
