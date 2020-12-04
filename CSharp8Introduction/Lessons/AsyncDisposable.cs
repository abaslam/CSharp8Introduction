using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Introduction.Lessons
{
    public class AsyncDisposable
    {
        public static async Task Run()
        {
            await using(var dis= new CustomDisposable())
            {
                await dis.Process();
            }

            await using var item = new CustomDisposable();
            await item.Process();

        }
    }

    public class CustomDisposable : IAsyncDisposable
    {   
        IAsyncDisposable _asyncDisposableResource = new MemoryStream();

        public Task Process()
        {
            Console.WriteLine("Doing Process");
            return Task.Delay(200);
        }
        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore();

            GC.SuppressFinalize(this);
        }
        
        protected virtual async ValueTask DisposeAsyncCore()
        {
            Console.WriteLine("Disposing Async");
            if (!(_asyncDisposableResource is null))
            {
                await _asyncDisposableResource.DisposeAsync().ConfigureAwait(false);
            }


            _asyncDisposableResource = null;
        }
    }
}
