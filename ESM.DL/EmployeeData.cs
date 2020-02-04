using EMS.DL;
using ESM.BL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ESM.DL
{
    public class EmployeeData : IEmployeeData
    {
        List<Employee> employees;
        public EmployeeData()
        {
            employees = new List<Employee>
            {
                new Employee { Id=1, FirstName="John", LastName="Roberts", Department=Department.HR, Salary=55000},
                new Employee { Id=2, FirstName="Jack", LastName="Kurata", Department=Department.Marketing, Salary=70000},
                new Employee { Id=3, FirstName="Sara", LastName="Smith", Department=Department.Development, Salary=70000},
                new Employee { Id=4, FirstName="Alisa", LastName="James", Department=Department.Finance, Salary=55000},
                new Employee { Id=5, FirstName="Mickie", LastName="Johnson", Department=Department.Admin, Salary=75000},
                new Employee { Id=6, FirstName="Ellie", LastName="Smith", Department=Department.Finance, Salary=52000},
                new Employee { Id=7, FirstName="Brendon", LastName="Allen", Department=Department.Development, Salary=65000},
                new Employee { Id=8, FirstName="Tom", LastName="Jones", Department=Department.Development, Salary=72000},
                new Employee { Id=9, FirstName="Charlie", LastName="Allen", Department=Department.Marketing, Salary=65000},
        };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public bool DeleteEmployee(int id)
        {
            return employees.Remove(employees.SingleOrDefault(x => x.Id == id));
        }

        public Employee AddEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
            newEmployee.Id = employees.Max(x => x.Id) + 1;
            return newEmployee;
        }

        public Employee UpdateEmployee(Employee updatedEmployee)
        {
            var employee = employees.SingleOrDefault(x => x.Id == updatedEmployee.Id);
            if (employee != null)
            {
                employee.FirstName = updatedEmployee.FirstName;
                employee.LastName = updatedEmployee.LastName;
                employee.Department = updatedEmployee.Department;
                employee.Salary = updatedEmployee.Salary;
            }
            return updatedEmployee;
        }
    }
}
