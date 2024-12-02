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
    public class BaseService<TEntidade> : IBaseService<TEntidade> where TEntidade : BaseEntity
    {
        protected readonly IBaseRepository<TEntidade> repository;

        public BaseService(IBaseRepository<TEntidade> repository)
        {
            this.repository = repository;
        }

        public void Update(TEntidade entidade)
        {
            repository.Update(entidade);
        }

        public void Remove(int id)
        {
            repository.Remove(id);
        }

        public void Remove(TEntidade entidade)
        {
            repository.Remove(entidade);
        }

        public int Add(TEntidade entidade)
        {
            return repository.Add(entidade);
        }

        public TEntidade GetById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<TEntidade> GetAll()
        {
            return repository.GetAll();
        }
    }
}
