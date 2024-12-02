using DesafioBookStore_Back.Domain.Entities;
using DesafioBookStore_Back.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Infrastructure.Data.Repositories
{
    public class AssuntoRepository : BaseRepository<Assunto>, IAssuntoRepository
    {
        public AssuntoRepository(ApplicationDbContext contexto)
            : base(contexto)
        {
        }
    }
}