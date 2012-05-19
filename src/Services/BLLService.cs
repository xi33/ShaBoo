using System;
using ShaBoo.Domain.Repositories;
using ShaBoo.Domain.Services;
using ShaBoo.EFRepositories;

namespace ShaBoo.Services
{
    public class BLLService : IBLLService, IDisposable
    {
        #region fields
        private IDALContext _context;
        private IRoleService _roleService;
        private IUserService _userService;
        private IProfileService _profileService;
        private IBoardService _boardService;
        private IDocumentService _documentService;
        private IClassService _classService;
        #endregion

        #region ctor
        public BLLService()
        {
            _context = new DALContext();
        }
        #endregion

        #region Services
        public IRoleService RoleService
        {
            get { return _roleService ?? (_roleService = new RoleService(_context)); }
        }

        public IUserService UserService
        {
            get { return _userService ?? (_userService = new UserService(_context)); }
        }

        public IProfileService ProfileService
        {
            get
            {
                return _profileService ?? (_profileService = new ProfileService(_context));
            }
        }

        public IBoardService BoardService
        {
            get { return _boardService ?? (_boardService = new BoardService(_context)); }
        }

        public IDocumentService DocumentService
        {
            get { return _documentService ?? (_documentService = new DocumentService(_context)); }
        }

        public IClassService ClassService
        {
            get { return _classService ?? (_classService = new ClassService(_context)); }
        }
        #endregion

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }
    }
}
