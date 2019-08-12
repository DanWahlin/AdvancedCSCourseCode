using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Security.Permissions;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        int Add(int x, int y);
    }

}
