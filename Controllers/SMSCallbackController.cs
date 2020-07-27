using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TruckAppAPISolution.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TruckAppAPISolution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSCallbackController : ControllerBase
    {
        private readonly SMSAPIDBContext _context;

        public SMSCallbackController(SMSAPIDBContext context)
        {
            _context = context;
        }
        // GET: api/<SMSCallbackController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SMSCallbackController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SMSCallback
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SMSCallback>> Post([Bind("request_id,recipient_id,dest_addr,Status")]SMSCallback smsCallback)
        {
            _context.smsCallback.Add(smsCallback);
            await _context.SaveChangesAsync();

            
            return new OkObjectResult(smsCallback);
        }

        // PUT api/<SMSCallbackController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SMSCallbackController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
