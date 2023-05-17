using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        DateTime DataCadastro { get; set; }

        List<Produto> ListaDeProdutos = new List<Produto>();
        
        Marca marca = new Marca();
        public void Cadastrar()
        {

        }

        public void Listar()
        {

        }

        public void Deletar()
        {

        }
    }
}