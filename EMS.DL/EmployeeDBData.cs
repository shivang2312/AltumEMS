using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EMS.DL
{
    public class EmployeeDBData : IEmployeeData
    {
        private readonly EMSDbContext db;

        public EmployeeDBData(EMSDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return db.Employee;
        }

        public Employee AddEmployee(Employee newEmployee)
        {
            db.Add(newEmployee);
            Commit();
            return newEmployee;
        }

        public Employee GetEmployeeById(int id)
        {
            return db.Employee.Find(id);
        }

        public bool DeleteEmployee(int id)
        {
            var emp = GetEmployeeById(id);
            db.Employee.Remove(emp);
            Commit();
            return true;
        }

        public Employee UpdateEmployee(Employee updatedEmployee)
        {
            var emp = db.Employee.Attach(updatedEmployee);
            emp.State = EntityState.Modified;
            Commit();
            return updatedEmployee;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }
    }
}
