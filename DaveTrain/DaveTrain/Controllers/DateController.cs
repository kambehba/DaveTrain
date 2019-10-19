using DaveTrain.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DaveTrain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateController : Controller
    {
        private DateClient _dateClient;

        public DateController(DateClient dateClient)
        {
            _dateClient = dateClient;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            //var client = _dateClient.CreateClient("c1");
            var result = await _dateClient.Client.GetStringAsync("/");
            return Ok(result);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
