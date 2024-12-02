using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Domain.Entities
{
    public class Assunto : BaseEntity
    {
        public int CodAs { get; set; }
        public string Descricao { get; set; }

        // Propriedade de relacionamento
        public ICollection<Livro> Livros { get; set; } = new List<Livro>();
    }
}
