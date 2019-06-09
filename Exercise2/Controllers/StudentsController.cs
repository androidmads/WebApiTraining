using Exercise2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Exercise2.Controllers
{
    public class StudentsController : ApiController
    {
        [HttpPost]
        [ActionName("GetStudent")]
        public Student GetStudent([FromUri]Student value)
        {
            return value;
        }

        [HttpPost]
        public Student GetStudentId([FromBody]Student value)
        {
            return value;
        }
    }
}
