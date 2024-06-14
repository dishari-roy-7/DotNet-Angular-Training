// See h/ttps://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Data Source=F91983E652CC589;Initial Catalog=Northwind;Integrated Security=True";

        // Read data from the Customers table in the Northwind database
        DataTable customersDataTable = ReadFromDb(connectionString, "SELECT * FROM Customers");

        //// Display original data
        Console.WriteLine("Original Customers Data:");
        DisplayDataTable(customersDataTable);

        //// Filter data to get only customers from France
        //DataTable frenchCustomersDataTable = FilterData(customersDataTable, "Country = 'France'");

        //// Display French customer data
        //Console.WriteLine("\nFrench Customers Data:");
        //DisplayDataTable(frenchCustomersDataTable);

        // Sort data by company name
        //DataTable sortedFrenchCustomersTable = SortData(frenchCustomersDataTable, "CompanyName ASC");

        // Display sorted French customer names
        //Console.WriteLine("\nSorted French Customers by Company Name:");
        //foreach (DataRow row in sortedFrenchCustomersTable.Rows)
        // Console.WriteLine(row["CompanyName"]);

        // Calculate and display the total number of customers
        //int totalCustomers = GetTotalNumberOfCustomers(customersDataTable);
        //Console.WriteLine("\nTotal number of customers: {0}", totalCustomers);
    }

    private static int GetTotalNumberOfCustomers(DataTable customersDataTable)
    {
        //throw new NotImplementedException();
        return customersDataTable.Rows.Count;
    }

    private static DataTable SortData(DataTable frenchCustomersDataTable, string v)
    {
        // throw new NotImplementedException();
        frenchCustomersDataTable.DefaultView.Sort = v;
        return frenchCustomersDataTable;
    }

    private static DataTable FilterData(DataTable customersDataTable, string v)
    {
        //throw new NotImplementedException();
        return customersDataTable.Select(v).CopyToDataTable();
    }

    private static void DisplayDataTable(DataTable customersDataTable)
    {
        //throw new NotImplementedException();
        foreach(DataRow i in customersDataTable.Rows)
        {
            foreach(DataColumn j in customersDataTable.Columns)
            {
                Console.WriteLine($"{j.ColumnName} : {i[j]}");
            }
        }
    }

    private static DataTable ReadFromDb(string connectionString, string v)
    {
        //throw new NotImplementedException();
        using(SqlConnection connection= new SqlConnection(connectionString))
        {
            SqlCommand cmd=new SqlCommand(v, connection);
            DataTable data = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                data.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return data;
        }
    }
}

