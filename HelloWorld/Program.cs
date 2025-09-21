using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Bienvenue dans l'application Hello World en C#!");

        if (args.Length > 0)
        {
            Console.WriteLine($"Arguments reçus: {string.Join(", ", args)}");
        }
        else
        {
        Console.WriteLine("Aucun argument fourni.");
        }
    }
}
