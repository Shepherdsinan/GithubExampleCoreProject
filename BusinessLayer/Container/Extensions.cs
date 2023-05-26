using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entityframework;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Container;

public static class Extensions
{
    public static void ContainerDependencies(this IServiceCollection services)
    {
        services.AddScoped<ICommentService, CommentManager>();
        services.AddScoped<ICommentDal, EfCommentDal>();
        services.AddScoped<IDestinationService, DestinationManager>();
        services.AddScoped<IDestinationDal, EfDestinationDal>();
        services.AddScoped<IAppUserService, AppUserManager>();
        services.AddScoped<IAppUserDal, EfAppUserDal>();
    }
}