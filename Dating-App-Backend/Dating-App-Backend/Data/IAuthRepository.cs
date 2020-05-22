using System;
using System.Threading.Tasks;
using Dating_App_Backend.Models;

namespace Dating_App_Backend.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
