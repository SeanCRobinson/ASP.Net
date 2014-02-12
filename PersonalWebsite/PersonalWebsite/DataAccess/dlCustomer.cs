using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class dlCustomer
    {

        public string GetCustomerFullName(int CustomerID)
        {
            string strFullname;
            try
            {
                string connectionString = ConfigurationManager.AppSettings["DatabaseConnection"];
                string strsql = "Select FirstName, LastName From Customer where CustomerID = @CustomerID";
                using (var Conn = new SqlConnection(connectionString))
                {
                    SqlCommand ObjCommand = new SqlCommand(strsql, Conn);

                    ObjCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                    Conn.Open();

                    SqlDataReader reader = ObjCommand.ExecuteReader();
                    reader.Read();
                    strFullname = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                }
            }
            catch (Exception ex)
            {
                
                strFullname = ex.ToString();
            }

            return strFullname;
        }
    }
}
