using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalCalc.Models
{
    public class Division : Operation
    {
        public Division(double a, double b) : base(a, b) 
        { 
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by Zero.");
        }
        public override double Execute() => A / B;
    }
}
