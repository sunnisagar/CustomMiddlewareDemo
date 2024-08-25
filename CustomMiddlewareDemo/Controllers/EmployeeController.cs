using CustomMiddlewareDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddlewareDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("getemployee")]
        public IActionResult Get(int id)
        {
            RaiseException();

            var employee = new EmployeeModel
            {
                Id = id,
                Name = "Raj"
            };

            return Ok(employee);
        }

        [HttpPost("saveemployee")]
        public IActionResult Save([FromBody] EmployeeModel employee)
        {
            RaiseException();

            return Ok("Employee saved");
        }

        private void RaiseException()
        {
            throw new Exception("Custom exception");
        }
    }
}
