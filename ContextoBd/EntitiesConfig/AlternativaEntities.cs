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
    public  class AlternativaEntities:IEntityTypeConfiguration<Alternativa_RespostasQuiz>
    {
        public void Configure(EntityTypeBuilder<Alternativa_RespostasQuiz> builder)
        {
            builder.HasKey(x => x.IDRespostasQuiz);
            builder.Property(x=> x.AlternativaQuiz).IsRequired().HasMaxLength(2);
        }
    }
}
