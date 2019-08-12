using System;
using System.Data;
using System.Configuration;


/// <summary>
/// Summary description for TryCatchFinallyDemo
/// </summary>
public static class TryCatchFinallyDemo
{
    public static void DemoTryCatch()
    {
        int x = 0;
        string s = string.Empty;
        try
        {
            int y = s.Length;
        }
        catch (Exception handled)
        {
            // x in scope
            // y not in scope
        }
    }

    public static void DemoTryFinally()
    {
        try
        {
            // code that might throw an exception
        }
        finally
        {
            // do not care what exception is
            // excecute code here regardless of success or failure
        }
    }

    public static void DemoDoNothing()
    {
        try
        {
            // this method causes an exception
            DemoApplicationException();
        }
        catch (Exception unhandled)
        {
            // do nothing
        }
    }

    public static void DemoArgNullException(string anyString)
    {
        if (anyString==null)
        {
            throw new ArgumentNullException("anyString");
        }
    }

    public static void DemoApplicationException()
    {
        throw new ApplicationException("Custom exception has been thrown");
    }

    public static void DemoThrowCustomException()
    {
        throw new CustomException(4);
    }

    public static void DemoBadReThrow()
    {
        try
        {
            // code
        }
        catch (Exception up)
        {
            throw up;
        }
    }

    public static void DemoGoodReThrow()
    {
        try
        {
            // code
        }
        catch (Exception up)
        {
            throw;
        }
    }

}
