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
    public class AssuntoApp : AppBaseService<Assunto, AssuntoDTO>, IAssuntoApp
    {
        public AssuntoApp(IMapper iMapper, IAssuntoService service)
            : base(iMapper, service)
        {

        }
    }
}
