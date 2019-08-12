using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [FaultContract(typeof(OperationStatusFault))]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void InsertCustomers(Customer[] custs);
    }

    [DataContract]
    public class Customer
    {
        [DataMember]
        public string CustomerID { get; set; }

        [DataMember]
        public string ContactName { get; set; }

        [DataMember]
        public string CompanyName { get; set; }
    }

    [DataContract]
    public class OperationStatusFault
    {
        [DataMember]
        public bool Status { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string StackTrace { get; set; }
    }
}
