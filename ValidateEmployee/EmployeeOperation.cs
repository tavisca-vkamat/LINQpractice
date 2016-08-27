using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOperations
{
    public class EmployeeOperation
    {
        private const string DBName = "HotelReservationSystem";
        public static DataSet getAll()
        {
            DatabaseProviderFactory dbPFactory = new DatabaseProviderFactory();
            Database defaultDb = dbPFactory.CreateDefault();
            Database database = dbPFactory.Create(DBName);
            DbCommand dbcommand = database.GetStoredProcCommand("spSelectEmployee");

            DataSet dataset = database.ExecuteDataSet(dbcommand);
            return dataset;
        }
    }
}
