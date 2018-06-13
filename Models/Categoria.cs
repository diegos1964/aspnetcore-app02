using System;
using System.Collections.Generic;

namespace app02.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public IEnumerable<Produto> Produto { get; set; }
    }
}