using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Schedule
{
 
        public class dataContext
        {
            private static IMongoDatabase _context;
            public static IMongoDatabase context()
            {
                if (_context == null)
                {
                    //testing
                    var con = "mongodb://localhost:27017";
                    var md = new MongoClient(con);
                    _context = md.GetDatabase("rehearse");


                }
                return _context;
                //var collection = db.GetCollection<schedule>("rehearsSched");
            }

        }
    
}
