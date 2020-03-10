using System;
using System.Collections.Generic;

namespace SampleSmartech
{
    public interface INetCoreIntegration
    {
        /// <summary>
        /// userKey could be email address
        /// </summary>
        /// <param name="userKey"></param>
        void Login(string userKey);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email">customer's email</param>
        /// <param name="eventName">event to track</param>
        /// <param name="payLoad">key value pair of parameters</param>
        void TrackEvent(string email, string eventName, Dictionary<string, string> payLoad);
    }
}
