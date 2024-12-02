using DesafioBookStore_Back.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Infrastructure.Data.Mapping
{
    public class LivroMap : BaseMap<Livro>
    {
        public override void Configure(EntityTypeBuilder<Livro> builder)
        {
            base.Configure(builder);
            builder.ToTable("Livro");
            builder.Property(c => c.Titulo).IsRequired().HasField("Titulo").HasMaxLength(40);
            builder.Property(c => c.Editora).IsRequired().HasField("Editora").HasMaxLength(40);
            builder.Property(c => c.Edicao).IsRequired().HasField("Edicao");
            builder.Property(c => c.AnoPublicacao).IsRequired().HasField("AnoPublicacao").HasMaxLength(4);
        }
    }
}
