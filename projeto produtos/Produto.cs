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

        Marca _marcas = new Marca();
        public void Cadastrar()
        {
            
            Produto _produtos = new Produto();

            Console.WriteLine($"Informe o código do produto: ");
            _produtos.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome do produto: ");
            _produtos.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Informe o preço do produto: ");
            _produtos.Preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o código da marca: ");
            _produtos._marcas.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome da marca: ");
            _produtos._marcas.NomeMarca = Console.ReadLine();

            _produtos.DataCadastro = DateTime.Now;

            ListaDeProdutos.Add(_produtos);

        }

        public void Listar()
        {
            foreach (var item in ListaDeProdutos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"
Código do produto: {item.Codigo}
Nome do produto: {item.NomeProduto}
Preço do produto: {item.Preco}
--------------------------------
Código da marca: {item._marcas.Codigo}
Nome da marca: {item._marcas.NomeMarca}
{item.DataCadastro}");
                Console.ResetColor();
            }
        }

        public void Deletar(int _cod)
        {
            Produto produtoEncontrado = ListaDeProdutos.Find(produto => produto.Codigo == _cod);
            ListaDeProdutos.Remove(produtoEncontrado);
        }
    }
}