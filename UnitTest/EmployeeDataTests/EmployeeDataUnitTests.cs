using EMS.DL;
using ESM.BL;
using ESM.DL;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDataTests
{
    public class EmployeeDataUnitTests
    {
        private IEmployeeData employeeData;

        [SetUp]
        public void Setup()
        {
            employeeData = new EmployeeData();
        }

 
        [Test]
        public void GetEmployeesTest()
        {
            //Arrange
            List<Employee> expected = new List<Employee>
            {
                new Employee { Id=1, FirstName="John", LastName="Roberts", Department=Department.HR, Salary=50000},
                new Employee { Id=2, FirstName="Jack", LastName="Kurata", Department=Department.Marketing, Salary=70000},
                new Employee { Id=3, FirstName="Sara", LastName="Smith", Department=Department.Development, Salary=70000},
                new Employee { Id=4, FirstName="Alisa", LastName="James", Department=Department.Finance, Salary=55000},

            };
            List<Employee> result = new List<Employee>();

            //Act
            result = employeeData.GetAllEmployees().ToList();

            //Assert
            Assert.AreEqual(expected[0].Id,result[0].Id);
            Assert.AreEqual(expected[0].FirstName,result[0].FirstName);
            Assert.AreEqual(expected[0].LastName,result[0].LastName);
            Assert.AreEqual(expected[0].Department,result[0].Department);
            Assert.AreEqual(expected[0].Salary,result[0].Salary);
        }

        [TestCase(1)]
        public void GetEmployeeByIdTest(int id)
        {
            //Arrange
            Employee expected = new Employee() { Id = 1, FirstName = "John", LastName = "Roberts", Department = Department.HR, Salary = 50000 };
            
            Employee result = new Employee();

            //Act
            result = employeeData.GetEmployeeById(id);

            //Assert
            Assert.AreEqual(expected.Id, result.Id);
            Assert.AreEqual(expected.FirstName, result.FirstName);
            Assert.AreEqual(expected.LastName, result.LastName);
            Assert.AreEqual(expected.Department, result.Department);
            Assert.AreEqual(expected.Salary, result.Salary);
        }

        [TestCase(2)]
        public void DeleteEmployeeTest(int id)
        {
            //Arrange

            //Act
            bool result = employeeData.DeleteEmployee(id);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void AddEmployeeTest()
        {
            //Arrange
            Employee expected = new Employee()
            {
                FirstName="Becky",
                LastName="Morgan",
                Department=Department.Admin,
                Salary=80000
            };
            Employee result = new Employee();

            //Act
            result = employeeData.AddEmployee(expected);

            //Assert
            Assert.AreEqual(5, result.Id);
            Assert.AreEqual(expected.FirstName, result.FirstName);
            Assert.AreEqual(expected.LastName, result.LastName);
            Assert.AreEqual(expected.Department, result.Department);
            Assert.AreEqual(expected.Salary, result.Salary);
        }

        [Test]
        public void UpdateEmployeeTest()
        {
            //Arrange
            Employee expected = new Employee()
            {
                Id=5,
                FirstName = "Becky",
                LastName = "Morgan",
                Department = Department.Admin,
                Salary = 85000
            };
            Employee result = new Employee();

            //Act
            result = employeeData.UpdateEmployee(expected);

            //Assert
            Assert.AreEqual(5, result.Id);
            Assert.AreEqual(expected.FirstName, result.FirstName);
            Assert.AreEqual(expected.LastName, result.LastName);
            Assert.AreEqual(expected.Department, result.Department);
            Assert.AreEqual(expected.Salary, result.Salary);
        }
    }
}