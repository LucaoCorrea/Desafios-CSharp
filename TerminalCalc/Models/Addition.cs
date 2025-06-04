using System;

namespace TerminalCalc.Models
{
    public class Addition : Operation
    {
        public Addition(double a, double b) : base(a, b) { }

        public override double Execute() => A + B;
    }
}
