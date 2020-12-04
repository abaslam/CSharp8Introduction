using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Introduction.Lessons
{
    public class IndexAndRanges
    {
        public static void Run()
        {
            var words = new string[]
{
                // index from start    index from end
    "The",      // 0                   ^9
    "quick",    // 1                   ^8
    "brown",    // 2                   ^7
    "fox",      // 3                   ^6
    "jumped",   // 4                   ^5
    "over",     // 5                   ^4
    "the",      // 6                   ^3
    "lazy",     // 7                   ^2
    "dog"       // 8                   ^1
};

            Console.WriteLine($"The last word is {words[^1]}");

            var quickBrownFox = words[1..4];
            Console.WriteLine(string.Join(" ", quickBrownFox));

            var lazyDog = words[^2..^0];
            Console.WriteLine(string.Join(" ", lazyDog));

            var allWords = words[..]; // contains "The" through "dog".
            Console.WriteLine(string.Join(" ", allWords));

            var firstPhrase = words[..4]; // contains "The" through "fox"
            Console.WriteLine(string.Join(" ", firstPhrase));

            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
            Console.WriteLine(string.Join(" ", lastPhrase));

            Range phrase = 1..4;
            var text = words[phrase];

            Console.WriteLine(string.Join(" ", text));
        }
    }
}
