using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeReviews
{
    public class Employee
    {
        public string FullName { set; get; }
        public  string EmailAddress { set; get; }
        public string PhoneNumber { set; get; }
        public decimal Salary { set; get; }

        public Employee(string fullname, string emailaddress, string phonenumber, decimal salary)
        {
            this.FullName = fullname;
            this.EmailAddress = emailaddress;
            this.PhoneNumber = phonenumber;
            this.Salary = salary;
        }

        
    }
}
