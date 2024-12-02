using DesafioBookStore_Back.Domain.Entities;
using DesafioBookStore_Back.Domain.Interfaces.Repositories;
using DesafioBookStore_Back.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Domain.Services
{
    public class AutorService : BaseService<Autor>, IAutorService
    {
        public AutorService(IAutorRepository repository)
            : base(repository)
        {

        }
    }
}
