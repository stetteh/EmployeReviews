﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeReviews
{
    [TestClass]
    public class UnitTest1
    {
        Department dept = new Department("Sales");
        Department dept2 = new Department("Accounting");
        Employee emp = new Employee("Seth Quaye", "stettehq@gmail.com", "501-269-4334", 95000m);
        Employee emp2 = new Employee("John Smith", "jsmith@gmail.com", "501-269-9999", 105000m);

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
    }
}
