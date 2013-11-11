using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Configuration;

namespace WCFServiceWrapper
{
    public partial class SvcWrapper
    {
        private static string _serviceAddress;
        private static string _configName;
        private static bool _needsConfig = true;

        internal static WcfSvc.Service1Client GetServiceClient()
        {
            if (_needsConfig)
            {
                //At this point I'd do some hoopajoop to determine what the 
                //current service address is for this version
                //something like:
                //
                //ServiceConfig config = SomeWCFService.GetServiceConfig(versionNo);
                //_serviceAddress = config.Address;
                //_configName = config.ClientEndPointName;

                //The address of the service endpoint
                _serviceAddress = "http://localhost:50324/Service1.svc";

                //This string is the Name of the Client Endpoint as defined in the running exe's app.config
                _configName = "WSHttpBinding_IService1";
            }
            return new WCFServiceWrapper.WcfSvc.Service1Client(_configName, _serviceAddress);
        }
    }
}
