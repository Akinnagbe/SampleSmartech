using System;
using System.Collections.Generic;
using NetCorePush;
using SampleSmartech.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(NetCoreIntegration))]
namespace SampleSmartech.iOS
{
    public class NetCoreIntegration : INetCoreIntegration
    {
        public NetCoreIntegration()
        {
        }

        public void Login(string userKey)
        {
            try
            {
                  NetCoreSharedManager.SharedInstance().SetUpIdentity(userKey);
                  NetCoreInstallation.SharedInstance().NetCorePushLogin(userKey);
            }
            catch (Exception ex)
            {

            }
        }

       

        public void TrackEvent(string email, string eventName, Dictionary<string, string> payLoad)
        {
           
        }
    }
}
