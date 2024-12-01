using CarLine.Model.Context;
using CarLine.Model.Entity;
using Microsoft.AspNetCore.Identity;

namespace Carline.Web.Extensions
{
    public static class AddIdentityApplicationExtensions
    {
        public static IServiceCollection AddIdentityApplicationServices(this IServiceCollection services, IConfiguration _config)
        {
            var builder = services.AddIdentityCore<AppSeller>();

            builder = new IdentityBuilder(builder.UserType, builder.Services);

            builder.AddEntityFrameworkStores<StoreDbContext>();

            builder.AddSignInManager<SignInManager<AppSeller>>();


            services.AddAuthentication();


            return services;

        }
    }
}
