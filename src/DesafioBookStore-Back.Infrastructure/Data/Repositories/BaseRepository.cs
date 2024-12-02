using DesafioBookStore_Back.Domain.Entities;
using DesafioBookStore_Back.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntidade> : IBaseRepository<TEntidade>
        where TEntidade : BaseEntity
    {
        protected readonly ApplicationDbContext contexto;

        public BaseRepository(ApplicationDbContext contexto)
            : base()
        {
            this.contexto = contexto;
        }

        public void Update(TEntidade entidade)
        {
            contexto.Set<TEntidade>().Update(entidade); 
            contexto.SaveChanges();
        }

        public void Remove(int id)
        {
            var entidade = GetById(id); 
            if (entidade != null) { 
                contexto.Set<TEntidade>().Remove(entidade); 
                contexto.SaveChanges(); 
            }
        }

        public void Remove(TEntidade entidade)
        {
            contexto.Set<TEntidade>().Remove(entidade); 
            contexto.SaveChanges();
        }

        public int Add(TEntidade entidade)
        {
            var id = contexto.Set<TEntidade>().Add(entidade).Entity.Id; 
            contexto.SaveChanges(); 
            return id;
        }

        public TEntidade GetById(int id)
        {
            return contexto.Set<TEntidade>().Find(id);
        }

        public IEnumerable<TEntidade> GetAll()
        {
            return contexto.Set<TEntidade>().ToList();
        }
    }
}
