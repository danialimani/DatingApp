using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user,string pasword);
         Task<User> Login(string username,string pasword);
         Task<bool> UserExists(string username);
    }
}