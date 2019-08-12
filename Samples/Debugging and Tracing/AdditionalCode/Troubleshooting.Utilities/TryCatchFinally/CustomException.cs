using System;
using System.Data;
using System.Configuration;

/// <summary>
/// Summary description for CustomException
/// </summary>
public class CustomException : ApplicationException
{
    public CustomException(int errorCode)
        : this(errorCode, null) { }

    public CustomException(int errorCode, Exception innerException)
        : base(string.Format("Internal Error [{0}]", errorCode),
                innerException)
    {
        this.InternalErrorCode = errorCode;
    }

    private int _InternalErrorCode;
    public int InternalErrorCode
    {
        get { return _InternalErrorCode; }// get
        set { _InternalErrorCode = value; }// set
    }// property        
}
