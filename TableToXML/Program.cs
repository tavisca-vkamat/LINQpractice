using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TableToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeLinqToSQLDataContext db = new EmployeeLinqToSQLDataContext();

            DataSet dataset = getEmployee.getAll();
            DataTable datatable = dataset.Tables[0];
            dataset.DataSetName = "Employees";
            datatable.TableName = "Employee";

            StringWriter writer = new StringWriter();
            datatable.WriteXml("..\\..\\..\\TableToXML\\XML\\Employees.xml");
           
            TextWriter stream = (TextWriter)writer;

            Console.WriteLine(stream.ToString());

            Console.ReadKey();
        }
    }
}
