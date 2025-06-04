using System;

namespace TerminalCalc.Models
{
    public class Subtraction : Operation
    {
        public Subtraction(double a, double b) : base(a, b) { }
        public override double Execute() => A - B;
    }
}
