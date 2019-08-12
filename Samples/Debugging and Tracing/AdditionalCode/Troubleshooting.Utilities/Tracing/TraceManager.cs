using System;
using System.Data;
using System.Configuration;
using System.Diagnostics;

/// <summary>
/// Summary description for TraceManager
/// </summary>
public class TraceManager
{
    public static void WriteLine(string message)
    {
        Trace.WriteLine(message);        
    }

    public static void WriteWithOnOffSwitch(string message)
    {
        Trace.WriteLineIf(OnOffSwitch.Enabled, message);
    }

    private static BooleanSwitch _OnOffSwitch;
    public static BooleanSwitch OnOffSwitch
    {
        get
        {
            if (_OnOffSwitch==null)
            {
                _OnOffSwitch = new BooleanSwitch
                    ("OnOffSwitch", "Boolean switch");
            }
            return _OnOffSwitch;
        }
    }

    public static void WriteAppError(string message)
    {
        Trace.WriteLineIf(AppSwitch.TraceError, message);
    }
    public static void WriteAppWarning(string message)
    {
        Trace.WriteLineIf(AppSwitch.TraceWarning, message);
    }
    public static void WriteAppInfo(string message)
    {
        Trace.WriteLineIf(AppSwitch.TraceInfo, message);
    }
    public static void WriteAppVerbose(string message)
    {
        Trace.WriteLineIf(AppSwitch.TraceVerbose, message);
    }

    private static TraceSwitch _AppSwitch;
    public static TraceSwitch AppSwitch
    {
        get
        {
            if (_AppSwitch == null)
            {
                _AppSwitch = new TraceSwitch 
                    ("AppSwitch", "Trace Switch");
            }
            return _AppSwitch;
        }
    }
}
