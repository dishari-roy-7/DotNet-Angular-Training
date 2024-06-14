// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace exercise1
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { CustomerID = 1, Name = "John Doe", City = "New York" },
                new Customer { CustomerID = 2, Name = "Jane Smith", City = "Los Angeles" },
                new Customer { CustomerID = 3, Name = "Emily Johnson", City = "Chicago" }
            };
            List<Order> orders = new List<Order>
            {
                new Order { OrderID = 1, CustomerID = 1, OrderDate = new DateTime(2023, 1, 20), Amount = 250.00m },
                new Order { OrderID = 2, CustomerID = 1, OrderDate = new DateTime(2023, 1, 22), Amount = 75.00m },
                new Order { OrderID = 3, CustomerID = 2, OrderDate = new DateTime(2023, 1, 25), Amount = 125.00m },
                new Order { OrderID = 4, CustomerID = 3, OrderDate = new DateTime(2023, 2, 1), Amount = 200.00m }
            };

            //task 1
            var res = from c in customers
                      join o in orders
                      on c.CustomerID equals o.CustomerID
                      where c.Name == "John Doe"
                      select new
                      {
                          o.OrderID,
                          o.CustomerID,
                          o.OrderDate,
                          o.Amount
                      };
            foreach (var i in res)
            {
                Console.WriteLine($"OrderID: {i.OrderID}, CustomerID: {i.CustomerID}, OrderDate: {i.OrderDate.ToShortDateString()}, Amount: ${i.Amount}");
            }
            Console.WriteLine("\n");

            //task 2
            var res1 = from c in customers
                       join o in orders
                       on c.CustomerID equals o.CustomerID
                       group o.Amount by c.City into g
                       select new
                       {
                           City = g.Key,
                           Sales = g.Sum()
                       };
           foreach(var v in res1)
           {
                Console.WriteLine($"City: {v.City}, Total Sales: ${v.Sales}");
           }
           Console.WriteLine("\n");

            //task 3
            var res2 = from c in customers
                       join o in orders
                       on c.CustomerID equals o.CustomerID into JoinTable
                       from j in JoinTable.DefaultIfEmpty() /* left join->default empty */
                       where j == null
                       select new
                       {
                           c.Name,
                           c.City
                       };
            foreach(var i in res2)
            {
                Console.WriteLine($"Name: {i.Name}, City: {i.City}");
            }
            Console.WriteLine("\n");

            //task 4
            var res3 = from c in customers
                       select new
                       {
                           CustomerID = c.CustomerID,
                           order = orders.Where(s => s.CustomerID == c.CustomerID).OrderByDescending(o => o.OrderDate).FirstOrDefault()
                       };
            foreach(var v in res3)
            {
                Console.WriteLine($"CustomerID: {v.CustomerID}, MostRecentOrder: {v.order.OrderID}, OrderDate: {v.order.OrderDate.ToShortDateString()}, Amount: ${v.order.Amount}");
            }
        }
    }  
}
