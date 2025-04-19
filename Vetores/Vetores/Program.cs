using System;
using Vetores;

class Program
{
    static void Main(string[] args)
    {
        Estudante[] aluno = new Estudante[10];
        Console.Write("Digite a quantidade de alunos a serem registrados: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o email do aluno: ");
            string email = Console.ReadLine();
            Console.Write("Digite qual quarto deseja alugar: ");
            int quarto = int.Parse(Console.ReadLine());
            aluno[quarto] = new Estudante { Nome = nome, Email = email };
        }

        Console.WriteLine();
        Console.WriteLine("Quartos ocupados: ");
        for (int i = 0; i < 10; i++)
        {
            if (aluno[i] != null)
            {
                Console.WriteLine($"Quarto {i}: " + aluno[i]);
            }
        }       
    }   
}
