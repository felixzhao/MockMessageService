using System.Web;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using MockContractLayer;

namespace MockMessageService
{
    public class MockHttpHandler : IHttpHandler
    {
        public MockHttpHandler() { }

        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            string response = string.Empty;

            StreamReader stream = new StreamReader(context.Request.InputStream);
            string request = stream.ReadLine();
            
            IMockSvc svc = (IMockSvc)new MongoDBHandler();
            response = svc.GetResponse(request);

            HttpContext.Current.Response.Write(response);
        }
    }
}