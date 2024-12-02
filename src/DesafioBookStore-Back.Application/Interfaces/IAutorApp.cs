using DesafioBookStore_Back.Application.DTO;
using DesafioBookStore_Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Application.Interfaces
{
    public interface IAutorApp : IAppBase<Autor, AutorDTO>
    {
    }
}
