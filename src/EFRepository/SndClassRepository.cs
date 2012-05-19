using ShaBoo.Domain.Repositories;
using ShaBoo.Entities;

namespace ShaBoo.EFRepositories
{
    public class SndClassRepository : Repository<SndClass>, ISndClassRepository
    {
        public SndClassRepository(ShaBooContainer context)
            : base(context)
        {
        }
    }
}
