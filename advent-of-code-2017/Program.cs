using System;
using System.Collections.Generic;

namespace advent_of_code_2017
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sum = 0;
            var captcha = args[0].ToCharArray();
            for (var i = 0; i < captcha.Length; i++)
            {
                var next = i == captcha.Length - 1 ? 0 : i + 1;
                if (captcha[i] == captcha[next])
                {
                    sum += int.Parse(captcha[i].ToString());
                }
            }
            Console.WriteLine($"Sum is: {sum}");
        }
    }
}