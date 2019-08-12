using System;
using System.Data;
using System.Configuration;
using System.Diagnostics;

/// <summary>
/// Summary description for Course
/// </summary>
[DebuggerDisplay("{_CourseId}: {_Name}")]
public class Course
{

    #region CourseId property
    private string _CourseId;
    public string CourseId
    {
        get { return _CourseId; }// get
        set { _CourseId = value; }// set
    }// property
    #endregion

    #region Name property
    private string _Name;
    public string Name
    {
        get { return _Name; }// get
        set { _Name = value; }// set
    }// property
    #endregion

    #region Description property
    private string _Description;
    public string Description
    {
        get { return _Description; }// get
        set { _Description = value; }// set
    }// property
    #endregion

}
