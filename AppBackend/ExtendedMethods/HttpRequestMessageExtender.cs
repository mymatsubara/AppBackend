using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace AppBackend.ExtendedMethods
{
    public static class HttpRequestMessageExtender
    {
        public static string BodyToString(this HttpRequestMessage requestMessage)
        {
            return requestMessage.Content.ReadAsStringAsync().Result;
        }
    }
}