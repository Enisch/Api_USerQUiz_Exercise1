using System.Runtime.CompilerServices;
using Contexto.Context_If_IDecideUseDB;
using Microsoft.EntityFrameworkCore;

namespace Services_DependencyInjection
{
    public static class ConectionWithDB
    {
            //Provavelmente será usada para o addscoped e outros services.

        public static IServiceCollection Servicos(this IServiceCollection services, IConfiguration configuration)
        {
            var conexao = configuration.GetConnectionString("DefaultString");
            services.AddDbContext<ContextDb>(opt => opt.UseMySql(conexao, ServerVersion.AutoDetect(conexao)));



            return services;
        }
    }
}
