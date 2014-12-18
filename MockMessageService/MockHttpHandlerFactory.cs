using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;


namespace MockMessageService
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class MockHttpHandlerFactory : IHttpHandlerFactory
    {
        public IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
        {
            IHttpHandler handlerToReturn;
            if ("post" == context.Request.RequestType.ToLower())
            {
                handlerToReturn = new MockHttpHandler();
            }
            else
            {
                handlerToReturn = null;
            }
            return handlerToReturn;
        }

        public void ReleaseHandler(IHttpHandler handler)
        {
        }

        public bool IsReusable
        {
            get
            {
                // To enable pooling, return true here.
                // This keeps the handler in memory.
                return false;
            }
        }
    }
}
