using ShaBoo.Domain.Repositories;
using ShaBoo.Entities;

namespace ShaBoo.EFRepositories
{
    public class FstClassRepository : Repository<FstClass>, IFstClassRepository
    {
        public FstClassRepository(ShaBooContainer context)
            : base(context)
        {
        }
    }
}
