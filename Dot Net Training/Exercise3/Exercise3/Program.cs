// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Xml.Linq;

namespace task3
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public List<int> ProjectIDs { get; set; }
    }
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
    }
    public class Project
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee { EmployeeID = 101, Name = "John Doe", DepartmentID = 1, ProjectIDs = new List<int> { 101, 102, 103 } },
            new Employee { EmployeeID = 102, Name = "Jane Smith", DepartmentID = 2, ProjectIDs = new List<int> { 104, 105 } },
            new Employee { EmployeeID = 103, Name = "Robert Johnson", DepartmentID = 1, ProjectIDs = new List<int> { 106 } },
            new Employee { EmployeeID = 104, Name = "Emily Brown", DepartmentID = 3, ProjectIDs = new List<int> { 107, 108 } },
            new Employee { EmployeeID = 105, Name = "Michael Lee", DepartmentID = 2, ProjectIDs = new List<int> { 109 } }
            };

            List<Department> dept = new List<Department>()
            {
            new Department { DepartmentID = 1, Name = "Sales" },
            new Department { DepartmentID = 2, Name = "Marketing" },
            new Department { DepartmentID = 3, Name = "Engineering" },
            new Department { DepartmentID = 4, Name = "Finance" },
            new Department { DepartmentID = 5, Name = "Human Resources" }
            };

            List<Project> projects = new List<Project>()
            {
            new Project { ProjectID = 101, Title = "Product Launch" },
            new Project { ProjectID = 102, Title = "Inventory Management" },
            new Project { ProjectID = 103, Title = "Website Redesign" },
            new Project { ProjectID = 104, Title = "Market Research" },
            new Project { ProjectID = 105, Title = "Social Media Campaign" }
            };
            /*
            //1
            var res = from e in employees
                      join d in dept
                      on e.DepartmentID equals d.DepartmentID
                      group e by d.DepartmentID into g
                      select new
                      {
                          Name = dept.Where(x => x.DepartmentID == g.Key).First().Name,
                          employee = g.ToList()
                      };
            /*
                      group e by d.Name into g
                      select new
                      {
                          Name = g.Key,
                          employee = g.ToList()
                      };
            
            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
                foreach(var item2 in item.employee)
                {
                    Console.WriteLine(item2.Name);
                }
            }
            
            //2
            var res2 = from e in employees
                       where (!e.ProjectIDs.Any(x => projects.Any(v => v.ProjectID == x)))
                      select e;
            foreach(var item in res2)
            {
                Console.WriteLine(item.Name);
            }
            

            //3
            var res3 = from p in projects
                       select new
                       {
                           Name = p.Title,
                           count = employees.Where(x => x.ProjectIDs.Contains(p.ProjectID)).Count()
                       };
            foreach (var item in res3)
            {
                Console.WriteLine($"{item.Name}, {item.count}");
            }
            

            //4
            var res3 = (from p in projects
                        select new
                        {
                            Name = p.Title,
                            count = employees.Where(x => x.ProjectIDs.Contains(p.ProjectID)).Count()
                        }).Where(x => x.count > 3);
            foreach (var item in res3)
            {
                Console.WriteLine($"{item.count}");
            }
            */

            //5
        }
    }  
}
