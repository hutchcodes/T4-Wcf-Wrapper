using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ServiceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WCFServiceWrapper.SvcWrapper.GetData(5));

            WCFServiceWrapper.WcfSvc.CompositeType complexType = new WCFServiceWrapper.WcfSvc.CompositeType();
            complexType.BoolValue = true;
            complexType.StringValue = "Test";

            complexType = WCFServiceWrapper.SvcWrapper.GetDataUsingDataContract(complexType);
            Console.WriteLine(complexType.StringValue);

            Console.ReadLine();
        }
    }
}
