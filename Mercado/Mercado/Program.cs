using System;

namespace Mercado 
{ 
    class Program 
    {
        static void Main(string[] args) 
        {
            Estoque produto = new Estoque("TV", 1500.00, 15);

            produto.SetNome("TV 4K");
            produto.SetValor(2000.00);
            produto.SetQuantidade(10);

            Console.WriteLine(produto.GetNome());
            Console.WriteLine(produto.GetValor());
            Console.WriteLine(produto.GetQuantidade());

            // Console.Write("Digite o nome do produto : ");
            // produto.Nome = Console.ReadLine();

            // Console.Write("Digite o valor do produto : ");
            // produto.Valor = double.Parse(Console.ReadLine());

            // Console.Write("Digite a quantidade no estoque : ");
            // produto.Quantidade = int.Parse(Console.ReadLine());

            // Console.WriteLine("Dados do produto: " + produto);

            // Console.Write("Quatidade de produtos adicionados no estoque : ");
            // int quantidade = int.Parse(Console.ReadLine());
            // produto.AdicionarProduto(quantidade);
            // Console.WriteLine("Dados atualizados: " + produto);

            // Console.Write("Quatidade de produtos removidos no estoque : ");
            // quantidade = int.Parse(Console.ReadLine());
            // produto.RemoverProduto(quantidade);
            // Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}