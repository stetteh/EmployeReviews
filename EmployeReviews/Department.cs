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
        private List<Employee> Employees { get; set; } = new List<Employee>();

        public Department(string departmentname)
        {
            this.DepartmentName = departmentname;
        }
     
    }
}
