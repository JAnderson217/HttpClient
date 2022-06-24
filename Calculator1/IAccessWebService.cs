using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    interface IAccessWebService
    {
        int getAdd(int firstNumber, int secondNumber);
        int getSubtract(int firstNumber, int secondNumber);
        int getMultiply(int firstNumber, int secondNumber);
        int getDivide(int firstNumber, int secondNumber);
    }
}
