using Microsoft.EntityFrameworkCore;
using app02.Data.Maps;
using app02.Models;

namespace app01.Data

{
    public class StoreDataContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-EEIDHJEK\DESENVOLVIMENTO;Database=netcore2;User ID=sqlserver_core;Password=sqlserver_core");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProdutoMap());
            builder.ApplyConfiguration(new CategoriaMap());
        }


    }
}