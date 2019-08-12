using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Transactions;

namespace Service
{
    [ServiceBehavior(TransactionIsolationLevel=IsolationLevel.ReadCommitted)]
    public class Service1 : IService1
    {
        //Ensure that inserts are rolled back if an error is encountered
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public void InsertCustomers(Customer[] custs)
        {
            try
            {
                if (custs != null)
                {
                    //Use LINQ to SQL to call sproc
                    using (Data.NorthwindDataContext context = new Data.NorthwindDataContext())
                    {
                        foreach (Customer cust in custs)
                        {
                            context.InsertCustomer(cust.CustomerID, cust.CompanyName, cust.ContactName);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                //Raise FaultException<T> if there was a problem
                OperationStatusFault opStatus = new OperationStatusFault();
                opStatus.StackTrace = exp.StackTrace;
                opStatus.Message = exp.Message;
                opStatus.Status = false;
                throw new FaultException<OperationStatusFault>(opStatus,"Error in InsertCustomers");
            }
        }

    }
}
