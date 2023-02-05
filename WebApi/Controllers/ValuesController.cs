using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IEmployeeService _service;

        public ValuesController(IEmployeeService service)
        {
            _service = service;
        }


        // GET: api/<ValuesController1>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            EmployeeDTO employee = new EmployeeDTO
            {
                FirstName = "hello",
                LastName = "World",
                Email = "email@email.com",
                DepartmentName = "IT"
            };
            _service.AddEmployee(employee);
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController1>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController1>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
