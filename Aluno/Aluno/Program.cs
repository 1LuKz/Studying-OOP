using System;

namespace Aluno 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            Trimestre aluno = new Trimestre();
            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite a nota do aluno no primeiro trimestre: ");
            aluno.PrimeiraNota = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota do aluno no segundo trimestre: ");
            aluno.SegundaNota = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota do aluno no terceiro trimestre: ");
            aluno.TerceiraNota = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota final: " + aluno.Resultado());
            Console.WriteLine(aluno.ToString()); 
        }
    }
}