using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de IMC");

        // POO
        User user = new User();
        user.getData();

        Calc calc = new Calc(user.weight, user.height);
        double imc = calc.Cal();

        Console.WriteLine($"\nSeu IMC é: {imc}");
        calc.Classrating();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();

    }
}

