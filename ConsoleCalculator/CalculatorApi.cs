using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class CalculatorApi : ICalculator
    {
        
        private IPrinter print = null;
        public CalculatorApi(){ }
        public CalculatorApi(IPrinter Printer)
        {
            this.print = Printer;
        }
        public void getPrint(string mess)
        {
            print.Print("Only print here: " + mess);
        }
        public int Add(int start, int amount)
        {
            int num = start + amount;
            print.Print(num.ToString());
            return num;
            
        }
        
        public int Divide(int start, int amount)
        {
            if (amount == 0)
            {
                Console.WriteLine("Divide by zero error");
                print.Print("Warning - Attempted Divide by zero error");
                return 0;
            }
            else
            {
                int divide = Convert.ToInt32(start / amount);
                print.Print("Divide result:" + divide.ToString());
                return divide;
            }
        }

        public int Multiply(int start, int amount)
        {
            print.Print("Multiply result " + (start * amount).ToString());
            return start * amount;
        }

        public int Subtract(int start, int amount)
        {
            print.Print("Subtract result " + (start - amount).ToString());
            return start - amount;
        }
    }
}
