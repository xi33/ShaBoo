namespace ShaBoo.Domain.Services
{
    public interface IBLLService
    {
        IUserService UserService { get; }
        IRoleService RoleService { get; }
        IProfileService ProfileService { get; }
        IBoardService BoardService { get; }
        IDocumentService DocumentService { get; }
        IClassService ClassService { get; }
    }
}