using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());
        int[,] array = new int[rows, columns];

        Console.Write("Who number do you want find: ");
        int findNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                if (array[i, j] == findNumber)
                {
                    if (j > 0)
                    {
                        Console.Write(array[i, j - 1] + "\t");
                    }
                    if (j < columns - 1)
                    {
                        Console.Write(array[i, j + 1] + "\t");
                    }
                    if (i > 0)
                    {
                        Console.Write(array[i - 1, j] + "\t");
                    }
                    if (i < rows - 1)
                    {
                        Console.Write(array[i + 1, j] + "\t");
                    }
                }
            }
        }
    }
}