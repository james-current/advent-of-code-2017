using System;

namespace advent
{
    public static class Day1
    {
        public static int Problem1(string input)
        {
            return Base(input, (i, length) => i == length - 1 ? 0 : i + 1);
        }

        public static int Problem2(string input)
        {
            return Base(input, (i, length) => (i + length / 2) % length);
        }

        private static int Base(string input, Func<int, int, int> nextFunc)
        {
            var sum = 0;
            var captcha = input.ToCharArray();
            for (var i = 0; i < captcha.Length; i++)
            {
                var next = nextFunc(i, captcha.Length);
                if (captcha[i] == captcha[next])
                {
                    sum += int.Parse(captcha[i].ToString());
                }
            }
            return sum;
        }
    }
}