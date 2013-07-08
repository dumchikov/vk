using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;

namespace VkService.Mongo
{
    public class MongoRepository
    {
        private readonly MongoDatabase _db;

        private readonly MongoCollection<dynamic> _collection;

        public MongoRepository(MongoDatabase db, string collectionName)
        {
            _db = db;
            _collection = _db.GetCollection<dynamic>(collectionName);
        }

        public IEnumerable<dynamic> GetAll()
        {
           return _collection.FindAll();
        }

        public void Save(dynamic entity)
        {
            _collection.Save<dynamic>(entity);
        }
    }
}
