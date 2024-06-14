// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
class program
{
    public static void Main(string[] args)
    {
        SqlCommandDemo cmd= new SqlCommandDemo();
        cmd.InsertData();
        cmd.ReadData();
        cmd.UpdateData();
        cmd.ReadData();
        cmd.DeleteData();
        cmd.ReadData();
    }
}


using System;
using System.Data;
using System.Data.SqlClient;
class program
{
    static void Main()
    {
        string connectionString = "Data Source=F91983E652CC589;Initial Catalog=Northwind; Integrated Security=true";

        //string queryString = @"Select ProductID, UnitPrice, ProductName from dbo.products
        //                      Where UnitPrice > @pricePoint 
        //                       Order By UnitPrice desc";
        //string queryString2 = @"Select EmployeeID, FirstName, LastName from dbo.Employees
        //                      Where city=@cityVal";
        // int paramValue = 5;
        // string Val = "London";

        string queryString = @"Select * from Customers";

        using (SqlConnection connection=new SqlConnection(connectionString))
        {
            // SqlCommand cmd=new SqlCommand(queryString, connection);
            // cmd.Parameters.AddWithValue("@pricePoint", paramValue);
            SqlCommand cmd = new SqlCommand(queryString, connection);
            //cmd.Parameters.AddWithValue("@cityVal", Val);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("Contact Name \t\t City \t\t Company Name");
                Console.WriteLine("------------- \t\t ------ \t\t ------------");
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", reader[2], reader[5], reader[1]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}

*/