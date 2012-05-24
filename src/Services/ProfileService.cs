using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShaBoo.Services
{
    using ShaBoo.Domain.Repositories;
    using ShaBoo.Domain.Services;
    using ShaBoo.Entities;

    public class ProfileService : IProfileService
    {
        private IDALContext _context;
        public ProfileService(IDALContext context)
        {
            _context = context;
        }

        #region Implementation of IProfileService

        public Profile GetProfile(int id)
        {
            return _context.ProfileRepository.GetByID(id);
        }

        public Profile GetProfile(string name)
        {
            return _context.ProfileRepository.GetAll()
                  .FirstOrDefault(_ => _.UserName == name);
        }

        public IQueryable<Profile> GetAllProfiles()
        {
            return _context.ProfileRepository.GetAll();
        }

        public void CreateProfile(string userName, string email, int point)
        {
            CreateProfile(userName, null, null, null, email, null, point);
        }

        public void CreateProfile(string userName, string firstName, string lastName, string alias, string email, string intro, int point)
        {
            CreateProfile(userName, null, null, null, email, null, point, "");
        }

        public void CreateProfile(string userName, string firstName, string lastName, string alias, string email, string intro, int point, string uid)
        {
            Profile newProfile = new Profile
                {
                    UserName = userName,
                    FirstName = firstName,
                    LastName = lastName,
                    Alias = alias,
                    Email = email,
                    Intro = intro,
                    Point = point,
                    UID = uid
                };
            _context.ProfileRepository.Insert(newProfile);
            _context.SaveChanges();
        }

        #endregion
    }
}
