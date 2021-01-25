using FluentValidation;
using FormWebSite.Bussiness.ValidationRules.FluentValidation.AppUser;
using FormWebSite.Entities.DTO.AppUserDTO;
using Microsoft.Extensions.DependencyInjection;

namespace FormWebSite.Bussiness.Extensions.ValidationConfig
{
    public static class ValidationConfiguration
    {
        public static void ValidatorConfig(this IServiceCollection services)
        {
            services.AddTransient<IValidator<UserAddDto>, UserAddValidator>();
            services.AddTransient<IValidator<UserSignInDto>, UserSignInValidator>();
        }
    }
}
