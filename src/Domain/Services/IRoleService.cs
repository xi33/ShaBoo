using System.Linq;
using ShaBoo.Entities;

namespace ShaBoo.Domain.Services
{
    public interface IRoleService
    {
        Role GetRole(string name);
        IQueryable<Role> GetAllRoles();
    }
}