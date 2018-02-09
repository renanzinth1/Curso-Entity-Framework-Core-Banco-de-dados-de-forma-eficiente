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
            int x = 10;
            Console.WriteLine(x);
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

        //private static void GravarUsandoAdoNet()
        //{
        //    Produto p = new Produto();
        //    p.Nome = "Harry Potter e a Ordem da Fênix";
        //    p.Categoria = "Livros";
        //    p.Preco = 19.89;


        //    using (var repo = new ProdutoDAO())
        //    {
        //        repo.Adicionar(p);
        //    }
        //}
    }
}
