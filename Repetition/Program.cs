using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Console.WriteLine("A soma dos números de 1 a 10 é: " + sum);
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();

    }
}