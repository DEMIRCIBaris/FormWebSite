using AutoMapper;
using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using FormWebSite.Entities.DTO.AppUserDTO;

namespace FormWebSite.Bussiness.Mappers.AutoMapper
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            #region UserApp
            CreateMap<UserAddDto, AppUser>();
            CreateMap<AppUser, UserAddDto>();

            CreateMap<UserUpdateDto, AppUser>();
            CreateMap<AppUser, UserUpdateDto>();

            CreateMap<AppUser, UserSignInDto>();
            CreateMap<UserSignInDto, AppUser>();
            #endregion

         
        }
    }
}
