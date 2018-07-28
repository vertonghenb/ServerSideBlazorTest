using Microsoft.AspNetCore.Blazor;
using System;

namespace test.App
{
    public class AppState :  IAppState, IDisposable
    {
        public int Count { get; set; }

        public void Dispose()
        {
            Console.WriteLine("Remove State");
        }
    }
}
