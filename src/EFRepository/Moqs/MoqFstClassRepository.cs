using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShaBoo.EFRepositories.Moqs
{
    using Moq;

    using ShaBoo.Domain.Repositories;
    using ShaBoo.Entities;

    public static class MoqFstClassRepository
    {
        public static IFstClassRepository Load()
        {
            var mock = new Mock<IFstClassRepository>();
            var du = 0;
            mock.Setup(m => m.GetAll()).Returns(new List<FstClass>
                                                  {
                                                      new FstClass(){ID=1, Name = "学习资料"}, 
                                                      new FstClass(){ID=2, Name = "实用技术"}, 
                                                      new FstClass(){ID=3, Name = "娱乐资料"}, 
                                                  }.AsQueryable());
            return mock.Object;
        }
    }
}
