using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.DL;
using ESM.BL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace ESM.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeData _employeeData;
        public EmployeeController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employeeData.GetAllEmployees().ToList());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_employeeData.DeleteEmployee(id));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_employeeData.GetEmployeeById(id));
        }

        [HttpPut]
        public IActionResult Put([FromBody]Employee updatedEmployee)
        {
            return Ok(_employeeData.UpdateEmployee(updatedEmployee));
        }

        [HttpPost]
        public IActionResult Post([FromBody]Employee newEmployee)
        {
            return Ok(_employeeData.AddEmployee(newEmployee));
        }
    }
}
