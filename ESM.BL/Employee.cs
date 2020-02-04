using System;

namespace ESM.BL
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public double Salary { get; set; }
    }
}
