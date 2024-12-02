﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.Domain.Entities
{
    public class Autor : BaseEntity
    {
        public int CodAu { get; set; }
        public string Nome { get; set; }

        // Propriedade de relacionamento
        public ICollection<Livro> Livros { get; set; } = new List<Livro>();
    }
}