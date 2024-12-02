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
    public class AutorMap : BaseMap<Autor>
    {
        public override void Configure(EntityTypeBuilder<Autor> builder)
        {
            base.Configure(builder);
            builder.ToTable("Autor");
            builder.Property(c => c.Nome).IsRequired().HasField("Nome").HasMaxLength(40);
        }
    }
}
