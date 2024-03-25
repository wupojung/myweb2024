using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaController : ControllerBase
    {
        // GET: api/Sa
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sa/5
        [HttpGet("{username}")]
        public SaModel Get(string username)
        {
            if (SaModelFakeDb._dictionary.ContainsKey(username))
            {
                return SaModelFakeDb._dictionary[username];
            }
            else
            {

                return new SaModel(){};
            }
        }

        // POST: api/Sa
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Sa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Sa/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
