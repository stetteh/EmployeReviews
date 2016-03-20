using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeReviews
{
    [TestClass]
    public class UnitTest1
    {
        Department dept = new Department("Sales");
        Department dept2 = new Department("Accounting");
        Employee emp = new Employee("Seth Quaye", "stettehq@test.com", "501-269-4334", 95000m);
        Employee emp2 = new Employee("John Smith", "jsmith@test.com", "501-269-9999", 105000m);
        Employee emp3 = new Employee("Lucky Newton", "lnewton@test.com", "501-269-9999", 200000m);
        Employee emp4 = new Employee("Lucky Brown", "lbrown@test.com", "901-999-4156", 25000m);
        

        [TestMethod]
        public void CreateNewEmployee()
        {    
            var emp = new Employee("Seth Quaye", "stettehq@gmail.com", "501-269-4334", 95000m);
            Assert.AreEqual("Seth Quaye", emp.FullName);
            Assert.AreEqual("stettehq@gmail.com", emp.EmailAddress);
            Assert.AreEqual("501-269-4334", emp.PhoneNumber);
            Assert.AreEqual(95000m, emp.Salary);

        }

        [TestMethod]
        public void CreateNewDepartment()
        {
            var dept = new Department("Sales");
            Assert.AreEqual("Sales", dept.DepartmentName);
        }

        [TestMethod]
        public void EmployeeNameTest()
        {
            Assert.AreEqual("Seth Quaye", emp.FullName);
        }

        [TestMethod]
        public void AddEmployeetoDepartment()
        {
            dept2.AddEmployee(emp2);
        }

        [TestMethod]
        public void EmployeeSalary()
        {
            Assert.AreEqual(95000m, emp.Salary);
        }

        [TestMethod]
        public void GetTotalSalary()
        {
            dept2.AddEmployee(emp2);
            dept2.AddEmployee(emp3);

            decimal totalSalary = dept2.SalaryTotal();
            
            Assert.AreEqual(305000m, totalSalary);
        }

        [TestMethod]
        public void SatisfactoryPerformance()
        {
            Assert.AreEqual(true, emp.IsSatisfactory());
        }

        [TestMethod]
        public void Raise()
        {
            emp.Satisfactory = true;
            emp2.Satisfactory = false;
            emp3.Satisfactory = true;
            emp4.Satisfactory = true;
            dept2.AddEmployee(emp2);
            dept.AddEmployee(emp4);
            dept.AddEmployee(emp3);
            dept2.AddEmployee(emp);
            dept.GivingRaise(1500m);
            dept2.GivingRaise(2500m);

            Assert.AreEqual(26500m, emp4.Salary);
            Assert.AreEqual(105000m, emp2.Salary);
            Assert.AreEqual(201500m, emp3.Salary);
            Assert.AreEqual(97500m, emp.Salary);

        }
    }
}
