using System;

namespace ShaBoo.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
    }

    public interface IDALContext : IUnitOfWork
    {
        IRoleRepository RoleRepository { get; }
        IUserRepository UserRepository { get; }
        IProfileRepository ProfileRepository { get; }
        IDocumentRepository DocumentRepository { get; }
        IFstClassRepository FstClassRepository { get; }
        ISndClassRepository SndClassRepository { get; }
        ITrdClassRepository TrdClassRepository { get; }
        IBoardRepository BoardRepository { get; }
    }
}