using System;
using TerminalCalc.Models;

namespace TerminalCalc.Services
{
    public class Calculator
    {
       public double Execute(Operation operation) => operation.Execute();
    }
}
