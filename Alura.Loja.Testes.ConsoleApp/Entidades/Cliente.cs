using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp.Entidades
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Endereco EnderecoDeEntrega { get; set; }
    }
}
