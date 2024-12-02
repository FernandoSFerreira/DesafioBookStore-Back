using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Domain.Entities
{
    public class Livro : BaseEntity
    {
        public int Codi { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
        public string AnoPublicacao { get; set; }

        // Propriedades de relacionamento
        public ICollection<Autor> Autores { get; set; } = new List<Autor>();
        public ICollection<Assunto> Assuntos { get; set; } = new List<Assunto>();
    }
}
