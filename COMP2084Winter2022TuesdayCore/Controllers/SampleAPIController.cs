using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace COMP2084Winter2022TuesdayCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleAPIController : ControllerBase
    {
        // GET: api/<SampleAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SampleAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SampleAPIController>
        [HttpPost]
        public string Post([FromBody] object value)
        {
            return "post string value = " + value;
        }

        // PUT api/<SampleAPIController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] object value)
        {
            return "put string value = " + value;
        }

        // DELETE api/<SampleAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
