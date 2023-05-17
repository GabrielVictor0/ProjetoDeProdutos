using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
    public class Usuario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        DateTime DataCadastro { get; set; }

        public void Cadastrar(int _codigo, string _nome, string _email, string _senha)
        {
           
        }

        public void Deletar()
        {

        }
    }
}