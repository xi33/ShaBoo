using System.Linq;
using ShaBoo.Domain.Repositories;
using ShaBoo.Domain.Services;
using ShaBoo.Entities;

namespace ShaBoo.Services
{
    public class UserService : IUserService
    {
        private IDALContext _context;
        public UserService(IDALContext context)
        {
            _context = context;
        }


        public User GetUser(int id)
        {
            return _context.UserRepository.GetByID(id);
        }

        public User GetUser(string name)
        {
            return _context.UserRepository.GetAll()
                .FirstOrDefault(_ => _.Name == name);
        }

        public IQueryable<User> GetAllUsers()
        {
            return _context.UserRepository.GetAll();
        }

        public void CreateUser(string username, string password, string email, string roleName)
        {
            var role = _context.RoleRepository.GetAll().FirstOrDefault(_ => _.Name == roleName);
            
            //todo:后台验证
            
            User newUser = new User()
                               {
                                   Name = username,
                                   Password = password,
                                   Email = email,
                                   RoleID = role.ID
                               };
            _context.UserRepository.Insert(newUser);
            _context.SaveChanges();
        }
    }
}
