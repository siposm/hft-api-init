using BlogSystem.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlogSystem.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {

        IBlogLogic blogLogic;

        public BlogController(IBlogLogic blogLogic)
        {
            this.blogLogic = blogLogic;
        }



        // GET: /blog
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET /blog/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST /blog
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT /blog
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE /blog/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
