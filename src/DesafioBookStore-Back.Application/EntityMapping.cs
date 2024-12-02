using AutoMapper;
using DesafioBookStore_Back.Application.DTO;
using DesafioBookStore_Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Application
{
    public class EntityMapping : Profile
    {
        public EntityMapping()
        {
            CreateMap<Livro, LivroDTO>();
            CreateMap<LivroDTO, Livro>();

            CreateMap<Assunto, AssuntoDTO>();
            CreateMap<AssuntoDTO, Assunto>();

            CreateMap<Autor, AutorDTO>();
            CreateMap<AutorDTO, Autor>();
        }
    }
}
