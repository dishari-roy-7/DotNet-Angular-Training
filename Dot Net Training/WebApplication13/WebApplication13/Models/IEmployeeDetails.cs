namespace WebApplication13.Models
{
    public interface IEmployeeDetails
    {
        public List<Employee> GetEmployees(); 
    }
    public class EmployeeDetails : IEmployeeDetails
    {
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id= 1,
                    Title="Mr",
                    Name="Simon",
                    Age=32,
                    EmailId="simon@mailinator.com",
                    MobileNumber=123456,
                    Address="Pune",
                    PinCode=411057
                },
                 new Employee()
                 {
                     Id= 2,
                     Title="Mr",
                     Name="David",
                     Age=35,
                     EmailId="david@mailinator.com",
                     MobileNumber=143456,
                     Address="Mumbai",
                     PinCode=400007
                 },
                 new Employee()
                 {
                     Id= 3,
                     Title="Mr",
                     Name="Peter",
                     Age=29,
                     EmailId="peter@mailinator.com",
                     MobileNumber=148756,
                     Address="Lucknow",
                     PinCode=221007
                 },
                 new Employee()
                 {
                     Id= 4,
                     Title="Mr",
                     Name="John",
                     Age=37,
                     EmailId="john@mailinator.com",
                     MobileNumber=943456,
                     Address="Bangalore",
                     PinCode=500007
                 },
            };
            return employees;
        }
    }
}
