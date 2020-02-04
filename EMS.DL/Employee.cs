using EMS.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DL
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
