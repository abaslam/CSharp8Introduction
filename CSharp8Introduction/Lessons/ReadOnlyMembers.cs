using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Introduction.Lessons
{
    public class ReadOnlyMembers
    {
        public static void Run()
        {
            //Guid;
        }
    }

    public struct PointNew
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        public readonly override string ToString()
        {
            //X = 10;- this will not work
            return $"({X}, {Y}) is {Distance} from the origin";
        }
    }
}
