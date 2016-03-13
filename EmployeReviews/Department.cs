using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeReviews
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees = new List<Employee>();
        
       

        public Department(string departmentname)
        {
            this.DepartmentName = departmentname;
        }

        public void AddEmployee(Employee AnotherEmployee)
        {
            Employees.Add(AnotherEmployee);
        }

    }
}
