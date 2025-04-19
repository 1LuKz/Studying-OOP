using System;

namespace Dolar 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            Console.Write("Digite a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Digite quantos dólares que você vai comprar: ");
            double quantidade = double.Parse(Console.ReadLine());

            double moeda = Conversao.Conversor(cotacao, quantidade);
            Console.WriteLine("Total: " + moeda);
        }
    }
}