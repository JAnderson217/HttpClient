using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter print = new ConsolePrinter();
            CalculatorApi myCalc = new CalculatorApi(print);

            int sum = myCalc.Add(3, 4);
            int div = myCalc.Divide(40, 2);
            int mult = myCalc.Multiply(22, 5);
            int sub = myCalc.Subtract(60, 22);
            myCalc.getPrint("this is called from main!!");
            Console.WriteLine("Main sum:", sum);
            Console.WriteLine("Main div:", div);
            Console.ReadLine();
        }
    }
}
