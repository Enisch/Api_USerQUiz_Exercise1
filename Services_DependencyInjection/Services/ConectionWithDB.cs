using ContextoBd;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Services_DependencyInjection
{
    public static class ConectionWithDB
    {
            //Provavelmente será usada para o addscoped e outros services.

        public static IServiceCollection Servicos(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextDb>(options =>
            {
                var conexao = configuration.GetConnectionString("DefaultString");
                options.UseMySql(conexao,ServerVersion.AutoDetect(conexao),
                    x => x.MigrationsAssembly(typeof(ContextDb).Assembly.FullName));
            });

            return services;
        }
    }
}
