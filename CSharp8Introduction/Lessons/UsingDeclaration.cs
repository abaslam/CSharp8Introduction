using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Introduction.Lessons
{
    public class UsingDeclaration
    {
        public static void Run()
        {
            var totalSkippedLines = WriteLinesToFile(new[] { "What", "Second", "Nothing", "Other" });
            Console.WriteLine($"Skipped Lines:{totalSkippedLines}");
        }


        static int WriteLinesToFile(IEnumerable<string> lines)
        {
            //using(var file1 = new System.IO.StreamWriter("some.tst"))
            //{
            //    Console.WriteLine("Writing");
            //}

            using var file = new System.IO.StreamWriter("WriteLines2.txt");
            int skippedLines = 0;
            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
                else
                {
                    skippedLines++;
                }
            }
            // Notice how skippedLines is in scope here.
            return skippedLines;
            // file is disposed here

        }
    }
}
