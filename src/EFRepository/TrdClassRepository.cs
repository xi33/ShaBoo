using ShaBoo.Domain.Repositories;
using ShaBoo.Entities;

namespace ShaBoo.EFRepositories
{
    public class TrdClassRepository : Repository<TrdClass>, ITrdClassRepository
    {
        public TrdClassRepository(ShaBooContainer context)
            : base(context)
        {
        }
    }
}
