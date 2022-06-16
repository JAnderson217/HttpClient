using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string mess)
        {
            Console.WriteLine("date:{0} :   Message:{1}", DateTime.Now, mess);
        }
    }

}
