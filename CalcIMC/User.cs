using System;

public class User
{
    public double weight { get; set; }
    public double height { get; set; }

    public void getData()
    {
        weight = ReadWrite("Informe seu peso (Kg): ");
        height = ReadWrite("Informe sua altura (m): ");
    }

    public double ReadWrite(string msg)
    {
        double value;
        while(true)
        {
            Console.Write(msg);
            string input = Console.ReadLine();
            if (double.TryParse(input, out value) && value > 0)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
            }
        }
    }


}
