using CSharp8Introduction.Lessons;
using System;
using System.Threading.Tasks;

namespace CSharp8Introduction
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //NullableReferenceTypes.Run();
            //DefaultInterfaceImplementation.Run();
            // ReadOnlyMembers.Run();
            // PatternMatching.Run();
            // UsingDeclaration.Run();
            // StaticLocalFunctions.Run();
            //await AsynchronousStream.Run();
            // await AsyncDisposable.Run();
            // IndexAndRanges.Run();
            NullCoalescingAssignment.Run();

            Console.ReadLine();
        }
    }

    
}
