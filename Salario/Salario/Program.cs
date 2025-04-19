using System;

namespace Salario 
{ 
    class Program 
    {
        static void Main(string[] args) 
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Digite o salário do funcionário: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Digite o imposto sobre o salário: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados atuais: " + funcionario);

            Console.Write("Digite a porcentagem de aumento que você deseja aplicar: ");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.Aumento(porcentagem);

            Console.WriteLine("Os dados atualizados: " + funcionario.ToString());
        }
    }
}