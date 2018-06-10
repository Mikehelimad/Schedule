using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule
{
   
        public class schedule
        {
            public string name { get; set; }

            public string role { get; set; }

            public string rolcat { get; set; }

            public ObjectId _id { get; set; }
        }
    
}
