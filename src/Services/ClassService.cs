using System.Linq;
using ShaBoo.Domain.Repositories;
using ShaBoo.Domain.Services;
using ShaBoo.Entities;

namespace ShaBoo.Services
{
    public class ClassService : IClassService
    {
        private IDALContext context;
        public ClassService(IDALContext contextParam)
        {
            context = contextParam;
        }

        public IQueryable<FstClass> GetFstClasses()
        {
            return context.FstClassRepository.GetAll();
        }

        public IQueryable<SndClass> GetSndClasses()
        {
            return context.SndClassRepository.GetAll();
        }

        public IQueryable<TrdClass> GetTrdClasses()
        {
            return context.TrdClassRepository.GetAll();
        }

        public void CreateNewFstClass(string name)
        {
            var newFstClass = new FstClass { Name = name };
            context.FstClassRepository.Insert(newFstClass);
            context.SaveChanges();
        }
    }
}
