using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class LojaContext : DbContext
    {
        //Deve se criar uma propriedade para o Entity monitorar a tabela e cria as migrations
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }/*Neste caso como a classe cliente esta relacionada com endereço
        a classe endereco tambem sera mapeada pelo Entity*/



        /*cria um metodo do construtor de modelo em que sem tem uma chave composta
        Onde Na PromocaoProduto tem como chave PId e ProdutoID*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<PromocaoProduto>()
                .HasKey(pp => new { pp.PromocaoId, pp.ProdutoId });
            base.OnModelCreating(modelBuilder);

            modelBuilder
             .Entity<Endereco>()
             .ToTable("Enderecos");

            modelBuilder
               .Entity<Endereco>()
               .Property<int>("ClienteId");//cria uma coluna na tabela endereco sem mostrala "shadow"

            modelBuilder
               .Entity<Endereco>()
               .HasKey("ClienteId");
        }

        //pega os parametros de conexao do DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }

    }
}