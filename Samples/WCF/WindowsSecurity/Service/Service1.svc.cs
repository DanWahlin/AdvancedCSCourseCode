using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Security.Permissions;

namespace Service
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in Web.config and in the associated .svc file.
    public class Service1 : IService1
    {
        //Can control access through file properties --> Security tab or by using PrincipalPermission with
        //a user name or a role
        //To run this demo update the user name below to the user that will be calling the service
        [PrincipalPermission(SecurityAction.Demand, Name = @"HP-M9152P\student")]
        public string GetData(int value)
        {
            return OperationContext.Current.ServiceSecurityContext.WindowsIdentity.Name;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
