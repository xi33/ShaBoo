using System.Linq;
using ShaBoo.Domain.Repositories;
using ShaBoo.Domain.Services;
using ShaBoo.Entities;

namespace ShaBoo.Services
{
    public class RoleService : IRoleService
    {
        private IDALContext _context;
        public RoleService(IDALContext context)
        {
            _context = context;
        }


        public Role GetRole(string name)
        {
            return _context.RoleRepository.GetAll()
                .FirstOrDefault(_ => _.Name == name);
        }

        public IQueryable<Role> GetAllRoles()
        {
            return _context.RoleRepository.GetAll();
        }
    }
}
