using DesafioBookStore_Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Domain.Interfaces.Services
{
    public interface IBaseService<TEntidade>
        where TEntidade : BaseEntity
    {
        int Add(TEntidade entidade);
        void Remove(int id);
        void Remove(TEntidade entidade);
        void Update(TEntidade entidade);
        TEntidade GetById(int id);
        IEnumerable<TEntidade> GetAll();
    }
}
