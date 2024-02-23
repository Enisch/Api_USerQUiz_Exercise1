using Infradata.Domain_.Models_Entities;
using InfraData.Domain;
using InfraData.Domain.Models_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContextoBd
{
    public class ContextDb:DbContext
    {


                public ContextDb(DbContextOptions<ContextDb> options):base(options)
                { 
        
                }


         public DbSet<Alternativa_RespostasQuiz> AlternativaQuiz {get;set;}
        public DbSet<RespostaQuiz> RespostaQuizzes { get;set;}
        public DbSet<TabelaQuiz> PerguntasDoQuiz { get;set;}
        public DbSet<Usuario> UsuariosDoQuiz { get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ContextDb).Assembly);
        }
    }
}
