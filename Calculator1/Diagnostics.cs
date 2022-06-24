using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    class Diagnostics : IDiagnostics
    {
        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }
}
