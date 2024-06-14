
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;
/*
class SqlConnectionDemo
{
    public static void Connection()
    {
        //1. Instantiate the connection
        SqlConnection conn = new SqlConnection("Data Source=F91983E652CC589;Initial Catalog=Northwind;Integrated Security=SSPI");
        SqlDataReader rdr = null;
        try
        {
            //2. Open the connection
            conn.Open();

            //3. Pass the connection to a command object
            SqlCommand cmd = new SqlCommand("select * from Customers", conn);

            //get the query results
            rdr = cmd.ExecuteReader();

            //print the CustomerID of each record
            while(rdr.Read())
            {
                Console.WriteLine(rdr[1]);
            }
        }
        catch
        {
            Console.Error.WriteLine("This is an error");
        }
    }
}
*/
class SqlCommandDemo
{
    SqlConnection conn;

    public SqlCommandDemo()
    {
        conn = new SqlConnection("Data Source=F91983E652CC589;Initial Catalog=Northwind;Integrated Security=SSPI");
    }
    /*
    static void Main()
    {
        SqlCommandDemo demo = new SqlCommandDemo();
        Console.WriteLine();
        Console.WriteLine("Categories before Insert");
        Console.WriteLine("-----------------");
        demo.ReadData();
        demo.InsertData();
        Console.WriteLine("Categories after Insert");
        Console.WriteLine("-----------------");
        demo.ReadData();
        demo.UpdateData();
        Console.WriteLine();
        Console.WriteLine("Categories after Update");
        Console.WriteLine("-----------------");
        demo.ReadData();
    }*/
    public void ReadData()
    {
        SqlDataReader rdr = null;
        try
        {
            //2. Open the connection
            conn.Open();

            //3. Pass the connection to a command object
            SqlCommand cmd = new SqlCommand("select * from Customers", conn);

            //get the query results
            rdr = cmd.ExecuteReader();

            //print the CustomerID of each record
            while (rdr.Read())
            {
                Console.WriteLine(rdr[1]);
            }
        }
        finally
        {
            if (rdr != null) rdr.Close();
            if(conn!=null) conn.Close();
        }
    }
    public void InsertData()
    {
        try
        {
            conn.Open();
            string insertString = @"insert into Categories 
                                    (CategoryName, Description) 
                                    values ('Miscelllaneous', 'Whatever doesn''t fit elsewhere')";
            SqlCommand cmd = new SqlCommand(insertString, conn);
            cmd.ExecuteNonQuery();
        }
        finally
        {
            if(conn!=null) conn.Close();
        }
    }
    public void UpdateData()
    {
        try
        {
            conn.Open();
            string updateString = @"update Categories 
                                    set CategoryName='Other'
                                    where CategoryName='Miscellaneous'";
            SqlCommand cmd = new SqlCommand(updateString,conn);
            cmd.ExecuteNonQuery();
        }
        finally
        {
            if (conn != null) conn.Close();
        }
    }
    public void DeleteData()
    {
        try
        {
            conn.Open();
            string deleteString = @"delete from Categories 
                                    where CategoryName='Other'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = deleteString;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
        }
        finally
        {
            if (conn != null) conn.Close();
        }
    }
}

