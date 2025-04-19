using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of array elements: ");
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        int[,] matriz = new int[n,n];
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i,j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }


        Console.WriteLine("\nArray!");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nMain diagonal!");
        for (int i = 0; i < n; i++)
        {
            Console.Write(matriz[i, i] + "\t");
        }

        Console.WriteLine("\nSecond diagonal!");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j == n - 1)
                {
                    Console.Write(matriz[j, i] + "\t");
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matriz[i,j] <= 0)
                { 
                    count++;
                }
            }
        }
        Console.WriteLine("\n\nNegative numbers from array: " + count);
    }
}