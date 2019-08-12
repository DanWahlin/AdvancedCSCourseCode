using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.IdentityModel.Policy;
using System.IdentityModel.Claims;
using System.Text;
using System.Security.Permissions;
using System.Security.Principal;

namespace WcfServiceLibrary
{
    public class CalcService : ICalc
    {

        #region ICalc Members

        //[PrincipalPermission(SecurityAction.Demand,Name="Domain/UserName")]
        public int Add(int x, int y)
        {
            //Imperative checking of role name
            //System.Threading.Thread.CurrentPrincipal.IsInRole("GroupName");
            
            Console.WriteLine(OperationContext.Current.ServiceSecurityContext.PrimaryIdentity.Name);
            
            //Looking at ClaimSets
            //AuthorizationContext context = OperationContext.Current.ServiceSecurityContext.AuthorizationContext;
            //foreach (ClaimSet cs in context.ClaimSets)
            //{
            //    foreach (Claim c in cs)
            //    {
            //        Console.WriteLine(c.ClaimType + " " + c.Right);
            //    }
            //}
            return x + y;
        }

        #endregion
    }
}
