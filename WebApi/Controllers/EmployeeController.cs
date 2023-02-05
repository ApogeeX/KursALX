﻿using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;
using WebApi.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService service)
        { 
            _employeeService = service;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task <IEnumerable<Employee>> GetAll()
        {
            return new List<Employee>() { new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = "Test",
                LastName = "TestLastName",
                DepartmentId = Guid.NewGuid(),
                PaycheckId = Guid.NewGuid(),
                Email = "test@paparam.com"
            } };
        }

        // GET api/<ValuesController1>/5
        [HttpGet("{id}")]
        public async Task<Employee> Get(int id)
        {
            return new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = "Test",
                LastName = "TestLastName",
                DepartmentId = Guid.NewGuid(),
                PaycheckId = Guid.NewGuid(),
                Email = "test@paparam.com"
            };
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task Post([FromQuery] EmployeeDTO employee)
        {
           await _employeeService.AddEmployee(employee);
        }
    }
}
