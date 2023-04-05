using SimpleInjector;
using SimpleInjector.Packaging;
using WebApi.Domain.Data;
using WebApi.Infrastructure.Interfaces;
using WebApi.Infrastructure.Repositories.Dapper;
using WebApi.Interfaces;
using WebApi.Service.Services;

namespace WebApi
{
    public class RegisterServices : IPackage
    {
        void IPackage.RegisterServices(Container container)
        {
            container.Register<DbContext>();
            container.Register<IAdminRepository, AdminRepository>();
            container.Register<IAdminService, AdminService>();
            container.Register<IUserRepository, UserRepository>();
            container.Register<IUserService, UserService>();
            container.Register<IClubRepository, ClubRepository>();
            container.Register<IClubService, ClubService>();

        }
    }
}
