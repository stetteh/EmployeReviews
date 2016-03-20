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
        public List<Employee> Employees { get; set; }= new List<Employee>();
        
       

        public Department(string departmentname)
        {
            this.DepartmentName = departmentname;
        }

        public void AddEmployee(Employee AnotherEmployee)
        {
            Employees.Add(AnotherEmployee);
        }

        public decimal SalaryTotal()
        {
            return Employees.Sum(s => s.Salary);
        }

        public Employee FindEmployee(string employeefullname)
        {
            return Employees.FirstOrDefault(n => n.FullName == employeefullname);
        }

        public void GivingRaise(decimal raise)
        {
            foreach (var emp in Employees)
            {
                if (emp.Satisfactory)
                {
                    emp.Salary += raise;
                }
            }
        }

        public void GiveRaiseToEmployee(decimal raise, Employee E)
        {
            E.Salary += raise;
        }
    }
}
