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
            return regex.Split(passphrases).Select(IsValidPassphrase1).Count(x => x);
        }

        public static bool IsValidPassphrase1(string passphrase)
        {
            var regex = new Regex(@"\s");
            var words = regex.Split(passphrase);
            var wordsSet = new HashSet<string>(words);
            return words.Length == wordsSet.Count;
        }

        public static bool IsValidPassphrase2(string passphrase)
        {
            var regex = new Regex(@"\s");
            var words = regex.Split(passphrase);
            var wordsSet = new HashSet<string>(words.Select(x => new string(x.ToCharArray().OrderBy(y => y).ToArray())));
            return words.Length == wordsSet.Count;
        }
    }
}
