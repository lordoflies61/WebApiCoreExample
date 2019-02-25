using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using LibraryExample;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCoreExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            var response = new string[] { "value1", "value2" };
            var list = new Dictionary<string, string>()
            {
                {"Id","1" },
                {"Name","Jorge" }
            };
            var ex = new ExampleClass().MyProperty = "Example";
            var ex2 = new ExampleClass2.ExampleClass2().MyProperty2 = "Example";
            return Ok(ex + ex2);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
