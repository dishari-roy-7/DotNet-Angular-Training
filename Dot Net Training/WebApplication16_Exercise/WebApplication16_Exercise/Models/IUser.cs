using Microsoft.EntityFrameworkCore;
using Web_API_Employee.Data;

namespace WebApplication16_Exercise.Models
{
    public interface IUser
    {
        Task<List<User>> GetUders();
        Task CreateUser(User user);
        Task<User> GetUser(int id);
        Task UpdateUser(int id, User user);
        Task DeleteUser(int id);
        bool UserExists(int id);
    }
    public class UserDetails:IUser
    {
        private 
    }
}
