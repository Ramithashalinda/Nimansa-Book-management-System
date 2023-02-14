using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.com.nimansa.db.configeration
{
    class Databaseconnection
    {
        private static Databaseconnection DbConnectionInstance = new Databaseconnection();
        private Databaseconnection() { }
        public static SqlConnection getCOnnection()
        {

            
               return new SqlConnection(@"Data Source=DESKTOP-2A05F4R;Initial Catalog=nimansaDB;Integrated Security=True");
        }
    }
}
