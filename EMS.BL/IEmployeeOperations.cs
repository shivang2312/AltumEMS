using ESM.BL;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.BL
{
    public interface IEmployeeOperations
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        bool DeleteEmployee(int id);
        Employee AddEmployee(Employee newEmployee);
        Employee UpdateEmployee(Employee updatedEmployee);
    }
}
