using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;

//// don't allow execution unless app is allowed to read C:\log.txt file
//[assembly: FileIOPermission(SecurityAction.RequestMinimum, Read = @"C:\logs\log.txt")]

//// Allow execution, but throw exception if app is not allowed to read file
//[assembly: FileIOPermission(SecurityAction.RequestOptional, Read = @"C:\logs\log.txt")]

//// Do not allow execution of code attempting file I/O
//[assembly: FileIOPermission(SecurityAction.RequestRefuse, Unrestricted = true)]

//// don't allow execution unless app has FullTrust permission set
//[assembly: PermissionSetAttribute(SecurityAction.RequestMinimum, 
//    Name = "FullTrust")]

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SecurityApp")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("SecurityApp")]
[assembly: AssemblyCopyright("Copyright ©  2007")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3560229f-a413-4c27-afa2-42a6923a2146")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
