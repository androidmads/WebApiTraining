using System.Collections.Generic;
using System.Web.Http;

namespace Exercise2.Controllers
{
    [RoutePrefix("values")]
    public class RouteController : ApiController
    {
        [Route("GetAll")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet, Route("GetOne/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("GetById/{id}/{value}")]
        public string GetById(int id, string value)
        {
            return value + " " + id;
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
