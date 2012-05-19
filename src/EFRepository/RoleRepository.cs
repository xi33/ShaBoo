using ShaBoo.Domain.Repositories;
using ShaBoo.Entities;

namespace ShaBoo.EFRepositories
{
    public class RoleRepository:Repository<Role>, IRoleRepository
    {
        public RoleRepository(ShaBooContainer context):base(context)
        {
        }
    }
}
