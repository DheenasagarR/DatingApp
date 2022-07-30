using Microsoft.AspNetCore.Mvc;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }
        //Get api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        //Get api/values/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValueOnly(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x=>x.Id == id);

            return Ok(value);
        }


        [HttpPost]
        public async void Post([FromBody] string value)
        {
        }

        [HttpPost]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpPost]
        public void Delete(int id)
        {
        }
    }
}