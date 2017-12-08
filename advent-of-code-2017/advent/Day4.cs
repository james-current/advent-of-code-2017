using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace advent
{
    public class Day4
    {
        public static int Problem1(string passphrases)
        {
            return -1;
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
