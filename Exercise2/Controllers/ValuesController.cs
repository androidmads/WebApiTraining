using Exercise2.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Exercise2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return string.Format("Selected Id is {0}", id);
        }

        //// POST api/values
        //public void Post([FromBody]Student value)
        //{
        //    System.Diagnostics.Debug.WriteLine(string.Format("{0}:{1}", value.name, value.age));
        //}

        // POST api/values
        public void Post([FromUri]Student value)
        {
            System.Diagnostics.Debug.WriteLine(string.Format("{0}:{1}", value.name, value.age));
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
