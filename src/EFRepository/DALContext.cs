using System;
using ShaBoo.Domain.Repositories;
using ShaBoo.EFRepositories.Moqs;
using ShaBoo.Entities;

namespace ShaBoo.EFRepositories
{
    using System.Data.Entity.Validation;
    using System.Diagnostics;

    public class DALContext : IDALContext
    {
        #region fields

        private readonly ShaBooContainer _context;
        private IRoleRepository _roleRepository;
        private IUserRepository _userRepository;
        private IProfileRepository _profileRepository;
        private IDocumentRepository _documentRepository ;
        private IFstClassRepository _fstClassRepository ;
        private ISndClassRepository _sndClassRepository ;
        private ITrdClassRepository _trdClassRepository ;
        private IBoardRepository _boardRepository ;

        #endregion

        #region ctor

        public DALContext()
        {
            _context = new ShaBooContainer();
        }

        #endregion

        #region Repositories

        public IRoleRepository RoleRepository
        {
            get
            {
                return _roleRepository ?? (_roleRepository = new RoleRepository(_context));
                //return MoqRoleRepository.Load();
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                return _userRepository ?? (_userRepository = new UserRepository(_context));
            }
        }

        public IProfileRepository ProfileRepository
        {
            get
            {
                return _profileRepository ?? (_profileRepository = new ProfileRepository(_context));
            }
        }

        public IDocumentRepository DocumentRepository
        {
            get
            {
                return _documentRepository ?? (_documentRepository = new DocumentRepository(_context));
            }
        }

        public IFstClassRepository FstClassRepository
        {
            get
            {
                return _fstClassRepository ?? (_fstClassRepository = new FstClassRepository(_context));
            }
        }

        public ISndClassRepository SndClassRepository
        {
            get
            {
                return _sndClassRepository ?? (_sndClassRepository = new SndClassRepository(_context));
            }
        }

        public ITrdClassRepository TrdClassRepository
        {
            get
            {
                return _trdClassRepository ?? (_trdClassRepository = new TrdClassRepository(_context));
            }
        }

        public IBoardRepository BoardRepository
        {
            get
            {
                return _boardRepository ?? (_boardRepository = new BoardRepository(_context));
            }
        }
        #endregion

        #region Unit of Work

        private bool _disposed;

        public void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        #endregion
    }
}