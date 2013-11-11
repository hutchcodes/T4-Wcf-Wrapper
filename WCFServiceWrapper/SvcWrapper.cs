

using System;

namespace WCFServiceWrapper
{
    public static partial class SvcWrapper
    {    
        public static string GetData(int value)
        {
            var proxy = GetServiceClient();
            try
            {
                var returnValue = proxy.GetData(value);
                proxy.Close();
                return returnValue;
            }
            catch
            {
                proxy.Abort();
                throw;
            }
        }
        
        public static WCFServiceWrapper.WcfSvc.CompositeType GetDataUsingDataContract(WCFServiceWrapper.WcfSvc.CompositeType composite)
        {
            var proxy = GetServiceClient();
            try
            {
                var returnValue = proxy.GetDataUsingDataContract(composite);
                proxy.Close();
                return returnValue;
            }
            catch
            {
                proxy.Abort();
                throw;
            }
        }
        
    }
}
