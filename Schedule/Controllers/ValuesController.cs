using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Schedule.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        // public IEnumerable<string> Get()
        public List<schedule> Get()
        {
            //var con = "mongodb://localhost:27017";
            //var md = new MongoClient(con);
            var db = dataContext.context();
            var collection = db.GetCollection<schedule>("rehearsSched");
            var query = from r in collection.AsQueryable<schedule>() select r;
            return query.ToList();

            // return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]

        public void Post([FromBody]schedule data)
        {
            var db = dataContext.context();
            var collection = db.GetCollection<schedule>("rehearsSched");
            collection.InsertOne(data);
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
