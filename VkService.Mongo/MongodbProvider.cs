using MongoDB.Driver;

namespace VkService.Mongo
{
    public class MongodbProvider
    {
        private const string DbName = "database";

        public MongoDatabase Create()
        {
            var server = new MongoClient().GetServer();
            var db = server.GetDatabase(DbName);
            return db;
        }
    }
}