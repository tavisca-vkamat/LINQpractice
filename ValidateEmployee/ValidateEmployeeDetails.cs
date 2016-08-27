using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeOperations
{
    public class ValidateEmployeeDetails
    {
        public static int ValidateEmployeeID(string employeeId)
        {
            int employeeid = 0;
            int.TryParse(employeeId,out employeeid);
            return employeeid;
        }
        public static int ValidateEmployeeDeptId(string employeeDeptId)
        {
            int employeedeptid = 0;
            int.TryParse(employeeDeptId, out employeedeptid);
            return employeedeptid;
        }

        public static string ValidateEmployeeFirstName(string employeeFirstName)
        {
            Regex rgx = new Regex(@"^[a-zA-Z]{3,15}$");
            if (rgx.IsMatch(employeeFirstName))
            {
                return employeeFirstName;
            }
            throw new Exception("Invalid First Name");
        }

        public static string ValidateEmployeeLastName(string employeeLastName)
        {
            Regex rgx = new Regex(@"^[a-zA-Z]{3,15}$");
            if (rgx.IsMatch(employeeLastName))
            {
                return employeeLastName;
            }
            throw new Exception("Invalid Last Name");
        }
        public static decimal ValidateEmployeeSalary(string salary)
        {
            decimal sal = 0;
            decimal.TryParse(salary, out sal);
            return sal;
        }
        
    }
}
