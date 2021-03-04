/**
 * @author Onur Guzel
 * @date 25.05.2020
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookShopManagement
{
    /**
    * \brief A class that initiates the connection with the database
    */
    public class Connection
    {
        public static SqlConnection connect = new SqlConnection("Insert the connection string");
    }
}
