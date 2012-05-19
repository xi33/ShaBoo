using ShaBoo.Domain.Repositories;
using ShaBoo.Entities;

namespace ShaBoo.EFRepositories
{
    public class BoardRepository:Repository<Board>, IBoardRepository
    {
        public BoardRepository(ShaBooContainer context)
            :base(context)
        {
        }
    }
}
