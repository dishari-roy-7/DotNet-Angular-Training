//See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AdoNetSP_Day18
{
    class Task1
    {
        public static void Main()
        {
            string connectionString = "Data Source=F91983E652CC589;Initial Catalog=Day18_sp;Integrated Security=true";

            //insert
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("Inserting", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //inserting values
                        cmd.Parameters.AddWithValue("@FirstName", "Jim");
                        cmd.Parameters.AddWithValue("@LastName", "Halpert");
                        cmd.Parameters.AddWithValue("@JobTitle", "Software Developer");
                        cmd.Parameters.AddWithValue("@HireDate", "2023-04-25");
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            //update
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("Updating", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Updating Values
                        cmd.Parameters.AddWithValue("@EmployeeID", 11);
                        cmd.Parameters.AddWithValue("@FirstName", "Ricky");
                        cmd.Parameters.AddWithValue("@LastName", "Ponting");
                        cmd.Parameters.AddWithValue("@JobTitle", "Backend Developer");
                        cmd.Parameters.AddWithValue("@HireDate", "2022-12-12");
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"Rows Affected:, {rowsAffected}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            //read
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                /*
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("Reading", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int employeeId = (int)reader["EmployeeID"];
                                string firstname = reader["FirstName"].ToString();
                                string lastname = reader["LastName"].ToString();
                                string jobtitle = reader["JobTitle"].ToString();
                                DateTime hireDate = Convert.ToDateTime(reader["HireDate"]);
                                Console.WriteLine($"Employee Id: {employeeId}, First Name: {firstname}, Last Name: {lastname}, Job Title: {jobtitle}, HireDate:{hireDate}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data returned for stored procedure");
                        }
                        reader.Close();
                    }              
                }
                */
                try
                {
                    int EmployeeID = 12;
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("READING", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader[1]}\t {reader[2]}\t {reader[3]}\t {reader[4]}");
                            }
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            //delete
                using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("Deleting", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        Updating Values
                            cmd.Parameters.AddWithValue("@EmployeeID", 2);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"Rows Affected:, {rowsAffected}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
