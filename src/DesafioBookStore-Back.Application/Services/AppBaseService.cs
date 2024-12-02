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
    public class AppBaseService<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : BaseEntity
        where TEntidadeDTO : BaseDTO
    {
        protected readonly IBaseService<TEntidade> service;
        protected readonly IMapper iMapper;

        public AppBaseService(IMapper iMapper, IBaseService<TEntidade> service)
            : base()
        {
            this.iMapper = iMapper;
            this.service = service;
        }

        public void Update(TEntidadeDTO entidade)
        {
            service.Update(iMapper.Map<TEntidade>(entidade));
        }

        public void Remove(int id)
        {
            service.Remove(id);
        }

        public void Remove(TEntidadeDTO entidade)
        {
            service.Remove(iMapper.Map<TEntidade>(entidade));
        }

        public int Add(TEntidadeDTO entidade)
        {
            return service.Add(iMapper.Map<TEntidade>(entidade));
        }

        public TEntidadeDTO GetById(int id)
        {
            return iMapper.Map<TEntidadeDTO>(service.GetById(id));
        }

        public IEnumerable<TEntidadeDTO> GetAll()
        {
            return iMapper.Map<IEnumerable<TEntidadeDTO>>(service.GetAll());
        }
    }
}
