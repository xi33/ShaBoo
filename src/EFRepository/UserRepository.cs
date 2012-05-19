using ShaBoo.Domain.Repositories;
using ShaBoo.Entities;

namespace ShaBoo.EFRepositories
{
    public class UserRepository:Repository<User>, IUserRepository
    {
        public UserRepository(ShaBooContainer context)
            : base(context)
        {
        }
    }
}
