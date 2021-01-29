using FormWebSite.Core.DataAccess.Abstract;
using FormWebSite.Entities.Concrete;

namespace FormWebSite.DataAccess.Abstract
{
    public interface IGenderDal : IEntityRepository<Gender>
    {
        void AddRange(string[] genders);
    }
}
