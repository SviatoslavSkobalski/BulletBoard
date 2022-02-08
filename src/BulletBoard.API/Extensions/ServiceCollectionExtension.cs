using BulletBoard.Application.Items.Mappers;
using BulletBoard.Application.Pojects.Mappers;
using BulletBoard.Application.Teams.Mappers;

namespace BulletBoard.API.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            return services.AddSingleton<ItemMapper>()
                           .AddSingleton<ProjectMapper>()
                           .AddSingleton<TeamMapper>(); 
        }
    }
}
