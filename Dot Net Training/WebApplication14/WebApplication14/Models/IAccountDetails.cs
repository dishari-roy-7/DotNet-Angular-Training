using System.Xml.Linq;

namespace WebApplication14.Models
{
    public interface IAccountDetails
    {
        public List<Account> GetAccounts();
    }
    public class AccountDetails: IAccountDetails
    {
        public List<Account> GetAccounts()
        {
            var accounts = new List<Account>()
            {
                new Account() {
                    Id=1,
                    Name="John", 
                    Amount=800
                },
                new Account() {
                    Id=2, 
                    Name="Jane", 
                    Amount=900
                },
                new Account() {
                    Id=3, 
                    Name="June", 
                    Amount=500
                }
            };
            return accounts;
        }
    }
}
