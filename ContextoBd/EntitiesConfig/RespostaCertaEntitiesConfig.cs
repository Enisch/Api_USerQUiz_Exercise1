using InfraData.Domain.Models_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextoBd.EntitiesConfig
{
    internal class RespostaEntitiesConfig : IEntityTypeConfiguration<RespostaQuiz>
    {
        public void Configure(EntityTypeBuilder<RespostaQuiz> builder)
        {
            builder.HasKey(X=> X.id);
            builder.HasMany(x => x.IDPerguntasQuiz).WithOne();
            builder.HasMany(x => x.IDRespostasQuiz).WithOne();
            builder.Property(x=> x.PerguntasDasAlternativas).HasMaxLength(300).IsRequired();
        }
    }
}
