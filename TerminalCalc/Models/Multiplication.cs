using System;

namespace TerminalCalc.Models
{
   public class Multiplication : Operation
    {
        public Multiplication(double a, double b) : base(a, b) { }
        public override double Execute() => A * B;
    }
}
