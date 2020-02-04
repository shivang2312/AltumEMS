using System.Linq;
using EMS.BL;
using Microsoft.AspNetCore.Mvc;
using Employee = ESM.BL.Employee;

namespace ESM.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeOperations _employeeOperations;
        public EmployeeController(IEmployeeOperations employeeOperations)
        {
            _employeeOperations = employeeOperations;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employeeOperations.GetAllEmployees().ToList());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_employeeOperations.DeleteEmployee(id));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_employeeOperations.GetEmployeeById(id));
        }

        [HttpPut]
        public IActionResult Put([FromBody]Employee updatedEmployee)
        {
            return Ok(_employeeOperations.UpdateEmployee(updatedEmployee));
        }

        [HttpPost]
        public IActionResult Post([FromBody]Employee newEmployee)
        {
            return Ok(_employeeOperations.AddEmployee(newEmployee));
        }
    }
}
