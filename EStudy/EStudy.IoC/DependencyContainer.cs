using EStudy.Application.Services.Implementations;
using EStudy.Application.Services.Interfaces;
using EStudy.Domain.Interfaces;
using EStudy.Infrastructure.Data.EntityFramework.Context;
using EStudy.Infrastructure.Data.Repositories.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EStudy.IoC
{
    public static class DependencyContainer
    {
        public static void AddServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EStudyContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            #region Repositories

            services.AddScoped<IRoleRepository, EFRoleRepository>();
            services.AddScoped<IUserLoginRepository, EFUserLoginRepository>();
            services.AddScoped<IUserRepository, EFUserRepository>();
            services.AddScoped<IUserRoleRepository, EFUserRoleRepository>();

            #endregion

            #region Services

            services.AddScoped<IEmailService, FakeMailService>();

            #endregion
        }
    }
}
