using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp3.Api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class ValuesController : ControllerBase //inheritance https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/inheritance
    {
        private readonly DataContext _context;// Readonly https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult> GetValue()
        {//it will keep the thread open and not block any other request

            var values = await _context.Values.ToListAsync();

            return Ok(values);


        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id) //Interface https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/
        {

            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
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