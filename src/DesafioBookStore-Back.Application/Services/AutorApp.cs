using AutoMapper;
using DesafioBookStore_Back.Application.DTO;
using DesafioBookStore_Back.Application.Interfaces;
using DesafioBookStore_Back.Domain.Entities;
using DesafioBookStore_Back.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Application.Services
{
    public class AutorApp : AppBaseService<Autor, AutorDTO>, IAutorApp
    {
        public AutorApp(IMapper iMapper, IAutorService service)
            : base(iMapper, service)
        {

        }
    }
}