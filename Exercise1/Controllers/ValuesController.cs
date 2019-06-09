using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace MyWebApi.Controllers
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

        // POST api/values
        public void Post([FromBody]string value)
        {
            System.Diagnostics.Debug.WriteLine(value);
        }
        

        // POST api/values
        public void Post([FromBody]Student value)
        {
            System.Diagnostics.Debug.WriteLine(value);
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
