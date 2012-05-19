using System.Linq;
using ShaBoo.Entities;

namespace ShaBoo.Domain.Services
{
    public interface IUserService
    {
        User GetUser(int id);
        User GetUser(string name);
        IQueryable<User> GetAllUsers();

        void CreateUser(string username, string password, string email, string roleName);
    }
}