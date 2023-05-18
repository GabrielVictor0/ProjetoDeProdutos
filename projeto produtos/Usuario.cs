using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
    public class Usuario
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        DateTime DataCadastro { get; set; }

        List<Usuario> ListaDeUsuarios = new List<Usuario>();

        //cadastrando usuário
        public void Cadastrar()
        {
            Usuario _novoUsuario = new Usuario();

            Console.WriteLine($"Informe o nome do novo usuário: ");
            _novoUsuario.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe o email do novo usuário: ");
            _novoUsuario.Email = Console.ReadLine();
            
            Console.WriteLine($"Informe a senha do novo usuário: ");
            _novoUsuario.Senha = Console.ReadLine();

            ListaDeUsuarios.Add(_novoUsuario);
        }

        public void Deletar()
        {

        }
    }
}