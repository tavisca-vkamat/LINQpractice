using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using EmployeeOperations;
using System.Data;
using System.Globalization;

namespace LinqToXML
{
    class XMLtoDatabase
    {
        public static void InsertEmployee(int id, int departmentId, string firstName, string lastName, decimal salary)
        {
            LinqForEmployeeDataContext db = new LinqForEmployeeDataContext();

            Employee employee = new Employee();
            employee.Id = id;
            employee.DepartmentId = departmentId;
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.Salary = salary;

            db.Employees.InsertOnSubmit(employee);
            db.SubmitChanges();
        }

       
        static void Main(string[] args)
        {
            int id = 0;
            int departmentId = 0;
            string firstName = null;
            string lastName = null;
            decimal salary = 0;

            /* get list of employee id from table */
            List<int> listOfId = new List<int>();

            LinqForEmployeeDataContext db = new LinqForEmployeeDataContext();
            var employeeData = from employee in db.Employees.AsEnumerable() select employee;
            foreach (Employee employee in employeeData)
                listOfId.Add(int.Parse((employee.Id).ToString()));

            /* paqrse XML */
            XmlReader xmlreader = XmlReader.Create(@"C:\Users\vkamat\Documents\visual studio 2015\Projects\LinqToSQL\LinqToXML\Employee-Company.xml");
            XElement xelement = XElement.Load(xmlreader);

            IEnumerable<XElement> textSegs = from seg in xelement.Descendants("Employee") select (XElement)seg;

            foreach (XElement employee in textSegs)
            {
                try
                {
                    id = ValidateEmployeeDetails.ValidateEmployeeID(employee.Element("ID").Value);
                    departmentId = ValidateEmployeeDetails.ValidateEmployeeDeptId(employee.Element("DepartmentId").Value);
                    firstName = ValidateEmployeeDetails.ValidateEmployeeFirstName(employee.Element("FirstName").Value);
                    lastName = ValidateEmployeeDetails.ValidateEmployeeLastName(employee.Element("LastName").Value);
                    salary = ValidateEmployeeDetails.ValidateEmployeeSalary(employee.Element("Salary").Value);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                /* insert to database */
                if (!listOfId.Contains(id) && id != 0 && departmentId != 0 && firstName != null && lastName != null && salary != 0)
                {
                    InsertEmployee(id, departmentId, firstName, lastName, salary);
                }
                else
                {
                    Console.WriteLine("Error in insertion to column values not present in xml file or duplicate ID");
                }
            }
            Console.WriteLine("press any key to cntinue.....");
            Console.Read();
        }
    }
}
