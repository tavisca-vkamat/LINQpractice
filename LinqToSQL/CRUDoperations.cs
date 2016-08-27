using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class CRUDoperations
    {

        public void SelectCustomer()
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();

            CustomerData customer = db.CustomerDatas.FirstOrDefault(e => e.FirstName.Equals("vivek"));

            Console.WriteLine(customer.CustomerId + " " + customer.FirstName + " " + customer.LastName + " " + customer.PhoneNumber);
        }
    }
}
