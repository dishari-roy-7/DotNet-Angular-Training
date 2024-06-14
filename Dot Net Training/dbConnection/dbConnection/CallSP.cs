using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbConnection
{
    class CallSP
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Data Source=F91983E652CC589; Initial Catalog=Northwind; Integrated Security=true";
            string customerID = "ALFKI";
            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command=new SqlCommand("CustOrderHist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            string productName = reader["ProductName"].ToString();
                            int totalOrders = (int)reader["Total"];
                            Console.WriteLine($"Product Name: {productName}, Total Orders: {totalOrders}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found for the specified customer");
                    }
                    reader.Close();
                    connection.Close();
                }
            }
        }
    }
}
