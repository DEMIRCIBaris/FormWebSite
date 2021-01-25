using FormWebSite.Bussiness.Abstract;
using FormWebSite.Bussiness.Concrete;
using FormWebSite.DataAccess.Abstract;
using FormWebSite.DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace FormWebSite.Bussiness.Extensions.DIResolvers
{
    public static class StartupDIResolvers
    {
        public static void AddContainerWithDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IMapperService, MapperService>();
        }
    }
}
