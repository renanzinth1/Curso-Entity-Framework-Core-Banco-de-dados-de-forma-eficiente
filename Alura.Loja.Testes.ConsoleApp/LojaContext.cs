using Alura.Loja.Testes.ConsoleApp.Entidades;
using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuração para criar chave primária composta na tabela PromocaoProduto
            modelBuilder
                .Entity<PromocaoProduto>()
                .HasKey(pp => new { pp.PromocaoID, pp.ProdutoID });
            base.OnModelCreating(modelBuilder);

            //Configuração para alterar o nome da tabela de Endereco para Enderecos
            modelBuilder
                .Entity<Endereco>()
                .ToTable("Enderecos");

            //Configuração para atribuir uma chave primária na tabela Endereco de forma explícita
            modelBuilder
               .Entity<Endereco>()
               .HasKey("ClienteID");

            // Testando nova branch
        }
    }
}