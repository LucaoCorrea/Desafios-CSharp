using System;


public class Calc
{
    private double weight;
    private double height;
    private double imc;

    public Calc(double weight, double height)
    {
        this.weight = weight;
        this.height = height;
        this.imc = Cal();
    } 

    public double Cal()
    {
        return weight / (height * height);
    }

    public void Classrating() 
    {
        Console.Write("Classificação: ");
        if (imc < 16)
        {
            Console.WriteLine("Magreza grave");
            Console.WriteLine("Procure ajuda médica imediatamente.");
        }
        else if (imc < 17)
        {
            Console.WriteLine("Magreza moderada");
            Console.WriteLine("Você pode estar com desnutrição.");
        }
        else if (imc < 18.5)
        {
            Console.WriteLine("Magreza leve");
            Console.WriteLine("Tente melhorar sua alimentação.");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Saudável");
            Console.WriteLine("Parabéns! Mantenha esse estilo de vida.");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Sobrepeso");
            Console.WriteLine("Cuidado com alimentação e sedentarismo.");
        }
        else if (imc < 35)
        {
            Console.WriteLine("Obesidade grau I");
            Console.WriteLine("Recomendado buscar acompanhamento médico.");
        }
        else if (imc < 40)
        {
            Console.WriteLine("Obesidade grau II (severa)");
            Console.WriteLine("Situação preocupante. Agende uma consulta.");
        }
        else
        {
            Console.WriteLine("Obesidade grau III (mórbida)");
            Console.WriteLine("Estado grave. Ajuda médica é essencial.");
        }
    }
}