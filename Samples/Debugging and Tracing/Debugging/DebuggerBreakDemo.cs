using System;
using System.Diagnostics;

namespace DebuggingAndTracing.Debugging
{
    //See App.config for switch definition
    class DebuggerBreakDemo
    {
        static void Main()
        {
            BooleanSwitch debugSwitch = new BooleanSwitch("BreakIntoDebugger",String.Empty);
            if (debugSwitch.Enabled)
            {
                Console.WriteLine("Breaking into the debugger.");
                Debugger.Break();
            }
            else
            {
                Console.WriteLine("Breaking into the debugger is not enabled in App.config.");
            }
            Console.Read();
        }
    }
}
