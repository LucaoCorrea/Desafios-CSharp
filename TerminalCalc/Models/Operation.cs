using System;


namespace TerminalCalc.Models
{
    public abstract class Operation
    {
        public double A { get; protected set; }
        public double B { get; protected set; }

        protected Operation(double a, double b)
        {
            A = a;
            B = b;
        }

        public abstract double Execute();
    }
}
