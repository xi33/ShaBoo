using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using ShaBoo.Domain.Repositories;
using ShaBoo.Entities;

namespace ShaBoo.EFRepositories.Moqs
{
    public static class MoqRoleRepository
    {
        public static IRoleRepository Load()
        {
            var mock = new Mock<IRoleRepository>();
            var du = 0;
            mock.Setup(m => m.GetAll()).Returns(new List<Role>
                                                  {
                                                      new Role{Name ="Super_Administrator"}, 
                                                      new Role{Name ="Administrator"}, 
                                                      new Role{Name ="User"}, 
                                                  }.AsQueryable());
            return mock.Object;
        }
    }
}
