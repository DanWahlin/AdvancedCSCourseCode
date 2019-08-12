using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in App.config.
    public class Service1 : IService1
    {
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void GetData(string val)
        {
            string massagedData = "You passed me: " + val;
            ITransferAck client =
                OperationContext.Current.GetCallbackChannel<ITransferAck>();
            client.GetCompletedData(massagedData);
        }

    }
}
