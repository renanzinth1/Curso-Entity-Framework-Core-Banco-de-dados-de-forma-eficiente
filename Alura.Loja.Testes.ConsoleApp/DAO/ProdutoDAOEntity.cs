using Alura.Loja.Testes.ConsoleApp.Entidades;
using Alura.Loja.Testes.ConsoleApp.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp.DAO
{
    class ProdutoDAOEntity : IDisposable, IProdutoDAO
    {
        private readonly LojaContext ctx;

        public ProdutoDAOEntity(LojaContext ctx)
        {
            this.ctx = new LojaContext();
        }

        public void Adicionar(Produto p)
        {
            ctx.Produtos.Add(p);
            ctx.SaveChanges();
        }

        public void Atualizar(Produto p)
        {
            ctx.Produtos.Update(p);
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            ctx.Dispose();
        }

        public List<Produto> Produtos()
        {
            return ctx.Produtos.ToList();
        }

        public void Remover(Produto p)
        {
            ctx.Produtos.Remove(p);
            ctx.SaveChanges();
        }
    }
}
