using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    public interface ICalculator
    {
        int Add(int start, int amount);
        int Sbtract(int start, int amount);
        int Multiply(int start, int amount);
        int Divide(int start, int amount);
    }
}
