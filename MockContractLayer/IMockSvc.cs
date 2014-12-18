using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockContractLayer
{
    public interface IMockSvc
    {
        string GetResponse(string resquest);
        bool SaveMessage(string request, string response);
        bool SaveMessage(string serviceName, string request, string response);
    }
}
