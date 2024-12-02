using AutoMapper;
using DesafioBookStore_Back.Application.DTO;
using DesafioBookStore_Back.Application.Interfaces;
using DesafioBookStore_Back.Domain.Entities;
using DesafioBookStore_Back.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Application.Services
{
    public class LivroApp : AppBaseService<Livro, LivroDTO>, ILivroApp
    {
        public LivroApp(IMapper iMapper, ILivroService service)
            : base(iMapper, service)
        {

        }
    }
}
