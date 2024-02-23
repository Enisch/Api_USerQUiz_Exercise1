using InfraData.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextoBd.EntitiesConfig
{
    internal class PerguntasEntitiesConfig : IEntityTypeConfiguration<TabelaQuiz>
    {
        public void Configure(EntityTypeBuilder<TabelaQuiz> builder)
        {
            builder.HasKey(x => x.IDPerguntasQuiz);
            builder.Property(x=> x.Perguntas).HasMaxLength(300);

        }
    }
}
