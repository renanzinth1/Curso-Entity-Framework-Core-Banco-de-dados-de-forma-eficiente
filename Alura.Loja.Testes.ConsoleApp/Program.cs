using Alura.Loja.Testes.ConsoleApp.DAO;
using Alura.Loja.Testes.ConsoleApp.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Produto() { Nome = "Suco de Laranja", Categoria = "Bebidas", PrecoUnitario = 8.79, Unidade = "Litros"};
            var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 12.45, Unidade = "Gramas" };
            var p3 = new Produto() { Nome = "Macarrão", Categoria = "Alimentos", PrecoUnitario = 4.23, Unidade = "Gramas" };

            var promocaoPascoa = new Promocao();
            promocaoPascoa.Descricao = "Páscoa Feliz";
            promocaoPascoa.DataInicio = DateTime.Now;
            promocaoPascoa.DataTermino = DateTime.Now.AddMonths(3);
             
            promocaoPascoa.IncluiProduto(p1);
            promocaoPascoa.IncluiProduto(p2);
            promocaoPascoa.IncluiProduto(p3);

            var ctx = new LojaContext();
            var promocao = ctx.Promocoes.FirstOrDefault(p => p.ID == 1);
            ctx.Promocoes.Remove(promocao);

            ctx.SaveChanges();
            ctx.Dispose();

        }

        //private static void AtualizaProduto()
        //{
        //    // inclui um produto
        //    GravarUsandoEntity();
        //    RecuperarProdutos();

        //    using (var repo = new LojaContext())
        //    {
        //        var primeiro = repo.Produtos.FirstOrDefault();
        //        primeiro.Nome += " - Editado";

        //        repo.Produtos.Update(primeiro);
        //        repo.SaveChanges();
        //    }

        //    RecuperarProdutos();
        //}

        //private static void ExcluirProduto()
        //{
        //    using (var repo = new ProdutoDAOEntity())
        //    {
        //        IList<Produto> produtos = repo.Produtos();

        //        foreach (var item in produtos)
        //        {
        //            repo.Remover(item);
        //        }
        //    }
        //}

        //private static void RecuperarProdutos()
        //{
        //    var ctx = new LojaContext();
        //    using(var repo = new ProdutoDAOEntity(ctx))
        //    {
        //        IList<Produto> produtos = repo.Produtos();

        //        Console.WriteLine("Foram encontrados {0} produto(s)", produtos.Count);
        //        foreach(var item in produtos)
        //        {
        //            Console.WriteLine(item.Nome + " - " + item.Preco);
        //        }
        //    }
        //}

        //private static void GravarUsandoEntity()
        //{
        //    Produto p = new Produto();
        //    p.Nome = "Programação Java e OO";
        //    p.Categoria = "Livros";
        //    p.Preco = 20.50;

        //    using (var contexto = new ProdutoDAOEntity())
        //    {
        //        contexto.Adicionar(p);
        //    }
        //}
    }
}
