using Data.Context;
using Data.Implementations;
using Data.Implementations.Location;
using Data.Repository;
using Domain.Interfaces;
using Domain.Repository;
using Domain.Repository.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();

            serviceCollection.AddScoped<IUfRepository, UfImplementation>();
            serviceCollection.AddScoped<IMunicipioRepository, MunicipioImplementation>();
            serviceCollection.AddScoped<ICepRepository, CepImplementation>();



            serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer("Server=127.0.0.1;Database=dbAPI;User Id=sa;Password=123456;")
            );
        }
    }
}
