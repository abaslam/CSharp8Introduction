using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Introduction.Lessons
{
    public class StaticLocalFunctions
    {
        public static void Run()
        {
            static int Add(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine($"Result: {Add(10, 10)}");
        }
    }
}
