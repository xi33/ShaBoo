using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShaBoo.EFRepositories
{
    using ShaBoo.Domain.Repositories;
    using ShaBoo.Entities;

    public class ProfileRepository:Repository<Profile>, IProfileRepository
    {
        public ProfileRepository(ShaBooContainer context):base(context)
        {
        }
    }
}
