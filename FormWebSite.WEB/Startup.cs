using FluentValidation.AspNetCore;
using FormHelper;
using FormWebSite.Bussiness.Extensions.DIResolvers;
using FormWebSite.Bussiness.Extensions.IdentityConfigurations;
using FormWebSite.Bussiness.Extensions.ValidationConfig;
using FormWebSite.DataAccess.Concrete.EntityFramework.Context;
using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using FormWebSite.WEB.Functions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormWebSite.WEB
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddFluentValidation();
            //CODEvils Data Transfer Object
            services.AddDbContext<MyDataContext>();
            services.AddContainerWithDependencies(); //DI isleri bundan sorulur
            services.AddIdentityConfiguration();
            services.CookieConfigurations("/Home/Login");
            services.ValidatorConfig();

            services.AddFormHelper(new FormHelperConfiguration
            {
                CheckTheFormFieldsMessage = "Form alanlarýný kontrol ediniz."
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            IdentityInitilaizer.SeedData(userManager, roleManager).Wait();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseFormHelper();
            app.UseStaticFiles();
          

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=LogIn}/{id?}"
                    );
            });
        }
    }
}
