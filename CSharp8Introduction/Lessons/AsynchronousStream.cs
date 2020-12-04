using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Introduction.Lessons
{
    public class AsynchronousStream
    {
        public static async Task Run()
        {
            //foreach (var item in (await GetSequence()))
            //{

            //}

            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }
        }

        public static async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        public static Task<List<int>> GetSequence()
        {
            return Task.FromResult(new List<int>());
        }
    }
}
