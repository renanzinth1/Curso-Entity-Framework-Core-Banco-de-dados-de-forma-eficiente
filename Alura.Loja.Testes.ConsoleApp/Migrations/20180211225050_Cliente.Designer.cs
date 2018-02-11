using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Alura.Loja.Testes.ConsoleApp;

namespace Alura.Loja.Testes.ConsoleApp.Migrations
{
    [DbContext(typeof(LojaContext))]
    [Migration("20180211225050_Cliente")]
    partial class Cliente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Entidades.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("ID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Entidades.Compra", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Preco");

                    b.Property<int>("ProdutoID");

                    b.Property<int>("Quantidade");

                    b.HasKey("ID");

                    b.HasIndex("ProdutoID");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Entidades.Endereco", b =>
                {
                    b.Property<int>("ClienteID");

                    b.Property<string>("Bairro");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Logradouro");

                    b.Property<int>("Numero");

                    b.HasKey("ClienteID");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria");

                    b.Property<string>("Nome");

                    b.Property<double>("PrecoUnitario");

                    b.Property<string>("Unidade");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Entidades.Promocao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataInicio");

                    b.Property<DateTime>("DataTermino");

                    b.Property<string>("Descricao");

                    b.HasKey("ID");

                    b.ToTable("Promocoes");
                });

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Entidades.PromocaoProduto", b =>
                {
                    b.Property<int>("PromocaoID");

                    b.Property<int>("ProdutoID");

                    b.HasKey("PromocaoID", "ProdutoID");

                    b.HasIndex("ProdutoID");

                    b.ToTable("PromocaoProduto");
                });

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Entidades.Compra", b =>
                {
                    b.HasOne("Alura.Loja.Testes.ConsoleApp.Entidades.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Entidades.Endereco", b =>
                {
                    b.HasOne("Alura.Loja.Testes.ConsoleApp.Entidades.Cliente", "Cliente")
                        .WithOne("EnderecoDeEntrega")
                        .HasForeignKey("Alura.Loja.Testes.ConsoleApp.Entidades.Endereco", "ClienteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Alura.Loja.Testes.ConsoleApp.Entidades.PromocaoProduto", b =>
                {
                    b.HasOne("Alura.Loja.Testes.ConsoleApp.Entidades.Produto", "Produto")
                        .WithMany("Promocoes")
                        .HasForeignKey("ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Alura.Loja.Testes.ConsoleApp.Entidades.Promocao", "Promocao")
                        .WithMany("Produtos")
                        .HasForeignKey("PromocaoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
