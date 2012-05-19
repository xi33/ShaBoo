using ShaBoo.Domain.Repositories;
using ShaBoo.Entities;

namespace ShaBoo.EFRepositories
{
    public class DocumentRepository : Repository<Document>, IDocumentRepository
    {
        public DocumentRepository(ShaBooContainer context)
            : base(context)
        {
        }
    }
}
