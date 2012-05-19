using System.Linq;
using ShaBoo.Entities;

namespace ShaBoo.Domain.Services
{
    public interface IClassService
    {
        IQueryable<FstClass> GetFstClasses();
        IQueryable<SndClass> GetSndClasses();
        IQueryable<TrdClass> GetTrdClasses();

        void CreateNewFstClass(string name);
    }
}
