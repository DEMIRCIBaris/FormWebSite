using AutoMapper;
using FormWebSite.Bussiness.Abstract;
using FormWebSite.Bussiness.Mappers.AutoMapper;

namespace FormWebSite.Bussiness.Concrete
{
    public class MapperService : IMapperService
    {
        public IMapper Mapper
        {
            get
            {
                return ObjectMapper.mymapper;
            }
        }
    }
}
