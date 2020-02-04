using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DL
{
    public interface IEmployeeData
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        bool DeleteEmployee(int id);
        Employee AddEmployee(Employee newEmployee);
        Employee UpdateEmployee(Employee updatedEmployee);
        int Commit();
    }
}
