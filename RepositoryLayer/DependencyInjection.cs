using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.BookEntitiesRepositories;
using RepositoryLayer.Repositories.Interfaces;
using RepositoryLayer.Repositories.Interfaces.BookEntitiesInterfaces;

namespace RepositoryLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositoryLayer(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IBookRepository, BookRepository>();

            return services;
        }
    }
}
