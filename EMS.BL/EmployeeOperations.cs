using AutoMapper;
using EMS.DL;
using ESM.BL;
using ESM.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Employee = ESM.BL.Employee;
using EmployeeDL = EMS.DL.Employee;

namespace EMS.BL
{
    public class EmployeeOperations: IEmployeeOperations
    {
        private IEmployeeData _employeeData;
        public EmployeeOperations(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
            
        }

        public EmployeeOperations()
        {
        }

        public IEnumerable<Employee> GetAllEmployees()
        { 
            return AutoMapperConfig.getMapper().Map<IEnumerable<EmployeeDL>, IEnumerable<Employee>>(_employeeData.GetAllEmployees().ToList());
        }

        public Employee GetEmployeeById(int id)
        {
            return AutoMapperConfig.getMapper().Map<EmployeeDL, Employee>(_employeeData.GetEmployeeById(id));
        }

        public bool DeleteEmployee(int id)
        {
            return _employeeData.DeleteEmployee(id);
        }

        public Employee AddEmployee(Employee newEmployee)
        {
            return AutoMapperConfig.getMapper().Map<EmployeeDL, Employee>(_employeeData.AddEmployee(AutoMapperConfig.getMapper().Map<Employee, EmployeeDL>(newEmployee)));
        }

        public Employee UpdateEmployee(Employee updatedEmployee)
        {
            return AutoMapperConfig.getMapper().Map<EmployeeDL, Employee>(_employeeData.UpdateEmployee(AutoMapperConfig.getMapper().Map<Employee, EmployeeDL>(updatedEmployee)));
        }
    }
}
