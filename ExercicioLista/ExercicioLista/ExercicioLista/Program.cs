using ExercicioLista;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Employees> employees = new List<Employees>();

        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());
        int id;
        string name;
        double salary;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"\nEmployee #{i}");
            Console.Write("Enter the Id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter the name: ");
            name = Console.ReadLine();
            Console.Write("Enter the salary: ");
            salary = double.Parse(Console.ReadLine());
            employees.Add(new Employees(id, name, salary));
        }
        Console.WriteLine();
        foreach(Employees obj in employees)
        {
            Console.WriteLine($"Employee {obj}");
        }

        Console.Write("\nEnter the employee Id that will have salary increase: ");
        id = int.Parse(Console.ReadLine());
        Employees employeeId = employees.Find(x => x.Id == id);
        if (employeeId.Id != null)
        {
            Console.Write("Enter the percentege: ");
            double percentege = double.Parse(Console.ReadLine());
            employeeId.IncreaseSalary(percentege);
        }
        else
        {
            Console.WriteLine("This id don't exist!\n");
        }

        Console.WriteLine();
        foreach (Employees obj in employees)
        {
            Console.WriteLine($"Employee {obj}");
        }
    }
}