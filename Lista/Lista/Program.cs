using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> lista = new List<string>(); // Você pode inserir o dados aqui

        lista.Add("Lucas");
        lista.Add("Osaka");
        lista.Add("Tokyo");
        lista.Add("Yokohama");
        lista.Insert(1, "Toyota");
        lista.Add("Yamanashi");
        lista.Add("Okinawa");

        foreach (string objeto in lista)
        {
            Console.WriteLine(objeto);
            // Retorna Lucas, Yokohama, Osaka, Tokyo
        }
        Console.WriteLine("\nQuantidade da lista: " + lista.Count);

        string primeiroElemento = lista.Find(x => x[0] == 'T');
        Console.WriteLine("Primeiro T: " + primeiroElemento);

        string segundoElemento = lista.FindLast(x => x[0] == 'T');
        Console.WriteLine("Último T: " + segundoElemento);

        // Observação ele tem que ser int
        int terceiroElemento = lista.FindIndex(x => x[0] == 'O');
        Console.WriteLine("Primeiro O está na posição: " + terceiroElemento);

        int quartoElemento = lista.FindLastIndex(x => x[0] == 'T');
        Console.WriteLine("O último T está na posição: " + quartoElemento + "\n");

        Console.Write("Encontrar todos cujo o tamanho seja de 5 letras: ");
        List<string> segundaLista = lista.FindAll(x => x.Length == 5);
        foreach (string objeto in segundaLista) 
        {
            Console.Write(objeto + "\t");
        }

        Console.WriteLine("\n\nRemovendo o elemento Toyota da Lista");
        lista.Remove("Toyota");
        foreach (string objeto in lista)
        {
            Console.WriteLine(objeto);
        }

        Console.WriteLine("\nRemovendo os elementos que possui 5 letras");
        lista.RemoveAll(x => x.Length == 5);
        foreach (string objeto in lista)
        {
            Console.WriteLine(objeto);
        }

        Console.WriteLine("\nRemovendo o elemento na posição 1");
        lista.RemoveAt(1);
        foreach (string objeto in lista)
        {
            Console.WriteLine(objeto);
        }

        lista.Add("Nagoya");
        lista.Add("Kyoto");
        lista.Add("Hokkaido");
        lista.Add("Fukuoka");
        lista.Add("Kawasaki");
        lista.Add("Sapporo");
        lista.Add("Kanagawa");

        Console.WriteLine("\nRemovendo todos apartir do indice 1");
        lista.RemoveRange(1, 8);
        foreach (string objeto in lista)
        {
            Console.WriteLine(objeto);
        }
    }
}