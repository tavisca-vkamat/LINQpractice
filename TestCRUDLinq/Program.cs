using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCRUDLinq
{
    class Program
    {
        /* select customer function equals to first name */
        public static void SelectCustomers(string Firstname)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();

            CustomerData customer = db.CustomerDatas.FirstOrDefault(e => e.FirstName.Equals(Firstname));

            Console.WriteLine(customer.CustomerId + " " + customer.FirstName + " " + customer.LastName + " " + customer.PhoneNumber);
        }

        /* insert customer function */
        public static void InsertCustomer(string customerFirstName, string customerLastName, string customerEmailId, string customerPhoneNumber)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();

            CustomerData customer = new CustomerData();
            customer.FirstName = customerFirstName;
            customer.LastName = customerLastName;
            customer.EmailId = customerEmailId;
            customer.PhoneNumber = customerPhoneNumber;

            db.CustomerDatas.InsertOnSubmit(customer);

            db.SubmitChanges();
        }

        /* update customer details */
        public static void UpdateCustomer()
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();

            CustomerData customer = db.CustomerDatas.FirstOrDefault(c=> c.FirstName.Equals("xyz"));

            customer.FirstName = "pqr";

            db.SubmitChanges();
        }

        /* call stored procedure LINQ */

        public static void SelectHotels()
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();

            var hotels = db.spSelectHotel(2);
            
            Console.WriteLine(hotels.ElementAt(0).HotelName);
        }

        static void Main(string[] args)
        {
            //SelectCustomers("vivek");
            //Program.InsertCustomer("vicky","vicky","vicky@gmail.com","0000000000");
            //UpdateCustomer();
            SelectHotels();
        }
    }
}
