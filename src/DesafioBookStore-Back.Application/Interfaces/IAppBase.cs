using DesafioBookStore_Back.Application.DTO;
using DesafioBookStore_Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Application.Interfaces
{
    public interface IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : BaseEntity
        where TEntidadeDTO : BaseDTO
    {
        int Add(TEntidadeDTO entidade);
        void Remove(int id);
        void Remove(TEntidadeDTO entidade);
        void Update(TEntidadeDTO entidade);
        TEntidadeDTO GetById(int id);
        IEnumerable<TEntidadeDTO> GetAll();
    }
}
