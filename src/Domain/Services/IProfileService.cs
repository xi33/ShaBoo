using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShaBoo.Domain.Services
{
    using ShaBoo.Entities;

    public interface IProfileService
    {
        Profile GetProfile(int id);
        Profile GetProfile(string name);
        IQueryable<Profile> GetAllProfiles();

        void CreateProfile(string userName, string email, int point);

        void CreateProfile(string userName, string firstName, string lastName, string alias, string email, string intro, int point);
    }
}
