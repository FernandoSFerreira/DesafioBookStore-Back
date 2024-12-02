using DesafioBookStore_Back.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Infrastructure.Data.Mapping
{
    public class AssuntoMap : BaseMap<Assunto>
    {
        public override void Configure(EntityTypeBuilder<Assunto> builder)
        {
            base.Configure(builder);
            builder.ToTable("Descricao");
            builder.Property(c => c.Descricao).IsRequired().HasField("Descricao").HasMaxLength(20);
        }
    }
}
