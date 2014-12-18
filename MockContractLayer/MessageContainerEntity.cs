using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockContractLayer
{
    public class MessageContainerEntity
    {
        public ObjectId Id { get; set; }       
        public long ID { get; set; }
        public string ServiceName { get; set; }
        public string RequestMessage { get; set; }
        public string ResponseMessage { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
