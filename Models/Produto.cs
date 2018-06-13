using System;


namespace app02.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string Imagem { get; set; }
        public DateTime DtCriacao { get; set; }
        public DateTime DtUltimaAtualizacao { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}