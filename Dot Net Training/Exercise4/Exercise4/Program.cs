// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace Exercise4
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        public static void Main()
        {
            List<Person> people = new List<Person>
            {
                new Person {Name="John", Age=28, City="New York"},
                new Person {Name="Jane", Age=22, City="London"},
                new Person {Name="Mike", Age=32, City="New York"},
                new Person {Name="Emily", Age=41, City="Paris"},
            };
            
            //1
            List<Person> l1=people.Where(x=>x.City == "New York").ToList();
            foreach(Person p in l1) Console.WriteLine(p.Name);

            //2
            List<Person> l2= people.Where(x => x.Age > 30).ToList();
            foreach (Person p in l2) Console.WriteLine(p.Name);

            //3
            List<Person> l3=people.OrderBy(x => x.Age).ToList();    
            foreach (var i in l3) Console.WriteLine(i.Name);

            //4
            Person eldest=people.OrderByDescending(x => x.Age).FirstOrDefault();
            Console.WriteLine(eldest.Name);

            //5
            var res = from p in people
                      group p by p.City into gp
                      select new
                      {
                          City = gp.Key,
                          Name = gp.ToList()
                      };
            foreach(var i in res)
            {
                foreach(var j in i.Name)
                    Console.WriteLine($"{j.Name}, {i.City}");
            }              
        }
    }
}
