﻿namespace Alura.Loja.Testes.ConsoleApp.Entidades
{
    public class Endereco
    {
        public int Numero { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
    }
}