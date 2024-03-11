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
    public class JokeController : ControllerBase
    {
        // GET: api/Joke
        [HttpGet]
        public IEnumerable<JokeModel> Get()
        {
            return new JokeModel[]
            {
                new JokeModel(){Id=1,Type = "黑色幽默",Content = "小菜被端走了..."}
                 ,new JokeModel(){Id=2,Type = "黑色幽默",Content = "小2菜被端走了..."}
                
            };
        }

        // GET: api/Joke/5
        [HttpGet("{id}", Name = "Get")]
        public JokeModel Get(int id)
        {
            return  new JokeModel(){Id=1,Type = "黑色幽默",Content = "小菜被端走了..."};
        }

        // POST: api/Joke
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Joke/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Joke/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
