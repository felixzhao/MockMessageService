using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using MockContractLayer;

namespace MockMessageService
{
    public class MongoDBHandler:IMockSvc
    {
        private MongoClient _client;

        public MongoDBHandler()
        {
        }

        public string GetResponse(string request)
        {
            string result = string.Empty;

            var connectionString = "mongodb://localhost";
            _client = new MongoClient(connectionString);

            var server = _client.GetServer();
            var database = server.GetDatabase("foo");

            var collection = database.GetCollection<MessageContainerEntity>("foo");

            var res =
                        from e in collection.AsQueryable<MessageContainerEntity>()
                        where e.RequestMessage == request
                        select e.ResponseMessage;

            result += res.FirstOrDefault();

            return result;
        }


        public bool SaveMessage(string request, string response)
        {
            return true;
        }

        public bool SaveMessage(string serviceName, string request, string response)
        {
            return true;
        }
    }
}