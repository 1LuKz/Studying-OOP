using System;

namespace TrianguloPOO 
{ 
    class Program 
    {
        static void Main(string[] args) 
        {
            Retangulo retangulo;
            retangulo = new Retangulo();
            Console.Write("Digite a largura do retângulo : ");
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo : ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            retangulo.ToString();
            Console.WriteLine(retangulo);
        }
    }
}