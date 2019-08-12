using System;
using System.Diagnostics;

namespace DebuggingAndTracing.Debugging
{
    class DebugAssertDemo
    {
        static void Main()
        {
            int x = 5;
            Debug.Listeners.Clear();
            Debug.Listeners.Add(new ConsoleTraceListener());
            Debug.Assert(x == 6, "X value does not equal 6!");
            Debug.WriteLineIf(x > 6, "X is greater than 6!");
            Console.Read();
        }
    }
}
